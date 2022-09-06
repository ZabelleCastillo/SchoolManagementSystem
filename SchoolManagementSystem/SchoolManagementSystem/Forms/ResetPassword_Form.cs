using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SchoolManagementSystem.Forms
{
    public partial class ResetPassword_Form : Form
    {
        string email = Forms.ForgotPassword_Form.to;
         
        public ResetPassword_Form()
        {
            InitializeComponent();
        }

        private void ResetPassword_BTN_Click(object sender, EventArgs e)
        {
            if(Reset_Txbox.Text == Retype_Reset_TextBox.Text)
            {
                if ((Reset_Txbox.TextLength < 6) && (Retype_Reset_TextBox.TextLength < 6))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Password must have 6 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Reset_Txbox.Clear();
                    Retype_Reset_TextBox.Clear();
                    return;
                }
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
                SqlCommand cmd = new SqlCommand("UPDATE ADMIN_TABLE SET PASSWORD = '" + Reset_Txbox.Text.Trim() + "', [RETYPE PASSWORD] = '" + Retype_Reset_TextBox.Text.Trim() + "' WHERE [EMAIL ADDRESS] = '" + email + "'", con);
                con.Open();
                cmd.Parameters.AddWithValue("@PASSWORD", Reset_Txbox.Text.Trim());
                cmd.Parameters.AddWithValue("@RETYPE_PASSWORD", Retype_Reset_TextBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MetroFramework.MetroMessageBox.Show(this, "Password reset successfully!");
                Forms.SecurityLogin_Form SecurityForm = new Forms.SecurityLogin_Form();
                this.Hide();
                SecurityForm.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Password do not match!");
            }
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                SecurityLogin_Form SecForm = new SecurityLogin_Form();
                this.Hide();
                SecForm.Show();
            }
        }
    }
}
