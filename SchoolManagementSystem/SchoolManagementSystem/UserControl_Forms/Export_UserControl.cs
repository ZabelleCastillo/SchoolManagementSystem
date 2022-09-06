using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace SchoolManagementSystem.UserControl_Forms
{
    public partial class Export_UserControl : UserControl
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public Export_UserControl()
        {
            InitializeComponent();

            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 5000;//5 seconds
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }

        private void Export_UserControl_Load(object sender, EventArgs e)
        {
            getAllStudentInfo();
            StudentGrades_Count();
        }
        private void getAllStudentInfo() // getAllStudentInfo() - this is call "function" where you can call it inside the load form.
        {
            cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM STUDENT_GRADE_SYSTEM_TABLE ORDER BY [STUDENT ID]", cn);
            da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            StudGrade_DataGridView.DataSource = dt;
        }

 
        private void StudentGrades_Count() // TO COUNT ALL THE STUDENTS THAT HAVE BEEN REGISTERED
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();    //SELECT COUNT(*) FROM STUDENT_GRADE_SYSTEM_TABLE
            SqlCommand comm = new SqlCommand("SELECT COUNT (DISTINCT [STUDENT ID] ) AS 'Number of Students' FROM STUDENT_GRADE_SYSTEM_TABLE", conn);
                                             
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            if (count == 0)
            {
                //result_label.Text = Convert.ToString(count.ToString()); //For example a Label
                //result_label.Text = "There is " + count.ToString() + " row in your database.";
                result_label.Text = "0";
                CountID_label.Visible = false;
            }
            if (count == 1)
            {
                result_label.Text = "There is " + count.ToString() + " student row in the database.";

            
             
            }
            if (count > 1)
            {
                result_label.Text = "There are " + count.ToString() + " students row in the database.";

              
               
            }
            //else
            //{
            //    result_label.Text = "0";
            //    //result_label.Visible = false;
            //}
            //if (count == 0)
            //{
            //    result_label.Visible = false;
            //    //button6.Visible = false;
            //}
            //if (count == 1)
            //{
            //    count = StudGrade_DataGridView.Rows.Count;
            //    result_label.Text = "There is " + count.ToString() + " row in your database.";
            //    result_label.Visible = true;

            //}
            //if (count > 1)
            //{
            //    count = StudGrade_DataGridView.Rows.Count;
            //    result_label.Text = "There are " + count.ToString() + " rows in your database.";
            //    result_label.Visible = true;
            //}


            //if (StudGrade_DataGridView.Rows.Count == 0)
            //{
            //    result_label.Visible = false;
            //    //button6.Visible = false;
            //}
            if (StudGrade_DataGridView.Rows.Count == 1)
            {
                count = StudGrade_DataGridView.Rows.Count;
                CountID_label.Text = "that contains " + count.ToString() + " recorded grades.";
                CountID_label.Visible = true;

            }
            if (StudGrade_DataGridView.Rows.Count > 1)
            {
                count = StudGrade_DataGridView.Rows.Count;
                CountID_label.Text = "that contains " + count.ToString() + " recorded grades.";
                CountID_label.Visible = true;
            }

            conn.Close(); //Remember close the connection
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StudentGrades_Count();
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
                excelWorksheet.Name = "ExportDataGridViewToExcel";


                //Get Data from DataGridView
                for (int i = 1; i < StudGrade_DataGridView.Columns.Count + 1; i++)
                {
                    excelWorksheet.Cells[1, i] = StudGrade_DataGridView.Columns[i - 1].HeaderText;
                }

                //XlXmlExportResult DataGridView Rows
                for (int j = 0; j < StudGrade_DataGridView.RowCount - 1; j++)
                {
                    for (int k = 0; k < StudGrade_DataGridView.ColumnCount; k++)
                    {
                        excelWorksheet.Cells[j + 2, k + 1] = StudGrade_DataGridView.Rows[j].Cells[k].Value.ToString();
                    }
                }

                SaveFileDialog exportExcelFile = new SaveFileDialog();
                exportExcelFile.FileName = "exportedFilename";
                exportExcelFile.DefaultExt = "xlsx";

                if (exportExcelFile.ShowDialog() == DialogResult.OK)
                {
                    excelWorkbook.SaveAs(exportExcelFile.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    MetroFramework.MetroMessageBox.Show(this, "Excel saved.", "Saved", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
    }

