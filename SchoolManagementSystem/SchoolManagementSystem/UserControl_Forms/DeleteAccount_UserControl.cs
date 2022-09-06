using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace SchoolManagementSystem.UserControl_Forms
{
    public partial class DeleteAccount_UserControl : UserControl
    {
        public static string to;

        string USER_FEEDBACK;

        public DeleteAccount_UserControl()
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
        private void DeleteAccount_UserControl_Load(object sender, EventArgs e)
        {
            /* ONCE THE USER LOGIN TO HIS ACCOUNT IN SECURITY LOGIN FORM, 
        HIS CREDENTIAL INFO WILL DISPLAY */
            ToEmail_Txbx.Text = DeactivateAccout_UserControl.email_add;
            Username_Txbx.Text = DeactivateAccout_UserControl.username;
        }

        private void Continue_BTN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM ADMIN_TABLE WHERE [EMAIL ADDRESS]= '" + ToEmail_Txbx.Text + "' " +
                                            "DELETE FROM TEACHER_CLASS_SCHEDULE_TABLE WHERE Username= '" + Username_Txbx.Text + "' ", con);
            con.Open();

            //MailMessage msg = new MailMessage();
            //msg.From = new MailAddress(ToEmail_Txbx.Text); 
            //msg.To.Add("castillobillyjess@gmail.com"); /* DEFAULT EMAIL FOR THIS SYSTEM */
            ////msg.Subject = ToEmail_Txbx.Text;
            //msg.Body = Question_Radiobutton1.Text;
            //msg.Body = Question_Radiobutton2.Text;
            //msg.Body = Question_Radiobutton3.Text;
            //msg.Body = Question_Radiobutton4.Text;
            //msg.Body = OtherQuestion_Txbox.Text;

            //SmtpClient smt = new SmtpClient();
            //smt.Host = "smtp.gmail.com";
            //NetworkCredential ntcd = new NetworkCredential();
            //ntcd.UserName = "castillobillyjess@gmail.com";
            //ntcd.Password = "zzsqrnabolvqiafj";
            //smt.Credentials = ntcd;
            //smt.EnableSsl = true;
            //smt.Port = 587;
            //smt.Send(msg);
            string from, pass, messageBody;
            MailMessage message = new MailMessage();
            to = (ToEmail_Txbx.Text).ToString();
            from = "castillobillyjess@gmail.com";
            pass = "zzsqrnabolvqiafj";
            messageBody = "Your account is deleted in School Management System. ";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Account Deleted!";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            smtp.Send(message);

            cmd.ExecuteNonQuery();
            con.Close();
            using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
            {
                string sql = "SELECT * FROM DELETE_ACCOUNT_TABLE";
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                connection.Open();
                using (SqlCommand cmd2 = new SqlCommand("INSERT INTO DELETE_ACCOUNT_TABLE (USERNAME, [EMAIL ADDRESS], MESSAGE, DATE) values (@USERNAME,@EMAIL_ADDRESS,@MESSAGE,@DATE)", connection))
                {
                    cmd2.Parameters.AddWithValue("@USERNAME", Username_Txbx.Text.Trim());
                    cmd2.Parameters.AddWithValue("@EMAIL_ADDRESS", ToEmail_Txbx.Text.Trim());
                    cmd2.Parameters.AddWithValue("@MESSAGE", USER_FEEDBACK + OtherQuestion_Txbox.Text.Trim());
                    cmd2.Parameters.AddWithValue("@DATE", DateTime.Now.ToString());
                    cmd2.ExecuteNonQuery();
                }

            }

            MetroFramework.MetroMessageBox.Show(this, "\n\n Account deleted!");
            Forms.SecurityLogin_Form SecurityForm = new Forms.SecurityLogin_Form();
            SecurityForm.Show();
            ParentForm.Hide();
            //MetroFramework.MetroMessageBox.Show(this, "Email has been sent!");
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\n Do you want to close the program?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
        }
        private void Question_Radiobutton1_CheckedChanged(object sender, EventArgs e)
        {
            USER_FEEDBACK = "I will create another account.";
        }
        private void Question_Radiobutton2_CheckedChanged(object sender, EventArgs e)
        {
            USER_FEEDBACK = "I will create another account.";
        }
        private void Question_Radiobutton3_CheckedChanged(object sender, EventArgs e)
        {
            USER_FEEDBACK = "I don't find School Management System useful.";
        }
        private void Question_Radiobutton4_CheckedChanged(object sender, EventArgs e)
        {
            USER_FEEDBACK = "I don't understand how to use School Management System useful.";
        }
        private void Question_Radiobutton5_CheckedChanged(object sender, EventArgs e)
        {
            USER_FEEDBACK = OtherQuestion_Txbox.Text;
        }

        private void OtherQuestion_Txbox_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (OtherQuestion_Txbox.Text.Length <= 0) return;
            string s = OtherQuestion_Txbox.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = OtherQuestion_Txbox.SelectionStart;
                int curSelLength = OtherQuestion_Txbox.SelectionLength;
                OtherQuestion_Txbox.SelectionStart = 0;
                OtherQuestion_Txbox.SelectionLength = 1;
                OtherQuestion_Txbox.SelectedText = s.ToUpper();
                OtherQuestion_Txbox.SelectionStart = curSelStart;
                OtherQuestion_Txbox.SelectionLength = curSelLength;
            }
        }
    }
}
