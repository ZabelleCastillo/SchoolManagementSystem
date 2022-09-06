using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem.UserControl_Forms
{
    public partial class TeacherClassSchedule_UserControl : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        int count = 0;
        public TeacherClassSchedule_UserControl()
        {
            InitializeComponent();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\n Do you want to close the program?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
        }

  
        private void Insert_Teacher_ClassSchedule()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM TEACHER_CLASS_SCHEDULE_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO TEACHER_CLASS_SCHEDULE_TABLE values(@TeacherID,@Username, @Name, @Lastname, @Middle_Name, @Suffix, @Subject, @Year_Level, @Class, @Time)", connection))
                {
                    if (TeacherName_Txbox.Text != "" && LastName_Txbox.Text != "" && SUBJ1_CMBOBX.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@TeacherID", TeacherID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Username", Username_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Name", TeacherName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Lastname", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Middle_Name", MiddleName_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Suffix", Suffix_Combobx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@Subject", SUBJ1_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Year_Level", YearLevel_Combobx1.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Class", Class_Combobox1.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Time", Time_combobox1.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "The class schedule of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "TEACHER_CLASS_SCHEDULE_TABLE");
                        connection.Close();

                        SUBJ1_CMBOBX.ResetText();
                        YearLevel_Combobx1.ResetText();
                        Class_Combobox1.ResetText();
                        Time_combobox1.ResetText();
                        return;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Insert_Teacher_ClassSchedule2()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM TEACHER_CLASS_SCHEDULE_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO TEACHER_CLASS_SCHEDULE_TABLE values(@TeacherID,@Username, @Name, @Lastname, @Middle_Name, @Suffix, @Subject, @Year_Level, @Class, @Time)", connection))
                {
                    if (TeacherName_Txbox.Text != "" && LastName_Txbox.Text != "" && SUBJ2_CMBOBX.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@TeacherID", TeacherID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Username", Username_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Name", TeacherName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Lastname", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Middle_Name", MiddleName_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Suffix", Suffix_Combobx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@Subject", SUBJ2_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Year_Level", YearLevel_Combobx2.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Class", Class_Combobox2.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Time", Time_combobox2.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "The class schedule of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "TEACHER_CLASS_SCHEDULE_TABLE");
                        SUBJ2_CMBOBX.ResetText();
                        YearLevel_Combobx2.ResetText();
                        Class_Combobox2.ResetText();
                        Time_combobox2.ResetText();

                        connection.Close();


                        return;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Insert_Teacher_ClassSchedule3()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM TEACHER_CLASS_SCHEDULE_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO TEACHER_CLASS_SCHEDULE_TABLE values(@TeacherID,@Username, @Name, @Lastname, @Middle_Name, @Suffix, @Subject, @Year_Level, @Class, @Time)", connection))
                {
                    if (TeacherName_Txbox.Text != "" && LastName_Txbox.Text != "" && SUBJ3_CMBOBX.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@TeacherID", TeacherID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Username", Username_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Name", TeacherName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Lastname", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Middle_Name", MiddleName_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Suffix", Suffix_Combobx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@Subject", SUBJ3_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Year_Level", YearLevel_Combobx3.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Class", Class_Combobox3.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Time", Time_combobox3.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "The class schedule of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "TEACHER_CLASS_SCHEDULE_TABLE");
                        SUBJ3_CMBOBX.ResetText();
                        YearLevel_Combobx3.ResetText();
                        Class_Combobox3.ResetText();
                        Time_combobox3.ResetText();
                        connection.Close();
                        return;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Insert_Teacher_ClassSchedule4()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM TEACHER_CLASS_SCHEDULE_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO TEACHER_CLASS_SCHEDULE_TABLE values(@TeacherID,@Username, @Name, @Lastname, @Middle_Name, @Suffix, @Subject, @Year_Level, @Class, @Time)", connection))
                {
                    if (TeacherName_Txbox.Text != "" && LastName_Txbox.Text != "" && SUBJ4_CMBOBX.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@TeacherID", TeacherID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Username", Username_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Name", TeacherName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Lastname", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Middle_Name", MiddleName_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Suffix", Suffix_Combobx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@Subject", SUBJ4_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Year_Level", YearLevel_Combobx4.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Class", Class_Combobox4.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Time", Time_combobox4.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "The class schedule of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "TEACHER_CLASS_SCHEDULE_TABLE");
                        SUBJ4_CMBOBX.ResetText();
                        YearLevel_Combobx4.ResetText();
                        Class_Combobox4.ResetText();
                        Time_combobox4.ResetText();
                        connection.Close();
                        return;
                    }
                    else
                    {
                         MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Insert_Teacher_ClassSchedule5()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM TEACHER_CLASS_SCHEDULE_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO TEACHER_CLASS_SCHEDULE_TABLE values(@TeacherID,@Username, @Name, @Lastname, @Middle_Name, @Suffix, @Subject, @Year_Level, @Class, @Time)", connection))
                {
                    if (TeacherName_Txbox.Text != "" && LastName_Txbox.Text != "" && SUBJ5_CMBOBX.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@TeacherID", TeacherID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Username", Username_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Name", TeacherName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Lastname", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Middle_Name", MiddleName_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Suffix", Suffix_Combobx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@Subject", SUBJ5_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Year_Level", YearLevel_Combobx5.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Class", Class_Combobox5.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Time", Time_combobox5.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "The class schedule of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "TEACHER_CLASS_SCHEDULE_TABLE");
                        SUBJ5_CMBOBX.ResetText();
                        YearLevel_Combobx5.ResetText();
                        Class_Combobox5.ResetText();
                        Time_combobox5.ResetText();
                        connection.Close();


                        return;
                    }
                    else
                    {
                         MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Insert_Teacher_ClassSchedule6()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM TEACHER_CLASS_SCHEDULE_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO TEACHER_CLASS_SCHEDULE_TABLE values(@TeacherID,@Username, @Name, @Lastname, @Middle_Name, @Suffix, @Subject, @Year_Level, @Class, @Time)", connection))
                {
                    if (TeacherName_Txbox.Text != "" && LastName_Txbox.Text != "" && SUBJ6_CMBOBX.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@TeacherID", TeacherID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Username", Username_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Name", TeacherName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Lastname", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Middle_Name", MiddleName_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Suffix", Suffix_Combobx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@Subject", SUBJ6_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Year_Level", YearLevel_Combobx6.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Class", Class_Combobox6.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Time", Time_combobox6.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "The class schedule of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "TEACHER_CLASS_SCHEDULE_TABLE");
                        SUBJ6_CMBOBX.ResetText();
                        YearLevel_Combobx6.ResetText();
                        Class_Combobox6.ResetText();
                        Time_combobox6.ResetText();
                        connection.Close();


                        return;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void Insert_Teacher_ClassSchedule7()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM TEACHER_CLASS_SCHEDULE_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdGradeCmd = new SqlCommand("INSERT INTO TEACHER_CLASS_SCHEDULE_TABLE values(@TeacherID,@Username, @Name, @Lastname, @Middle_Name, @Suffix, @Subject, @Year_Level, @Class, @Time)", connection))
                {
                    if (TeacherName_Txbox.Text != "" && LastName_Txbox.Text != "" && SUBJ7_CMBOBX.Text != "")
                    {
                        UpdGradeCmd.Parameters.AddWithValue("@TeacherID", TeacherID_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Username", Username_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Name", TeacherName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Lastname", LastName_Txbox.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Middle_Name", MiddleName_Txbx.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Suffix", Suffix_Combobx.Text);

                        UpdGradeCmd.Parameters.AddWithValue("@Subject", SUBJ7_CMBOBX.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Year_Level", YearLevel_Combobx7.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Class", Class_Combobox7.Text);
                        UpdGradeCmd.Parameters.AddWithValue("@Time", Time_combobox7.Text);

                        UpdGradeCmd.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "The class schedule of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + " is now save.", "Save All", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "TEACHER_CLASS_SCHEDULE_TABLE");
                        SUBJ7_CMBOBX.ResetText();
                        YearLevel_Combobx7.ResetText();
                        Class_Combobox7.ResetText();
                        Time_combobox7.ResetText();
                        connection.Close();


                        return;
                    }
                    else
                    {
                         MetroFramework.MetroMessageBox.Show(this, "\n\n Please fill up the information that has been given of " + TeacherName_Txbox.Text.Trim() + "," + LastName_Txbox.Text.Trim() + ". Thank you!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void TeacherClassSchedule_UserControl_Load(object sender, EventArgs e)
        {
            /* ONCE THE USER LOGIN TO HIS ACCOUNT IN SECURITY LOGIN FORM, 
                 HIS CREDENTIAL INFO WILL DISPLAY */
            Username_Txbx.Text = Forms.SecurityLogin_Form.username;

            /* RETRIEVE AND DISPLAY THE SUBJECTS FROM DATABASE TO WINDOWS FORM INTO COMBOBOXES */
            Subject1_ComboboxMethod();
            Subject2_ComboboxMethod();
            Subject3_ComboboxMethod();
            Subject4_ComboboxMethod();
            Subject5_ComboboxMethod();
            Subject6_ComboboxMethod();
            Subject7_ComboboxMethod();

            /* RETRIEVE AND DISPLAY THE YEAR LEVEL FROM DATABASE TO WINDOWS FORM INTO COMBOBOXES */
            Yearlevel_ClassSection1();
            Yearlevel_ClassSection2();
            Yearlevel_ClassSection3();
            Yearlevel_ClassSection4();
            Yearlevel_ClassSection5();
            Yearlevel_ClassSection6();
            Yearlevel_ClassSection7();

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
            YearLevel_Combobx1.Enabled = false;
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
            YearLevel_Combobx2.Enabled = false;
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
            YearLevel_Combobx3.Enabled = false;
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
            YearLevel_Combobx4.Enabled = false;
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
            YearLevel_Combobx5.Enabled = false;
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
            YearLevel_Combobx6.Enabled = false;
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
            YearLevel_Combobx7.Enabled = false;
        }

        private void Yearlevel_ClassSection1()
        {
            YearLevel_Combobx1.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from YEAR_LEVEL_TABLE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            YearLevel_Combobx1.ValueMember = "YearID";
            YearLevel_Combobx1.DisplayMember = "Year Level";

            YearLevel_Combobx1.DataSource = dt;
            Class_Combobox1.Enabled = false;
            Time_combobox1.Enabled = false;
        }
        private void Yearlevel_ClassSection2()
        {
            YearLevel_Combobx2.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from YEAR_LEVEL_TABLE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            YearLevel_Combobx2.ValueMember = "YearID";
            YearLevel_Combobx2.DisplayMember = "Year Level";

            YearLevel_Combobx2.DataSource = dt;
            Class_Combobox2.Enabled = false;
            Time_combobox2.Enabled = false;
        }
        private void Yearlevel_ClassSection3()
        {
            YearLevel_Combobx3.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from YEAR_LEVEL_TABLE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            YearLevel_Combobx3.ValueMember = "YearID";
            YearLevel_Combobx3.DisplayMember = "Year Level";

            YearLevel_Combobx3.DataSource = dt;
            Class_Combobox3.Enabled = false;
            Time_combobox3.Enabled = false;
        }
        private void Yearlevel_ClassSection4()
        {
            YearLevel_Combobx4.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from YEAR_LEVEL_TABLE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            YearLevel_Combobx4.ValueMember = "YearID";
            YearLevel_Combobx4.DisplayMember = "Year Level";

            YearLevel_Combobx4.DataSource = dt;
            Class_Combobox4.Enabled = false;
            Time_combobox4.Enabled = false;
        }
        private void Yearlevel_ClassSection5()
        {
            YearLevel_Combobx5.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from YEAR_LEVEL_TABLE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            YearLevel_Combobx5.ValueMember = "YearID";
            YearLevel_Combobx5.DisplayMember = "Year Level";

            YearLevel_Combobx5.DataSource = dt;
            Class_Combobox5.Enabled = false;
            Time_combobox5.Enabled = false;
        }
        private void Yearlevel_ClassSection6()
        {
            YearLevel_Combobx6.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from YEAR_LEVEL_TABLE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            YearLevel_Combobx6.ValueMember = "YearID";
            YearLevel_Combobx6.DisplayMember = "Year Level";

            YearLevel_Combobx6.DataSource = dt;
            Class_Combobox6.Enabled = false;
            Time_combobox6.Enabled = false;
        }
        private void Yearlevel_ClassSection7()
        {
            YearLevel_Combobx7.Items.Clear();
            //con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from YEAR_LEVEL_TABLE";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            YearLevel_Combobx7.ValueMember = "YearID";
            YearLevel_Combobx7.DisplayMember = "Year Level";

            YearLevel_Combobx7.DataSource = dt;
            Class_Combobox7.Enabled = false;
            Time_combobox7.Enabled = false;
        }

        private void YearLevel_Combobx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearLevel_Combobx1.SelectedValue.ToString() != null)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                string sql = "SELECT * from CLASS_SECTION_TABLE where YearID=@YearID";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                SqlCommand cmd2 = new SqlCommand(sql, connection);
                connection.Open();
                cmd2.Parameters.AddWithValue("@YearID", YearLevel_Combobx1.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Class_Combobox1.ValueMember = "";
                Class_Combobox1.DisplayMember = "Class";
                Class_Combobox1.DataSource = dt;
                Class_Combobox1.Enabled = true;
            }
        }
        private void YearLevel_Combobx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YearLevel_Combobx2.SelectedValue.ToString() != null)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                string sql = "SELECT * from CLASS_SECTION_TABLE where YearID=@YearID";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                SqlCommand cmd2 = new SqlCommand(sql, connection);
                connection.Open();
                cmd2.Parameters.AddWithValue("@YearID", YearLevel_Combobx2.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Class_Combobox2.ValueMember = "";
                Class_Combobox2.DisplayMember = "Class";
                Class_Combobox2.DataSource = dt;
                Class_Combobox2.Enabled = true;
            }
        }
        private void YearLevel_Combobx3_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (YearLevel_Combobx3.SelectedValue.ToString() != null)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                string sql = "SELECT * from CLASS_SECTION_TABLE where YearID=@YearID";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                SqlCommand cmd2 = new SqlCommand(sql, connection);
                connection.Open();
                cmd2.Parameters.AddWithValue("@YearID", YearLevel_Combobx3.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Class_Combobox3.ValueMember = "";
                Class_Combobox3.DisplayMember = "Class";
                Class_Combobox3.DataSource = dt;
                Class_Combobox3.Enabled = true;
            }
        }
        private void YearLevel_Combobx4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (YearLevel_Combobx4.SelectedValue.ToString() != null)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                string sql = "SELECT * from CLASS_SECTION_TABLE where YearID=@YearID";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                SqlCommand cmd2 = new SqlCommand(sql, connection);
                connection.Open();
                cmd2.Parameters.AddWithValue("@YearID", YearLevel_Combobx4.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Class_Combobox4.ValueMember = "";
                Class_Combobox4.DisplayMember = "Class";
                Class_Combobox4.DataSource = dt;
                Class_Combobox4.Enabled = true;
            }
        }
        private void YearLevel_Combobx5_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (YearLevel_Combobx5.SelectedValue.ToString() != null)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                string sql = "SELECT * from CLASS_SECTION_TABLE where YearID=@YearID";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                SqlCommand cmd2 = new SqlCommand(sql, connection);
                connection.Open();
                cmd2.Parameters.AddWithValue("@YearID", YearLevel_Combobx5.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Class_Combobox5.ValueMember = "";
                Class_Combobox5.DisplayMember = "Class";
                Class_Combobox5.DataSource = dt;
                Class_Combobox5.Enabled = true;
            }
        }
        private void YearLevel_Combobx6_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (YearLevel_Combobx6.SelectedValue.ToString() != null)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                string sql = "SELECT * from CLASS_SECTION_TABLE where YearID=@YearID";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                SqlCommand cmd2 = new SqlCommand(sql, connection);
                connection.Open();
                cmd2.Parameters.AddWithValue("@YearID", YearLevel_Combobx6.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Class_Combobox6.ValueMember = "";
                Class_Combobox6.DisplayMember = "Class";
                Class_Combobox6.DataSource = dt;
                Class_Combobox6.Enabled = true;
            }
        }
        private void YearLevel_Combobx7_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (YearLevel_Combobx7.SelectedValue.ToString() != null)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                string sql = "SELECT * from CLASS_SECTION_TABLE where YearID=@YearID";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                SqlCommand cmd2 = new SqlCommand(sql, connection);
                connection.Open();
                cmd2.Parameters.AddWithValue("@YearID", YearLevel_Combobx7.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Class_Combobox7.ValueMember = "";
                Class_Combobox7.DisplayMember = "Class";
                Class_Combobox7.DataSource = dt;
                Class_Combobox7.Enabled = true;
            }
        }


        private void Username_Txbx_TextChanged(object sender, EventArgs e)
        {
            count = 0;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TEACHER_CLASS_SCHEDULE_TABLE where Username='" + Username_Txbx.Text.Trim() + "'", con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            con.Close();

            TeacherInfoMethod();
        }
        private void TeacherInfoMethod()
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string query = "select * from TEACHER_CLASS_SCHEDULE_TABLE where Username= '" + Username_Txbx.Text.Trim() + "';";
            SqlConnection contaBase = new SqlConnection(constring);
            SqlCommand cmdBase = new SqlCommand(query, contaBase);
            SqlDataReader myReader;
            try
            {
                contaBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {
                    TeacherName_Txbox.Text = myReader.GetValue(2).ToString();
                    LastName_Txbox.Text = myReader.GetValue(3).ToString();
                    MiddleName_Txbx.Text = myReader.GetValue(4).ToString();
                    Suffix_Combobx.Text = myReader.GetValue(5).ToString();

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }


        private void SUBJ1_CMBOBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearLevel_Combobx1.Enabled = true;
        }
        private void SUBJ2_CMBOBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearLevel_Combobx2.Enabled = true;
        }
        private void SUBJ3_CMBOBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearLevel_Combobx3.Enabled = true;
        }
        private void SUBJ4_CMBOBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearLevel_Combobx4.Enabled = true;
        }
        private void SUBJ5_CMBOBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearLevel_Combobx5.Enabled = true;
        }
        private void SUBJ6_CMBOBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearLevel_Combobx6.Enabled = true;
        }
        private void SUBJ7_CMBOBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            YearLevel_Combobx7.Enabled = true;
        }

        private void Class_Combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_Combobox1.Enabled == true)
            {
                Time_combobox1.Enabled = true;
            }
        }
        private void Class_Combobox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_Combobox2.Enabled == true)
            {
                Time_combobox2.Enabled = true;
            }
        }
        private void Class_Combobox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_Combobox3.Enabled == true)
            {
                Time_combobox3.Enabled = true;
            }
        }
        private void Class_Combobox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_Combobox4.Enabled == true)
            {
                Time_combobox4.Enabled = true;
            }
        }
        private void Class_Combobox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_Combobox5.Enabled == true)
            {
                Time_combobox5.Enabled = true;
            }
        }
        private void Class_Combobox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_Combobox6.Enabled == true)
            {
                Time_combobox6.Enabled = true;
            }
        }
        private void Class_Combobox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Class_Combobox7.Enabled == true)
            {
                Time_combobox7.Enabled = true;
            }
        }

        private void AddClass1_Btn_Click(object sender, EventArgs e)
        {
            Panel_Class2.Visible = true;
            AddClass1_Btn.Visible = false;
        }

        private void AddClass2_Btn_Click(object sender, EventArgs e)
        {
            Panel_Class3.Visible = true;
            AddClass2_Btn.Visible = false;
        }

        private void AddClass3_Btn_Click(object sender, EventArgs e)
        {
            Panel_Class4.Visible = true;
            AddClass3_Btn.Visible = false;
        }

        private void AddClass4_Btn_Click(object sender, EventArgs e)
        {
            Panel_Class5.Visible = true;
            AddClass4_Btn.Visible = false;
        }

        private void AddClass5_Btn_Click(object sender, EventArgs e)
        {
            Panel_Class6.Visible = true;
            AddClass5_Btn.Visible = false;
        }

        private void AddClass6_Btn_Click(object sender, EventArgs e)
        {
            Panel_Class7.Visible = true;
            AddClass6_Btn.Visible = false;
        }

        private void Insert_btn1_Click(object sender, EventArgs e)
        {
            Insert_Teacher_ClassSchedule();
        }
        private void Insert_btn2_Click(object sender, EventArgs e)
        {
            Insert_Teacher_ClassSchedule2();
        }
        private void Insert_btn3_Click(object sender, EventArgs e)
        {
            Insert_Teacher_ClassSchedule3();
        }
        private void Insert_btn4_Click(object sender, EventArgs e)
        {
            Insert_Teacher_ClassSchedule4();
        }
        private void Insert_btn5_Click(object sender, EventArgs e)
        {
            Insert_Teacher_ClassSchedule5();
        }
        private void Insert_btn6_Click(object sender, EventArgs e)
        {
            Insert_Teacher_ClassSchedule6();
        }
        private void Insert_btn7_Click(object sender, EventArgs e)
        {
            Insert_Teacher_ClassSchedule7();
        }

        private void TeacherName_Txbox_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (TeacherName_Txbox.Text.Length <= 0) return;
            string s = TeacherName_Txbox.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = TeacherName_Txbox.SelectionStart;
                int curSelLength = TeacherName_Txbox.SelectionLength;
                TeacherName_Txbox.SelectionStart = 0;
                TeacherName_Txbox.SelectionLength = 1;
                TeacherName_Txbox.SelectedText = s.ToUpper();
                TeacherName_Txbox.SelectionStart = curSelStart;
                TeacherName_Txbox.SelectionLength = curSelLength;
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
    }
}

