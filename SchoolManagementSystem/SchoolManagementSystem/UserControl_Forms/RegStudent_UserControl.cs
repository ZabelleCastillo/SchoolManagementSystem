using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace SchoolManagementSystem.UserControl_Forms
{
    public partial class RegStudent_UserControl : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        Image DefaultImage;
        string STUDENT_REGISTRY;
        string GENDER;
        string ImgLocation = ""; // STUDENT PHOTO LOCATION

        public RegStudent_UserControl()
        {
            InitializeComponent();
            DefaultImage = StudPicture_Pcturebox.Image;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\n Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
        }
        private void MobileNo_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "Letters are invalid. Please input number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void PHOTO_BTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ProfImg = new OpenFileDialog();
            ProfImg.Filter = "JPG FILES(*.jpg)|*.jpg| PNG FILES(*.png)|*.png|ALL FILES(*.*)|*.*";
            if (ProfImg.ShowDialog() == DialogResult.OK)
            {
                ImgLocation = ProfImg.FileName.ToString();
                StudPicture_Pcturebox.ImageLocation = ImgLocation;
            }
        }
        private void NewStud_Checkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (NewStud_Checkbx.Checked == true)
            {
                STUDENT_REGISTRY = "NEW STUDENT";
                OldStud_CheckBox.Checked = false;
            }
        }
        private void OldStud_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OldStud_CheckBox.Checked == true)
            {
                STUDENT_REGISTRY = "OLD STUDENT";
                NewStud_Checkbx.Checked = false;
            }
        }
        private void Female_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "FEMALE";
        }
        private void MALE_RADIOBTN_CheckedChanged(object sender, EventArgs e)
        {
            GENDER = "MALE";
        }

        private void DOB_DateTimePickr_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = DOB_DateTimePickr.Value;
            DateTime to = DateTime.Now;
            TimeSpan Tspan = to - from;
            double days = Tspan.TotalDays;
            Age_Txbox.Text = (days / 365).ToString("0");
        }
        private void Age_Txbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MetroFramework.MetroMessageBox.Show(this, "Letters are invalid. Please input number!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void RegStudent_UserControl_Load(object sender, EventArgs e)
        {
            FillComboboxFromSQL_Database_ClassSection();
        }
        private void FillComboboxFromSQL_Database_ClassSection()
        {
            YearLevel_Cmbobx.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from YEAR_LEVEL_TABLE ORDER BY [YEAR LEVEL] ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            YearLevel_Cmbobx.ValueMember = "YearID";
            YearLevel_Cmbobx.DisplayMember = "Year Level";

            YearLevel_Cmbobx.DataSource = dt;
            Class_cmbobx.Enabled = false;
        }
      

        private void LOGIN_BTN_Click(object sender, EventArgs e)
        {
            REGISTER_ADD_STUDENT_INFO();
        }
        private void REGISTER_ADD_STUDENT_INFO()
        {
            /* INSERT INTO STUDENT INFO TABLE */
            byte[] images = null; /* STUDENT PHOTO  */
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_INFO_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand cmd2 = new SqlCommand("insert into STUDENT_INFO_TABLE (NAME, LASTNAME, [MIDDLE NAME], SUFFIX, [YEAR LEVEL], CLASS, SESSION, PHOTO, [STUDENT REGISTRY], STATUS, [MOBILE NUMBER], GENDER, [DATE OF BIRTH], AGE, [PLACE OF BIRTH], ADDRESS, [DATE OF ADMISSION]) values(@NAME,@LASTNAME, @MIDDLE_NAME, @SUFFIX, @YEAR_LEVEL, @CLASS, @SESSION, @PHOTO, @STUDENT_REGISTRY, @STATUS, @MOBILE_NUMBER, @GENDER, @DATE_OF_BIRTH, @AGE, @PLACE_OF_BIRTH, @ADDRESS, @DATE_OF_ADMISSION);" +
                                                        "insert STUDENT_GRADE_TABLE  (NAME, LASTNAME, [MIDDLE NAME]) VALUES (' " + StudName_Txbox.Text.Trim() + "', ' " + StudLastName_Txbox.Text.Trim() + "', ' " + MiddleName_Txbox.Text.Trim() + "')" +
                                                        "insert STUDENT_GRADE2_TABLE  (NAME, LASTNAME, [MIDDLE NAME]) VALUES (' " + StudName_Txbox.Text.Trim() + "', ' " + StudLastName_Txbox.Text.Trim() + "', ' " + MiddleName_Txbox.Text.Trim() + "')" +
                                                        "insert STUDENT_GRADE3_TABLE  (NAME, LASTNAME, [MIDDLE NAME]) VALUES (' " + StudName_Txbox.Text.Trim() + "', ' " + StudLastName_Txbox.Text.Trim() + "', ' " + MiddleName_Txbox.Text.Trim() + "')" +
                                                        "insert STUDENT_GRADE4_TABLE  (NAME, LASTNAME, [MIDDLE NAME]) VALUES (' " + StudName_Txbox.Text.Trim() + "', ' " + StudLastName_Txbox.Text.Trim() + "', ' " + MiddleName_Txbox.Text.Trim() + "')" +
                                                        "insert STUDENT_GRADE5_TABLE  (NAME, LASTNAME, [MIDDLE NAME]) VALUES (' " + StudName_Txbox.Text.Trim() + "', ' " + StudLastName_Txbox.Text.Trim() + "', ' " + MiddleName_Txbox.Text.Trim() + "')" +
                                                        "insert STUDENT_GRADE6_TABLE  (NAME, LASTNAME, [MIDDLE NAME]) VALUES (' " + StudName_Txbox.Text.Trim() + "', ' " + StudLastName_Txbox.Text.Trim() + "', ' " + MiddleName_Txbox.Text.Trim() + "')" +
                                                        "insert STUDENT_GRADE7_TABLE  (NAME, LASTNAME, [MIDDLE NAME]) VALUES (' " + StudName_Txbox.Text.Trim() + "', ' " + StudLastName_Txbox.Text.Trim() + "', ' " + MiddleName_Txbox.Text.Trim() + "')" +
                                                        "insert STUDENT_GRADE8_TABLE  (NAME, LASTNAME, [MIDDLE NAME]) VALUES (' " + StudName_Txbox.Text.Trim() + "', ' " + StudLastName_Txbox.Text.Trim() + "', ' " + MiddleName_Txbox.Text.Trim() + "')" +
                                                        "insert STUDENT_GUARDIAN_TABLE  (NAME, LASTNAME, FATHER, [FATHER OCCUPATION], MOTHER, [MOTHER OCCUPATION], [TEMPORARY ADDRESS], [PERMANENT ADDRESS], [CELL NUMBER], [TELEPHONE NUMBER]) VALUES (' " + StudName_Txbox.Text.Trim() + "', ' " + StudLastName_Txbox.Text.Trim() + "', ' " + FathersName_Txbox.Text.Trim() + "', ' " + FatherOccu_Txbx.Text.Trim() + "', ' " + mothersName_txbx.Text.Trim() + "', ' " + MotherOccu_Txbx.Text.Trim() + "', ' " + TempoAddress_Txbx.Text.Trim() + "', ' " + PermanentAddr_Txbx.Text.Trim() + "', ' " + GuardMobileNo_Txbx.Text.Trim() + "', ' " + TelephoneNo_Txbx.Text.Trim() + "')", connection))
                {
                    try
                    {
                        if (StudName_Txbox.Text != string.Empty && StudLastName_Txbox.Text != "" && MiddleName_Txbox.Text != "" && YearLevel_Cmbobx.Text != "" && Class_cmbobx.Text != "" && Session_Txbx.Text != "" && StudPicture_Pcturebox.Image != null && Status_Txbx.Text != "" && GuardMobileNo_Txbx.Text != "" && PlaceOfBirth_Txbx.Text != "" && STUDENT_REGISTRY.ToString() != null)
                        {
                            FileStream ProfileStream = new FileStream(ImgLocation, FileMode.Open, FileAccess.Read);
                            BinaryReader brs = new BinaryReader(ProfileStream);
                            images = brs.ReadBytes((int)ProfileStream.Length);

                            cmd2.Parameters.AddWithValue("@NAME", StudName_Txbox.Text.Trim());
                            cmd2.Parameters.AddWithValue("@LASTNAME", StudLastName_Txbox.Text.Trim());
                            cmd2.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbox.Text.Trim());
                            cmd2.Parameters.AddWithValue("@SUFFIX", Suffix_Combobx.Text.Trim());
                            cmd2.Parameters.AddWithValue("@YEAR_LEVEL", YearLevel_Cmbobx.Text.Trim());
                            cmd2.Parameters.AddWithValue("@CLASS", Class_cmbobx.Text.Trim());
                            cmd2.Parameters.AddWithValue("@SESSION", Session_Txbx.Text.Trim());
                            cmd2.Parameters.AddWithValue("@PHOTO", images);
                            cmd2.Parameters.AddWithValue("@STUDENT_REGISTRY", STUDENT_REGISTRY.ToString());
                            cmd2.Parameters.AddWithValue("@STATUS", Status_Txbx.Text.Trim());
                            cmd2.Parameters.AddWithValue("@MOBILE_NUMBER", MobileNo_TextBox.Text.Trim());
                            cmd2.Parameters.AddWithValue("@GENDER", GENDER);
                            cmd2.Parameters.AddWithValue("@DATE_OF_BIRTH", DOB_DateTimePickr.Value.ToString());
                            cmd2.Parameters.AddWithValue("@AGE", Age_Txbox.Text.Trim());
                            cmd2.Parameters.AddWithValue("@PLACE_OF_BIRTH", PlaceOfBirth_Txbx.Text.Trim());
                            cmd2.Parameters.AddWithValue("@ADDRESS", AddressStud_Txbx.Text.Trim());
                            cmd2.Parameters.AddWithValue("@DATE_OF_ADMISSION", DateTime.Now.ToString());
                            cmd2.Parameters.AddWithValue("@FATHER", FathersName_Txbox.Text.Trim());
                            cmd2.Parameters.AddWithValue("@FATHER_OCCUPATION", FatherOccu_Txbx.Text.Trim());
                            cmd2.Parameters.AddWithValue("@MOTHER", mothersName_txbx.Text.Trim());
                            cmd2.Parameters.AddWithValue("@MOTHER_OCCUPATION", MotherOccu_Txbx.Text.Trim());
                            cmd2.Parameters.AddWithValue("@TEMPORARY_ADDRESS", TempoAddress_Txbx.Text.Trim());
                            cmd2.Parameters.AddWithValue("@PERMANENT_ADDRESS", PermanentAddr_Txbx.Text.Trim());
                            cmd2.Parameters.AddWithValue("@CELL_NUMBER", GuardMobileNo_Txbx.Text.Trim());
                            cmd2.Parameters.AddWithValue("@TELEPHONE_NUMBER", TelephoneNo_Txbx.Text.Trim());
                            cmd2.ExecuteNonQuery();
                            MetroFramework.MetroMessageBox.Show(this, "\n\n " + StudName_Txbox.Text + " , " + StudLastName_Txbox.Text + " is successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            StudName_Txbox.Clear();
                            StudLastName_Txbox.Clear();
                            MiddleName_Txbox.Clear();
                            Suffix_Combobx.ResetText();
                            YearLevel_Cmbobx.ResetText(); //Items.Clear();
                            Class_cmbobx.ResetText();
                            Session_Txbx.Clear();
                            Status_Txbx.Clear();
                            MobileNo_TextBox.Clear();
                            Age_Txbox.Clear();
                            AddressStud_Txbx.Clear();
                            NewStud_Checkbx.Checked = false;
                            OldStud_CheckBox.Checked = false;
                            PlaceOfBirth_Txbx.Clear();
                            Female_RadioBtn.Checked = false;
                            MALE_RADIOBTN.Checked = false;
                            DOB_DateTimePickr.Value = DateTime.Now;
                            StudPicture_Pcturebox.Image = DefaultImage;

                            FathersName_Txbox.Clear();
                            FatherOccu_Txbx.Clear();
                            mothersName_txbx.Clear();
                            MotherOccu_Txbx.Clear();
                            TempoAddress_Txbx.Clear();
                            PermanentAddr_Txbx.Clear();
                            GuardMobileNo_Txbx.Clear();
                            TelephoneNo_Txbx.Clear();

                            dataadapter.Fill(ds, "STUDENT_TABLE_INFO");
                            connection.Close();

                        }

                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Please provide the details", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            StudName_Txbox.Clear();
                            StudLastName_Txbox.Clear();
                            MiddleName_Txbox.Clear();
                            Suffix_Combobx.ResetText();
                            YearLevel_Cmbobx.ResetText();
                            Class_cmbobx.ResetText();
                            Session_Txbx.Clear();
                            Status_Txbx.Clear();
                            MobileNo_TextBox.Clear();
                            Age_Txbox.Clear();
                            AddressStud_Txbx.Clear();
                            NewStud_Checkbx.Checked = false;
                            OldStud_CheckBox.Checked = false;
                            PlaceOfBirth_Txbx.Clear();
                            Female_RadioBtn.Checked = false;
                            MALE_RADIOBTN.Checked = false;
                            DOB_DateTimePickr.Value = DateTime.Now;
                            StudPicture_Pcturebox.Image = DefaultImage;

                            FathersName_Txbox.Clear();
                            FatherOccu_Txbx.Clear();
                            mothersName_txbx.Clear();
                            MotherOccu_Txbx.Clear();
                            TempoAddress_Txbx.Clear();
                            PermanentAddr_Txbx.Clear();
                            GuardMobileNo_Txbx.Clear();
                            TelephoneNo_Txbx.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }
        private void StudName_Txbox_TextChanged(object sender, EventArgs e)
        {

            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (StudName_Txbox.Text.Length <= 0) return;
            string s = StudName_Txbox.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = StudName_Txbox.SelectionStart;
                int curSelLength = StudName_Txbox.SelectionLength;
                StudName_Txbox.SelectionStart = 0;
                StudName_Txbox.SelectionLength = 1;
                StudName_Txbox.SelectedText = s.ToUpper();
                StudName_Txbox.SelectionStart = curSelStart;
                StudName_Txbox.SelectionLength = curSelLength;
            }
        }
        private void StudLastName_Txbox_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (StudLastName_Txbox.Text.Length <= 0) return;
            string s = StudLastName_Txbox.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = StudLastName_Txbox.SelectionStart;
                int curSelLength = StudLastName_Txbox.SelectionLength;
                StudLastName_Txbox.SelectionStart = 0;
                StudLastName_Txbox.SelectionLength = 1;
                StudLastName_Txbox.SelectedText = s.ToUpper();
                StudLastName_Txbox.SelectionStart = curSelStart;
                StudLastName_Txbox.SelectionLength = curSelLength;
            }
        }
        private void MiddleName_Txbox_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (MiddleName_Txbox.Text.Length <= 0) return;
            string s = MiddleName_Txbox.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = MiddleName_Txbox.SelectionStart;
                int curSelLength = MiddleName_Txbox.SelectionLength;
                MiddleName_Txbox.SelectionStart = 0;
                MiddleName_Txbox.SelectionLength = 1;
                MiddleName_Txbox.SelectedText = s.ToUpper();
                MiddleName_Txbox.SelectionStart = curSelStart;
                MiddleName_Txbox.SelectionLength = curSelLength;
            }
        }
        private void Status_Txbx_TextChanged(object sender, EventArgs e)
        {

            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (Status_Txbx.Text.Length <= 0) return;
            string s = Status_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = Status_Txbx.SelectionStart;
                int curSelLength = Status_Txbx.SelectionLength;
                Status_Txbx.SelectionStart = 0;
                Status_Txbx.SelectionLength = 1;
                Status_Txbx.SelectedText = s.ToUpper();
                Status_Txbx.SelectionStart = curSelStart;
                Status_Txbx.SelectionLength = curSelLength;
            }
        }
        private void PlaceOfBirth_Txbx_TextChanged(object sender, EventArgs e)
        {

            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (PlaceOfBirth_Txbx.Text.Length <= 0) return;
            string s = PlaceOfBirth_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = PlaceOfBirth_Txbx.SelectionStart;
                int curSelLength = PlaceOfBirth_Txbx.SelectionLength;
                PlaceOfBirth_Txbx.SelectionStart = 0;
                PlaceOfBirth_Txbx.SelectionLength = 1;
                PlaceOfBirth_Txbx.SelectedText = s.ToUpper();
                PlaceOfBirth_Txbx.SelectionStart = curSelStart;
                PlaceOfBirth_Txbx.SelectionLength = curSelLength;
            }
        }
        private void AddressStud_Txbx_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (AddressStud_Txbx.Text.Length <= 0) return;
            string s = AddressStud_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = AddressStud_Txbx.SelectionStart;
                int curSelLength = AddressStud_Txbx.SelectionLength;
                AddressStud_Txbx.SelectionStart = 0;
                AddressStud_Txbx.SelectionLength = 1;
                AddressStud_Txbx.SelectedText = s.ToUpper();
                AddressStud_Txbx.SelectionStart = curSelStart;
                AddressStud_Txbx.SelectionLength = curSelLength;
            }
        }
        private void FathersName_Txbox_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (FathersName_Txbox.Text.Length <= 0) return;
            string s = FathersName_Txbox.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = FathersName_Txbox.SelectionStart;
                int curSelLength = FathersName_Txbox.SelectionLength;
                FathersName_Txbox.SelectionStart = 0;
                FathersName_Txbox.SelectionLength = 1;
                FathersName_Txbox.SelectedText = s.ToUpper();
                FathersName_Txbox.SelectionStart = curSelStart;
                FathersName_Txbox.SelectionLength = curSelLength;
            }
        }
        private void mothersName_txbx_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (mothersName_txbx.Text.Length <= 0) return;
            string s = mothersName_txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = mothersName_txbx.SelectionStart;
                int curSelLength = mothersName_txbx.SelectionLength;
                mothersName_txbx.SelectionStart = 0;
                mothersName_txbx.SelectionLength = 1;
                mothersName_txbx.SelectedText = s.ToUpper();
                mothersName_txbx.SelectionStart = curSelStart;
                mothersName_txbx.SelectionLength = curSelLength;
            }
        }
        private void FatherOccu_Txbx_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (FatherOccu_Txbx.Text.Length <= 0) return;
            string s = FatherOccu_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = FatherOccu_Txbx.SelectionStart;
                int curSelLength = FatherOccu_Txbx.SelectionLength;
                FatherOccu_Txbx.SelectionStart = 0;
                FatherOccu_Txbx.SelectionLength = 1;
                FatherOccu_Txbx.SelectedText = s.ToUpper();
                FatherOccu_Txbx.SelectionStart = curSelStart;
                FatherOccu_Txbx.SelectionLength = curSelLength;
            }
        }
        private void MotherOccu_Txbx_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (MotherOccu_Txbx.Text.Length <= 0) return;
            string s = MotherOccu_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = MotherOccu_Txbx.SelectionStart;
                int curSelLength = MotherOccu_Txbx.SelectionLength;
                MotherOccu_Txbx.SelectionStart = 0;
                MotherOccu_Txbx.SelectionLength = 1;
                MotherOccu_Txbx.SelectedText = s.ToUpper();
                MotherOccu_Txbx.SelectionStart = curSelStart;
                MotherOccu_Txbx.SelectionLength = curSelLength;
            }
        }
        private void TempoAddress_Txbx_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (TempoAddress_Txbx.Text.Length <= 0) return;
            string s = TempoAddress_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = TempoAddress_Txbx.SelectionStart;
                int curSelLength = TempoAddress_Txbx.SelectionLength;
                TempoAddress_Txbx.SelectionStart = 0;
                TempoAddress_Txbx.SelectionLength = 1;
                TempoAddress_Txbx.SelectedText = s.ToUpper();
                TempoAddress_Txbx.SelectionStart = curSelStart;
                TempoAddress_Txbx.SelectionLength = curSelLength;
            }
        }
        private void PermanentAddr_Txbx_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (PermanentAddr_Txbx.Text.Length <= 0) return;
            string s = PermanentAddr_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = PermanentAddr_Txbx.SelectionStart;
                int curSelLength = PermanentAddr_Txbx.SelectionLength;
                PermanentAddr_Txbx.SelectionStart = 0;
                PermanentAddr_Txbx.SelectionLength = 1;
                PermanentAddr_Txbx.SelectedText = s.ToUpper();
                PermanentAddr_Txbx.SelectionStart = curSelStart;
                PermanentAddr_Txbx.SelectionLength = curSelLength;
            }
        }

        private void YearLevel_Cmbobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearLevel_Cmbobx.SelectedValue.ToString() != null)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                string sql = "SELECT * FROM CLASS_SECTION_TABLE WHERE YearID=@YearID";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                SqlCommand cmd2 = new SqlCommand(sql, connection);
                connection.Open();
                cmd2.Parameters.AddWithValue("@YearID", YearLevel_Cmbobx.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Class_cmbobx.ValueMember = "Year Level";
                Class_cmbobx.DisplayMember = "Class";
                Class_cmbobx.DataSource = dt;
                Class_cmbobx.Enabled = true;
            }
        }
    }
}
