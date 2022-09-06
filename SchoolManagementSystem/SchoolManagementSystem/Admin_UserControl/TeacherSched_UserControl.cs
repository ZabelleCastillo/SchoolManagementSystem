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
using Microsoft.Office.Interop.Excel;

namespace SchoolManagementSystem.Admin_UserControl
{
    public partial class TeacherSched_UserControl : UserControl
    {
        /* CONNECTION IN NAVIGATION FOR NEXT AND PREVIOUS BUTTON */
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter adapter;
        System.Data.DataTable table = new System.Data.DataTable();
        int pos = 0;
        int count = 0;

        public TeacherSched_UserControl()
        {
            InitializeComponent();
        }

        private void TeacherSched_UserControl_Load(object sender, EventArgs e)
        {
            showData(pos);
            Teacher_Count();
            Subject_Count();
            //teacherload();
        }
        private void Teacher_Count() 
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(DISTINCT USERNAME) AS 'TEACHERS' FROM TEACHER_CLASS_SCHEDULE_TABLE", conn);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count == 0)
            {
                RESULT_TXBX.Text = Convert.ToString(count.ToString());
                Teacher_label.Text = " NO RECORD";
            }
            if (count == 1)
            {
                RESULT_TXBX.Text = Convert.ToString(count.ToString());
                Teacher_label.Text = " TEACHER";
            }
            if (count > 1)
            {
                RESULT_TXBX.Text = Convert.ToString(count.ToString());
                Teacher_label.Text = " TEACHERS";

            }
            conn.Close(); //Remember close the connection
        }
        private void Subject_Count()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(SUBJECT) FROM TEACHER_CLASS_SCHEDULE_TABLE", conn);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count == 0)
            {
                Subject_Txbx.Text = Convert.ToString(count.ToString());
                Subj_label.Text = " NO RECORD";
            }
            if (count == 1)
            {
                Subject_Txbx.Text = Convert.ToString(count.ToString());
                Subj_label.Text = " SUBJECT";
            }
            if (count > 1)
            {
                Subject_Txbx.Text = Convert.ToString(count.ToString());
                Subj_label.Text = " SUBJECTS";

            }
            conn.Close(); //Remember close the connection
        }

        private void showData(int index) // DISPLAY THE STUDENT INFO UPON SEARCHING THE STUDENT ID
        {
            adapter = new SqlDataAdapter("SELECT * FROM ADMIN_TABLE WHERE TYPE= 'TEACHER' OR TYPE='CLERK' ", con);
            adapter.Fill(table);

            UsernameTeacher_Txbx.Text = table.Rows[index][0].ToString();
            TeacherName_Txbx.Text = table.Rows[index][1].ToString();
            LastNme_Txbx.Text = table.Rows[index][2].ToString();
        }
        private void teacherload()
        {
            con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from TEACHER_CLASS_SCHEDULE_TABLE", con);
            adapter = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            adapter.Fill(dt);
            Teacher_DataGridView.DataSource = dt;
        }
        private void Teacher_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Teacher_DataGridView.Rows[e.RowIndex];
                UsernameTeacher_Txbx.Text = row.Cells[0].Value.ToString();
            }
        }

        private void UsernameTeacher_Txbx_TextChanged(object sender, EventArgs e)
        {
            count = 0;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TEACHER_CLASS_SCHEDULE_TABLE WHERE Username='" + UsernameTeacher_Txbx.Text.Trim() + "'", con);
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            Teacher_DataGridView.DataSource = dt;
            con.Close();

            Teacher_Sched();
        }
        private void Teacher_Sched() //UPON SEARCHING THE STUDENT ID, THIS FUNCTIONAL METHOD WILL ALSO CALLED FOR ITS GRADE IN SUBJECT AND DISPLAY IT.
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string query = " SELECT * FROM TEACHER_CLASS_SCHEDULE_TABLE where Username= '" + UsernameTeacher_Txbx.Text.Trim() + "';";
            SqlConnection contaBase = new SqlConnection(constring);
            SqlCommand cmdBase = new SqlCommand(query, contaBase);

            SqlDataReader myReader;
            try
            {
                contaBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {
                    UsernameTeacher_Txbx.Text = myReader.GetValue(1).ToString();
                    TeacherName_Txbx.Text = myReader.GetValue(2).ToString();
                    LastNme_Txbx.Text = myReader.GetValue(3).ToString();
                    MiddleNme_TextBox.Text = myReader.GetValue(4).ToString();
                    Suffix_Txbox.Text = myReader.GetValue(5).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TeacherName_Txbx_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (TeacherName_Txbx.Text.Length <= 0) return;
            string s = TeacherName_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = TeacherName_Txbx.SelectionStart;
                int curSelLength = TeacherName_Txbx.SelectionLength;
                TeacherName_Txbx.SelectionStart = 0;
                TeacherName_Txbx.SelectionLength = 1;
                TeacherName_Txbx.SelectedText = s.ToUpper();
                TeacherName_Txbx.SelectionStart = curSelStart;
                TeacherName_Txbx.SelectionLength = curSelLength;
            }
        }
        private void LastNme_Txbx_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (LastNme_Txbx.Text.Length <= 0) return;
            string s = LastNme_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = LastNme_Txbx.SelectionStart;
                int curSelLength = LastNme_Txbx.SelectionLength;
                LastNme_Txbx.SelectionStart = 0;
                LastNme_Txbx.SelectionLength = 1;
                LastNme_Txbx.SelectedText = s.ToUpper();
                LastNme_Txbx.SelectionStart = curSelStart;
                LastNme_Txbx.SelectionLength = curSelLength;
            }
        }
        private void MiddleNme_TextBox_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (MiddleNme_TextBox.Text.Length <= 0) return;
            string s = MiddleNme_TextBox.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = MiddleNme_TextBox.SelectionStart;
                int curSelLength = MiddleNme_TextBox.SelectionLength;
                MiddleNme_TextBox.SelectionStart = 0;
                MiddleNme_TextBox.SelectionLength = 1;
                MiddleNme_TextBox.SelectedText = s.ToUpper();
                MiddleNme_TextBox.SelectionStart = curSelStart;
                MiddleNme_TextBox.SelectionLength = curSelLength;
            }
        }

        private void EXPORT_BTN_Click(object sender, EventArgs e)
        {
            _Application excelApp;
            _Workbook excelWorkbook;
            _Worksheet excelWorksheet;

            try
            {
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelWorkbook = excelApp.Workbooks.Add(Type.Missing);
                excelWorksheet = null;

                excelWorksheet = excelWorkbook.Sheets["Sheet1"];
                excelWorksheet = excelWorkbook.ActiveSheet;
                excelWorksheet.Name = "TeacherScheduleExcel";


                //Get Data from DataGridView
                for (int i = 1; i < Teacher_DataGridView.Columns.Count + 1; i++)
                {
                    excelWorksheet.Cells[1, i] = Teacher_DataGridView.Columns[i - 1].HeaderText;
                }

                //XlXmlExportResult DataGridView Rows
                for (int j = 0; j < Teacher_DataGridView.RowCount - 1; j++)
                {
                    for (int k = 0; k < Teacher_DataGridView.ColumnCount; k++)
                    {
                        excelWorksheet.Cells[j + 2, k + 1] = Teacher_DataGridView.Rows[j].Cells[k].Value.ToString();
                    }
                }

                SaveFileDialog exportExcelFile = new SaveFileDialog();
                exportExcelFile.FileName = "TeacherScheduleExcel";
                exportExcelFile.DefaultExt = "xlsx";

                if (exportExcelFile.ShowDialog() == DialogResult.OK)
                {
                    excelWorkbook.SaveAs(exportExcelFile.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    MetroFramework.MetroMessageBox.Show(this, "\n\n Excel saved.", "Saved", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Teacher_Timer_Tick(object sender, EventArgs e)
        {
            Teacher_Count();
        }
        private void Subj_Timer_Tick(object sender, EventArgs e)
        {
            Subject_Count();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DEL_btn_Click(object sender, EventArgs e)
        {
            //con.Open();
            SqlCommand cmd = new SqlCommand("DELETE TEACHER_CLASS_SCHEDULE_TABLE WHERE Username=@Username", con);
            cmd.Parameters.AddWithValue("@Username", UsernameTeacher_Txbx.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MetroFramework.MetroMessageBox.Show(this, "\n\n User deleted.");
            RESULT_TXBX.Refresh();
            Subject_Txbx.Refresh();

            teacherload();
        }
        private void DEL_aLL_BTN_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "Select * from TEACHER_CLASS_SCHEDULE_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                System.Data.DataTable dt = new System.Data.DataTable();
                dataadapter.Fill(dt);

                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM TEACHER_CLASS_SCHEDULE_TABLE", connection))
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete all these Teacher scheddule?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmdDelete.ExecuteNonQuery();
                        int rowCount = Teacher_DataGridView.Rows.Count;
                        for (int n = 0; n < rowCount; n++)
                        {
                            if (Teacher_DataGridView.Rows[0].IsNewRow == false)
                                Teacher_DataGridView.Rows.RemoveAt(0);
                        }
                        teacherload();
                    }


                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\n The record is not deleted!", "Remove Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Prev_btn_Click(object sender, EventArgs e)
        {
            pos--;
            if (pos >= 0)
            {
                showData(pos);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "End.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void Next_btn_Click(object sender, EventArgs e)
        {
            pos++;
            if (pos < table.Rows.Count)
            {
                showData(pos);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "End.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                pos = table.Rows.Count - 1;
            }
        }
    }
    }