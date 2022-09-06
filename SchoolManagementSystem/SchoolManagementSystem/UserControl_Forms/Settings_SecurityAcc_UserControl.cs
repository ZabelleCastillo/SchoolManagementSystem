using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;



namespace SchoolManagementSystem.UserControl_Forms
{
    public partial class Settings_SecurityAcc_UserControl : UserControl
    {
        public Settings_SecurityAcc_UserControl()
        {
            InitializeComponent();
        }
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_emailaddress = email_validation();

        private void ChangePass_LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PASSWORD_PANEL.Visible = true;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void RetypePass_Texbox_TextChanged(object sender, EventArgs e)
        {
            if (RetypePass_Texbox.Text != "")
            {
                EyeShowHide_PctureBox.Visible = true;
            }
            else
            {
                EyeShowHide_PctureBox.Visible = false;
            }
        }

        private void EyeShowHide_PctureBox_MouseUp(object sender, MouseEventArgs e)
        {
            NewPass_Texbox.PasswordChar = '*';
            NewPass_Texbox.UseSystemPasswordChar = true;
            RetypePass_Texbox.PasswordChar = '*';
            RetypePass_Texbox.UseSystemPasswordChar = true;
            EyeShowHide_PctureBox.Image = Properties.Resources.EyeShowHideGreen;
        }

        private void EyeShowHide_PctureBox_MouseDown(object sender, MouseEventArgs e)
        {
            NewPass_Texbox.PasswordChar = '\0';
            NewPass_Texbox.UseSystemPasswordChar = false;
            RetypePass_Texbox.PasswordChar = '\0';
            RetypePass_Texbox.UseSystemPasswordChar = false;
            EyeShowHide_PctureBox.Image = Properties.Resources.EyeShowGRN;
        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n Are you not going to change your password?", "Cancel", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                PASSWORD_PANEL.Visible = false;
            }
        }

        private void Settings_SecurityAcc_UserControl_Load(object sender, EventArgs e)
        {
     /* ONCE THE USER LOGIN TO HIS ACCOUNT IN SECURITY LOGIN FORM, 
        HIS CREDENTIAL INFO WILL DISPLAY */
            USERNAME_TextBox.Text = Forms.SecurityLogin_Form.username;
            NAME_Txbox.Text = Forms.SecurityLogin_Form.name;
            Lastname_Txbox.Text = Forms.SecurityLogin_Form.lastname;
            Email_TextBox.Text = Forms.SecurityLogin_Form.email_add;
            UpdatePass_Textbox.Text = Forms.SecurityLogin_Form.password;
        }

        private void ChangePass_Btn_Click(object sender, EventArgs e)
        {
            ChangePassMethod();
        }
        private void ChangePassMethod()
        {
            /* THIS IS TO READ THE PREVIOUS PASSWORD AND RETRIEVE IF IT'S MATCH ONCE TYPING THE OLD PASSWORD */
            string CurrPass = Lastname_Txbox.Text;
            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")) // making connection            
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ADMIN_TABLE where USERNAME='" + USERNAME_TextBox.Text.Trim() + "' AND PASSWORD='" + OldPass__Txbox.Text.Trim() + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (OldPass__Txbox.Text != "" && NewPass_Texbox.Text != "" && RetypePass_Texbox.Text != "")
                {               
                    if (dt.Rows.Count > 0)
                    {
                        CurrPass = OldPass__Txbox.Text;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\n Wrong old password", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        OldPass__Txbox.Focus();
                        CurrPass = OldPass__Txbox.Text = "";
                        NewPass_Texbox.Clear();
                        RetypePass_Texbox.Clear();
                        return;
                    }
                    con.Close();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\n Please provide the details!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    OldPass__Txbox.Focus();
                    OldPass__Txbox.Clear();
                    NewPass_Texbox.Clear();
                    RetypePass_Texbox.Clear();
                    return;
                }
                using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
                {
                    string sql = "SELECT * ADMIN_TABLE";
                    SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    connection.Open();
                    using (SqlCommand UpdPassCmd = new SqlCommand("UPDATE ADMIN_TABLE set PASSWORD =@PASSWORD, [RETYPE PASSWORD] =@RETYPE_PASSWORD where PASSWORD='" + OldPass__Txbox.Text.Trim() + "'", connection))
                    {
                        if (NewPass_Texbox.Text != RetypePass_Texbox.Text)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\n The password is not match.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            OldPass__Txbox.Focus();
                            OldPass__Txbox.Clear();
                            NewPass_Texbox.Clear();
                            RetypePass_Texbox.Clear();
                            return;
                        }
                        if ((NewPass_Texbox.TextLength < 6) && (RetypePass_Texbox.TextLength < 6))
                        {
                            MetroFramework.MetroMessageBox.Show(this, "Password must have 6 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            NewPass_Texbox.Clear();
                            RetypePass_Texbox.Clear();
                            return;
                        }

                        UpdPassCmd.Parameters.AddWithValue("@PASSWORD", NewPass_Texbox.Text);
                        UpdPassCmd.Parameters.AddWithValue("@RETYPE_PASSWORD", RetypePass_Texbox.Text);
                        UpdPassCmd.ExecuteNonQuery();
                        connection.Close();

                        DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\n The password has been changed. \n Do you want to logout?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            Forms.SecurityLogin_Form form = new Forms.SecurityLogin_Form();                         
                            form.Show();
                            ParentForm.Hide(); /* A FORM THAT THE CONTAINER CONTROL IS ASSIGNED TO AND THIS PROPERTY WILL RETURN TO NULL WHERE HIDE CAN NOT CLOSE THE PARENT FORM */

                        }
                        Forms.SecurityLogin_Form.password = NewPass_Texbox.Text.ToUpper(); /* ONCE THE USER CHANGE THE PASSWORD AGAIN, THE VALUE OF VARIABLES WILL CHANGE AS WELL.  */
                        OldPass__Txbox.Enabled = false;
                        NewPass_Texbox.Enabled = false;
                        RetypePass_Texbox.Enabled = false;
                        OldPass__Txbox.Clear();
                    }
                }
            }
        }

        private void SecureAcc_BTN_Click(object sender, EventArgs e)
        {
            SecureAccountMethod();
        }
        private void SecureAccountMethod()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM ADMIN_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand UpdAdminCmd = new SqlCommand("UPDATE ADMIN_TABLE set NAME =@NAME, LASTNAME =@LASTNAME, [EMAIL ADDRESS] = @EMAIL_ADDRESS, PASSWORD = @PASSWORD, [RETYPE PASSWORD] = @RETYPE_PASSWORD WHERE USERNAME='" + USERNAME_TextBox.Text.Trim() + "'", connection))
                {
                    if (USERNAME_TextBox.Text != string.Empty || Lastname_Txbox.Text != string.Empty)
                    {
                        if (validate_emailaddress.IsMatch(Email_TextBox.Text) == true)
                        {
                            UpdAdminCmd.Parameters.AddWithValue("@USERNAME", USERNAME_TextBox.Text);
                            UpdAdminCmd.Parameters.AddWithValue("@NAME", NAME_Txbox.Text);
                            UpdAdminCmd.Parameters.AddWithValue("@LASTNAME", Lastname_Txbox.Text);
                            UpdAdminCmd.Parameters.AddWithValue("@EMAIL_ADDRESS", Email_TextBox.Text);
                            UpdAdminCmd.Parameters.AddWithValue("@PASSWORD", UpdatePass_Textbox.Text);
                            UpdAdminCmd.Parameters.AddWithValue("@RETYPE_PASSWORD", UpdatePass_Textbox.Text);
                            UpdAdminCmd.ExecuteNonQuery();
                            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\n Your account is secured!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dataadapter.Fill(ds, "ADMIN_TABLE");

                            connection.Close();
                            NewPass_Texbox.Clear();
                            RetypePass_Texbox.Clear();
                            return;
                        }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Email_TextBox.Clear();
                        return;
                    }
                }
                    else
                    {
                        DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\n Please provide the details!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        NewPass_Texbox.Clear();
                        RetypePass_Texbox.Clear();
                    }
                }
            }
        }

        private void USERNAME_TextBox_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (USERNAME_TextBox.Text.Length <= 0) return;
            string s = USERNAME_TextBox.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = USERNAME_TextBox.SelectionStart;
                int curSelLength = USERNAME_TextBox.SelectionLength;
                USERNAME_TextBox.SelectionStart = 0;
                USERNAME_TextBox.SelectionLength = 1;
                USERNAME_TextBox.SelectedText = s.ToUpper();
                USERNAME_TextBox.SelectionStart = curSelStart;
                USERNAME_TextBox.SelectionLength = curSelLength;
            }
        }

        private void NAME_Txbox_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (NAME_Txbox.Text.Length <= 0) return;
            string s = NAME_Txbox.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = NAME_Txbox.SelectionStart;
                int curSelLength = NAME_Txbox.SelectionLength;
                NAME_Txbox.SelectionStart = 0;
                NAME_Txbox.SelectionLength = 1;
                NAME_Txbox.SelectedText = s.ToUpper();
                NAME_Txbox.SelectionStart = curSelStart;
                NAME_Txbox.SelectionLength = curSelLength;
            }
        }

        private void Lastname_Txbox_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (Lastname_Txbox.Text.Length <= 0) return;
            string s = Lastname_Txbox.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = Lastname_Txbox.SelectionStart;
                int curSelLength = Lastname_Txbox.SelectionLength;
                Lastname_Txbox.SelectionStart = 0;
                Lastname_Txbox.SelectionLength = 1;
                Lastname_Txbox.SelectedText = s.ToUpper();
                Lastname_Txbox.SelectionStart = curSelStart;
                Lastname_Txbox.SelectionLength = curSelLength;
            }
        }
    }
}
