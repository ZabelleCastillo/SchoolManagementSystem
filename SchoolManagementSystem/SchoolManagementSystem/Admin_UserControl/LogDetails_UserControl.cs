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
using SchoolManagementSystem.Forms;

namespace SchoolManagementSystem.Admin_UserControl
{
    public partial class LogDetails_UserControl : UserControl
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public LogDetails_UserControl()
        {
            InitializeComponent();
        }

        private void LogDetails_UserControl_Load(object sender, EventArgs e)
        {
            TeacherTime();
        }
        private void TeacherTime()
        { //@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True

            //Data Source=.\SQLEXPRESS;Initial Catalog=School_DB;Integrated Security=True;Pooling=False"
            cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();
            cmd = new SqlCommand("Select * from TEACHER_LOGIN_TABLE order by DATE", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TeacherTime_DataGridView.DataSource = dt;
            
        }
 
        private void TeacherTime_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {      
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.TeacherTime_DataGridView.Rows[e.RowIndex];
                USERNAME_TXBX.Text = row.Cells[0].Value.ToString();
                DATE_TXBX.Text = row.Cells[1].Value.ToString();
            }
        }

     

        private void DELETE_BTN_Click(object sender, EventArgs e)
        {
            if (USERNAME_TXBX.Text != string.Empty)
            {
                cmd = new SqlCommand("DELETE TEACHER_LOGIN_TABLE WHERE USERNAME=@USERNAME", cn);
                //cn.Open();
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to all this data?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd.Parameters.AddWithValue("@USERNAME", USERNAME_TXBX.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    MetroFramework.MetroMessageBox.Show(this, "\n\n Record deleted successfully.");
                    TeacherTime();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\n Data not deleted.");
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\n Select username to delete.");
            }
        }

        public void DeleteLog()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "Select * from TEACHER_LOGIN_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM TEACHER_LOGIN_TABLE", connection))
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to all these data?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmdDelete.ExecuteNonQuery();
                        int rowCount = TeacherTime_DataGridView.Rows.Count;
                        for (int n = 0; n < rowCount; n++)
                        {
                            if (TeacherTime_DataGridView.Rows[0].IsNewRow == false)
                                TeacherTime_DataGridView.Rows.RemoveAt(0);
                        }
                    }
        

                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\n The record is not deleted!", "Remove Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                 
                }
            }
        }
        private void DEL_ALL_BTN_Click(object sender, EventArgs e)
        {
            DeleteLog();
        }

        private void USERNAME_TXBX_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (USERNAME_TXBX.Text.Length <= 0) return;
            string s = USERNAME_TXBX.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = USERNAME_TXBX.SelectionStart;
                int curSelLength = USERNAME_TXBX.SelectionLength;
                USERNAME_TXBX.SelectionStart = 0;
                USERNAME_TXBX.SelectionLength = 1;
                USERNAME_TXBX.SelectedText = s.ToUpper();
                USERNAME_TXBX.SelectionStart = curSelStart;
                USERNAME_TXBX.SelectionLength = curSelLength;
            }
        }

        private void DATE_TXBX_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (DATE_TXBX.Text.Length <= 0) return;
            string s = DATE_TXBX.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = DATE_TXBX.SelectionStart;
                int curSelLength = DATE_TXBX.SelectionLength;
                DATE_TXBX.SelectionStart = 0;
                DATE_TXBX.SelectionLength = 1;
                DATE_TXBX.SelectedText = s.ToUpper();
                DATE_TXBX.SelectionStart = curSelStart;
                DATE_TXBX.SelectionLength = curSelLength;
            }
        }

        private void TeacherTime_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
