using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem.UserControl_Forms
{
    public partial class StudentGrade_UserControl : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        
        // CONNECTION IN NAVIGATION FOR NEXT AND PREVIOUS BUTTON
        //SqlDataAdapter adapter;
        DataTable table = new DataTable();
        //int pos = 0;
        int count = 0;

        public StudentGrade_UserControl()
        {
            InitializeComponent();
            AutoCompleteStudentInfo();
        }
        private void AutoCompleteStudentInfo()
        {
            SqlCommand cmd = new SqlCommand("Select NAME + ' , ' + LASTNAME + ' , ' + [MIDDLE NAME]  FROM STUDENT_INFO_TABLE", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection collect = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                collect.Add(dr.GetString(0));
            }
            SearchStudentFullName_Txbox.AutoCompleteCustomSource = collect;
            con.Close();
        }

        private void SearchSubj_Btn_Click(object sender, EventArgs e)
        {
            SEARCH_STUDENT_INFO();
        }
        private void SEARCH_STUDENT_INFO() // FUNCTIONAL METHOD FOR SEARCH BUTTON AND DISPLAY THE STUDENT INFORMATION
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string query = "select * from STUDENT_INFO_TABLE where [STUDENT ID]= '" + Student_ID2_Txbx.Text.Trim() + "';";
            SqlConnection contaBase = new SqlConnection(constring);
            SqlCommand cmdBase = new SqlCommand(query, contaBase);

            SqlDataReader myReader;
            try
            {
                contaBase.Open();
                myReader = cmdBase.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        Student_ID2_Txbx.Text = myReader.GetInt32(0).ToString();
                        Student_ID_Txbx.Text = myReader.GetInt32(0).ToString();
                        SearchStudentFullName_Txbox.Text = myReader.GetValue(1).ToString();
                        StudName_Txbox.Text = myReader.GetValue(1).ToString();
                        LastName_Txbox.Text = myReader.GetValue(2).ToString();
                        MiddleName_Txbx.Text = myReader.GetValue(3).ToString();
                        Suffix_Combobx.Text = myReader.GetValue(4).ToString();
                        YearLevel_Txbx.Text = myReader.GetValue(5).ToString();
                        Class_Txbx.Text = myReader.GetValue(6).ToString();
                        Session_Txbx.Text = myReader.GetValue(7).ToString();
                    }
                    Search_Stud_Grade();
                    Search_Stud_Grade2();
                    Search_Stud_Grade3();
                    Search_Stud_Grade4();
                    Search_Stud_Grade5();
                    Search_Stud_Grade6();
                    Search_Stud_Grade7();
                    Search_Stud_Grade8();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "The " + Student_ID2_Txbx.Text.Trim() + " has not yet registered.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void SearchStudentFullName_Txbox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select [STUDENT ID] from STUDENT_INFO_TABLE where [STUDENT ID]='" + Student_ID_Txbx.Text.Trim() + "'", con);
            cmd.ExecuteNonQuery();  
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            con.Close();

            SearchStudentFullName_TexboxMethod();
            Search_Stud_Grade();
            Search_Stud_Grade2();
            Search_Stud_Grade3();
            Search_Stud_Grade4();
            Search_Stud_Grade5();
            Search_Stud_Grade6();
            Search_Stud_Grade7();
            Search_Stud_Grade8();
        }

        private void SearchStudentFullName_TexboxMethod() /* SEARCH STUDENT FULLNAME TEXTBOX */
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string query = "select * from STUDENT_INFO_TABLE where NAME= '" + SearchStudentFullName_Txbox.Text + "' OR LASTNAME= '" + SearchStudentFullName_Txbox.Text + "' OR [MIDDLE NAME]= '" + SearchStudentFullName_Txbox.Text + "'";
            SqlConnection contaBase = new SqlConnection(constring);
            SqlCommand cmdBase = new SqlCommand(query, contaBase);
            SqlDataReader myReader;
            try
            {
                contaBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {
                    Student_ID2_Txbx.Text = myReader.GetInt32(0).ToString();
                    Student_ID_Txbx.Text = myReader.GetInt32(0).ToString();
                    StudName_Txbox.Text = myReader.GetValue(1).ToString();
                    LastName_Txbox.Text = myReader.GetValue(2).ToString();
                    MiddleName_Txbx.Text = myReader.GetValue(3).ToString();
                    Suffix_Combobx.Text = myReader.GetValue(4).ToString();
                    YearLevel_Txbx.Text = myReader.GetValue(5).ToString();
                    Class_Txbx.Text = myReader.GetValue(6).ToString();
                    Session_Txbx.Text = myReader.GetValue(7).ToString();
                }

                if (SearchStudentFullName_Txbox.Text == string.Empty)
                {
                    Student_ID2_Txbx.Clear();
                    Student_ID_Txbx.Clear();
                    StudName_Txbox.Clear();
                    LastName_Txbox.Clear();
                    MiddleName_Txbx.Clear();
                    Suffix_Combobx.ResetText(); //Items.Clear();
                    YearLevel_Txbx.Clear();
                    Class_Txbx.Clear();
                    Session_Txbx.Clear();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }
        private void Search_Stud_Grade() //UPON SEARCHING THE STUDENT ID, THIS FUNCTIONAL METHOD WILL ALSO CALLED FOR ITS GRADE IN SUBJECT AND DISPLAY IT.
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string query = "select * from STUDENT_GRADE_TABLE where [STUDENT ID]= '" + Student_ID_Txbx.Text.Trim() + "';";
            SqlConnection contaBase = new SqlConnection(constring);
            SqlCommand cmdBase = new SqlCommand(query, contaBase);

            SqlDataReader myReader;
            try
            {
                contaBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {
                    SUBJ1_CMBOBX.Text = myReader.GetValue(4).ToString();
                    Prelim1_Txbx.Text = myReader.GetValue(5).ToString();
                    MidTerm1_TextBox.Text = myReader.GetValue(6).ToString();
                    Prefinal1_TextBox.Text = myReader.GetValue(7).ToString();
                    Final1_Txbx.Text = myReader.GetValue(8).ToString();
                    Average1_Txbx.Text = myReader.GetValue(9).ToString();
                    Remark1_Txbx.Text = myReader.GetValue(10).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Search_Stud_Grade2() //UPON SEARCHING THE STUDENT ID, THIS FUNCTIONAL METHOD WILL ALSO CALLED FOR ITS GRADE IN SUBJECT AND DISPLAY IT.
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string query = "select * from STUDENT_GRADE2_TABLE where [STUDENT ID]= '" + Student_ID_Txbx.Text.Trim() + "';";
            SqlConnection contaBase = new SqlConnection(constring);
            SqlCommand cmdBase = new SqlCommand(query, contaBase);

            SqlDataReader myReader;
            try
            {
                contaBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {
                    SUBJ2_CMBOBX.Text = myReader.GetValue(4).ToString();
                    Prelim2_Txbx.Text = myReader.GetValue(5).ToString();
                    MidTerm2_TextBox.Text = myReader.GetValue(6).ToString();
                    Prefinal2_TextBox.Text = myReader.GetValue(7).ToString();
                    Final2_Txbx.Text = myReader.GetValue(8).ToString();
                    Average2_Txbx.Text = myReader.GetValue(9).ToString();
                    Remark2_Txbx.Text = myReader.GetValue(10).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Search_Stud_Grade3() //UPON SEARCHING THE STUDENT ID, THIS FUNCTIONAL METHOD WILL ALSO CALLED FOR ITS GRADE IN SUBJECT AND DISPLAY IT.
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string query = "select * from STUDENT_GRADE3_TABLE where [STUDENT ID]= '" + Student_ID_Txbx.Text.Trim() + "';";
            SqlConnection contaBase = new SqlConnection(constring);
            SqlCommand cmdBase = new SqlCommand(query, contaBase);

            SqlDataReader myReader;
            try
            {
                contaBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {
                    SUBJ3_CMBOBX.Text = myReader.GetValue(4).ToString();
                    Prelim3_Txbx.Text = myReader.GetValue(5).ToString();
                    MidTerm3_TextBox.Text = myReader.GetValue(6).ToString();
                    Prefinal3_TextBox.Text = myReader.GetValue(7).ToString();
                    Final3_Txbx.Text = myReader.GetValue(8).ToString();
                    Average3_Txbx.Text = myReader.GetValue(9).ToString();
                    Remark3_Txbx.Text = myReader.GetValue(10).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Search_Stud_Grade4() //UPON SEARCHING THE STUDENT ID, THIS FUNCTIONAL METHOD WILL ALSO CALLED FOR ITS GRADE IN SUBJECT AND DISPLAY IT.
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string query = "select * from STUDENT_GRADE4_TABLE where [STUDENT ID]= '" + Student_ID_Txbx.Text.Trim() + "';";
            SqlConnection contaBase = new SqlConnection(constring);
            SqlCommand cmdBase = new SqlCommand(query, contaBase);

            SqlDataReader myReader;
            try
            {
                contaBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {
                    SUBJ4_CMBOBX.Text = myReader.GetValue(4).ToString();
                    Prelim4_Txbx.Text = myReader.GetValue(5).ToString();
                    MidTerm4_TextBox.Text = myReader.GetValue(6).ToString();
                    Prefinal4_TextBox.Text = myReader.GetValue(7).ToString();
                    Final4_Txbx.Text = myReader.GetValue(8).ToString();
                    Average4_Txbx.Text = myReader.GetValue(9).ToString();
                    Remark4_Txbx.Text = myReader.GetValue(10).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Search_Stud_Grade5() //UPON SEARCHING THE STUDENT ID, THIS FUNCTIONAL METHOD WILL ALSO CALLED FOR ITS GRADE IN SUBJECT AND DISPLAY IT.
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string query = "select * from STUDENT_GRADE5_TABLE where [STUDENT ID]= '" + Student_ID_Txbx.Text.Trim() + "';";
            SqlConnection contaBase = new SqlConnection(constring);
            SqlCommand cmdBase = new SqlCommand(query, contaBase);

            SqlDataReader myReader;
            try
            {
                contaBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {
                    SUBJ5_CMBOBX.Text = myReader.GetValue(4).ToString();
                    Prelim5_Txbx.Text = myReader.GetValue(5).ToString();
                    MidTerm5_TextBox.Text = myReader.GetValue(6).ToString();
                    Prefinal5_TextBox.Text = myReader.GetValue(7).ToString();
                    Final5_Txbx.Text = myReader.GetValue(8).ToString();
                    Average5_Txbx.Text = myReader.GetValue(9).ToString();
                    Remark5_Txbx.Text = myReader.GetValue(10).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Search_Stud_Grade6() //UPON SEARCHING THE STUDENT ID, THIS FUNCTIONAL METHOD WILL ALSO CALLED FOR ITS GRADE IN SUBJECT AND DISPLAY IT.
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string query = "select * from STUDENT_GRADE6_TABLE where [STUDENT ID]= '" + Student_ID_Txbx.Text.Trim() + "';";
            SqlConnection contaBase = new SqlConnection(constring);
            SqlCommand cmdBase = new SqlCommand(query, contaBase);

            SqlDataReader myReader;
            try
            {
                contaBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {
                    SUBJ6_CMBOBX.Text = myReader.GetValue(4).ToString();
                    Prelim6_Txbx.Text = myReader.GetValue(5).ToString();
                    MidTerm6_TextBox.Text = myReader.GetValue(6).ToString();
                    Prefinal6_TextBox.Text = myReader.GetValue(7).ToString();
                    Final6_Txbx.Text = myReader.GetValue(8).ToString();
                    Average6_Txbx.Text = myReader.GetValue(9).ToString();
                    Remark6_Txbx.Text = myReader.GetValue(10).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Search_Stud_Grade7() //UPON SEARCHING THE STUDENT ID, THIS FUNCTIONAL METHOD WILL ALSO CALLED FOR ITS GRADE IN SUBJECT AND DISPLAY IT.
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string query = "select * from STUDENT_GRADE7_TABLE where [STUDENT ID]= '" + Student_ID_Txbx.Text.Trim() + "';";
            SqlConnection contaBase = new SqlConnection(constring);
            SqlCommand cmdBase = new SqlCommand(query, contaBase);

            SqlDataReader myReader;
            try
            {
                contaBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {
                    SUBJ7_CMBOBX.Text = myReader.GetValue(4).ToString();
                    Prelim7_Txbx.Text = myReader.GetValue(5).ToString();
                    MidTerm7_TextBox.Text = myReader.GetValue(6).ToString();
                    Prefinal7_TextBox.Text = myReader.GetValue(7).ToString();
                    Final7_Txbx.Text = myReader.GetValue(8).ToString();
                    Average7_Txbx.Text = myReader.GetValue(9).ToString();
                    Remark7_Txbx.Text = myReader.GetValue(10).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Search_Stud_Grade8() //UPON SEARCHING THE STUDENT ID, THIS FUNCTIONAL METHOD WILL ALSO CALLED FOR ITS GRADE IN SUBJECT AND DISPLAY IT.
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string query = "select * from STUDENT_GRADE8_TABLE where [STUDENT ID]= '" + Student_ID_Txbx.Text.Trim() + "';";
            SqlConnection contaBase = new SqlConnection(constring);
            SqlCommand cmdBase = new SqlCommand(query, contaBase);

            SqlDataReader myReader;
            try
            {
                contaBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {
                    SUBJ8_CMBOBX.Text = myReader.GetValue(4).ToString();
                    Prelim8_Txbx.Text = myReader.GetValue(5).ToString();
                    MidTerm8_TextBox.Text = myReader.GetValue(6).ToString();
                    Prefinal8_TextBox.Text = myReader.GetValue(7).ToString();
                    Final8_Txbx.Text = myReader.GetValue(8).ToString();
                    Average8_Txbx.Text = myReader.GetValue(9).ToString();
                    Remark8_Txbx.Text = myReader.GetValue(10).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StudentGrade_UserControl_Load(object sender, EventArgs e)
        {
            Subject1_ComboboxMethod();
            Subject2_ComboboxMethod();
            Subject3_ComboboxMethod();
            Subject4_ComboboxMethod();
            Subject5_ComboboxMethod();
            Subject6_ComboboxMethod();
            Subject7_ComboboxMethod();
            Subject8_ComboboxMethod();
        }

        private void Subject1_ComboboxMethod()
        {
            SUBJ1_CMBOBX.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ADD_NEW_SUBJECT_TABLE ORDER BY SUBJECTS ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            SUBJ1_CMBOBX.ValueMember = "SUBJECT ID";
            SUBJ1_CMBOBX.DisplayMember = "SUBJECTS";
            SUBJ1_CMBOBX.DataSource = dt;
        }
        private void Subject2_ComboboxMethod()
        {
            SUBJ2_CMBOBX.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ADD_NEW_SUBJECT_TABLE ORDER BY SUBJECTS ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            SUBJ2_CMBOBX.ValueMember = "SUBJECT ID";
            SUBJ2_CMBOBX.DisplayMember = "SUBJECTS";
            SUBJ2_CMBOBX.DataSource = dt;
        }
        private void Subject3_ComboboxMethod()
        {
            SUBJ3_CMBOBX.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ADD_NEW_SUBJECT_TABLE ORDER BY SUBJECTS ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            SUBJ3_CMBOBX.ValueMember = "SUBJECT ID";
            SUBJ3_CMBOBX.DisplayMember = "SUBJECTS";
            SUBJ3_CMBOBX.DataSource = dt;
        }
        private void Subject4_ComboboxMethod()
        {
            SUBJ4_CMBOBX.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ADD_NEW_SUBJECT_TABLE ORDER BY SUBJECTS ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            SUBJ4_CMBOBX.ValueMember = "SUBJECT ID";
            SUBJ4_CMBOBX.DisplayMember = "SUBJECTS";
            SUBJ4_CMBOBX.DataSource = dt;
        }
        private void Subject5_ComboboxMethod()
        {
            SUBJ5_CMBOBX.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ADD_NEW_SUBJECT_TABLE ORDER BY SUBJECTS ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            SUBJ5_CMBOBX.ValueMember = "SUBJECT ID";
            SUBJ5_CMBOBX.DisplayMember = "SUBJECTS";
            SUBJ5_CMBOBX.DataSource = dt;
        }
        private void Subject6_ComboboxMethod()
        {
            SUBJ6_CMBOBX.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ADD_NEW_SUBJECT_TABLE ORDER BY SUBJECTS ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            SUBJ6_CMBOBX.ValueMember = "SUBJECT ID";
            SUBJ6_CMBOBX.DisplayMember = "SUBJECTS";
            SUBJ6_CMBOBX.DataSource = dt;
        }
        private void Subject7_ComboboxMethod()
        {
            SUBJ7_CMBOBX.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ADD_NEW_SUBJECT_TABLE ORDER BY SUBJECTS ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            SUBJ7_CMBOBX.ValueMember = "SUBJECT ID";
            SUBJ7_CMBOBX.DisplayMember = "SUBJECTS";
            SUBJ7_CMBOBX.DataSource = dt;
        }
        private void Subject8_ComboboxMethod()
        {
            SUBJ8_CMBOBX.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ADD_NEW_SUBJECT_TABLE ORDER BY SUBJECTS ASC";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            SUBJ8_CMBOBX.ValueMember = "SUBJECT ID";
            SUBJ8_CMBOBX.DisplayMember = "SUBJECTS";
            SUBJ8_CMBOBX.DataSource = dt;
        }

        private void AddStud_Grades_BTN_Click(object sender, EventArgs e)
        {
            StudentGradesMethod();
            Insert_all_subj_btn.Visible = false;
        }
        private void StudentGradesMethod()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("UPDATE STUDENT_GRADE_TABLE set NAME =@NAME, LASTNAME =@LASTNAME, [MIDDLE NAME] =@MIDDLE_NAME, SUBJECT =@SUBJECT, PRELIM =@PRELIM, MIDTERM =@MIDTERM, [PRE FINAL] =@PRE_FINAL, FINAL = @FINAL, AVERAGE =@AVERAGE, REMARK =@REMARK where [STUDENT ID]='" + Student_ID_Txbx.Text.Trim() + "'", connection))
                //using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO STUDENT_GRADE_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    //if (Student_ID_Txbx.Text != "" && SearchStudentFullName_Txbox.Text != string.Empty && SUBJ1_CMBOBX.SelectedText == "21st Century Literature from the Philippines and the World")
                    if (Student_ID_Txbx.Text != string.Empty && SearchStudentFullName_Txbox.Text != string.Empty)
                    {
                        try
                        {
                            UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                            UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                            UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                            UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                            UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ1_CMBOBX.Text);
                            UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim1_Txbx.Text);
                            UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm1_TextBox.Text);
                            UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal1_TextBox.Text);
                            UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final1_Txbx.Text);
                            UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average1_Txbx.Text);
                            UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark1_Txbx.Text);

                            UpdGradeCmd.ExecuteNonQuery();
                            MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataadapter.Fill(ds, "STUDENT_GRADE_TABLE");

                            StudentGradesMethod2();

                            connection.Close();

                            Student_ID2_Txbx.Clear();
                            Student_ID_Txbx.Clear();
                            StudName_Txbox.Clear();
                            LastName_Txbox.Clear();
                            MiddleName_Txbx.Clear();
                            Suffix_Combobx.ResetText();
                            YearLevel_Txbx.Clear();
                            Class_Txbx.Clear();
                            Session_Txbx.Clear();
                            SUBJ1_CMBOBX.ResetText();
                            Prelim1_Txbx.Clear();
                            MidTerm1_TextBox.Clear();
                            Prefinal1_TextBox.Clear();
                            Final1_Txbx.Clear();
                            Average1_Txbx.Clear();
                            Remark1_Txbx.Clear();
                            return;
                        }

                        catch (Exception ex)
                        {
                            MetroFramework.MetroMessageBox.Show(this, ex.Message);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given " + StudName_Txbox.Text.Trim() + "." + LastName_Txbox.Text.Trim() + ". Thank you!", "GRADE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void StudentGradesMethod2()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql2 = "SELECT * FROM STUDENT_GRADE2_TABLE";
                SqlDataAdapter dataadapter2 = new SqlDataAdapter(sql2, connection);
                DataSet ds2 = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd2 = new SqlCommand("UPDATE STUDENT_GRADE2_TABLE set NAME =@NAME, LASTNAME =@LASTNAME, [MIDDLE NAME] =@MIDDLE_NAME, SUBJECT =@SUBJECT, PRELIM =@PRELIM, MIDTERM =@MIDTERM, [PRE FINAL] =@PRE_FINAL, FINAL = @FINAL, AVERAGE =@AVERAGE, REMARK =@REMARK where [STUDENT ID]='" + Student_ID_Txbx.Text.Trim() + "'", connection))
                //using (SqlCommand UpdGradeCmd2 = new SqlCommand("INSERT INTO STUDENT_GRADE2_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    try
                    {
                        UpdGradeCmd2.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd2.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd2.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd2.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd2.Parameters.AddWithValue("@SUBJECT", SUBJ2_CMBOBX.Text);
                        UpdGradeCmd2.Parameters.AddWithValue("@PRELIM", Prelim2_Txbx.Text);
                        UpdGradeCmd2.Parameters.AddWithValue("@MIDTERM", MidTerm2_TextBox.Text);
                        UpdGradeCmd2.Parameters.AddWithValue("@PRE_FINAL", Prefinal2_TextBox.Text);
                        UpdGradeCmd2.Parameters.AddWithValue("@FINAL", Final2_Txbx.Text);
                        UpdGradeCmd2.Parameters.AddWithValue("@AVERAGE", Average2_Txbx.Text);
                        UpdGradeCmd2.Parameters.AddWithValue("@REMARK", Remark2_Txbx.Text);

                        UpdGradeCmd2.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter2.Fill(ds2, "STUDENT_GRADE2_TABLE");

                        StudentGradesMethod3();

                        connection.Close();

                        Student_ID2_Txbx.Clear();
                        Student_ID_Txbx.Clear();
                        StudName_Txbox.Clear();
                        LastName_Txbox.Clear();
                        MiddleName_Txbx.Clear();
                        Suffix_Combobx.ResetText();
                        YearLevel_Txbx.Clear();
                        Class_Txbx.Clear();
                        Session_Txbx.Clear();

                        SUBJ2_CMBOBX.ResetText();
                        Prelim2_Txbx.Clear();
                        MidTerm2_TextBox.Clear();
                        Prefinal2_TextBox.Clear();
                        Final2_Txbx.Clear();
                        Average2_Txbx.Clear();
                        Remark2_Txbx.Clear();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }
                }
            }
        }
        private void StudentGradesMethod3()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql3 = "SELECT * FROM STUDENT_GRADE3_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql3, connection);
                DataSet ds3 = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd3 = new SqlCommand("UPDATE STUDENT_GRADE3_TABLE set NAME =@NAME, LASTNAME =@LASTNAME, [MIDDLE NAME] =@MIDDLE_NAME, SUBJECT =@SUBJECT, PRELIM =@PRELIM, MIDTERM =@MIDTERM, [PRE FINAL] =@PRE_FINAL, FINAL = @FINAL, AVERAGE =@AVERAGE, REMARK =@REMARK where [STUDENT ID]='" + Student_ID_Txbx.Text.Trim() + "'", connection))
                //using (SqlCommand UpdGradeCmd3 = new SqlCommand("INSERT INTO STUDENT_GRADE3_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    try
                    {
                        UpdGradeCmd3.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd3.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd3.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd3.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd3.Parameters.AddWithValue("@SUBJECT", SUBJ3_CMBOBX.Text);
                        UpdGradeCmd3.Parameters.AddWithValue("@PRELIM", Prelim3_Txbx.Text);
                        UpdGradeCmd3.Parameters.AddWithValue("@MIDTERM", MidTerm3_TextBox.Text);
                        UpdGradeCmd3.Parameters.AddWithValue("@PRE_FINAL", Prefinal3_TextBox.Text);
                        UpdGradeCmd3.Parameters.AddWithValue("@FINAL", Final3_Txbx.Text);
                        UpdGradeCmd3.Parameters.AddWithValue("@AVERAGE", Average3_Txbx.Text);
                        UpdGradeCmd3.Parameters.AddWithValue("@REMARK", Remark3_Txbx.Text);

                        UpdGradeCmd3.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds3, "STUDENT_GRADE3_TABLE");

                        StudentGradesMethod4();

                        connection.Close();

                        Student_ID2_Txbx.Clear();
                        Student_ID_Txbx.Clear();
                        StudName_Txbox.Clear();
                        LastName_Txbox.Clear();
                        MiddleName_Txbx.Clear();
                        Suffix_Combobx.ResetText();
                        YearLevel_Txbx.Clear();
                        Class_Txbx.Clear();
                        Session_Txbx.Clear();

                        SUBJ3_CMBOBX.ResetText();
                        Prelim3_Txbx.Clear();
                        MidTerm3_TextBox.Clear();
                        Prefinal3_TextBox.Clear();
                        Final3_Txbx.Clear();
                        Average3_Txbx.Clear();
                        Remark3_Txbx.Clear();
                        return;

                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }
                }
            }
        }
        private void StudentGradesMethod4()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE4_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("UPDATE STUDENT_GRADE4_TABLE set NAME =@NAME, LASTNAME =@LASTNAME, [MIDDLE NAME] =@MIDDLE_NAME, SUBJECT =@SUBJECT, PRELIM =@PRELIM, MIDTERM =@MIDTERM, [PRE FINAL] =@PRE_FINAL, FINAL = @FINAL, AVERAGE =@AVERAGE, REMARK =@REMARK where [STUDENT ID]='" + Student_ID_Txbx.Text.Trim() + "'", connection))
                //using (SqlCommand UpdGradeCmd3 = new SqlCommand("INSERT INTO STUDENT_GRADE3_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    try
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ4_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim4_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm4_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal4_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final4_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average4_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark4_Txbx.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "STUDENT_GRADE4_TABLE");

                        StudentGradesMethod5();

                        connection.Close();

                        Student_ID2_Txbx.Clear();
                        Student_ID_Txbx.Clear();
                        StudName_Txbox.Clear();
                        LastName_Txbox.Clear();
                        MiddleName_Txbx.Clear();
                        Suffix_Combobx.ResetText();
                        YearLevel_Txbx.Clear();
                        Class_Txbx.Clear();
                        Session_Txbx.Clear();

                        SUBJ4_CMBOBX.ResetText();
                        Prelim4_Txbx.Clear();
                        MidTerm4_TextBox.Clear();
                        Prefinal4_TextBox.Clear();
                        Final4_Txbx.Clear();
                        Average4_Txbx.Clear();
                        Remark4_Txbx.Clear();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }
                }
            }
        }
        private void StudentGradesMethod5()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE5_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("UPDATE STUDENT_GRADE5_TABLE set NAME =@NAME, LASTNAME =@LASTNAME, [MIDDLE NAME] =@MIDDLE_NAME, SUBJECT =@SUBJECT, PRELIM =@PRELIM, MIDTERM =@MIDTERM, [PRE FINAL] =@PRE_FINAL, FINAL = @FINAL, AVERAGE =@AVERAGE, REMARK =@REMARK where [STUDENT ID]='" + Student_ID_Txbx.Text.Trim() + "'", connection))
                //using (SqlCommand UpdGradeCmd3 = new SqlCommand("INSERT INTO STUDENT_GRADE3_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    try
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ5_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim5_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm5_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal5_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final5_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average5_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark5_Txbx.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "STUDENT_GRADE5_TABLE");

                        StudentGradesMethod6();

                        connection.Close();

                        Student_ID2_Txbx.Clear();
                        Student_ID_Txbx.Clear();
                        StudName_Txbox.Clear();
                        LastName_Txbox.Clear();
                        MiddleName_Txbx.Clear();
                        Suffix_Combobx.ResetText();
                        YearLevel_Txbx.Clear();
                        Class_Txbx.Clear();
                        Session_Txbx.Clear();

                        SUBJ5_CMBOBX.ResetText();
                        Prelim5_Txbx.Clear();
                        MidTerm5_TextBox.Clear();
                        Prefinal5_TextBox.Clear();
                        Final5_Txbx.Clear();
                        Average5_Txbx.Clear();
                        Remark5_Txbx.Clear();
                        return;
                    }

                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }
                }
            }
        }
        private void StudentGradesMethod6()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE6_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("UPDATE STUDENT_GRADE6_TABLE set NAME =@NAME, LASTNAME =@LASTNAME, [MIDDLE NAME] =@MIDDLE_NAME, SUBJECT =@SUBJECT, PRELIM =@PRELIM, MIDTERM =@MIDTERM, [PRE FINAL] =@PRE_FINAL, FINAL = @FINAL, AVERAGE =@AVERAGE, REMARK =@REMARK where [STUDENT ID]='" + Student_ID_Txbx.Text.Trim() + "'", connection))
                //using (SqlCommand UpdGradeCmd3 = new SqlCommand("INSERT INTO STUDENT_GRADE3_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    try
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ6_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim6_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm6_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal6_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final6_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average6_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark6_Txbx.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "STUDENT_GRADE6_TABLE");

                        StudentGradesMethod7();

                        connection.Close();

                        Student_ID2_Txbx.Clear();
                        Student_ID_Txbx.Clear();
                        StudName_Txbox.Clear();
                        LastName_Txbox.Clear();
                        MiddleName_Txbx.Clear();
                        Suffix_Combobx.ResetText();
                        YearLevel_Txbx.Clear();
                        Class_Txbx.Clear();
                        Session_Txbx.Clear();

                        SUBJ6_CMBOBX.ResetText();
                        Prelim6_Txbx.Clear();
                        MidTerm6_TextBox.Clear();
                        Prefinal6_TextBox.Clear();
                        Final6_Txbx.Clear();
                        Average6_Txbx.Clear();
                        Remark6_Txbx.Clear();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }
                }
            }
        }
        private void StudentGradesMethod7()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE7_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("UPDATE STUDENT_GRADE7_TABLE set NAME =@NAME, LASTNAME =@LASTNAME, [MIDDLE NAME] =@MIDDLE_NAME, SUBJECT =@SUBJECT, PRELIM =@PRELIM, MIDTERM =@MIDTERM, [PRE FINAL] =@PRE_FINAL, FINAL = @FINAL, AVERAGE =@AVERAGE, REMARK =@REMARK where [STUDENT ID]='" + Student_ID_Txbx.Text.Trim() + "'", connection))
                //using (SqlCommand UpdGradeCmd3 = new SqlCommand("INSERT INTO STUDENT_GRADE3_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    try
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ7_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim7_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm7_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal7_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final7_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average7_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark7_Txbx.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "STUDENT_GRADE7_TABLE");

                        StudentGradesMethod8();

                        connection.Close();

                        Student_ID2_Txbx.Clear();
                        Student_ID_Txbx.Clear();
                        StudName_Txbox.Clear();
                        LastName_Txbox.Clear();
                        MiddleName_Txbx.Clear();
                        Suffix_Combobx.ResetText();
                        YearLevel_Txbx.Clear();
                        Class_Txbx.Clear();
                        Session_Txbx.Clear();

                        SUBJ7_CMBOBX.ResetText();
                        Prelim7_Txbx.Clear();
                        MidTerm7_TextBox.Clear();
                        Prefinal7_TextBox.Clear();
                        Final7_Txbx.Clear();
                        Average7_Txbx.Clear();
                        Remark7_Txbx.Clear();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }
                }
            }
        }
        private void StudentGradesMethod8()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE8_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("UPDATE STUDENT_GRADE8_TABLE set NAME =@NAME, LASTNAME =@LASTNAME, [MIDDLE NAME] =@MIDDLE_NAME, SUBJECT =@SUBJECT, PRELIM =@PRELIM, MIDTERM =@MIDTERM, [PRE FINAL] =@PRE_FINAL, FINAL = @FINAL, AVERAGE =@AVERAGE, REMARK =@REMARK where [STUDENT ID]='" + Student_ID_Txbx.Text.Trim() + "'", connection))
                //using (SqlCommand UpdGradeCmd3 = new SqlCommand("INSERT INTO STUDENT_GRADE3_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    try
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ8_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim8_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm8_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal8_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final8_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average8_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark8_Txbx.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "STUDENT_GRADE8_TABLE");
                        connection.Close();

                        Student_ID2_Txbx.Clear();
                        Student_ID_Txbx.Clear();
                        StudName_Txbox.Clear();
                        LastName_Txbox.Clear();
                        MiddleName_Txbx.Clear();
                        Suffix_Combobx.ResetText();
                        YearLevel_Txbx.Clear();
                        Class_Txbx.Clear();
                        Session_Txbx.Clear();

                        SUBJ8_CMBOBX.ResetText();
                        Prelim8_Txbx.Clear();
                        MidTerm8_TextBox.Clear();
                        Prefinal8_TextBox.Clear();
                        Final8_Txbx.Clear();
                        Average8_Txbx.Clear();
                        Remark8_Txbx.Clear();
                        return;
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }
                }
            }
        }

        private void AddSubj1_Btn_Click(object sender, EventArgs e)
        {
            Panel_Subj2.Visible = true;
            AddSubj1_Btn.Visible = false;
        }
        private void AddSubj2_Btn_Click(object sender, EventArgs e)
        {
            Panel_Subj3.Visible = true;
            AddSubj2_Btn.Visible = false;
        }
        private void AddSubj3_Btn_Click(object sender, EventArgs e)
        {
            Panel_Subj4.Visible = true;
            AddSubj3_Btn.Visible = false;
        }
        private void AddSubj4_Btn_Click(object sender, EventArgs e)
        {

            Panel_Subj5.Visible = true;
            AddSubj4_Btn.Visible = false;
        }
        private void AddSubj5_Btn_Click(object sender, EventArgs e)
        { 
            Panel_Subj6.Visible = true;
            AddSubj5_Btn.Visible = false;
        }
        private void AddSubj6_Btn_Click(object sender, EventArgs e)
        {
            Panel_Subj7.Visible = true;
            AddSubj6_Btn.Visible = false;
        }
        private void AddSubj7_Btn_Click(object sender, EventArgs e)
        {
            Panel_Subj8.Visible = true;
            AddSubj7_Btn.Visible = false;
        }
        private void Close_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\n Do you want to close the program?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void Prelim1_Txbx_TextChanged(object sender, EventArgs e)
        {
            if (Prelim1_Txbx.Text == "" || MidTerm1_TextBox.Text == "" || Prefinal1_TextBox.Text == "" || Final1_Txbx.Text == "")
            {
                Average1_Txbx.Clear();
                Remark1_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim1_Txbx.Text);
                midterm = double.Parse(MidTerm1_TextBox.Text);
                prefinal = double.Parse(Prefinal1_TextBox.Text);
                final = double.Parse(Final1_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average1_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark1_Txbx.Text = ave.ToString("Passed");
                    Remark1_Txbx.Font = new Font(Remark1_Txbx.Font, FontStyle.Bold);
                    Remark1_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark1_Txbx.Text = ave.ToString("Failed");
                    Remark1_Txbx.Font = new Font(Remark1_Txbx.Font, FontStyle.Bold);
                    Remark1_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void MidTerm1_TextBox_TextChanged(object sender, EventArgs e)
        {

            if (Prelim1_Txbx.Text == "" || MidTerm1_TextBox.Text == "" || Prefinal1_TextBox.Text == "" || Final1_Txbx.Text == "")
            {
                Average1_Txbx.Clear();
                Remark1_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim1_Txbx.Text);
                midterm = double.Parse(MidTerm1_TextBox.Text);
                prefinal = double.Parse(Prefinal1_TextBox.Text);
                final = double.Parse(Final1_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average1_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark1_Txbx.Text = ave.ToString("Passed");
                    Remark1_Txbx.Font = new Font(Remark1_Txbx.Font, FontStyle.Bold);
                    Remark1_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark1_Txbx.Text = ave.ToString("Failed");
                    Remark1_Txbx.Font = new Font(Remark1_Txbx.Font, FontStyle.Bold);
                    Remark1_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Prefinal1_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Prelim1_Txbx.Text == "" || MidTerm1_TextBox.Text == "" || Prefinal1_TextBox.Text == "" || Final1_Txbx.Text == "")
            {
                Average1_Txbx.Clear();
                Remark1_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim1_Txbx.Text);
                midterm = double.Parse(MidTerm1_TextBox.Text);
                prefinal = double.Parse(Prefinal1_TextBox.Text);
                final = double.Parse(Final1_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average1_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark1_Txbx.Text = ave.ToString("Passed");
                    Remark1_Txbx.Font = new Font(Remark1_Txbx.Font, FontStyle.Bold);
                    Remark1_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark1_Txbx.Text = ave.ToString("Failed");
                    Remark1_Txbx.Font = new Font(Remark1_Txbx.Font, FontStyle.Bold);
                    Remark1_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Final1_Txbx_TextChanged(object sender, EventArgs e)
        {
            if (Prelim1_Txbx.Text == "" || MidTerm1_TextBox.Text == "" || Prefinal1_TextBox.Text == "" || Final1_Txbx.Text == "")
            {
                Average1_Txbx.Clear();
                Remark1_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim1_Txbx.Text);
                midterm = double.Parse(MidTerm1_TextBox.Text);
                prefinal = double.Parse(Prefinal1_TextBox.Text);
                final = double.Parse(Final1_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average1_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark1_Txbx.Text = ave.ToString("Passed");
                    Remark1_Txbx.Font = new Font(Remark1_Txbx.Font, FontStyle.Bold);
                    Remark1_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark1_Txbx.Text = ave.ToString("Failed");
                    Remark1_Txbx.Font = new Font(Remark1_Txbx.Font, FontStyle.Bold);
                    Remark1_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }

        private void Prelim2_Txbx_TextChanged(object sender, EventArgs e)
        {
            if (Prelim2_Txbx.Text == "" || MidTerm2_TextBox.Text == "" || Prefinal2_TextBox.Text == "" || Final2_Txbx.Text == "")
            {
                Average2_Txbx.Clear();
                Remark2_Txbx.Clear();
            }
            {
                try
                {
                    const double HIGH_SCORE = 75.0; // high Score value
                    double prelim, midterm, prefinal, final; // holds test scores
                    double ave;                 // holds average score

                    // Get the 4 test scores - MUST parse - why?
                    prelim = double.Parse(Prelim2_Txbx.Text);
                    midterm = double.Parse(MidTerm2_TextBox.Text);
                    prefinal = double.Parse(Prefinal2_TextBox.Text);
                    final = double.Parse(Final2_Txbx.Text);

                    // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                    ave = (prelim + midterm + prefinal + final) / 4.0;
                    Average2_Txbx.Text = ave.ToString();

                    // If the average is a high score, congratulate
                    // the user with a message box
                    if (ave > HIGH_SCORE)
                    {
                        Remark2_Txbx.Text = ave.ToString("Passed");
                        Remark2_Txbx.Font = new Font(Remark2_Txbx.Font, FontStyle.Bold);
                        Remark2_Txbx.ForeColor = Color.Blue;
                    }
                    else if (ave <= 75)
                    {
                        Remark2_Txbx.Text = ave.ToString("Failed");
                        Remark2_Txbx.Font = new Font(Remark2_Txbx.Font, FontStyle.Bold);
                        Remark2_Txbx.ForeColor = Color.Red;
                    }
                }
                catch
                {
                }
            }
        }
        private void MidTerm2_TextBox_TextChanged(object sender, EventArgs e)
        {

            if (Prelim2_Txbx.Text == "" || MidTerm2_TextBox.Text == "" || Prefinal2_TextBox.Text == "" || Final2_Txbx.Text == "")
            {
                //MidTerm2_TextBox.Clear();
                Average2_Txbx.Clear();
                Remark2_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim2_Txbx.Text);
                midterm = double.Parse(MidTerm2_TextBox.Text);
                prefinal = double.Parse(Prefinal2_TextBox.Text);
                final = double.Parse(Final2_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average2_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark2_Txbx.Text = ave.ToString("Passed");
                    Remark2_Txbx.Font = new Font(Remark2_Txbx.Font, FontStyle.Bold);
                    Remark2_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark2_Txbx.Text = ave.ToString("Failed");
                    Remark2_Txbx.Font = new Font(Remark2_Txbx.Font, FontStyle.Bold);
                    Remark2_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Prefinal2_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Prelim2_Txbx.Text == "" || MidTerm2_TextBox.Text == "" || Prefinal2_TextBox.Text == "" || Final2_Txbx.Text == "")
            {
                //MidTerm2_TextBox.Clear();
                Average2_Txbx.Clear();
                Remark2_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim2_Txbx.Text);
                midterm = double.Parse(MidTerm2_TextBox.Text);
                prefinal = double.Parse(Prefinal2_TextBox.Text);
                final = double.Parse(Final2_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average2_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark2_Txbx.Text = ave.ToString("Passed");
                    Remark2_Txbx.Font = new Font(Remark2_Txbx.Font, FontStyle.Bold);
                    Remark2_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark2_Txbx.Text = ave.ToString("Failed");
                    Remark2_Txbx.Font = new Font(Remark2_Txbx.Font, FontStyle.Bold);
                    Remark2_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Final2_Txbx_TextChanged(object sender, EventArgs e)
        {
            if (Prelim2_Txbx.Text == "" || MidTerm2_TextBox.Text == "" || Prefinal2_TextBox.Text == "" || Final2_Txbx.Text == "")
            {
                Average2_Txbx.Clear();
                Remark2_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim2_Txbx.Text);
                midterm = double.Parse(MidTerm2_TextBox.Text);
                prefinal = double.Parse(Prefinal2_TextBox.Text);
                final = double.Parse(Final2_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average2_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark2_Txbx.Text = ave.ToString("Passed");
                    Remark2_Txbx.Font = new Font(Remark2_Txbx.Font, FontStyle.Bold);
                    Remark2_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark2_Txbx.Text = ave.ToString("Failed");
                    Remark2_Txbx.Font = new Font(Remark2_Txbx.Font, FontStyle.Bold);
                    Remark2_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }

        private void Prelim3_Txbx_TextChanged(object sender, EventArgs e)
        {
            if (Prelim3_Txbx.Text == "" || MidTerm3_TextBox.Text == "" || Prefinal3_TextBox.Text == "" || Final3_Txbx.Text == "")
            {
                Average3_Txbx.Clear();
                Remark3_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim3_Txbx.Text);
                midterm = double.Parse(MidTerm3_TextBox.Text);
                prefinal = double.Parse(Prefinal3_TextBox.Text);
                final = double.Parse(Final3_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average3_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark3_Txbx.Text = ave.ToString("Passed");
                    Remark3_Txbx.Font = new Font(Remark3_Txbx.Font, FontStyle.Bold);
                    Remark3_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark3_Txbx.Text = ave.ToString("Failed");
                    Remark3_Txbx.Font = new Font(Remark3_Txbx.Font, FontStyle.Bold);
                    Remark3_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void MidTerm3_TextBox_TextChanged(object sender, EventArgs e)
        {

            if (Prelim3_Txbx.Text == "" || MidTerm3_TextBox.Text == "" || Prefinal3_TextBox.Text == "" || Final3_Txbx.Text == "")
            {
                Average3_Txbx.Clear();
                Remark3_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim3_Txbx.Text);
                midterm = double.Parse(MidTerm3_TextBox.Text);
                prefinal = double.Parse(Prefinal3_TextBox.Text);
                final = double.Parse(Final3_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average3_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark3_Txbx.Text = ave.ToString("Passed");
                    Remark3_Txbx.Font = new Font(Remark3_Txbx.Font, FontStyle.Bold);
                    Remark3_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark3_Txbx.Text = ave.ToString("Failed");
                    Remark3_Txbx.Font = new Font(Remark3_Txbx.Font, FontStyle.Bold);
                    Remark3_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Prefinal3_TextBox_TextChanged(object sender, EventArgs e)
        {

            if (Prelim3_Txbx.Text == "" || MidTerm3_TextBox.Text == "" || Prefinal3_TextBox.Text == "" || Final3_Txbx.Text == "")
            {
                Average3_Txbx.Clear();
                Remark3_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim3_Txbx.Text);
                midterm = double.Parse(MidTerm3_TextBox.Text);
                prefinal = double.Parse(Prefinal3_TextBox.Text);
                final = double.Parse(Final3_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average3_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark3_Txbx.Text = ave.ToString("Passed");
                    Remark3_Txbx.Font = new Font(Remark3_Txbx.Font, FontStyle.Bold);
                    Remark3_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark3_Txbx.Text = ave.ToString("Failed");
                    Remark3_Txbx.Font = new Font(Remark3_Txbx.Font, FontStyle.Bold);
                    Remark3_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Final3_Txbx_TextChanged(object sender, EventArgs e)
        {
            if (Prelim3_Txbx.Text == "" || MidTerm3_TextBox.Text == "" || Prefinal3_TextBox.Text == "" || Final3_Txbx.Text == "")
            {
                Average3_Txbx.Clear();
                Remark3_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim3_Txbx.Text);
                midterm = double.Parse(MidTerm3_TextBox.Text);
                prefinal = double.Parse(Prefinal3_TextBox.Text);
                final = double.Parse(Final3_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average3_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark3_Txbx.Text = ave.ToString("Passed");
                    Remark3_Txbx.Font = new Font(Remark3_Txbx.Font, FontStyle.Bold);
                    Remark3_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark3_Txbx.Text = ave.ToString("Failed");
                    Remark3_Txbx.Font = new Font(Remark3_Txbx.Font, FontStyle.Bold);
                    Remark3_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }

        private void Prelim4_Txbx_TextChanged(object sender, EventArgs e)
        {
            if (Prelim4_Txbx.Text == "" || MidTerm4_TextBox.Text == "" || Prefinal4_TextBox.Text == "" || Final4_Txbx.Text == "")
            {
                Average4_Txbx.Clear();
                Remark4_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim4_Txbx.Text);
                midterm = double.Parse(MidTerm4_TextBox.Text);
                prefinal = double.Parse(Prefinal4_TextBox.Text);
                final = double.Parse(Final4_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average4_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark4_Txbx.Text = ave.ToString("Passed");
                    Remark4_Txbx.Font = new Font(Remark4_Txbx.Font, FontStyle.Bold);
                    Remark4_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark4_Txbx.Text = ave.ToString("Failed");
                    Remark4_Txbx.Font = new Font(Remark4_Txbx.Font, FontStyle.Bold);
                    Remark4_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void MidTerm4_TextBox_TextChanged(object sender, EventArgs e)
        {

            if (Prelim4_Txbx.Text == "" || MidTerm4_TextBox.Text == "" || Prefinal4_TextBox.Text == "" || Final4_Txbx.Text == "")
            {
                Average4_Txbx.Clear();
                Remark4_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim4_Txbx.Text);
                midterm = double.Parse(MidTerm4_TextBox.Text);
                prefinal = double.Parse(Prefinal4_TextBox.Text);
                final = double.Parse(Final4_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average4_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark4_Txbx.Text = ave.ToString("Passed");
                    Remark4_Txbx.Font = new Font(Remark4_Txbx.Font, FontStyle.Bold);
                    Remark4_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark4_Txbx.Text = ave.ToString("Failed");
                    Remark4_Txbx.Font = new Font(Remark4_Txbx.Font, FontStyle.Bold);
                    Remark4_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Prefinal4_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Prelim4_Txbx.Text == "" || MidTerm4_TextBox.Text == "" || Prefinal4_TextBox.Text == "" || Final4_Txbx.Text == "")
            {
                Average4_Txbx.Clear();
                Remark4_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim4_Txbx.Text);
                midterm = double.Parse(MidTerm4_TextBox.Text);
                prefinal = double.Parse(Prefinal4_TextBox.Text);
                final = double.Parse(Final4_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average4_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark4_Txbx.Text = ave.ToString("Passed");
                    Remark4_Txbx.Font = new Font(Remark4_Txbx.Font, FontStyle.Bold);
                    Remark4_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark4_Txbx.Text = ave.ToString("Failed");
                    Remark4_Txbx.Font = new Font(Remark4_Txbx.Font, FontStyle.Bold);
                    Remark4_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Final4_Txbx_TextChanged(object sender, EventArgs e)
        {
            if (Prelim4_Txbx.Text == "" || MidTerm4_TextBox.Text == "" || Prefinal4_TextBox.Text == "" || Final4_Txbx.Text == "")
            {
                Average4_Txbx.Clear();
                Remark4_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim4_Txbx.Text);
                midterm = double.Parse(MidTerm4_TextBox.Text);
                prefinal = double.Parse(Prefinal4_TextBox.Text);
                final = double.Parse(Final4_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average4_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark4_Txbx.Text = ave.ToString("Passed");
                    Remark4_Txbx.Font = new Font(Remark4_Txbx.Font, FontStyle.Bold);
                    Remark4_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark4_Txbx.Text = ave.ToString("Failed");
                    Remark4_Txbx.Font = new Font(Remark4_Txbx.Font, FontStyle.Bold);
                    Remark4_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }

        private void Prelim5_Txbx_TextChanged(object sender, EventArgs e)
        {
            if (Prelim5_Txbx.Text == "" || MidTerm5_TextBox.Text == "" || Prefinal5_TextBox.Text == "" || Final5_Txbx.Text == "")
            {
                Average5_Txbx.Clear();
                Remark5_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim5_Txbx.Text);
                midterm = double.Parse(MidTerm5_TextBox.Text);
                prefinal = double.Parse(Prefinal5_TextBox.Text);
                final = double.Parse(Final5_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average5_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark5_Txbx.Text = ave.ToString("Passed");
                    Remark5_Txbx.Font = new Font(Remark5_Txbx.Font, FontStyle.Bold);
                    Remark5_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark5_Txbx.Text = ave.ToString("Failed");
                    Remark5_Txbx.Font = new Font(Remark5_Txbx.Font, FontStyle.Bold);
                    Remark5_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void MidTerm5_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Prelim5_Txbx.Text == "" || MidTerm5_TextBox.Text == "" || Prefinal5_TextBox.Text == "" || Final5_Txbx.Text == "")
            {
                Average5_Txbx.Clear();
                Remark5_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim5_Txbx.Text);
                midterm = double.Parse(MidTerm5_TextBox.Text);
                prefinal = double.Parse(Prefinal5_TextBox.Text);
                final = double.Parse(Final5_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average5_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark5_Txbx.Text = ave.ToString("Passed");
                    Remark5_Txbx.Font = new Font(Remark5_Txbx.Font, FontStyle.Bold);
                    Remark5_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark5_Txbx.Text = ave.ToString("Failed");
                    Remark5_Txbx.Font = new Font(Remark5_Txbx.Font, FontStyle.Bold);
                    Remark5_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Prefinal5_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Prelim5_Txbx.Text == "" || MidTerm5_TextBox.Text == "" || Prefinal5_TextBox.Text == "" || Final5_Txbx.Text == "")
            {
                Average5_Txbx.Clear();
                Remark5_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim5_Txbx.Text);
                midterm = double.Parse(MidTerm5_TextBox.Text);
                prefinal = double.Parse(Prefinal5_TextBox.Text);
                final = double.Parse(Final5_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average5_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark5_Txbx.Text = ave.ToString("Passed");
                    Remark5_Txbx.Font = new Font(Remark5_Txbx.Font, FontStyle.Bold);
                    Remark5_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark5_Txbx.Text = ave.ToString("Failed");
                    Remark5_Txbx.Font = new Font(Remark5_Txbx.Font, FontStyle.Bold);
                    Remark5_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Final5_Txbx_TextChanged(object sender, EventArgs e)
        {
            if (Prelim5_Txbx.Text == "" || MidTerm5_TextBox.Text == "" || Prefinal5_TextBox.Text == "" || Final5_Txbx.Text == "")
            {
                Average5_Txbx.Clear();
                Remark5_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim5_Txbx.Text);
                midterm = double.Parse(MidTerm5_TextBox.Text);
                prefinal = double.Parse(Prefinal5_TextBox.Text);
                final = double.Parse(Final5_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average5_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark5_Txbx.Text = ave.ToString("Passed");
                    Remark5_Txbx.Font = new Font(Remark5_Txbx.Font, FontStyle.Bold);
                    Remark5_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark5_Txbx.Text = ave.ToString("Failed");
                    Remark5_Txbx.Font = new Font(Remark5_Txbx.Font, FontStyle.Bold);
                    Remark5_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }

        private void Prelim6_Txbx_TextChanged(object sender, EventArgs e)
        {

            if (Prelim6_Txbx.Text == "" || MidTerm6_TextBox.Text == "" || Prefinal6_TextBox.Text == "" || Final6_Txbx.Text == "")
            {
                Average6_Txbx.Clear();
                Remark6_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim6_Txbx.Text);
                midterm = double.Parse(MidTerm6_TextBox.Text);
                prefinal = double.Parse(Prefinal6_TextBox.Text);
                final = double.Parse(Final6_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average6_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark6_Txbx.Text = ave.ToString("Passed");
                    Remark6_Txbx.Font = new Font(Remark6_Txbx.Font, FontStyle.Bold);
                    Remark6_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark6_Txbx.Text = ave.ToString("Failed");
                    Remark6_Txbx.Font = new Font(Remark6_Txbx.Font, FontStyle.Bold);
                    Remark6_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void MidTerm6_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Prelim6_Txbx.Text == "" || MidTerm6_TextBox.Text == "" || Prefinal6_TextBox.Text == "" || Final6_Txbx.Text == "")
            {
                Average6_Txbx.Clear();
                Remark6_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim6_Txbx.Text);
                midterm = double.Parse(MidTerm6_TextBox.Text);
                prefinal = double.Parse(Prefinal6_TextBox.Text);
                final = double.Parse(Final6_Txbx.Text);


                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average6_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark6_Txbx.Text = ave.ToString("Passed");
                    Remark6_Txbx.Font = new Font(Remark6_Txbx.Font, FontStyle.Bold);
                    Remark6_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark6_Txbx.Text = ave.ToString("Failed");
                    Remark6_Txbx.Font = new Font(Remark6_Txbx.Font, FontStyle.Bold);
                    Remark6_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Prefinal6_TextBox_TextChanged(object sender, EventArgs e)
        {

            if (Prelim6_Txbx.Text == "" || MidTerm6_TextBox.Text == "" || Prefinal6_TextBox.Text == "" || Final6_Txbx.Text == "")
            {
                Average6_Txbx.Clear();
                Remark6_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim6_Txbx.Text);
                midterm = double.Parse(MidTerm6_TextBox.Text);
                prefinal = double.Parse(Prefinal6_TextBox.Text);
                final = double.Parse(Final6_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average6_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark6_Txbx.Text = ave.ToString("Passed");
                    Remark6_Txbx.Font = new Font(Remark6_Txbx.Font, FontStyle.Bold);
                    Remark6_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark6_Txbx.Text = ave.ToString("Failed");
                    Remark6_Txbx.Font = new Font(Remark6_Txbx.Font, FontStyle.Bold);
                    Remark6_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Final6_Txbx_TextChanged(object sender, EventArgs e)
        {
            if (Prelim6_Txbx.Text == "" || MidTerm6_TextBox.Text == "" || Prefinal6_TextBox.Text == "" || Final6_Txbx.Text == "")
            {
                Average6_Txbx.Clear();
                Remark6_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim6_Txbx.Text);
                midterm = double.Parse(MidTerm6_TextBox.Text);
                prefinal = double.Parse(Prefinal6_TextBox.Text);
                final = double.Parse(Final6_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average6_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark6_Txbx.Text = ave.ToString("Passed");
                    Remark6_Txbx.Font = new Font(Remark6_Txbx.Font, FontStyle.Bold);
                    Remark6_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark6_Txbx.Text = ave.ToString("Failed");
                    Remark6_Txbx.Font = new Font(Remark6_Txbx.Font, FontStyle.Bold);
                    Remark6_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }

        private void Prelim7_Txbx_TextChanged(object sender, EventArgs e)
        {

            if (Prelim7_Txbx.Text == "" || MidTerm7_TextBox.Text == "" || Prefinal7_TextBox.Text == "" || Final7_Txbx.Text == "")
            {
                Average7_Txbx.Clear();
                Remark7_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim7_Txbx.Text);
                midterm = double.Parse(MidTerm7_TextBox.Text);
                prefinal = double.Parse(Prefinal7_TextBox.Text);
                final = double.Parse(Final7_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average7_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark7_Txbx.Text = ave.ToString("Passed");
                    Remark7_Txbx.Font = new Font(Remark7_Txbx.Font, FontStyle.Bold);
                    Remark7_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark7_Txbx.Text = ave.ToString("Failed");
                    Remark7_Txbx.Font = new Font(Remark7_Txbx.Font, FontStyle.Bold);
                    Remark7_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void MidTerm7_TextBox_TextChanged(object sender, EventArgs e)
        {

            if (Prelim7_Txbx.Text == "" || MidTerm7_TextBox.Text == "" || Prefinal7_TextBox.Text == "" || Final7_Txbx.Text == "")
            {
                Average7_Txbx.Clear();
                Remark7_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim7_Txbx.Text);
                midterm = double.Parse(MidTerm7_TextBox.Text);
                prefinal = double.Parse(Prefinal7_TextBox.Text);
                final = double.Parse(Final7_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average7_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark7_Txbx.Text = ave.ToString("Passed");
                    Remark7_Txbx.Font = new Font(Remark7_Txbx.Font, FontStyle.Bold);
                    Remark7_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark7_Txbx.Text = ave.ToString("Failed");
                    Remark7_Txbx.Font = new Font(Remark7_Txbx.Font, FontStyle.Bold);
                    Remark7_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Prefinal7_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Prelim7_Txbx.Text == "" || MidTerm7_TextBox.Text == "" || Prefinal7_TextBox.Text == "" || Final7_Txbx.Text == "")
            {
                Average7_Txbx.Clear();
                Remark7_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim7_Txbx.Text);
                midterm = double.Parse(MidTerm7_TextBox.Text);
                prefinal = double.Parse(Prefinal7_TextBox.Text);
                final = double.Parse(Final7_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average7_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark7_Txbx.Text = ave.ToString("Passed");
                    Remark7_Txbx.Font = new Font(Remark7_Txbx.Font, FontStyle.Bold);
                    Remark7_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark7_Txbx.Text = ave.ToString("Failed");
                    Remark7_Txbx.Font = new Font(Remark7_Txbx.Font, FontStyle.Bold);
                    Remark7_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Final7_Txbx_TextChanged(object sender, EventArgs e)
        {

            if (Prelim7_Txbx.Text == "" || MidTerm7_TextBox.Text == "" || Prefinal7_TextBox.Text == "" || Final7_Txbx.Text == "")
            {
                Average7_Txbx.Clear();
                Remark7_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim7_Txbx.Text);
                midterm = double.Parse(MidTerm7_TextBox.Text);
                prefinal = double.Parse(Prefinal7_TextBox.Text);
                final = double.Parse(Final7_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average7_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark7_Txbx.Text = ave.ToString("Passed");
                    Remark7_Txbx.Font = new Font(Remark7_Txbx.Font, FontStyle.Bold);
                    Remark7_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark7_Txbx.Text = ave.ToString("Failed");
                    Remark7_Txbx.Font = new Font(Remark7_Txbx.Font, FontStyle.Bold);
                    Remark7_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }

        private void Prelim8_Txbx_TextChanged(object sender, EventArgs e)
        {

            if (Prelim8_Txbx.Text == "" || MidTerm8_TextBox.Text == "" || Prefinal8_TextBox.Text == "" || Final8_Txbx.Text == "")
            {
                Average8_Txbx.Clear();
                Remark8_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim8_Txbx.Text);
                midterm = double.Parse(MidTerm8_TextBox.Text);
                prefinal = double.Parse(Prefinal8_TextBox.Text);
                final = double.Parse(Final8_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average8_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark8_Txbx.Text = ave.ToString("Passed");
                    Remark8_Txbx.Font = new Font(Remark8_Txbx.Font, FontStyle.Bold);
                    Remark8_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark8_Txbx.Text = ave.ToString("Failed");
                    Remark8_Txbx.Font = new Font(Remark8_Txbx.Font, FontStyle.Bold);
                    Remark8_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void MidTerm8_TextBox_TextChanged(object sender, EventArgs e)
        {

            if (Prelim8_Txbx.Text == "" || MidTerm8_TextBox.Text == "" || Prefinal8_TextBox.Text == "" || Final8_Txbx.Text == "")
            {
                Average8_Txbx.Clear();
                Remark8_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim8_Txbx.Text);
                midterm = double.Parse(MidTerm8_TextBox.Text);
                prefinal = double.Parse(Prefinal8_TextBox.Text);
                final = double.Parse(Final8_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average8_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark8_Txbx.Text = ave.ToString("Passed");
                    Remark8_Txbx.Font = new Font(Remark8_Txbx.Font, FontStyle.Bold);
                    Remark8_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark8_Txbx.Text = ave.ToString("Failed");
                    Remark8_Txbx.Font = new Font(Remark8_Txbx.Font, FontStyle.Bold);
                    Remark8_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Prefinal8_TextBox_TextChanged(object sender, EventArgs e)
        {

            if (Prelim8_Txbx.Text == "" || MidTerm8_TextBox.Text == "" || Prefinal8_TextBox.Text == "" || Final8_Txbx.Text == "")
            {
                Average8_Txbx.Clear();
                Remark8_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim8_Txbx.Text);
                midterm = double.Parse(MidTerm8_TextBox.Text);
                prefinal = double.Parse(Prefinal8_TextBox.Text);
                final = double.Parse(Final8_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average8_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark8_Txbx.Text = ave.ToString("Passed");
                    Remark8_Txbx.Font = new Font(Remark8_Txbx.Font, FontStyle.Bold);
                    Remark8_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark8_Txbx.Text = ave.ToString("Failed");
                    Remark8_Txbx.Font = new Font(Remark8_Txbx.Font, FontStyle.Bold);
                    Remark8_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }
        private void Final8_Txbx_TextChanged(object sender, EventArgs e)
        {
            if (Prelim8_Txbx.Text == "" || MidTerm8_TextBox.Text == "" || Prefinal8_TextBox.Text == "" || Final8_Txbx.Text == "")
            {
                Average8_Txbx.Clear();
                Remark8_Txbx.Clear();
            }
            try
            {
                const double HIGH_SCORE = 75.0; // high Score value
                double prelim, midterm, prefinal, final; // holds test scores
                double ave;                 // holds average score

                // Get the 4 test scores - MUST parse - why?
                prelim = double.Parse(Prelim8_Txbx.Text);
                midterm = double.Parse(MidTerm8_TextBox.Text);
                prefinal = double.Parse(Prefinal8_TextBox.Text);
                final = double.Parse(Final8_Txbx.Text);

                // Calculate the average test score - MUST be 2.0 - why? (not 3.0m - why?)
                ave = (prelim + midterm + prefinal + final) / 4.0;
                Average8_Txbx.Text = ave.ToString();

                // If the average is a high score, congratulate
                // the user with a message box
                if (ave > HIGH_SCORE)
                {
                    Remark8_Txbx.Text = ave.ToString("Passed");
                    Remark8_Txbx.Font = new Font(Remark8_Txbx.Font, FontStyle.Bold);
                    Remark8_Txbx.ForeColor = Color.Blue;
                }
                else if (ave <= 75)
                {
                    Remark8_Txbx.Text = ave.ToString("Failed");
                    Remark8_Txbx.Font = new Font(Remark8_Txbx.Font, FontStyle.Bold);
                    Remark8_Txbx.ForeColor = Color.Red;
                }
            }
            catch
            {
            }
        }

        private void Insert_all_subj_btn_Click(object sender, EventArgs e)
        {
            Insert_All_Subj_Method1();
            AddStud_Grades_BTN.Enabled = true;
        }
        private void Insert_All_Subj_Method1()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE_SYSTEM_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO STUDENT_GRADE_SYSTEM_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    if (Student_ID_Txbx.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ1_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim1_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm1_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal1_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final1_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average1_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark1_Txbx.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "STUDENT_GRADE_SYSTEM_TABLE");

                        Insert_all_subj_btn.Enabled = false;

                        Insert_All_Subj_Method2();
                        connection.Close();


                        return;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Insert_All_Subj_Method2()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE_SYSTEM_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO STUDENT_GRADE_SYSTEM_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    if (Student_ID_Txbx.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ2_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim2_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm2_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal2_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final2_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average2_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark2_Txbx.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "STUDENT_GRADE_SYSTEM_TABLE");

                        Insert_All_Subj_Method3();
                        connection.Close();

                        return;
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Insert_All_Subj_Method3()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE_SYSTEM_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO STUDENT_GRADE_SYSTEM_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    if (Student_ID_Txbx.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ3_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim3_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm3_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal3_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final3_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average3_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark3_Txbx.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "STUDENT_GRADE_SYSTEM_TABLE");

                        Insert_All_Subj_Method4();
                        connection.Close();

                        return;
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Insert_All_Subj_Method4()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE_SYSTEM_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO STUDENT_GRADE_SYSTEM_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    if (Student_ID_Txbx.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ4_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim4_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm4_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal4_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final4_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average4_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark4_Txbx.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "STUDENT_GRADE_SYSTEM_TABLE");

                        Insert_All_Subj_Method5();
                        connection.Close();

                        return;
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Insert_All_Subj_Method5()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE_SYSTEM_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO STUDENT_GRADE_SYSTEM_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    if (Student_ID_Txbx.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ5_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim5_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm5_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal5_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final5_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average5_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark5_Txbx.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "STUDENT_GRADE_SYSTEM_TABLE");

                        Insert_All_Subj_Method6();
                        connection.Close();

                        return;
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Insert_All_Subj_Method6()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE_SYSTEM_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO STUDENT_GRADE_SYSTEM_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    if (Student_ID_Txbx.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ6_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim6_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm6_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal6_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final6_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average6_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark6_Txbx.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "STUDENT_GRADE_SYSTEM_TABLE");

                        Insert_All_Subj_Method7();
                        connection.Close();
                        return;
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Insert_All_Subj_Method7()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE_SYSTEM_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO STUDENT_GRADE_SYSTEM_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    if (Student_ID_Txbx.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ7_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim7_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm7_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal7_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final7_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average7_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark7_Txbx.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "STUDENT_GRADE_SYSTEM_TABLE");

                        Insert_All_Subj_Method8();
                        connection.Close();

                        return;
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Insert_All_Subj_Method8()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM STUDENT_GRADE_SYSTEM_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO STUDENT_GRADE_SYSTEM_TABLE values(@STUDENT_ID,@NAME,@LASTNAME,@MIDDLE_NAME, @SUBJECT, @PRELIM, @MIDTERM, @PRE_FINAL, @FINAL, @AVERAGE, @REMARK)", connection))
                {
                    if (Student_ID_Txbx.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@STUDENT_ID", Student_ID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@NAME", StudName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@LASTNAME", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDDLE_NAME", MiddleName_Txbx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@SUBJECT", SUBJ8_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRELIM", Prelim8_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@MIDTERM", MidTerm8_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@PRE_FINAL", Prefinal8_TextBox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@FINAL", Final8_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@AVERAGE", Average8_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@REMARK", Remark8_Txbx.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        //MetroFramework.MetroMessageBox.Show(this, "The student grade of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "STUDENT_GRADE_SYSTEM_TABLE");


                        connection.Close();
                        return;
                    }
                    else
                    {
                        //MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + StudName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Remark8_Txbx_TextChanged(object sender, EventArgs e)
        {

            if (Remark8_Txbx.Text != string.Empty)
            {
                Insert_all_subj_btn.Visible = true;
                AddStud_Grades_BTN.Enabled = false;
            }
            else if (Average8_Txbx.Text == string.Empty)
            {
                Insert_all_subj_btn.Visible = false;
                AddStud_Grades_BTN.Enabled = true;
            }
            else
            {
                Insert_all_subj_btn.Visible = false;
            }
        }

        private void SUBJ1_CMBOBX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Student_ID2_Txbx_TextChanged(object sender, EventArgs e)
        {

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

        private void LastName_Txbox_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (LastName_Txbox.Text.Length <= 0) return;
            string s = LastName_Txbox.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = LastName_Txbox.SelectionStart;
                int curSelLength = LastName_Txbox.SelectionLength;
                LastName_Txbox.SelectionStart = 0;
                LastName_Txbox.SelectionLength = 1;
                LastName_Txbox.SelectedText = s.ToUpper();
                LastName_Txbox.SelectionStart = curSelStart;
                LastName_Txbox.SelectionLength = curSelLength;
            }
        }

        private void MiddleName_Txbx_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (MiddleName_Txbx.Text.Length <= 0) return;
            string s = MiddleName_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = MiddleName_Txbx.SelectionStart;
                int curSelLength = MiddleName_Txbx.SelectionLength;
                MiddleName_Txbx.SelectionStart = 0;
                MiddleName_Txbx.SelectionLength = 1;
                MiddleName_Txbx.SelectedText = s.ToUpper();
                MiddleName_Txbx.SelectionStart = curSelStart;
                MiddleName_Txbx.SelectionLength = curSelLength;
            }
        }

        private void Average8_Txbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
