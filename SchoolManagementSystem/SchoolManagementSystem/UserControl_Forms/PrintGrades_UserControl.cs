using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Globalization;
using Microsoft.Office.Interop.Excel;

namespace SchoolManagementSystem.UserControl_Forms
{
    public partial class PrintGrades_UserControl : UserControl
    {
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
        /* CONNECTION IN NAVIGATION FOR NEXT AND PREVIOUS BUTTON */
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        SqlDataAdapter adapter;
        System.Data.DataTable table = new System.Data.DataTable();
        int pos = 0;
        int count = 0;

        public PrintGrades_UserControl()
        {
            InitializeComponent();
            AutoCompleteStudentID();
        }
        private void AutoCompleteStudentID()
        {
            SqlCommand cmd = new SqlCommand("Select [STUDENT ID]  FROM STUDENT_INFO_TABLE", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            AutoCompleteStringCollection collect = new AutoCompleteStringCollection();
            while (dr.Read())
            {
                collect.Add(dr.GetInt32(0).ToString());
            }
            SearchStudID_Txbx.AutoCompleteCustomSource = collect;
            con.Close();
        }
        private void Close_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void PrintGrades_UserControl_Load(object sender, EventArgs e)
        {
            Date_label.Text = DateTime.Now.ToLongDateString();
        }
      
      
        private void PREV_BTN_Click(object sender, EventArgs e)
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
        private void NEXT_BTN_Click(object sender, EventArgs e)
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

        private void StudentID_Txbx_TextChanged(object sender, EventArgs e)
        {
            count = 0;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT_GRADE_SYSTEM_TABLE WHERE [STUDENT ID]='" + StudentID_Txbx.Text.Trim() + "'", con);
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            StudGrade_DataGridView.DataSource = dt;
            con.Close();

            showData(pos);
            Search_Stud_Grade();

        }
        private void showData(int index) // DISPLAY THE STUDENT INFO UPON SEARCHING THE STUDENT ID
        {
            try
            {
                adapter = new SqlDataAdapter("SELECT * FROM STUDENT_INFO_TABLE", con);
                adapter.Fill(table);

                StudentID_Txbx.Text = table.Rows[index][0].ToString();
                StudName_Txbx.Text = table.Rows[index][1].ToString();
                LastNme_Txbx.Text = table.Rows[index][2].ToString();
                MiddleNme_TextBox.Text = table.Rows[index][3].ToString();
                Suffix_Txbox.Text = table.Rows[index][4].ToString();
                YearLevel_Txbx.Text = table.Rows[index][5].ToString();
                Class_Txbx.Text = table.Rows[index][6].ToString();
                Session_Txbx.Text = table.Rows[index][7].ToString();


            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
                return;
            }

        }

        private void Search_Stud_Grade() //UPON SEARCHING THE STUDENT ID, THIS FUNCTIONAL METHOD WILL ALSO CALLED FOR ITS GRADE IN SUBJECT AND DISPLAY IT.
        {
            string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            string query = "select * from STUDENT_GRADE_TABLE where [STUDENT ID]= '" + StudentID_Txbx.Text.Trim() + "';";
            SqlConnection contaBase = new SqlConnection(constring);
            SqlCommand cmdBase = new SqlCommand(query, contaBase);

            SqlDataReader myReader;
            try
            {
                contaBase.Open();
                myReader = cmdBase.ExecuteReader();

                while (myReader.Read())
                {                  
                        StudName_Txbx.Text = myReader.GetValue(1).ToString();
                        LastNme_Txbx.Text = myReader.GetValue(2).ToString();
                        MiddleNme_TextBox.Text = myReader.GetValue(3).ToString();
                        Subject_Tx.Text = myReader.GetValue(4).ToString();
                        PrelimGrade_Txbx.Text = myReader.GetValue(5).ToString();
                        MidTermGrade_Txbx.Text = myReader.GetValue(6).ToString();
                        PreFinalGrade_Txbx.Text = myReader.GetValue(7).ToString();
                        FinalGrade_Txbx.Text = myReader.GetValue(8).ToString();             
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);      
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;

        private void PRINT_BTN_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            System.Drawing.Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }
        private void Download_Btn_Click(object sender, EventArgs e)
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
        private void SearchStudID_Btn_Click(object sender, EventArgs e)
        {
            count = 0;
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT_GRADE_SYSTEM_TABLE WHERE [STUDENT ID]='" + SearchStudID_Txbx.Text.Trim() + "'", con);
            cmd.ExecuteNonQuery();
            System.Data.DataTable dt = new System.Data.DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            StudGrade_DataGridView.DataSource = dt;
            con.Close();
            if (dt.Rows.Count > 0)
            {
                showData(pos);
                Search_Stud_Grade();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\n Record not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StudentID_Txbx.Clear();
                StudName_Txbx.Clear();
                LastNme_Txbx.Clear();
                MiddleNme_TextBox.Clear();
                Suffix_Txbox.ResetText();
                YearLevel_Txbx.Clear();
                Class_Txbx.Clear();
                Session_Txbx.Clear();
            }
        
        }

 
       
    }
}

