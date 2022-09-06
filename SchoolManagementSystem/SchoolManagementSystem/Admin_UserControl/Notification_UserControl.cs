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
    public partial class Notification_UserControl : UserControl
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        int count = 0;

        public Notification_UserControl()
        {
            InitializeComponent();
           
        }

        private void Notification_UserControl_Load(object sender, EventArgs e)
        {
            feedbackuser();
        }
        public void feedbackuser()
        {
            try
            {
                SqlDataAdapter MyDA = new SqlDataAdapter();
                string sqlSelectAll = "SELECT * FROM DELETE_ACCOUNT_TABLE order by DATE DESC";
                MyDA.SelectCommand = new SqlCommand(sqlSelectAll, cn);
                DataTable table = new DataTable();
                MyDA.Fill(table);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;
                FeedBack_User_DataGridView.DataSource = bSource;
                cn.Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            } 
        }

        private void LOAD_BTN_Click(object sender, EventArgs e)
        {
            count = 0;
            cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            cn.Open();
            cmd = new SqlCommand("SELECT * FROM DELETE_ACCOUNT_TABLE order by DATE DESC", cn);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            da.Fill(dt);
            FeedBack_User_DataGridView.DataSource = dt;
            cn.Close();
        }

        private void FeedBack_User_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.FeedBack_User_DataGridView.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                Email_Txbox.Text = row.Cells[1].Value.ToString();
                msg_txbx.Text = row.Cells[2].Value.ToString();
            }
        }

        private void DEL_BTN_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("DELETE DELETE_ACCOUNT_TABLE WHERE [EMAIL ADDRESS]=@EMAIL_ADDRESS", cn);
            cmd.Parameters.AddWithValue("@EMAIL_ADDRESS", Email_Txbox.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            MetroFramework.MetroMessageBox.Show(this, "\n\n Message deleted.");
            feedbackuser();
            Email_Txbox.Clear();
            msg_txbx.Clear();
        }
    }
}
