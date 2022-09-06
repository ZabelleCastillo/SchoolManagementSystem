namespace SchoolManagementSystem.Admin_Form
{
    partial class Admin_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.AdminForm_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Sidebar_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Teacher_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DashBoard_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Logout_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.YearSec_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Subject_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Notification_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Log_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Admin_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.TopSidebar_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.DashClose_btn = new Guna.UI2.WinForms.Guna2Button();
            this.DashOpen_btn = new Guna.UI2.WinForms.Guna2Button();
            this.SideBar_Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.yearClass_UserControl1 = new SchoolManagementSystem.Admin_UserControl.YearClass_UserControl();
            this.teacherSched_UserControl1 = new SchoolManagementSystem.Admin_UserControl.TeacherSched_UserControl();
            this.addSubject_UserControl1 = new SchoolManagementSystem.UserControl_Forms.AddSubject_UserControl();
            this.notification_UserControl1 = new SchoolManagementSystem.Admin_UserControl.Notification_UserControl();
            this.logDetails_UserControl1 = new SchoolManagementSystem.Admin_UserControl.LogDetails_UserControl();
            this.Sliding_Timer = new System.Windows.Forms.Timer(this.components);
            this.childformTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.dashboard_UserControl1 = new SchoolManagementSystem.UserControl_Forms.Dashboard_UserControl();
            this.Sidebar_Panel.SuspendLayout();
            this.TopSidebar_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminForm_Elipse
            // 
            this.AdminForm_Elipse.BorderRadius = 10;
            this.AdminForm_Elipse.TargetControl = this;
            // 
            // Sidebar_Panel
            // 
            this.Sidebar_Panel.BackColor = System.Drawing.Color.White;
            this.Sidebar_Panel.Controls.Add(this.Teacher_btn);
            this.Sidebar_Panel.Controls.Add(this.DashBoard_btn);
            this.Sidebar_Panel.Controls.Add(this.Logout_btn);
            this.Sidebar_Panel.Controls.Add(this.YearSec_btn);
            this.Sidebar_Panel.Controls.Add(this.Subject_btn);
            this.Sidebar_Panel.Controls.Add(this.Notification_btn);
            this.Sidebar_Panel.Controls.Add(this.Log_btn);
            this.Sidebar_Panel.Controls.Add(this.Admin_Panel);
            this.Sidebar_Panel.Controls.Add(this.TopSidebar_Panel);
            this.childformTransition.SetDecoration(this.Sidebar_Panel, BunifuAnimatorNS.DecorationType.None);
            this.SideBar_Transition.SetDecoration(this.Sidebar_Panel, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar_Panel.FillColor = System.Drawing.Color.LightSkyBlue;
            this.Sidebar_Panel.Location = new System.Drawing.Point(0, 0);
            this.Sidebar_Panel.Name = "Sidebar_Panel";
            this.Sidebar_Panel.Size = new System.Drawing.Size(188, 627);
            this.Sidebar_Panel.TabIndex = 0;
            // 
            // Teacher_btn
            // 
            this.Teacher_btn.Activecolor = System.Drawing.Color.LightSkyBlue;
            this.Teacher_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Teacher_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Teacher_btn.BorderRadius = 0;
            this.Teacher_btn.ButtonText = "Teacher";
            this.Teacher_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childformTransition.SetDecoration(this.Teacher_btn, BunifuAnimatorNS.DecorationType.None);
            this.SideBar_Transition.SetDecoration(this.Teacher_btn, BunifuAnimatorNS.DecorationType.None);
            this.Teacher_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Teacher_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Teacher_btn.ForeColor = System.Drawing.Color.Black;
            this.Teacher_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Teacher_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Teacher_btn.Iconimage")));
            this.Teacher_btn.Iconimage_right = null;
            this.Teacher_btn.Iconimage_right_Selected = null;
            this.Teacher_btn.Iconimage_Selected = null;
            this.Teacher_btn.IconMarginLeft = 0;
            this.Teacher_btn.IconMarginRight = 0;
            this.Teacher_btn.IconRightVisible = true;
            this.Teacher_btn.IconRightZoom = 0D;
            this.Teacher_btn.IconVisible = true;
            this.Teacher_btn.IconZoom = 50D;
            this.Teacher_btn.IsTab = false;
            this.Teacher_btn.Location = new System.Drawing.Point(0, 483);
            this.Teacher_btn.Name = "Teacher_btn";
            this.Teacher_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Teacher_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Teacher_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Teacher_btn.selected = false;
            this.Teacher_btn.Size = new System.Drawing.Size(188, 48);
            this.Teacher_btn.TabIndex = 7;
            this.Teacher_btn.Text = "Teacher";
            this.Teacher_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Teacher_btn.Textcolor = System.Drawing.Color.Black;
            this.Teacher_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_btn.Click += new System.EventHandler(this.Teacher_btn_Click);
            // 
            // DashBoard_btn
            // 
            this.DashBoard_btn.Activecolor = System.Drawing.Color.LightSkyBlue;
            this.DashBoard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.DashBoard_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashBoard_btn.BorderRadius = 0;
            this.DashBoard_btn.ButtonText = "Dashboard";
            this.DashBoard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childformTransition.SetDecoration(this.DashBoard_btn, BunifuAnimatorNS.DecorationType.None);
            this.SideBar_Transition.SetDecoration(this.DashBoard_btn, BunifuAnimatorNS.DecorationType.None);
            this.DashBoard_btn.DisabledColor = System.Drawing.Color.Gray;
            this.DashBoard_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DashBoard_btn.ForeColor = System.Drawing.Color.Black;
            this.DashBoard_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.DashBoard_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("DashBoard_btn.Iconimage")));
            this.DashBoard_btn.Iconimage_right = null;
            this.DashBoard_btn.Iconimage_right_Selected = null;
            this.DashBoard_btn.Iconimage_Selected = null;
            this.DashBoard_btn.IconMarginLeft = 0;
            this.DashBoard_btn.IconMarginRight = 0;
            this.DashBoard_btn.IconRightVisible = true;
            this.DashBoard_btn.IconRightZoom = 0D;
            this.DashBoard_btn.IconVisible = true;
            this.DashBoard_btn.IconZoom = 50D;
            this.DashBoard_btn.IsTab = false;
            this.DashBoard_btn.Location = new System.Drawing.Point(0, 531);
            this.DashBoard_btn.Name = "DashBoard_btn";
            this.DashBoard_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.DashBoard_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.DashBoard_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.DashBoard_btn.selected = false;
            this.DashBoard_btn.Size = new System.Drawing.Size(188, 48);
            this.DashBoard_btn.TabIndex = 6;
            this.DashBoard_btn.Text = "Dashboard";
            this.DashBoard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DashBoard_btn.Textcolor = System.Drawing.Color.Black;
            this.DashBoard_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashBoard_btn.Click += new System.EventHandler(this.DashBoard_btn_Click);
            // 
            // Logout_btn
            // 
            this.Logout_btn.Activecolor = System.Drawing.Color.Transparent;
            this.Logout_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logout_btn.BorderRadius = 0;
            this.Logout_btn.ButtonText = "Logout";
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childformTransition.SetDecoration(this.Logout_btn, BunifuAnimatorNS.DecorationType.None);
            this.SideBar_Transition.SetDecoration(this.Logout_btn, BunifuAnimatorNS.DecorationType.None);
            this.Logout_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Logout_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Logout_btn.ForeColor = System.Drawing.Color.Transparent;
            this.Logout_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Logout_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Logout_btn.Iconimage")));
            this.Logout_btn.Iconimage_right = null;
            this.Logout_btn.Iconimage_right_Selected = null;
            this.Logout_btn.Iconimage_Selected = null;
            this.Logout_btn.IconMarginLeft = 0;
            this.Logout_btn.IconMarginRight = 0;
            this.Logout_btn.IconRightVisible = true;
            this.Logout_btn.IconRightZoom = 0D;
            this.Logout_btn.IconVisible = true;
            this.Logout_btn.IconZoom = 50D;
            this.Logout_btn.IsTab = false;
            this.Logout_btn.Location = new System.Drawing.Point(0, 579);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Logout_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Logout_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Logout_btn.selected = false;
            this.Logout_btn.Size = new System.Drawing.Size(188, 48);
            this.Logout_btn.TabIndex = 5;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Logout_btn.Textcolor = System.Drawing.Color.Black;
            this.Logout_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // YearSec_btn
            // 
            this.YearSec_btn.Activecolor = System.Drawing.Color.LightSkyBlue;
            this.YearSec_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.YearSec_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YearSec_btn.BorderRadius = 0;
            this.YearSec_btn.ButtonText = "Year Level";
            this.YearSec_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childformTransition.SetDecoration(this.YearSec_btn, BunifuAnimatorNS.DecorationType.None);
            this.SideBar_Transition.SetDecoration(this.YearSec_btn, BunifuAnimatorNS.DecorationType.None);
            this.YearSec_btn.DisabledColor = System.Drawing.Color.Gray;
            this.YearSec_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.YearSec_btn.ForeColor = System.Drawing.Color.Black;
            this.YearSec_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.YearSec_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("YearSec_btn.Iconimage")));
            this.YearSec_btn.Iconimage_right = null;
            this.YearSec_btn.Iconimage_right_Selected = null;
            this.YearSec_btn.Iconimage_Selected = null;
            this.YearSec_btn.IconMarginLeft = 0;
            this.YearSec_btn.IconMarginRight = 0;
            this.YearSec_btn.IconRightVisible = true;
            this.YearSec_btn.IconRightZoom = 0D;
            this.YearSec_btn.IconVisible = true;
            this.YearSec_btn.IconZoom = 50D;
            this.YearSec_btn.IsTab = false;
            this.YearSec_btn.Location = new System.Drawing.Point(0, 337);
            this.YearSec_btn.Name = "YearSec_btn";
            this.YearSec_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.YearSec_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.YearSec_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.YearSec_btn.selected = false;
            this.YearSec_btn.Size = new System.Drawing.Size(188, 48);
            this.YearSec_btn.TabIndex = 4;
            this.YearSec_btn.Text = "Year Level";
            this.YearSec_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YearSec_btn.Textcolor = System.Drawing.Color.Black;
            this.YearSec_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearSec_btn.Click += new System.EventHandler(this.YearSec_btn_Click);
            // 
            // Subject_btn
            // 
            this.Subject_btn.Activecolor = System.Drawing.Color.LightSkyBlue;
            this.Subject_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Subject_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Subject_btn.BorderRadius = 0;
            this.Subject_btn.ButtonText = "Subject";
            this.Subject_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childformTransition.SetDecoration(this.Subject_btn, BunifuAnimatorNS.DecorationType.None);
            this.SideBar_Transition.SetDecoration(this.Subject_btn, BunifuAnimatorNS.DecorationType.None);
            this.Subject_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Subject_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Subject_btn.ForeColor = System.Drawing.Color.Black;
            this.Subject_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Subject_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Subject_btn.Iconimage")));
            this.Subject_btn.Iconimage_right = null;
            this.Subject_btn.Iconimage_right_Selected = null;
            this.Subject_btn.Iconimage_Selected = null;
            this.Subject_btn.IconMarginLeft = 0;
            this.Subject_btn.IconMarginRight = 0;
            this.Subject_btn.IconRightVisible = true;
            this.Subject_btn.IconRightZoom = 0D;
            this.Subject_btn.IconVisible = true;
            this.Subject_btn.IconZoom = 50D;
            this.Subject_btn.IsTab = false;
            this.Subject_btn.Location = new System.Drawing.Point(0, 289);
            this.Subject_btn.Name = "Subject_btn";
            this.Subject_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Subject_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Subject_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Subject_btn.selected = false;
            this.Subject_btn.Size = new System.Drawing.Size(188, 48);
            this.Subject_btn.TabIndex = 3;
            this.Subject_btn.Text = "Subject";
            this.Subject_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Subject_btn.Textcolor = System.Drawing.Color.Black;
            this.Subject_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_btn.Click += new System.EventHandler(this.Subject_btn_Click);
            // 
            // Notification_btn
            // 
            this.Notification_btn.Activecolor = System.Drawing.Color.LightSkyBlue;
            this.Notification_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Notification_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Notification_btn.BorderRadius = 0;
            this.Notification_btn.ButtonText = "Notification";
            this.Notification_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childformTransition.SetDecoration(this.Notification_btn, BunifuAnimatorNS.DecorationType.None);
            this.SideBar_Transition.SetDecoration(this.Notification_btn, BunifuAnimatorNS.DecorationType.None);
            this.Notification_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Notification_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Notification_btn.ForeColor = System.Drawing.Color.Black;
            this.Notification_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Notification_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Notification_btn.Iconimage")));
            this.Notification_btn.Iconimage_right = null;
            this.Notification_btn.Iconimage_right_Selected = null;
            this.Notification_btn.Iconimage_Selected = null;
            this.Notification_btn.IconMarginLeft = 0;
            this.Notification_btn.IconMarginRight = 0;
            this.Notification_btn.IconRightVisible = true;
            this.Notification_btn.IconRightZoom = 0D;
            this.Notification_btn.IconVisible = true;
            this.Notification_btn.IconZoom = 50D;
            this.Notification_btn.IsTab = false;
            this.Notification_btn.Location = new System.Drawing.Point(0, 241);
            this.Notification_btn.Name = "Notification_btn";
            this.Notification_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Notification_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Notification_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Notification_btn.selected = false;
            this.Notification_btn.Size = new System.Drawing.Size(188, 48);
            this.Notification_btn.TabIndex = 2;
            this.Notification_btn.Text = "Notification";
            this.Notification_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Notification_btn.Textcolor = System.Drawing.Color.Black;
            this.Notification_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification_btn.Click += new System.EventHandler(this.Notification_btn_Click);
            // 
            // Log_btn
            // 
            this.Log_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Log_btn.BorderRadius = 0;
            this.Log_btn.ButtonText = "Log details";
            this.Log_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childformTransition.SetDecoration(this.Log_btn, BunifuAnimatorNS.DecorationType.None);
            this.SideBar_Transition.SetDecoration(this.Log_btn, BunifuAnimatorNS.DecorationType.None);
            this.Log_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Log_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Log_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Log_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Log_btn.Iconimage")));
            this.Log_btn.Iconimage_right = null;
            this.Log_btn.Iconimage_right_Selected = null;
            this.Log_btn.Iconimage_Selected = null;
            this.Log_btn.IconMarginLeft = 0;
            this.Log_btn.IconMarginRight = 0;
            this.Log_btn.IconRightVisible = true;
            this.Log_btn.IconRightZoom = 0D;
            this.Log_btn.IconVisible = true;
            this.Log_btn.IconZoom = 50D;
            this.Log_btn.IsTab = false;
            this.Log_btn.Location = new System.Drawing.Point(0, 193);
            this.Log_btn.Name = "Log_btn";
            this.Log_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Log_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Log_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Log_btn.selected = false;
            this.Log_btn.Size = new System.Drawing.Size(188, 48);
            this.Log_btn.TabIndex = 0;
            this.Log_btn.Text = "Log details";
            this.Log_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Log_btn.Textcolor = System.Drawing.Color.Black;
            this.Log_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log_btn.Click += new System.EventHandler(this.Log_btn_Click);
            // 
            // Admin_Panel
            // 
            this.Admin_Panel.BackColor = System.Drawing.Color.Navy;
            this.childformTransition.SetDecoration(this.Admin_Panel, BunifuAnimatorNS.DecorationType.None);
            this.SideBar_Transition.SetDecoration(this.Admin_Panel, BunifuAnimatorNS.DecorationType.None);
            this.Admin_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Admin_Panel.Location = new System.Drawing.Point(0, 126);
            this.Admin_Panel.Name = "Admin_Panel";
            this.Admin_Panel.Size = new System.Drawing.Size(188, 67);
            this.Admin_Panel.TabIndex = 1;
            // 
            // TopSidebar_Panel
            // 
            this.TopSidebar_Panel.BackColor = System.Drawing.Color.White;
            this.TopSidebar_Panel.Controls.Add(this.DashClose_btn);
            this.TopSidebar_Panel.Controls.Add(this.DashOpen_btn);
            this.childformTransition.SetDecoration(this.TopSidebar_Panel, BunifuAnimatorNS.DecorationType.None);
            this.SideBar_Transition.SetDecoration(this.TopSidebar_Panel, BunifuAnimatorNS.DecorationType.None);
            this.TopSidebar_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopSidebar_Panel.FillColor = System.Drawing.Color.LightSkyBlue;
            this.TopSidebar_Panel.Location = new System.Drawing.Point(0, 0);
            this.TopSidebar_Panel.Name = "TopSidebar_Panel";
            this.TopSidebar_Panel.Size = new System.Drawing.Size(188, 126);
            this.TopSidebar_Panel.TabIndex = 0;
            // 
            // DashClose_btn
            // 
            this.childformTransition.SetDecoration(this.DashClose_btn, BunifuAnimatorNS.DecorationType.None);
            this.SideBar_Transition.SetDecoration(this.DashClose_btn, BunifuAnimatorNS.DecorationType.None);
            this.DashClose_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashClose_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashClose_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashClose_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashClose_btn.FillColor = System.Drawing.Color.LightSkyBlue;
            this.DashClose_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashClose_btn.ForeColor = System.Drawing.Color.White;
            this.DashClose_btn.Image = ((System.Drawing.Image)(resources.GetObject("DashClose_btn.Image")));
            this.DashClose_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashClose_btn.Location = new System.Drawing.Point(149, 0);
            this.DashClose_btn.Name = "DashClose_btn";
            this.DashClose_btn.Size = new System.Drawing.Size(39, 45);
            this.DashClose_btn.TabIndex = 4;
            this.DashClose_btn.Click += new System.EventHandler(this.DashClose_btn_Click);
            // 
            // DashOpen_btn
            // 
            this.childformTransition.SetDecoration(this.DashOpen_btn, BunifuAnimatorNS.DecorationType.None);
            this.SideBar_Transition.SetDecoration(this.DashOpen_btn, BunifuAnimatorNS.DecorationType.None);
            this.DashOpen_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DashOpen_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DashOpen_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DashOpen_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DashOpen_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DashOpen_btn.FillColor = System.Drawing.Color.LightSkyBlue;
            this.DashOpen_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DashOpen_btn.ForeColor = System.Drawing.Color.White;
            this.DashOpen_btn.Image = ((System.Drawing.Image)(resources.GetObject("DashOpen_btn.Image")));
            this.DashOpen_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DashOpen_btn.Location = new System.Drawing.Point(0, 0);
            this.DashOpen_btn.Name = "DashOpen_btn";
            this.DashOpen_btn.Size = new System.Drawing.Size(188, 45);
            this.DashOpen_btn.TabIndex = 3;
            this.DashOpen_btn.Click += new System.EventHandler(this.DashOpen_btn_Click);
            // 
            // SideBar_Transition
            // 
            this.SideBar_Transition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.SideBar_Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.SideBar_Transition.DefaultAnimation = animation1;
            // 
            // yearClass_UserControl1
            // 
            this.yearClass_UserControl1.BackColor = System.Drawing.Color.White;
            this.SideBar_Transition.SetDecoration(this.yearClass_UserControl1, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this.yearClass_UserControl1, BunifuAnimatorNS.DecorationType.None);
            this.yearClass_UserControl1.Location = new System.Drawing.Point(197, 11);
            this.yearClass_UserControl1.Name = "yearClass_UserControl1";
            this.yearClass_UserControl1.Size = new System.Drawing.Size(981, 604);
            this.yearClass_UserControl1.TabIndex = 4;
            this.yearClass_UserControl1.Visible = false;
            // 
            // teacherSched_UserControl1
            // 
            this.teacherSched_UserControl1.BackColor = System.Drawing.Color.White;
            this.SideBar_Transition.SetDecoration(this.teacherSched_UserControl1, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this.teacherSched_UserControl1, BunifuAnimatorNS.DecorationType.None);
            this.teacherSched_UserControl1.Location = new System.Drawing.Point(240, 47);
            this.teacherSched_UserControl1.Name = "teacherSched_UserControl1";
            this.teacherSched_UserControl1.Size = new System.Drawing.Size(892, 532);
            this.teacherSched_UserControl1.TabIndex = 5;
            this.teacherSched_UserControl1.Visible = false;
            // 
            // addSubject_UserControl1
            // 
            this.addSubject_UserControl1.BackColor = System.Drawing.Color.White;
            this.SideBar_Transition.SetDecoration(this.addSubject_UserControl1, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this.addSubject_UserControl1, BunifuAnimatorNS.DecorationType.None);
            this.addSubject_UserControl1.Location = new System.Drawing.Point(309, 83);
            this.addSubject_UserControl1.Name = "addSubject_UserControl1";
            this.addSubject_UserControl1.Size = new System.Drawing.Size(743, 496);
            this.addSubject_UserControl1.TabIndex = 3;
            this.addSubject_UserControl1.Visible = false;
            // 
            // notification_UserControl1
            // 
            this.SideBar_Transition.SetDecoration(this.notification_UserControl1, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this.notification_UserControl1, BunifuAnimatorNS.DecorationType.None);
            this.notification_UserControl1.Location = new System.Drawing.Point(210, 92);
            this.notification_UserControl1.Name = "notification_UserControl1";
            this.notification_UserControl1.Size = new System.Drawing.Size(951, 487);
            this.notification_UserControl1.TabIndex = 2;
            this.notification_UserControl1.Visible = false;
            // 
            // logDetails_UserControl1
            // 
            this.logDetails_UserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SideBar_Transition.SetDecoration(this.logDetails_UserControl1, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this.logDetails_UserControl1, BunifuAnimatorNS.DecorationType.None);
            this.logDetails_UserControl1.Location = new System.Drawing.Point(205, 83);
            this.logDetails_UserControl1.Name = "logDetails_UserControl1";
            this.logDetails_UserControl1.Size = new System.Drawing.Size(956, 479);
            this.logDetails_UserControl1.TabIndex = 1;
            this.logDetails_UserControl1.Visible = false;
            // 
            // Sliding_Timer
            // 
            this.Sliding_Timer.Enabled = true;
            this.Sliding_Timer.Interval = 40;
            // 
            // childformTransition
            // 
            this.childformTransition.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.childformTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.childformTransition.DefaultAnimation = animation2;
            // 
            // dashboard_UserControl1
            // 
            this.dashboard_UserControl1.BackColor = System.Drawing.Color.Transparent;
            this.SideBar_Transition.SetDecoration(this.dashboard_UserControl1, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this.dashboard_UserControl1, BunifuAnimatorNS.DecorationType.None);
            this.dashboard_UserControl1.Location = new System.Drawing.Point(356, 25);
            this.dashboard_UserControl1.Name = "dashboard_UserControl1";
            this.dashboard_UserControl1.Size = new System.Drawing.Size(668, 554);
            this.dashboard_UserControl1.TabIndex = 6;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 627);
            this.Controls.Add(this.dashboard_UserControl1);
            this.Controls.Add(this.yearClass_UserControl1);
            this.Controls.Add(this.teacherSched_UserControl1);
            this.Controls.Add(this.addSubject_UserControl1);
            this.Controls.Add(this.logDetails_UserControl1);
            this.Controls.Add(this.Sidebar_Panel);
            this.Controls.Add(this.notification_UserControl1);
            this.SideBar_Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Form";
            this.Sidebar_Panel.ResumeLayout(false);
            this.TopSidebar_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse AdminForm_Elipse;
        private Guna.UI2.WinForms.Guna2Panel Sidebar_Panel;
        private Guna.UI2.WinForms.Guna2Panel Admin_Panel;
        private Guna.UI2.WinForms.Guna2Panel TopSidebar_Panel;
        private Guna.UI2.WinForms.Guna2Button DashOpen_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Logout_btn;
        private Bunifu.Framework.UI.BunifuFlatButton YearSec_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Subject_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Notification_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Log_btn;
        private Guna.UI2.WinForms.Guna2Button DashClose_btn;
        private BunifuAnimatorNS.BunifuTransition SideBar_Transition;
        private System.Windows.Forms.Timer Sliding_Timer;
        private Bunifu.Framework.UI.BunifuFlatButton DashBoard_btn;
        private Admin_UserControl.LogDetails_UserControl logDetails_UserControl1;
        private BunifuAnimatorNS.BunifuTransition childformTransition;
        private Admin_UserControl.Notification_UserControl notification_UserControl1;
        private UserControl_Forms.AddSubject_UserControl addSubject_UserControl1;
        private Admin_UserControl.YearClass_UserControl yearClass_UserControl1;
        private Bunifu.Framework.UI.BunifuFlatButton Teacher_btn;
        private Admin_UserControl.TeacherSched_UserControl teacherSched_UserControl1;
        private UserControl_Forms.Dashboard_UserControl dashboard_UserControl1;
    }
}