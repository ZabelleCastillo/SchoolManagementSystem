using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            customizeDesign();
            this.Refresh();
            // SETTING DEFAULT ON DASHBOARD BUTTON
            Cursor_Panel.Height = Dashboard_BTN.Height;
            Cursor_Panel.Top = Dashboard_BTN.Top;
        }
        private void customizeDesign() // FUNCTION METHODS
        {
            SubMenu_MainEntry_Panel.Visible = false;
            SubMenu_Student_Panel.Visible = false;
            SubMenu_Teacher_Panel.Visible = false;
            SubMenu_Settings_Panel.Visible = false;
        }
        private void Hide_SubMenu()
        {
            if (SubMenu_MainEntry_Panel.Visible == true)
                SubMenu_MainEntry_Panel.Visible = false;

            if (SubMenu_Student_Panel.Visible == true)
                SubMenu_Student_Panel.Visible = false;

            if (SubMenu_Teacher_Panel.Visible == true)
                SubMenu_Teacher_Panel.Visible = false;

            if (SubMenu_Settings_Panel.Visible == true)
                SubMenu_Settings_Panel.Visible = false;
        }
        private void Show_SubMenu(Panel SubMenu) // all submenus are panel, therefore, as a parameter, we indicated that types are SubMenu
        {
            if (SubMenu.Visible == false)
            {
                Hide_SubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void Close_Btn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n Do you really want to close the program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Dashboard_BTN_Click(object sender, EventArgs e)
        {
            Cursor_Panel.Height = Dashboard_BTN.Height;
            Cursor_Panel.Top = Dashboard_BTN.Top;
            Hide_SubMenu();

            SideBar_Transition.Show(dashboard_UserControl1);
            dashboard_UserControl1.Refresh();

            regStudent_UserControl1.Hide();
            inbox_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            studentGrade_UserControl3.Hide();
            printGrades_UserControl1.Hide();
            teacherClassSchedule_UserControl1.Hide();
            deleteStudent_UserControl1.Hide();
            export_UserControl1.Hide();
            settings_SecurityAcc_UserControl1.Hide();
            deactivateAccout_UserControl1.Hide();

        }
        private void MainEntry_btn_Click(object sender, EventArgs e)
        {
            Cursor_Panel.Height = MainEntry_btn.Height;
            Cursor_Panel.Top = MainEntry_btn.Top;

            Show_SubMenu(SubMenu_MainEntry_Panel);
        }
        private void Student_btn_Click(object sender, EventArgs e)
        {
            Show_SubMenu(SubMenu_Student_Panel);

            Cursor_Panel.Height = Student_btn.Height;
            Cursor_Panel.Top = Student_btn.Top;
        }
        private void Teacher_btn_Click(object sender, EventArgs e)
        {
            Show_SubMenu(SubMenu_Teacher_Panel);

            Cursor_Panel.Height = Teacher_btn.Height;
            Cursor_Panel.Top = Teacher_btn.Top;
        }
        private void Settings_btn_Click(object sender, EventArgs e)
        {
            Show_SubMenu(SubMenu_Settings_Panel);

            Cursor_Panel.Height = Settings_btn.Height;
            Cursor_Panel.Top = Settings_btn.Top;
        }
        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Cursor_Panel.Height = Logout_btn.Height;
            Cursor_Panel.Top = Logout_btn.Top;

            DialogResult dialog = MetroFramework.MetroMessageBox.Show(this, "\n\nAre you sure you want to logout?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Forms.SecurityLogin_Form form = new SecurityLogin_Form();
                form.Show();
                this.Hide();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            /* ONCE THE USER LOGIN TO HIS ACCOUNT IN SECURITY LOGIN FORM, 
           HIS CREDENTIAL INFO WILL DISPLAY */
            Lastname_Label.Text = SecurityLogin_Form.lastname;
            Name_Label.Text = SecurityLogin_Form.name;


            /* UPON CLICKING THE  dashboard_UserControl1, THE  dashboard_UserControl1 WILL APPEAR WITH TRANSITION EFFECT */
            dashboard_UserControl1.Location = new Point(152, 46);
            dashboard_UserControl1.Size = new Size(669, 581);

            /* UPON CLICKING THE addSubject_UserControl1, THE addSubject_UserControl1FORM WILL APPEAR WITH TRANSITION EFFECT */
            inbox_UserControl1.Location = new Point(129, 63);
            inbox_UserControl1.Size = new Size(743, 449);

            /* UPON CLICKING THE addSubject_UserControl1, THE addSubject_UserControl1FORM WILL APPEAR WITH TRANSITION EFFECT */
            addSubject_UserControl1.Location = new Point(129, 78);
            addSubject_UserControl1.Size = new Size(743, 511);


            /* UPON CLICKING THE regStudent_UserControl1, THE regStudent_UserControl1 FORM WILL APPEAR WITH TRANSITION EFFECT */
            regStudent_UserControl1.Location = new Point(62, 63);
            regStudent_UserControl1.Size = new Size(856, 569);


            /* UPON CLICKING THE export_UserControl1, THE export_UserControl1 FORM WILL APPEAR WITH TRANSITION EFFECT */
            export_UserControl1.Location = new Point(6, 46);
            export_UserControl1.Size = new Size(997, 466);

            /* UPON CLICKING THE studentGrade_UserControl1, THE studentGrade_UserControl1 FORM WILL APPEAR WITH TRANSITION EFFECT */
            studentGrade_UserControl3.Location = new Point(24, 18);
            studentGrade_UserControl3.Size = new Size(949, 673);


            /* UPON CLICKING THE printGrades_UserControl1, THE printGrades_UserControl1 FORM WILL APPEAR WITH TRANSITION EFFECT */
            printGrades_UserControl1.Location = new Point(99, 13);
            printGrades_UserControl1.Size = new Size(818, 652);

            /* UPON CLICKING THE teacherClassSchedule_UserControl1, THE teacherClassSchedule_UserControl1 FORM WILL APPEAR WITH TRANSITION EFFECT */
            teacherClassSchedule_UserControl1.Location = new Point(34, 6);
            teacherClassSchedule_UserControl1.Size = new Size(951, 643);

            /* UPON CLICKING THE settings_SecurityAcc_UserControl1, THE settings_SecurityAcc_UserControl1 FORM WILL APPEAR WITH TRANSITION EFFECT */
            settings_SecurityAcc_UserControl1.Location = new Point(152, 63);
            settings_SecurityAcc_UserControl1.Size = new Size(672, 460);


            /* UPON CLICKING THE deleteStudent_UserControl1, THE deleteStudent_UserControl1 FORM WILL APPEAR WITH TRANSITION EFFECT */
            deleteStudent_UserControl1.Location = new Point(293, 159);
            deleteStudent_UserControl1.Size = new Size(413, 184);

        }

        private void Subject_btn_Click(object sender, EventArgs e)
        {
            /* SHOW THE addSubject_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(addSubject_UserControl1);
            addSubject_UserControl1.Refresh();

            dashboard_UserControl1.Hide();
            inbox_UserControl1.Hide();
            regStudent_UserControl1.Hide();
            studentGrade_UserControl3.Hide();
            export_UserControl1.Hide();
            printGrades_UserControl1.Hide();
            teacherClassSchedule_UserControl1.Hide();
            settings_SecurityAcc_UserControl1.Hide();
            deleteStudent_UserControl1.Hide();
            deactivateAccout_UserControl1.Hide();
        }
        private void Grades_btn_Click(object sender, EventArgs e)
        {
            this.Refresh();
            /* SHOW THE studentGrade_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(studentGrade_UserControl3);
            studentGrade_UserControl3.Refresh();

            dashboard_UserControl1.Hide();
            inbox_UserControl1.Hide();
            regStudent_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            printGrades_UserControl1.Hide();
            export_UserControl1.Hide();
            teacherClassSchedule_UserControl1.Hide();
            settings_SecurityAcc_UserControl1.Hide();
            deleteStudent_UserControl1.Hide();
            deactivateAccout_UserControl1.Hide();
        }
        private void Print_btn_Click(object sender, EventArgs e)
        {
            /* SHOW THE printGrades_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(printGrades_UserControl1);
            printGrades_UserControl1.Refresh();

            dashboard_UserControl1.Hide();
            inbox_UserControl1.Hide();
            regStudent_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            studentGrade_UserControl3.Hide();
            export_UserControl1.Hide();
            teacherClassSchedule_UserControl1.Hide();
            settings_SecurityAcc_UserControl1.Hide();
            deleteStudent_UserControl1.Hide();
            deactivateAccout_UserControl1.Hide();
        }

        private void Settings_Security_Btn_Click(object sender, EventArgs e)
        {
            /* SHOW THE settings_SecurityAcc_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(settings_SecurityAcc_UserControl1);
            settings_SecurityAcc_UserControl1.Refresh();

            dashboard_UserControl1.Hide();
            inbox_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            regStudent_UserControl1.Hide();
            studentGrade_UserControl3.Hide();
            export_UserControl1.Hide();
            printGrades_UserControl1.Hide();
            teacherClassSchedule_UserControl1.Hide();
            deleteStudent_UserControl1.Hide();
            deactivateAccout_UserControl1.Hide();
        }

        private void Minimized_Btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddStudent_btn_Click(object sender, EventArgs e)
        {
            /* SHOW THE regStudent_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(regStudent_UserControl1);
            regStudent_UserControl1.Refresh();

            dashboard_UserControl1.Hide();
            inbox_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            studentGrade_UserControl3.Hide();
            export_UserControl1.Hide();
            printGrades_UserControl1.Hide();
            teacherClassSchedule_UserControl1.Hide();
            settings_SecurityAcc_UserControl1.Hide();
            deleteStudent_UserControl1.Hide();
            deactivateAccout_UserControl1.Hide();
        }
        private void Inbox_btn_Click(object sender, EventArgs e)
        {
            /* SHOW THE inbox_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(inbox_UserControl1);
            inbox_UserControl1.Refresh();

            dashboard_UserControl1.Hide();
            regStudent_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            studentGrade_UserControl3.Hide();
            export_UserControl1.Hide();
            printGrades_UserControl1.Hide();
            teacherClassSchedule_UserControl1.Hide();
            settings_SecurityAcc_UserControl1.Hide();
            deleteStudent_UserControl1.Hide();
            deactivateAccout_UserControl1.Hide();
        }
        private void Export_btn_Click(object sender, EventArgs e)
        {
            /* SHOW THE export_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(export_UserControl1);
            export_UserControl1.Refresh();

            dashboard_UserControl1.Hide();
            regStudent_UserControl1.Hide();
            inbox_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            studentGrade_UserControl3.Hide();
            teacherClassSchedule_UserControl1.Hide();
            printGrades_UserControl1.Hide();
            settings_SecurityAcc_UserControl1.Hide();
            deleteStudent_UserControl1.Hide();
            deactivateAccout_UserControl1.Hide();
        }
        private void ClassSched_btn_Click(object sender, EventArgs e)
        {
         /* SHOW THE teacherClassSchedule_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(teacherClassSchedule_UserControl1);
            teacherClassSchedule_UserControl1.Refresh();

            dashboard_UserControl1.Hide();
            regStudent_UserControl1.Hide();
            inbox_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            studentGrade_UserControl3.Hide();
            deleteStudent_UserControl1.Hide();
            printGrades_UserControl1.Hide();
            export_UserControl1.Hide();
            settings_SecurityAcc_UserControl1.Hide();
            deactivateAccout_UserControl1.Hide();
            
        }

        private void DeleteAcc_btn_Click(object sender, EventArgs e)
        {

            /* SHOW THE  deactivateAccout_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(deactivateAccout_UserControl1);
            deactivateAccout_UserControl1.Refresh();

            dashboard_UserControl1.Hide();
            regStudent_UserControl1.Hide();
            inbox_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            studentGrade_UserControl3.Hide();
            deleteStudent_UserControl1.Hide();
            printGrades_UserControl1.Hide();
            export_UserControl1.Hide();
            teacherClassSchedule_UserControl1.Hide();
            settings_SecurityAcc_UserControl1.Hide();
            
        }
        private void DelStud_Btn_Click(object sender, EventArgs e)
        {
            /* SHOW THE deleteStudent_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(deleteStudent_UserControl1);
            deleteStudent_UserControl1.Refresh();

            dashboard_UserControl1.Hide();
            regStudent_UserControl1.Hide();
            inbox_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            studentGrade_UserControl3.Hide();
            teacherClassSchedule_UserControl1.Hide();
            printGrades_UserControl1.Hide();
            export_UserControl1.Hide();
            settings_SecurityAcc_UserControl1.Hide();
            deactivateAccout_UserControl1.Hide();
        }
    }
}
