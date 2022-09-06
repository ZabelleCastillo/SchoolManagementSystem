using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace SchoolManagementSystem.Forms
{
    public partial class ForgotPassword_Form : Form
    {
        string randomCode;
        public static string to;

        public ForgotPassword_Form()
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

        private void SENDEMAIL_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate_emailaddress.IsMatch(Email_Txbox.Text) == true)
                {

                    string from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (Email_Txbox.Text).ToString();
                    from = "castillobillyjess@gmail.com";
                    pass = "zzsqrnabolvqiafj";
                    messageBody = "Your reset code is " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Reset Password";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                    smtp.Send(message);
                    MetroFramework.MetroMessageBox.Show(this, "The code has been sent to your email successfully!");
                    VerifyCode_Panel.Visible = true;
                }
            
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Email_Txbox.Focus();
                    Email_Txbox.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void VerifyCode_btn_Click(object sender, EventArgs e)
        {
            if(randomCode == (VerifyCode_Txbox.Text).ToString())
            {
                to = Email_Txbox.Text;
                Forms.ResetPassword_Form resetform = new Forms.ResetPassword_Form();
                this.Hide();
                resetform.Show();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\n " + VerifyCode_Txbox.Text + " is wrong. ");
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
