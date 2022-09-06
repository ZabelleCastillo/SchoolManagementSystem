using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.Data;

namespace SchoolManagementSystem.Forms
{
    public partial class Registration_Form : Form
    {
        string randomCode;
        public static string to;

        public Registration_Form()
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                SecurityLogin_Form secuForm = new SecurityLogin_Form();
                this.Hide();
                secuForm.Show(this);
            }
        }
        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RetypePass_Txbx_TextChanged(object sender, EventArgs e)
        {
            if (RetypePass_Txbx.Text != "")
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
            Password_Txbx.PasswordChar = '*';
            Password_Txbx.UseSystemPasswordChar = true;
            RetypePass_Txbx.PasswordChar = '*';
            RetypePass_Txbx.UseSystemPasswordChar = true;
            EyeShowHide_PctureBox.Image = Properties.Resources.EyeShowHideGreen;
        }

        private void EyeShowHide_PctureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Password_Txbx.PasswordChar = '\0';
            Password_Txbx.UseSystemPasswordChar = false;
            RetypePass_Txbx.PasswordChar = '\0';
            RetypePass_Txbx.UseSystemPasswordChar = false;
            EyeShowHide_PctureBox.Image = Properties.Resources.EyeShowGRN;
        }

        private void Name_Txbx_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (Name_Txbx.Text.Length <= 0) return;
            string s = Name_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = Name_Txbx.SelectionStart;
                int curSelLength = Name_Txbx.SelectionLength;
                Name_Txbx.SelectionStart = 0;
                Name_Txbx.SelectionLength = 1;
                Name_Txbx.SelectedText = s.ToUpper();
                Name_Txbx.SelectionStart = curSelStart;
                Name_Txbx.SelectionLength = curSelLength;
            }
        }
        private void Lastname_Txbx_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (Lastname_Txbx.Text.Length <= 0) return;
            string s = Lastname_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = Lastname_Txbx.SelectionStart;
                int curSelLength = Lastname_Txbx.SelectionLength;
                Lastname_Txbx.SelectionStart = 0;
                Lastname_Txbx.SelectionLength = 1;
                Lastname_Txbx.SelectedText = s.ToUpper();
                Lastname_Txbx.SelectionStart = curSelStart;
                Lastname_Txbx.SelectionLength = curSelLength;
            }
        }

        private void SIGNUP_BTN_Click(object sender, EventArgs e)
        {
            REGISTER_ACCOUNT_METHOD();
        }
        private void REGISTER_ACCOUNT_METHOD()
        {
            /* SELECTING THE USER IF IT IS ALREADY EXIST */
            var con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            var UserCmd = new SqlCommand("SELECT 1 FROM ADMIN_TABLE WHERE USERNAME = @USERNAME", con);
            con.Open();
            UserCmd.Parameters.AddWithValue("@USERNAME", USERNAME_TextBox.Text.Trim());

            using (var userReader = UserCmd.ExecuteReader())
            {
                if (userReader.HasRows)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Username is already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    USERNAME_TextBox.Focus();
                    USERNAME_TextBox.Clear();
                    Name_Txbx.Clear();
                    Lastname_Txbx.Clear();
                    email_Txbx.Clear();
                    Password_Txbx.Clear();
                    RetypePass_Txbx.Clear();
                    return; //username
                }
            }
            /* SELECTING THE EMAIL ADDRESS IF IT IS ALREADY EXIST */
            var UserCmd2 = new SqlCommand("SELECT 1 FROM ADMIN_TABLE WHERE [EMAIL ADDRESS] = @EMAIL_ADDRESS", con);
            //con.Open();
            UserCmd2.Parameters.AddWithValue("@EMAIL_ADDRESS", email_Txbx.Text.Trim());

            using (var userReader = UserCmd2.ExecuteReader())
            {
                if (userReader.HasRows)
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\n Email is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    USERNAME_TextBox.Focus();
                    USERNAME_TextBox.Clear();
                    Name_Txbx.Clear();
                    Lastname_Txbx.Clear();
                    email_Txbx.Clear();
                    Password_Txbx.Clear();
                    RetypePass_Txbx.Clear();
                    return;
                }
            }
            /* TO CATCH AN ERROR IF THE TEXTFIELDS ARE EMPTY AND NOT MATCH PASSWORD 
               AND TO VALIDATE THE REGISTRATION FIRST BY VERIFYING THE CODE THROUGH EMAIL*/
                    if ((USERNAME_TextBox.Text != "") && (Name_Txbx.Text != "") && (Lastname_Txbx.Text != "") && (email_Txbx.Text != "") && (Password_Txbx.Text != "") && (RetypePass_Txbx.Text != "" && (TYPE_COMBOBX.Text != "")))
                    {
                        if (Password_Txbx.Text != RetypePass_Txbx.Text)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\n Password is not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Password_Txbx.Clear();
                            RetypePass_Txbx.Clear();
                            return;
                        }
                        if ((Password_Txbx.TextLength < 6) && (RetypePass_Txbx.TextLength < 6))
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\n Password must have 6 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Password_Txbx.Clear();
                            RetypePass_Txbx.Clear();
                            return;
                        }
                        if (USERNAME_TextBox.TextLength < 6)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\n Username must have 6 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            USERNAME_TextBox.Focus();
                            USERNAME_TextBox.Clear();
                            return;
                        }
                        if (validate_emailaddress.IsMatch(email_Txbx.Text) == true)
                        {
                            string from, pass, messageBody;
                            Random rand = new Random();
                            randomCode = (rand.Next(999999)).ToString();
                            MailMessage message = new MailMessage();
                            to = (email_Txbx.Text).ToString();
                            from = "castillobillyjess@gmail.com";
                            pass = "zzsqrnabolvqiafj";
                            messageBody = "Your verification code is " + randomCode;
                            message.To.Add(to);
                            message.From = new MailAddress(from);
                            message.Body = messageBody;
                            message.Subject = "Verify Email";
                            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                            smtp.EnableSsl = true;
                            smtp.Port = 587;
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.Credentials = new NetworkCredential(from, pass);

                            smtp.Send(message);
                            MetroFramework.MetroMessageBox.Show(this, "\n\n The verification code has been sent to your email successfully!");
                            VerifyCode_Panel.Visible = true;
                        }
                        else
                        {
                            MetroFramework.MetroMessageBox.Show(this, "\n\n Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            email_Txbx.Clear();
                            return;
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Please fill up the TextBox!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        USERNAME_TextBox.Focus();
                        USERNAME_TextBox.Clear();
                        Name_Txbx.Clear();
                        Lastname_Txbx.Clear();
                        email_Txbx.Clear();
                        Password_Txbx.Clear();
                        RetypePass_Txbx.Clear();
                        return;
                    }

                }

        private void VerifyCode_Panel_Paint(object sender, PaintEventArgs e)
        {
            if (VerifyCode_Panel.Visible == true)
            {
                Registration_Panel.Enabled = false;
            }
        }

        private void VerifyCode_btn_Click(object sender, EventArgs e)
        {
            //inserting and registering information with valid username to database.
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                connection.Open();
                using (SqlCommand cmd2 = new SqlCommand("INSERT INTO ADMIN_TABLE values(@USERNAME,@NAME,@LASTNAME,@EMAIL_ADDRESS,@PASSWORD,@RETYPE_PASSWORD,@DATE_CREATED,@TYPE)" , connection))
                {
                    if (randomCode == (VerifyCode_Txbox.Text).ToString())
                    {
                        to = email_Txbx.Text;
                        cmd2.Parameters.AddWithValue("@USERNAME", USERNAME_TextBox.Text.Trim());
                        cmd2.Parameters.AddWithValue("@NAME", Name_Txbx.Text.Trim());
                        cmd2.Parameters.AddWithValue("@LASTNAME", Lastname_Txbx.Text.Trim());
                        cmd2.Parameters.AddWithValue("@EMAIL_ADDRESS", email_Txbx.Text.Trim());
                        cmd2.Parameters.AddWithValue("@PASSWORD", Password_Txbx.Text.Trim());
                        cmd2.Parameters.AddWithValue("@RETYPE_PASSWORD", RetypePass_Txbx.Text.Trim());
                        cmd2.Parameters.AddWithValue("@DATE_CREATED", DateTime.Now.ToString());
                        cmd2.Parameters.AddWithValue("@TYPE", TYPE_COMBOBX.Text.Trim());
                        cmd2.ExecuteNonQuery();
                        MetroFramework.MetroMessageBox.Show(this, "\n\n Registered!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Insert_TeacherAcc_Method1();
                        connection.Close();
                        TYPE_COMBOBX.ResetText();
                        USERNAME_TextBox.Clear();
                        Name_Txbx.Clear();
                        Lastname_Txbx.Clear();
                        email_Txbx.Clear();
                        Password_Txbx.Clear();
                        RetypePass_Txbx.Clear();

                        SecurityLogin_Form form = new SecurityLogin_Form();
                        this.Hide();
                        form.Show(this);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\n " + VerifyCode_Txbox.Text + " is wrong. ");
                    }
                }
            }
        }
        private void Insert_TeacherAcc_Method1()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                connection.Open();
                using (SqlCommand cmd2 = new SqlCommand("insert TEACHER_CLASS_SCHEDULE_TABLE  (Username, Name, Lastname) VALUES (' " + USERNAME_TextBox.Text.Trim() + "', ' " + Name_Txbx.Text.Trim() + "', ' " + Lastname_Txbx.Text.Trim() + "')", connection))
                {
                    try
                    {
                        //cmd2.Parameters.AddWithValue("@TeacherID", TeacherID_Txbx.Text);
                        cmd2.Parameters.AddWithValue("@Username", USERNAME_TextBox.Text.Trim());
                        cmd2.Parameters.AddWithValue("@Name", Name_Txbx.Text.Trim());
                        cmd2.Parameters.AddWithValue("@Lastname", Lastname_Txbx.Text.Trim());
                        cmd2.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch(Exception ex)
                    {
                        MetroFramework.MetroMessageBox.Show(this, ex.Message);
                    }
                  
                }
            }
        }
    }
}
