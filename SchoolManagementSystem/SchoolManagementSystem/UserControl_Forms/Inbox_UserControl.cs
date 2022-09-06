using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace SchoolManagementSystem.UserControl_Forms
{
    public partial class Inbox_UserControl : UserControl
    {
        public Inbox_UserControl()
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
        private void SEND_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate_emailaddress.IsMatch(to_txbx.Text) == true)
                {
                    /* THIS IS GMAIL TO GMAIL SEND */
                    /* "zzsqrnabolvqiafj" APP PASSWORD OF castillobillyjess@gmail.com  */
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress(FROM_tXBOX.Text);  //("castillobillyjess@gmail.com");
                    msg.To.Add(to_txbx.Text);
                    msg.Subject = subject_Txbx.Text;
                    msg.Body = Body_Txbx.Text;

                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    ntcd.UserName = FROM_tXBOX.Text;
                    ntcd.Password = "zzsqrnabolvqiafj";
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    smt.Send(msg);

                    MetroFramework.MetroMessageBox.Show(this, "Email has been sent!");
                    //FROM_tXBOX.Clear();
                    to_txbx.Clear();
                    subject_Txbx.Clear();
                    Body_Txbx.Clear();
                    //SmtpClient client = new SmtpClient();
                    //{
                    //    Host = "smtp.gmail.com",
                    //    Port = 587,
                    //    EnableSsl = true,
                    //    DeliveryMethod = SmtpDeliveryMethod.Network,
                    //    UseDefaultCredentials = false,
                    //    Credentials = new NetworkCredential()
                    //    {
                    //        UserName = FROM_tXBOX.Text,
                    //        Password = "zzsqrnabolvqiafj"

                    //    }
                    //};
                    //MailAddress fromEmail = new MailAddress(FROM_tXBOX.Text, "Jess");
                    //MailAddress ToEmail = new MailAddress(to_txbx.Text, "Someone");
                    //MailMessage Message = new MailMessage();
                    //{
                    //    From = fromEmail,
                    //    Subject = subject_Txbx.Text,
                    //    Body = Body_Txbx.Text
                    //};
                    //Message.To.Add(ToEmail);
                    //client.Send(Message);



                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    to_txbx.Focus();
                    to_txbx.Clear();
                    subject_Txbx.Clear();
                    Body_Txbx.Clear();
                    return;
                }
                }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
                to_txbx.Clear();
                subject_Txbx.Clear();
                Body_Txbx.Clear();
            }

            //MailAddress from = new MailAddress("Someone@domain.topleveldomain", "Name and stuff");
            //MailAddress to = new MailAddress("Someone@domain.topleveldomain", "Name and stuff");
            //List<MailAddress> cc = new List<MailAddress>();
            //cc.Add(new MailAddress("Someone@domain.topleveldomain", "Name and stuff"));
            //SendEmail("Want to test this damn thing", from, to, cc);
        }
        //protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc, List<MailAddress> _bcc = null)
        //{
        //    string Text = "";
        //    SmtpClient mailClient = new SmtpClient("Mailhost");
        //    MailMessage msgMail;
        //    Text = "Stuff";
        //    msgMail = new MailMessage();
        //    msgMail.From = _from;
        //    msgMail.To.Add(_to);
        //    foreach (MailAddress addr in _cc)
        //    {
        //        msgMail.CC.Add(addr);
        //    }
        //    if (_bcc != null)
        //    {
        //        foreach (MailAddress addr in _bcc)
        //        {
        //            msgMail.Bcc.Add(addr);
        //        }
        //    }
        //    msgMail.Subject = _subject;
        //    msgMail.Body = Text;
        //    msgMail.IsBodyHtml = true;
        //    mailClient.Send(msgMail);
        //    msgMail.Dispose();
        //}
        private void Close_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\n Do you want to close the program?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void to_txbx_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void subject_Txbx_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (subject_Txbx.Text.Length <= 0) return;
            string s = subject_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = subject_Txbx.SelectionStart;
                int curSelLength = subject_Txbx.SelectionLength;
                subject_Txbx.SelectionStart = 0;
                subject_Txbx.SelectionLength = 1;
                subject_Txbx.SelectedText = s.ToUpper();
                subject_Txbx.SelectionStart = curSelStart;
                subject_Txbx.SelectionLength = curSelLength;
            }
        }

        private void Body_Txbx_TextChanged(object sender, EventArgs e)
        {
            /* THIS IS TO UPPER CASE THE FIRST LETTE OF THE TEXT WORD */
            if (Body_Txbx.Text.Length <= 0) return;
            string s = Body_Txbx.Text.Substring(0, 1);
            if (s != s.ToUpper())
            {
                int curSelStart = Body_Txbx.SelectionStart;
                int curSelLength = Body_Txbx.SelectionLength;
                Body_Txbx.SelectionStart = 0;
                Body_Txbx.SelectionLength = 1;
                Body_Txbx.SelectedText = s.ToUpper();
                Body_Txbx.SelectionStart = curSelStart;
                Body_Txbx.SelectionLength = curSelLength;
            }
        }
    }
}
