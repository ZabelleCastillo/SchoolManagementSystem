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
    public partial class DeactivateAccout_UserControl : UserControl
    {
        public static string username = "";
        public static string email_add = "";

        public DeactivateAccout_UserControl()
        {
            InitializeComponent();
        }

        private void DeactivateAccout_UserControl_Load(object sender, EventArgs e)
        {
            Username_Txbx.Text = Forms.SecurityLogin_Form.username;
        }

        private void Continue_BTN_Click(object sender, EventArgs e)
        {
            PasswordSecurity();
        }
        private void PasswordSecurity()
        {
            try
            {
                if (PASSWORD_TextBox.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease fill up the form", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"; // making connection            
                    string query = "Select * from ADMIN_TABLE where USERNAME = '" + Username_Txbx.Text.Trim() + "' AND PASSWORD = '" + PASSWORD_TextBox.Text.Trim() + "';";
                    SqlConnection contaBase = new SqlConnection(constring);
                    SqlCommand cmdBase = new SqlCommand(query, contaBase);
                    SqlDataReader selectreader;

                    int count = 0; /* COUNT, IS FOR VALIDATION WHETHER THERE IS A PASSWORD OR NONE */
                    contaBase.Open();
                    selectreader = cmdBase.ExecuteReader();

                    while (selectreader.Read())
                    {
                        username = selectreader["USERNAME"].ToString();
                        email_add = selectreader["EMAIL ADDRESS"].ToString();
                        count++;
                    }
                    if (count > 0)
                    {
                        /* if nag 1 ang count merong account */
                        DeleteAccount_UserControl form = new DeleteAccount_UserControl();
                        this.Parent.Controls.Add(form);
                        this.Hide();
                        
                        //this.Hide(); /* TO HIDE THIS SECURITY LOGIN FORM (PARENT FORM) */
                       
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n ACCESS DENIED! \n\n Incorrect password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    contaBase.Close();
                }
            }
            catch (Exception Error_Message)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n" + Error_Message.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
