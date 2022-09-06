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

namespace SchoolManagementSystem.Admin_UserControl
{
    public partial class YearClass_UserControl : UserControl
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public YearClass_UserControl()
        {
            InitializeComponent();
        }

        private void YearClass_UserControl_Load(object sender, EventArgs e)
        {
            getAllyEARlEVEL();
            getAllclassSection();
            YearLevelCombobox();
        }
        private void getAllyEARlEVEL()
        {
            cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open(); 
           cmd = new SqlCommand("SELECT * FROM YEAR_LEVEL_TABLE order by [Year Level] ASC",cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            YearSec_DataGridView.DataSource = dt;
        }
        private void getAllclassSection()
        {
            cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();                  //SELECT DISTINCT Country FROM Customers;
            cmd = new SqlCommand("Select * from CLASS_SECTION_TABLE order by [Year Level] ASC", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Class_DataGridView.DataSource = dt;
        }

        private void YearLevelCombobox()
        {
            cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cmd = new SqlCommand("SELECT YearID, [Year Level] FROM YEAR_LEVEL_TABLE", cn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            YearLevel_ComboBox.DataSource = dt;
            YearLevel_ComboBox.ValueMember = "YearID";
            YearLevel_ComboBox.DisplayMember = "Year Level";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
       
            AddYearLevelInfo();
        }
        protected void AddYearLevelInfo()
        {
      /* SELECTING THE Year_Level IF IT'S ALREADY EXIST */
            var con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            var ProCod = new SqlCommand("SELECT 1 FROM YEAR_LEVEL_TABLE WHERE [Year Level] = @Year_Level", con);
            con.Open();
            ProCod.Parameters.AddWithValue("@Year_Level", YEARLEVEL_TXBX.Text.Trim());
            using (var ProCodReader = ProCod.ExecuteReader())
            {
                if (ProCodReader.HasRows)
                {
                    MetroFramework.MetroMessageBox.Show(this, "The " + YEARLEVEL_TXBX.Text.Trim() + " is already exist!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    YEARLEVEL_TXBX.Clear();
                    return; // SUBJECT
                }
            }

        /* INSERTING NEW SUBJECT ONTO DATABASE */
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM YEAR_LEVEL_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand cmd2 = new SqlCommand("insert into YEAR_LEVEL_TABLE values(@Year_Level)", connection))
                {
                    try
                    {
                       if (YEARLEVEL_TXBX.Text.Trim() != "")
                        {                         
                            cmd2.Parameters.AddWithValue("@Year_Level", YEARLEVEL_TXBX.Text.Trim());
                            cmd2.ExecuteNonQuery();
                            MetroFramework.MetroMessageBox.Show(this, "The " + YEARLEVEL_TXBX.Text.Trim() + "\n is successfully saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataadapter.Fill(ds, "YEAR_LEVEL_TABLE");

                            comboboxRefresh();

                            connection.Close();
                            YearSec_DataGridView.DataSource = ds;
                            YearSec_DataGridView.DataMember = "YEAR_LEVEL_TABLE";
                            YearSec_DataGridView.Sort(YearSec_DataGridView.Columns[0], ListSortDirection.Ascending);
                            YEARLEVEL_TXBX.Clear();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\n Please provide the details!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            YEARLEVEL_TXBX.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }
                }
            }
        }
        private void comboboxRefresh()
        {
            da = new SqlDataAdapter();
            cmd = new SqlCommand("SELECT * FROM YEAR_LEVEL_TABLE", cn);          
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            YearLevel_ComboBox.DataSource = dt;
            YearLevel_ComboBox.DisplayMember = "Year Level";
        }

        private void addClass_Button_Click(object sender, EventArgs e)
        {
            AddClass();
        }
        protected void AddClass()
        {
            /* SELECTING THE Class IF IT'S ALREADY EXIST */
            var con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            var ProCod = new SqlCommand("SELECT 1 FROM CLASS_SECTION_TABLE WHERE Class = @Class", con);
            con.Open();
            //ProCod.Parameters.AddWithValue("@Year_Level", YEARLEVEL_TXBX.Text.Trim());
            ProCod.Parameters.AddWithValue("@Class", CLASS_TEXBX.Text.Trim());
            using (var ProCodReader = ProCod.ExecuteReader())
            {
                if (ProCodReader.HasRows)
                {
                    MetroFramework.MetroMessageBox.Show(this, "The " + CLASS_TEXBX.Text.Trim() + " is already exist!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CLASS_TEXBX.Clear();
                    return; 
                }
            }

            /* INSERTING NEW SUBJECT ONTO DATABASE */
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM CLASS_SECTION_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand cmd2 = new SqlCommand("insert into CLASS_SECTION_TABLE values(@YearID,@Year_Level,@Class)", connection))
                {
                    try
                    {
                        if (YearLevel_ComboBox.Text.Trim() != "" && CLASS_TEXBX.Text.Trim() !="")
                        {
                            cmd2.Parameters.AddWithValue("@YearID", YearID_Textbox.Text.Trim());
                            cmd2.Parameters.AddWithValue("@Year_Level", YearLevel_ComboBox.Text.Trim());
                            cmd2.Parameters.AddWithValue("@Class", CLASS_TEXBX.Text.Trim());
                            cmd2.ExecuteNonQuery();
                            MetroFramework.MetroMessageBox.Show(this, "\n\n The " + YearLevel_ComboBox.Text.Trim() + "," + CLASS_TEXBX.Text.Trim() + "\n is successfully added!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataadapter.Fill(ds, "CLASS_SECTION_TABLE");
                            connection.Close();
                            Class_DataGridView.DataSource = ds;
                            Class_DataGridView.DataMember = "CLASS_SECTION_TABLE";
                            Class_DataGridView.Sort(Class_DataGridView.Columns[0], ListSortDirection.Ascending);
                            CLASS_TEXBX.Clear();
                            YearLevel_ComboBox.ResetText();
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\n Please provide the details!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            YearID_Textbox.Clear();
                            CLASS_TEXBX.Clear();
                            YearLevel_ComboBox.ResetText();
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }
                }
            }
        }

        private void YearLevel_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();
            string str = "select * from YEAR_LEVEL_TABLE where [Year Level]='" + YearLevel_ComboBox.Text + "'";
            SqlCommand cmd = new SqlCommand(str, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                YearID_Textbox.Text = dr["YearID"].ToString();
            }

        }

        private void Class_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* DELETE THE DATE THROUGH CELL IN DATAGRIDVIEW */
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                var classSec = Class_DataGridView.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                string sql = "Select * from CLASS_SECTION_TABLE where CLASS='" + classSec + "'";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand cmdDelete = new SqlCommand("DELETE CLASS_SECTION_TABLE WHERE CLASS=@CLASS", connection))
                {
                        if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to remove this data?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmdDelete.Parameters.AddWithValue("@CLASS", classSec);
                            cmdDelete.ExecuteNonQuery();
                            MetroFramework.MetroMessageBox.Show(this, "Record successfully deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataadapter.Fill(ds, "CLASS_SECTION_TABLE");

                            getAllclassSection();
                            connection.Close();
                            //Class_DataGridView.DataSource = ds;
                            //Class_DataGridView.DataMember = "CLASS_SECTION_TABLE";
                            //Class_DataGridView.Sort(Class_DataGridView.Columns[0], ListSortDirection.Ascending);
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\n The record is not deleted!", "Remove Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                }
            }
        }
        private void YearSec_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* DELETE THE DATE THROUGH CELL IN DATAGRIDVIEW */
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                int yEARid = Convert.ToInt32(YearSec_DataGridView.Rows[e.RowIndex].Cells[0].FormattedValue.ToString());
                //var yEARLev = YearSec_DataGridView.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                string sql = "Select * from YEAR_LEVEL_TABLE where YearID='" + yEARid + "'";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand cmdDelete = new SqlCommand("DELETE YEAR_LEVEL_TABLE WHERE YearID=@YearID", connection))
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to remove this " + yEARid + " data?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmdDelete.Parameters.AddWithValue("@YearID", yEARid);
                        cmdDelete.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "Record successfully deleted!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataadapter.Fill(ds, "YEAR_LEVEL_TABLE");

                        getAllyEARlEVEL();
                        connection.Close();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\n The record is not deleted!", "Remove Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void YEARLEVEL_TXBX_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (YEARLEVEL_TXBX.Text.Length <= 0) return;
            string s = YEARLEVEL_TXBX.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = YEARLEVEL_TXBX.SelectionStart;
                int curSelLength = YEARLEVEL_TXBX.SelectionLength;
                YEARLEVEL_TXBX.SelectionStart = 0;
                YEARLEVEL_TXBX.SelectionLength = 1;
                YEARLEVEL_TXBX.SelectedText = s.ToUpper();
                YEARLEVEL_TXBX.SelectionStart = curSelStart;
                YEARLEVEL_TXBX.SelectionLength = curSelLength;
            }
        }

        private void CLASS_TEXBX_TextChanged(object sender, EventArgs e)
        {

            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (CLASS_TEXBX.Text.Length <= 0) return;
            string s = CLASS_TEXBX.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = CLASS_TEXBX.SelectionStart;
                int curSelLength = CLASS_TEXBX.SelectionLength;
                CLASS_TEXBX.SelectionStart = 0;
                CLASS_TEXBX.SelectionLength = 1;
                CLASS_TEXBX.SelectedText = s.ToUpper();
                CLASS_TEXBX.SelectionStart = curSelStart;
                CLASS_TEXBX.SelectionLength = curSelLength;
            }
        }
    }
}
