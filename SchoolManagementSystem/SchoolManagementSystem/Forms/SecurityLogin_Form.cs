using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SchoolManagementSystem.Forms
{
    public partial class SecurityLogin_Form : Form
    {
        public static string name = "";
        public static string username = "";
        public static string lastname = "";
        public static string email_add = "";
        public static string password = "";
        //public static string Image { get; set; }

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        public SecurityLogin_Form()
        {
            InitializeComponent();     
        }

        private void EyeShowHide_PctureBox_MouseUp(object sender, MouseEventArgs e)
        {
            PASSWORD_TextBox.PasswordChar = '*';
            PASSWORD_TextBox.UseSystemPasswordChar = true;
            EyeShowHide_PctureBox.Image = Properties.Resources.EyeShowHideGreen;
        }
        private void EyeShowHide_PctureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PASSWORD_TextBox.PasswordChar = '\0';
            PASSWORD_TextBox.UseSystemPasswordChar = false;
            EyeShowHide_PctureBox.Image = Properties.Resources.EyeShowGRN;
        }
        private void USERNAME_TextBox_Enter(object sender, EventArgs e)
        {
            if (USERNAME_TextBox.Text == "")
            {
                USERNAME_TextBox.ForeColor = Color.LimeGreen;
            }
        }
        private void PASSWORD_TextBox_Enter(object sender, EventArgs e)
        {

            if (PASSWORD_TextBox.Text == "")
            {
                PASSWORD_TextBox.UseSystemPasswordChar = true;
                PASSWORD_TextBox.Text = "";
                PASSWORD_TextBox.ForeColor = Color.LimeGreen;
            }
        }
        private void PASSWORD_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (PASSWORD_TextBox.Text != "")
            {
                EyeShowHide_PctureBox.Visible = true;
            }
            else
            {
                EyeShowHide_PctureBox.Visible = false;
            }
        }

        private void LOGIN_BTN_Click(object sender, EventArgs e)
        {
            MultiSecurityLogin();
        }
        private int _failedAttemptUser = 0; /* LIMIT TO LOGIN USER */
        private void SecurityLogin() /* FUNCTION METHOD FOR SECURITY LOGIN */
        {
            try
            {
                if (USERNAME_TextBox.Text == string.Empty || PASSWORD_TextBox.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease fill up the form", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string constring = @"Data Source=.\SQLEXPRESS;Initial Catalog=School_DB;Integrated Security=True;Pooling=False"; // making connection            
                    string query = "Select * from USER_TABLE where USERNAME = '" + USERNAME_TextBox.Text.Trim() + "' AND PASSWORD = '" + PASSWORD_TextBox.Text.Trim() + "';";
                    SqlConnection contaBase = new SqlConnection(constring);
                    SqlCommand cmdBase = new SqlCommand(query, contaBase);
                    SqlDataReader selectreader;
                    DataTable dt = new DataTable();
                    

                    int count = 0; /* COUNT, IS FOR VALIDATION WHETHER THERE IS AN ACCOUNT OR NONE */
                    contaBase.Open();
                    selectreader = cmdBase.ExecuteReader();

                    while (selectreader.Read())
                    {
                        name = selectreader["NAME"].ToString();
                        lastname = selectreader["LASTNAME"].ToString();
                        username = selectreader["USERNAME"].ToString();
                        email_add = selectreader["EMAIL ADDRESS"].ToString();
                        password = selectreader["PASSWORD"].ToString();
                        count++;
                    }
              
                    if (count > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n Successfully login.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /* if nag 1 ang count merong account */
                        Forms.Dashboard form = new Dashboard();
                        form.Show();
                        this.Hide(); /* TO HIDE THIS SECURITY LOGIN FORM (PARENT FORM) */
                    }
                    else
                    {
                        _failedAttemptUser++;
                        MetroFramework.MetroMessageBox.Show(this, "\n ACCESS DENIED! \n\n Incorrect username and password. \n\n You only have " + (3 - _failedAttemptUser) + " left to attempt.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    contaBase.Close();                 
                }
            }
            catch (Exception Error_Message)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n" + Error_Message.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void MultiSecurityLogin() /* FUNCTION METHOD FOR SECURITY LOGIN */
        {
            try
            {
                if (USERNAME_TextBox.Text == string.Empty || PASSWORD_TextBox.Text == string.Empty || TYPE_COMBOBX.Text == string.Empty)
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n\nPlease fill up the form", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string constring = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"; // making connection            
                    string query = "Select * FROM ADMIN_TABLE where USERNAME = '" + USERNAME_TextBox.Text.Trim() + "' AND PASSWORD = '" + PASSWORD_TextBox.Text.Trim() + "' AND TYPE = '" + TYPE_COMBOBX.Text.Trim() + "';";
                    SqlConnection contaBase = new SqlConnection(constring);
                    SqlCommand cmdBase = new SqlCommand(query, contaBase);
                    SqlDataReader selectreader;
                    DataTable dt = new DataTable();

                    string userRole = string.Empty;
                    int count = 0; /* COUNT, IS FOR VALIDATION WHETHER THERE IS AN ACCOUNT OR NONE */
                    contaBase.Open();
                    selectreader = cmdBase.ExecuteReader();

                    while (selectreader.Read())
                    {
                        count = count + 1;
                        
                        name = selectreader["NAME"].ToString();
                        lastname = selectreader["LASTNAME"].ToString();
                        username = selectreader["USERNAME"].ToString();
                        email_add = selectreader["EMAIL ADDRESS"].ToString();
                        password = selectreader["PASSWORD"].ToString();
                        userRole = selectreader["TYPE"].ToString();
                        //count++;
                    }
                
                    if (count == 1)
                    {                 
                       if (userRole == "SERVER")
                                {
                                    //MetroFramework.MetroMessageBox.Show(this, " role is wrong ");
                                    MetroFramework.MetroMessageBox.Show(this, "\n Successfully login.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    /* if nag 1 ang count merong account */
                                    Admin_Form.Admin_Form form = new Admin_Form.Admin_Form();
                                    form.Show();
                                    this.Hide(); /* TO HIDE THIS SECURITY LOGIN FORM (PARENT FORM) */
                                }
                        if (userRole == "CLERK")
                        {
                            //MetroFramework.MetroMessageBox.Show(this, " role is wrong ");
                            MetroFramework.MetroMessageBox.Show(this, "\n Successfully login.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            /* if nag 1 ang count merong account */
                            Forms.Dashboard form2 = new Dashboard();
                            form2.Show();
                            this.Hide(); /* TO HIDE THIS SECURITY LOGIN FORM (PARENT FORM) */
                        }

                        else if (userRole == "TEACHER")
                               {
                              
                                MetroFramework.MetroMessageBox.Show(this, "\n Successfully login.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                /* if nag 1 ang count merong account */
                                Forms.Dashboard form2 = new Dashboard();
                                form2.Show();
                                this.Hide(); /* TO HIDE THIS SECURITY LOGIN FORM (PARENT FORM) */

                                    using (SqlConnection connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"))
                                    {
                                        string Username1 = USERNAME_TextBox.Text;
                                        string roleType = TYPE_COMBOBX.Text;
                                        string sql = "SELECT * FROM ADMIN_TABLE";
                                        SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
                                        DataSet ds = new DataSet();
                                        connection.Open();
                                        using (SqlCommand cmd2 = new SqlCommand("INSERT INTO TEACHER_LOGIN_TABLE (USERNAME, DATE, ROLE) values (@USERNAME,@DATE,@ROLE)", connection))
                                        {
                                            cmd2.Parameters.AddWithValue("@USERNAME", Username1);
                                            cmd2.Parameters.AddWithValue("@DATE", DateTime.Now.ToString());
                                            cmd2.Parameters.AddWithValue("@ROLE", roleType);   
                                            cmd2.ExecuteNonQuery();
                                        }

                                    }
                                 }
                        else if (count > 1)
                                {
                                    MetroFramework.MetroMessageBox.Show(this, "\n\n Duplicate User And Password", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                }
                    }
                    else
                    {
                  
                        MetroFramework.MetroMessageBox.Show(this, "\n ACCESS DENIED! \n\n Incorrect username and password.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                    contaBase.Close();
                }
            }
            catch (Exception Error_Message)
            {
                MetroFramework.MetroMessageBox.Show(this, "\n" + Error_Message.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void PASSWORD_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* TO AVOID ERROR ONCE MAG-INSERT SA DATABASE NG VALUE */
            string notallowed = "'";
            char ch = e.KeyChar;
            if (e.KeyChar == Convert.ToChar(notallowed)) /* AVOID SINGLE QUOTATION */
            {
                e.Handled = true;
            }
            else if (Char.IsLetter(ch) || Char.IsDigit(ch) || ch == 8 || Char.IsSymbol(ch)) /* AVOID COPY-PASTE */
            {
            }
            else
            {
                e.Handled = true;
            }
        }
        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void ForgotPassword_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.ForgotPassword_Form form = new ForgotPassword_Form();
            form.Show();
            this.Hide();
        }
        private void CreateAcc_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_Form form = new Registration_Form();
            form.Show(this);
            this.Hide();
        }
        private void SecurityLogin_Form_Load(object sender, EventArgs e)
        {
         
        }
    }
}
