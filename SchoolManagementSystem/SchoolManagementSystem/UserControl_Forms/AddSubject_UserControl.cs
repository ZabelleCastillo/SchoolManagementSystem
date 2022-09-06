using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem.UserControl_Forms
{
    public partial class AddSubject_UserControl : UserControl
    {
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        SqlConnection AutoCon = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public AddSubject_UserControl()
        {
            InitializeComponent();

            Timer Subject_Timer = new Timer();
            Subject_Timer.Interval = 5000;//5 seconds
            Subject_Timer.Tick += new System.EventHandler(Subject_Timer_Tick);
            Subject_Timer.Start();
        }

        private void ADDSUBJ_BTN_Click(object sender, EventArgs e)
        {
            AddSubjectInfo();
        }
        protected void AddSubjectInfo()
        {
            /* SELECTING THE SUBJECT IF IT'S ALREADY EXIST */
            var con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            var ProCod = new SqlCommand("SELECT 1 FROM ADD_NEW_SUBJECT_TABLE WHERE SUBJECTS = @SUBJECTS", con);
            con.Open();
            ProCod.Parameters.AddWithValue("@SUBJECTS", AddSubj_Txbox.Text.Trim());
            using (var ProCodReader = ProCod.ExecuteReader())
            {
                if (ProCodReader.HasRows)
                {
                    MetroFramework.MetroMessageBox.Show(this, "The " + AddSubj_Txbox.Text.Trim() + " is already exist!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddSubj_Txbox.Clear();
                    return; // SUBJECT
                }
            }

            /* INSERTING NEW SUBJECT ONTO DATABASE */
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM ADD_NEW_SUBJECT_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand cmd2 = new SqlCommand("insert into ADD_NEW_SUBJECT_TABLE values(@SUBJECTS)", connection))
                {
                    try
                    {
                        if (AddSubj_Txbox.Text.Trim() != "")
                        {
                            cmd2.Parameters.AddWithValue("@SUBJECTS", AddSubj_Txbox.Text.Trim());
                            cmd2.ExecuteNonQuery();
                            MetroFramework.MetroMessageBox.Show(this, "The " + AddSubj_Txbox.Text.Trim() + "\n is successfully saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataadapter.Fill(ds, "ADD_NEW_SUBJECT_TABLE");
                            connection.Close();
                            Student_DataGridView.DataSource = ds;
                            Student_DataGridView.DataMember = "ADD_NEW_SUBJECT_TABLE";
                            Student_DataGridView.Sort(Student_DataGridView.Columns[0], ListSortDirection.Ascending);
                            AddSubj_Txbox.Clear();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\n Please provide the details!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            AddSubj_Txbox.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }
                }
            }
        }

        private void AddSubject_UserControl_Load(object sender, EventArgs e)
        {
            SUBJECTS_Count();
            Auto();
            getAllStudentInfo();
        }
        private void SUBJECTS_Count() // TO COUNT ALL THE SUBJECTS THAT HAVE BEEN ADDED
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM ADD_NEW_SUBJECT_TABLE", conn);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count == 0)
            {
                count_label.Text = Convert.ToString(count.ToString());
                name_label.Text = "NO RECORD";
            }
            if (count == 1)
            {
                count_label.Text = Convert.ToString(count.ToString());
                name_label.Text = "SUBJECT";
            }
            if (count > 1)
            {
                count_label.Text = Convert.ToString(count.ToString());
                name_label.Text = "SUBJECTS";
            }
            conn.Close(); //Remember close the connection
        }
        public void Auto()  /* MAIN LOGIC OF AUTOCOMPLETE TEXTBOX */
        {
            da = new SqlDataAdapter("Select SUBJECTS from ADD_NEW_SUBJECT_TABLE order by SUBJECTS asc", AutoCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    coll.Add(dt.Rows[i]["SUBJECTS"].ToString());
                }
            }
            else
            {
                MessageBox.Show("SUBJECTS not found");
            }
            Search_Subj_Txbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Search_Subj_Txbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
            Search_Subj_Txbx.AutoCompleteCustomSource = coll;
        }
        private void getAllStudentInfo() // getAllStudentInfo() - this is call "function" where you can call it inside the load form.
        {
            cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();
            cmd = new SqlCommand("Select * from ADD_NEW_SUBJECT_TABLE order by SUBJECTS", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Student_DataGridView.DataSource = dt;
        }

        private void Search_Subj_Txbx_TextChanged(object sender, EventArgs e)
        {
            fillgrid();
        }
        public void fillgrid() /* READ THE SUBJECT IN DATAGRIDVIEW UPON SEARCHING IN THE SEARCH SUBJECT TEXTBOX */
        {
            da = new SqlDataAdapter("Select * from ADD_NEW_SUBJECT_TABLE where SUBJECTS='" + Search_Subj_Txbx.Text.Trim() + "'", AutoCon);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Student_DataGridView.DataSource = dt;
            }

            else
            {
                getAllStudentInfo();
            }
        }

        private void Student_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DeleteSubjectInDataGridView();
        }
        public void DeleteSubjectInDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "Select * from ADD_NEW_SUBJECT_TABLE where SUBJECTS='" + Search_Subj_Txbx.Text + "'";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand cmdDelete = new SqlCommand("DELETE ADD_NEW_SUBJECT_TABLE WHERE SUBJECTS=@SUBJECTS", connection))
                {
                    if (Search_Subj_Txbx.Text != "")
                    {
                        if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to remove this data?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmdDelete.Parameters.AddWithValue("@SUBJECTS", Search_Subj_Txbx.Text);
                            cmdDelete.ExecuteNonQuery();
                            MetroFramework.MetroMessageBox.Show(this, "Record successfully deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataadapter.Fill(ds, "ADD_NEW_SUBJECT_TABLE");
                            connection.Close();
                            Student_DataGridView.DataSource = ds;
                            Student_DataGridView.DataMember = "ADD_NEW_SUBJECT_TABLE";
                            //Student_DataGridView.Sort(Student_DataGridView.Columns[0], ListSortDirection.Ascending);
                            Search_Subj_Txbx.Clear();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\n The " + AddSubj_Txbox.Text + " record is not deleted!", "Remove Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\n Please Select Record to Delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void SearchSubj_Btn_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select * from ADD_NEW_SUBJECT_TABLE where SUBJECTS='" + Search_Subj_Txbx.Text.Trim() + "'", AutoCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Student_DataGridView.DataSource = dt;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\n Record not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getAllStudentInfo();
            }
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\n Do you want to close the program?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void AddSubj_Txbox_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (AddSubj_Txbox.Text.Length <= 0) return;
            string s = AddSubj_Txbox.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = AddSubj_Txbox.SelectionStart;
                int curSelLength = AddSubj_Txbox.SelectionLength;
                AddSubj_Txbox.SelectionStart = 0;
                AddSubj_Txbox.SelectionLength = 1;
                AddSubj_Txbox.SelectedText = s.ToUpper();
                AddSubj_Txbox.SelectionStart = curSelStart;
                AddSubj_Txbox.SelectionLength = curSelLength;
            }
        }

        private void Subject_Timer_Tick(object sender, EventArgs e)
        {
            SUBJECTS_Count();
        }

        private void LOAD_BTN_Click(object sender, EventArgs e)
        {        
            SqlDataAdapter MyDA = new SqlDataAdapter();
            string sqlSelectAll = "SELECT * FROM ADD_NEW_SUBJECT_TABLE ORDER BY SUBJECTS ASC";
            MyDA.SelectCommand = new SqlCommand(sqlSelectAll, cn);
            DataTable table = new DataTable();
            MyDA.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            Student_DataGridView.DataSource = bSource;
            cn.Close();
        }
    }
}
