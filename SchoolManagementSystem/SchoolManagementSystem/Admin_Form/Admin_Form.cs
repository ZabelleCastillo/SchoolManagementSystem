using SchoolManagementSystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Admin_Form
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void DashClose_btn_Click(object sender, EventArgs e)
        {
            Sidebar_Panel.Size = new Size(55, 590);
            Sidebar_Panel.Hide();///hide first para gumana ang animation
            SideBar_Transition.Show(Sidebar_Panel);///show pag katapos hide           
            DashOpen_btn.Visible = true;

            logDetails_UserControl1.Location = new Point(69, 83);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            logDetails_UserControl1.Size = new Size(956, 479);

            notification_UserControl1.Location = new Point(69, 92);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            notification_UserControl1.Size = new Size(951, 487);

            addSubject_UserControl1.Location = new Point(69, 83);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            addSubject_UserControl1.Size = new Size(743, 496);
           
            yearClass_UserControl1.Location = new Point(69, 11);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            yearClass_UserControl1.Size = new Size(981, 604);

            teacherSched_UserControl1.Location = new Point(69, 47);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            teacherSched_UserControl1.Size = new Size(892, 532);


            dashboard_UserControl1.Location = new Point(69, 25);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            dashboard_UserControl1.Size = new Size(668, 554);
        }

        private void DashOpen_btn_Click(object sender, EventArgs e)
        {
            Sidebar_Panel.Size = new Size(188, 590);
            Sidebar_Panel.Hide();///hide first para gumana ang animation
            SideBar_Transition.Show(Sidebar_Panel);///show pag katapos hide
            DashOpen_btn.Visible = false;

            logDetails_UserControl1.Location = new Point(205, 83);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            logDetails_UserControl1.Size = new Size(956, 479);


            notification_UserControl1.Location = new Point(210, 92);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            notification_UserControl1.Size = new Size(951, 487);

            addSubject_UserControl1.Location = new Point(309, 83);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            addSubject_UserControl1.Size = new Size(743, 496);

            yearClass_UserControl1.Location = new Point(197, 11);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            yearClass_UserControl1.Size = new Size(981, 604);

            teacherSched_UserControl1.Location = new Point(240, 47);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            teacherSched_UserControl1.Size = new Size(892, 532);

            dashboard_UserControl1.Location = new Point(356, 25);//para umurong yung main panel pag nag close na yung form kasi liliit yung form
            dashboard_UserControl1.Size = new Size(668, 554);
        }

        private void Log_btn_Click(object sender, EventArgs e)
        {
            childformTransition.Show(logDetails_UserControl1);
            logDetails_UserControl1.Refresh();

            notification_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            yearClass_UserControl1.Hide();
            teacherSched_UserControl1.Hide();
            dashboard_UserControl1.Hide();
        }

        private void Notification_btn_Click(object sender, EventArgs e)
        {          
            childformTransition.Show(notification_UserControl1);
            notification_UserControl1.Refresh();

            logDetails_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            yearClass_UserControl1.Hide();
            teacherSched_UserControl1.Hide();
            dashboard_UserControl1.Hide();
        }

        private void Subject_btn_Click(object sender, EventArgs e)
        {          
            childformTransition.Show(addSubject_UserControl1);
            addSubject_UserControl1.Refresh();

            notification_UserControl1.Hide();
            logDetails_UserControl1.Hide();
            yearClass_UserControl1.Hide();
            teacherSched_UserControl1.Hide();
            dashboard_UserControl1.Hide();
        }

        private void YearSec_btn_Click(object sender, EventArgs e)
        {
           
           childformTransition.Show(yearClass_UserControl1);
            yearClass_UserControl1.Refresh();

            notification_UserControl1.Hide();
            logDetails_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            teacherSched_UserControl1.Hide();
            dashboard_UserControl1.Hide();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nAre you sure you want to logout?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Forms.SecurityLogin_Form form = new SecurityLogin_Form();
                form.Show();
                this.Hide();
            }
        }

        private void Teacher_btn_Click(object sender, EventArgs e)
        {         
            childformTransition.Show(teacherSched_UserControl1);
            teacherSched_UserControl1.Refresh();

            notification_UserControl1.Hide();
            logDetails_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            yearClass_UserControl1.Hide();
            dashboard_UserControl1.Hide();
        }

        private void DashBoard_btn_Click(object sender, EventArgs e)
        {
            
            childformTransition.Show(dashboard_UserControl1);
            dashboard_UserControl1.Refresh();
         
            notification_UserControl1.Hide();
            logDetails_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            yearClass_UserControl1.Hide();
            teacherSched_UserControl1.Hide();
        }
    }
}
