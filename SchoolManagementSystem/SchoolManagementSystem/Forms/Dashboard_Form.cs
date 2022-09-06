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
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
            customizeDesign();

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
        private void Minimized_Btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dashboard_BTN_Click(object sender, EventArgs e)
        {
            Cursor_Panel.Height = Dashboard_BTN.Height;
            Cursor_Panel.Top = Dashboard_BTN.Top;
            Hide_SubMenu();
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

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            /* ONCE THE USER LOGIN TO HIS ACCOUNT IN SECURITY LOGIN FORM, 
            HIS CREDENTIAL INFO WILL DISPLAY */
            Lastname_Label.Text = SecurityLogin_Form.lastname;
            Name_Label.Text = SecurityLogin_Form.name;

            /* UPON CLICKING THE addSubject_UserControl1, THE addSubject_UserControl1FORM WILL APPEAR WITH TRANSITION EFFECT */
            addSubject_UserControl1.Location = new Point(182, 81);
            addSubject_UserControl1.Size = new Size(743, 445);


            /* UPON CLICKING THE studentGrade_UserControl1, THE studentGrade_UserControl1 FORM WILL APPEAR WITH TRANSITION EFFECT */
            studentGrade_UserControl1.Location = new Point(69, 6);
            studentGrade_UserControl1.Size = new Size(949, 673);

            /* UPON CLICKING THE printGrades_UserControl1, THE printGrades_UserControl1 FORM WILL APPEAR WITH TRANSITION EFFECT */
            printGrades_UserControl1.Location = new Point(136, 21);
            printGrades_UserControl1.Size = new Size(828, 614);

            /* UPON CLICKING THE settings_SecurityAcc_UserControl1, THE settings_SecurityAcc_UserControl1 FORM WILL APPEAR WITH TRANSITION EFFECT */
            settings_SecurityAcc_UserControl1.Location = new Point(222, 81);
            settings_SecurityAcc_UserControl1.Size = new Size(672, 460);
        }
        private void Print_btn_Click(object sender, EventArgs e)
        {

            /* SHOW THE printGrades_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(printGrades_UserControl1);
            printGrades_UserControl1.Refresh();

            //regStudent_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            studentGrade_UserControl1.Hide();
            settings_SecurityAcc_UserControl1.Hide();
        }
        private void Settings_Security_Btn_Click(object sender, EventArgs e)
        {
            /* SHOW THE settings_SecurityAcc_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(settings_SecurityAcc_UserControl1);
            settings_SecurityAcc_UserControl1.Refresh();

            addSubject_UserControl1.Hide();
            // regStudent_UserControl1.Hide();
            // studentGrade_UserControl1.Hide();
            printGrades_UserControl1.Hide();
        }

        private void Grades_btn_Click(object sender, EventArgs e)
        {
            /* SHOW THE studentGrade_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(studentGrade_UserControl1);
            studentGrade_UserControl1.Refresh();

            //regStudent_UserControl1.Hide();
            addSubject_UserControl1.Hide();
            printGrades_UserControl1.Hide();
            settings_SecurityAcc_UserControl1.Hide();
        }

        private void Subject_btn_Click_1(object sender, EventArgs e)
        {
            /* SHOW THE addSubject_UserControl1 FORM WITH TRANSITION EFFECT */
            SideBar_Transition.Show(addSubject_UserControl1);
            addSubject_UserControl1.Refresh();

            //regStudent_UserControl1.Hide();
            studentGrade_UserControl1.Hide();
            printGrades_UserControl1.Hide();
            settings_SecurityAcc_UserControl1.Hide();
        }
    }
}
