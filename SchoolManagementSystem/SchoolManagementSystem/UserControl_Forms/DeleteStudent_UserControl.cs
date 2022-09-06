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
    public partial class DeleteStudent_UserControl : UserControl
    {
        public DeleteStudent_UserControl()
        {
            InitializeComponent();
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void SearchSTUDid_Btn_Click(object sender, EventArgs e)
        {
            if (!(STUDENT_ID_TXBX.Text == string.Empty))
            {
                string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
                SqlConnection con = new SqlConnection(str);
                string query = "DELETE FROM STUDENT_GRADE_SYSTEM_TABLE where [STUDENT ID]= '" + this.STUDENT_ID_TXBX.Text.Trim() + "'" +
                               "DELETE FROM STUDENT_GRADE_TABLE where [STUDENT ID]= '" + this.STUDENT_ID_TXBX.Text.Trim() + "'" +
                               "DELETE FROM STUDENT_GRADE2_TABLE where [STUDENT ID]= '" + this.STUDENT_ID_TXBX.Text.Trim() + "'" +
                               "DELETE FROM STUDENT_GRADE3_TABLE where [STUDENT ID]= '" + this.STUDENT_ID_TXBX.Text.Trim() + "'" +
                               "DELETE FROM STUDENT_GRADE4_TABLE where [STUDENT ID]= '" + this.STUDENT_ID_TXBX.Text.Trim() + "'" +
                               "DELETE FROM STUDENT_GRADE5_TABLE where [STUDENT ID]= '" + this.STUDENT_ID_TXBX.Text.Trim() + "'" +
                               "DELETE FROM STUDENT_GRADE6_TABLE where [STUDENT ID]= '" + this.STUDENT_ID_TXBX.Text.Trim() + "'" +
                               "DELETE FROM STUDENT_GRADE7_TABLE where [STUDENT ID]= '" + this.STUDENT_ID_TXBX.Text.Trim() + "'" +
                               "DELETE FROM STUDENT_GRADE8_TABLE where [STUDENT ID]= '" + this.STUDENT_ID_TXBX.Text.Trim() + "'" +
                               "DELETE FROM STUDENT_GUARDIAN_TABLE where [STUDENT ID]= '" + this.STUDENT_ID_TXBX.Text.Trim() + "'" +
                               "DELETE FROM STUDENT_INFO_TABLE where [STUDENT ID]= '" + this.STUDENT_ID_TXBX.Text.Trim() + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader myreader;
                try
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "\n\n Are you sure you want to remove " + STUDENT_ID_TXBX.Text.Trim() + " ?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        con.Open();
                        myreader = cmd.ExecuteReader();

                        while (myreader.Read())
                        {
                        }
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n\n The " + STUDENT_ID_TXBX.Text.Trim() + " record is not deleted!", "Remove Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n\n Enter an ID which you want to delete.", "User information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }

