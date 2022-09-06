namespace SchoolManagementSystem.Forms
{
    partial class Dashboard_Form
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Form));
            this.Sidebar_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Cursor_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Logout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.SubMenu_Settings_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Settings_Security_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Settings_btn = new Guna.UI2.WinForms.Guna2Button();
            this.SubMenu_Teacher_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Print_btn = new Guna.UI2.WinForms.Guna2Button();
            this.ClassSched_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Teacher_btn = new Guna.UI2.WinForms.Guna2Button();
            this.SubMenu_Student_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Export_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Grades_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Register_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Student_btn = new Guna.UI2.WinForms.Guna2Button();
            this.SubMenu_MainEntry_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Subject_btn = new Guna.UI2.WinForms.Guna2Button();
            this.inbox_btn = new Guna.UI2.WinForms.Guna2Button();
            this.MainEntry_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Dashboard_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Lastname_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logo_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Dashboard_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Left_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Right_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Bottom_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Center_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.studentGrade_UserControl1 = new SchoolManagementSystem.UserControl_Forms.StudentGrade_UserControl();
            this.printGrades_UserControl1 = new SchoolManagementSystem.UserControl_Forms.PrintGrades_UserControl();
            this.addSubject_UserControl1 = new SchoolManagementSystem.UserControl_Forms.AddSubject_UserControl();
            this.settings_SecurityAcc_UserControl1 = new SchoolManagementSystem.UserControl_Forms.Settings_SecurityAcc_UserControl();
            this.SideBar_Transition = new Guna.UI2.WinForms.Guna2Transition();
            this.Top_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.Minimized_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Close_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Sidebar_Panel.SuspendLayout();
            this.SubMenu_Settings_Panel.SuspendLayout();
            this.SubMenu_Teacher_Panel.SuspendLayout();
            this.SubMenu_Student_Panel.SuspendLayout();
            this.SubMenu_MainEntry_Panel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.Logo_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.Center_Panel.SuspendLayout();
            this.Top_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar_Panel
            // 
            this.Sidebar_Panel.AutoScroll = true;
            this.Sidebar_Panel.BackColor = System.Drawing.Color.Navy;
            this.Sidebar_Panel.Controls.Add(this.Cursor_Panel);
            this.Sidebar_Panel.Controls.Add(this.Logout_btn);
            this.Sidebar_Panel.Controls.Add(this.SubMenu_Settings_Panel);
            this.Sidebar_Panel.Controls.Add(this.Settings_btn);
            this.Sidebar_Panel.Controls.Add(this.SubMenu_Teacher_Panel);
            this.Sidebar_Panel.Controls.Add(this.Teacher_btn);
            this.Sidebar_Panel.Controls.Add(this.SubMenu_Student_Panel);
            this.Sidebar_Panel.Controls.Add(this.Student_btn);
            this.Sidebar_Panel.Controls.Add(this.SubMenu_MainEntry_Panel);
            this.Sidebar_Panel.Controls.Add(this.MainEntry_btn);
            this.Sidebar_Panel.Controls.Add(this.Dashboard_BTN);
            this.Sidebar_Panel.Controls.Add(this.guna2Panel1);
            this.Sidebar_Panel.Controls.Add(this.Logo_Panel);
            this.SideBar_Transition.SetDecoration(this.Sidebar_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Sidebar_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar_Panel.Location = new System.Drawing.Point(0, 0);
            this.Sidebar_Panel.Name = "Sidebar_Panel";
            this.Sidebar_Panel.Size = new System.Drawing.Size(201, 749);
            this.Sidebar_Panel.TabIndex = 0;
            // 
            // Cursor_Panel
            // 
            this.Cursor_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SideBar_Transition.SetDecoration(this.Cursor_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Cursor_Panel.Location = new System.Drawing.Point(187, 947);
            this.Cursor_Panel.Name = "Cursor_Panel";
            this.Cursor_Panel.Size = new System.Drawing.Size(10, 45);
            this.Cursor_Panel.TabIndex = 1;
            // 
            // Logout_btn
            // 
            this.SideBar_Transition.SetDecoration(this.Logout_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Logout_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Logout_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Logout_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Logout_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Logout_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logout_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Logout_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout_btn.ForeColor = System.Drawing.Color.White;
            this.Logout_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Logout_btn.Location = new System.Drawing.Point(0, 785);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(197, 45);
            this.Logout_btn.TabIndex = 11;
            this.Logout_btn.Text = "Logout";
            this.Logout_btn.Click += new System.EventHandler(this.Logout_btn_Click);
            // 
            // SubMenu_Settings_Panel
            // 
            this.SubMenu_Settings_Panel.Controls.Add(this.Settings_Security_Btn);
            this.SideBar_Transition.SetDecoration(this.SubMenu_Settings_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SubMenu_Settings_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenu_Settings_Panel.Location = new System.Drawing.Point(0, 746);
            this.SubMenu_Settings_Panel.Name = "SubMenu_Settings_Panel";
            this.SubMenu_Settings_Panel.Size = new System.Drawing.Size(197, 39);
            this.SubMenu_Settings_Panel.TabIndex = 10;
            // 
            // Settings_Security_Btn
            // 
            this.SideBar_Transition.SetDecoration(this.Settings_Security_Btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Settings_Security_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Settings_Security_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Settings_Security_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Settings_Security_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Settings_Security_Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings_Security_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Settings_Security_Btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_Security_Btn.ForeColor = System.Drawing.Color.White;
            this.Settings_Security_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Settings_Security_Btn.Image")));
            this.Settings_Security_Btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Settings_Security_Btn.Location = new System.Drawing.Point(0, 0);
            this.Settings_Security_Btn.Name = "Settings_Security_Btn";
            this.Settings_Security_Btn.Size = new System.Drawing.Size(197, 41);
            this.Settings_Security_Btn.TabIndex = 5;
            this.Settings_Security_Btn.Text = "Security Account";
            this.Settings_Security_Btn.Click += new System.EventHandler(this.Settings_Security_Btn_Click);
            // 
            // Settings_btn
            // 
            this.SideBar_Transition.SetDecoration(this.Settings_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Settings_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Settings_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Settings_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Settings_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Settings_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Settings_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_btn.ForeColor = System.Drawing.Color.White;
            this.Settings_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings_btn.Location = new System.Drawing.Point(0, 701);
            this.Settings_btn.Name = "Settings_btn";
            this.Settings_btn.Size = new System.Drawing.Size(197, 45);
            this.Settings_btn.TabIndex = 9;
            this.Settings_btn.Text = "Settings";
            this.Settings_btn.Click += new System.EventHandler(this.Settings_btn_Click);
            // 
            // SubMenu_Teacher_Panel
            // 
            this.SubMenu_Teacher_Panel.Controls.Add(this.Print_btn);
            this.SubMenu_Teacher_Panel.Controls.Add(this.ClassSched_btn);
            this.SideBar_Transition.SetDecoration(this.SubMenu_Teacher_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SubMenu_Teacher_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenu_Teacher_Panel.Location = new System.Drawing.Point(0, 622);
            this.SubMenu_Teacher_Panel.Name = "SubMenu_Teacher_Panel";
            this.SubMenu_Teacher_Panel.Size = new System.Drawing.Size(197, 79);
            this.SubMenu_Teacher_Panel.TabIndex = 8;
            // 
            // Print_btn
            // 
            this.SideBar_Transition.SetDecoration(this.Print_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Print_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Print_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Print_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Print_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Print_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Print_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Print_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_btn.ForeColor = System.Drawing.Color.White;
            this.Print_btn.Image = ((System.Drawing.Image)(resources.GetObject("Print_btn.Image")));
            this.Print_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Print_btn.Location = new System.Drawing.Point(0, 41);
            this.Print_btn.Name = "Print_btn";
            this.Print_btn.Size = new System.Drawing.Size(197, 41);
            this.Print_btn.TabIndex = 5;
            this.Print_btn.Text = "Print";
            this.Print_btn.Click += new System.EventHandler(this.Print_btn_Click);
            // 
            // ClassSched_btn
            // 
            this.SideBar_Transition.SetDecoration(this.ClassSched_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ClassSched_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClassSched_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClassSched_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClassSched_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClassSched_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClassSched_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClassSched_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassSched_btn.ForeColor = System.Drawing.Color.White;
            this.ClassSched_btn.Image = ((System.Drawing.Image)(resources.GetObject("ClassSched_btn.Image")));
            this.ClassSched_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ClassSched_btn.Location = new System.Drawing.Point(0, 0);
            this.ClassSched_btn.Name = "ClassSched_btn";
            this.ClassSched_btn.Size = new System.Drawing.Size(197, 41);
            this.ClassSched_btn.TabIndex = 4;
            this.ClassSched_btn.Text = "Class Schedule";
            // 
            // Teacher_btn
            // 
            this.SideBar_Transition.SetDecoration(this.Teacher_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Teacher_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Teacher_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Teacher_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Teacher_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Teacher_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Teacher_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Teacher_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_btn.ForeColor = System.Drawing.Color.White;
            this.Teacher_btn.Image = ((System.Drawing.Image)(resources.GetObject("Teacher_btn.Image")));
            this.Teacher_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Teacher_btn.Location = new System.Drawing.Point(0, 577);
            this.Teacher_btn.Name = "Teacher_btn";
            this.Teacher_btn.Size = new System.Drawing.Size(197, 45);
            this.Teacher_btn.TabIndex = 7;
            this.Teacher_btn.Text = "Teacher";
            this.Teacher_btn.Click += new System.EventHandler(this.Teacher_btn_Click);
            // 
            // SubMenu_Student_Panel
            // 
            this.SubMenu_Student_Panel.Controls.Add(this.Export_btn);
            this.SubMenu_Student_Panel.Controls.Add(this.Grades_btn);
            this.SubMenu_Student_Panel.Controls.Add(this.Register_btn);
            this.SideBar_Transition.SetDecoration(this.SubMenu_Student_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SubMenu_Student_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenu_Student_Panel.Location = new System.Drawing.Point(0, 456);
            this.SubMenu_Student_Panel.Name = "SubMenu_Student_Panel";
            this.SubMenu_Student_Panel.Size = new System.Drawing.Size(197, 121);
            this.SubMenu_Student_Panel.TabIndex = 6;
            // 
            // Export_btn
            // 
            this.SideBar_Transition.SetDecoration(this.Export_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Export_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Export_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Export_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Export_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Export_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Export_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Export_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_btn.ForeColor = System.Drawing.Color.White;
            this.Export_btn.Image = ((System.Drawing.Image)(resources.GetObject("Export_btn.Image")));
            this.Export_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Export_btn.Location = new System.Drawing.Point(0, 82);
            this.Export_btn.Name = "Export_btn";
            this.Export_btn.Size = new System.Drawing.Size(197, 41);
            this.Export_btn.TabIndex = 3;
            this.Export_btn.Text = "Export";
            // 
            // Grades_btn
            // 
            this.SideBar_Transition.SetDecoration(this.Grades_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Grades_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Grades_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Grades_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Grades_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Grades_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Grades_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Grades_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grades_btn.ForeColor = System.Drawing.Color.White;
            this.Grades_btn.Image = ((System.Drawing.Image)(resources.GetObject("Grades_btn.Image")));
            this.Grades_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Grades_btn.Location = new System.Drawing.Point(0, 41);
            this.Grades_btn.Name = "Grades_btn";
            this.Grades_btn.Size = new System.Drawing.Size(197, 41);
            this.Grades_btn.TabIndex = 2;
            this.Grades_btn.Text = "Grades";
            this.Grades_btn.Click += new System.EventHandler(this.Grades_btn_Click);
            // 
            // Register_btn
            // 
            this.SideBar_Transition.SetDecoration(this.Register_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Register_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Register_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Register_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Register_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Register_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Register_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Register_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_btn.ForeColor = System.Drawing.Color.White;
            this.Register_btn.Image = ((System.Drawing.Image)(resources.GetObject("Register_btn.Image")));
            this.Register_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Register_btn.Location = new System.Drawing.Point(0, 0);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(197, 41);
            this.Register_btn.TabIndex = 1;
            this.Register_btn.Text = "Register";
            // 
            // Student_btn
            // 
            this.SideBar_Transition.SetDecoration(this.Student_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Student_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Student_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Student_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Student_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Student_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Student_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Student_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_btn.ForeColor = System.Drawing.Color.White;
            this.Student_btn.Image = ((System.Drawing.Image)(resources.GetObject("Student_btn.Image")));
            this.Student_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Student_btn.Location = new System.Drawing.Point(0, 411);
            this.Student_btn.Name = "Student_btn";
            this.Student_btn.Size = new System.Drawing.Size(197, 45);
            this.Student_btn.TabIndex = 5;
            this.Student_btn.Text = "Student";
            this.Student_btn.Click += new System.EventHandler(this.Student_btn_Click);
            // 
            // SubMenu_MainEntry_Panel
            // 
            this.SubMenu_MainEntry_Panel.Controls.Add(this.Subject_btn);
            this.SubMenu_MainEntry_Panel.Controls.Add(this.inbox_btn);
            this.SideBar_Transition.SetDecoration(this.SubMenu_MainEntry_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SubMenu_MainEntry_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubMenu_MainEntry_Panel.Location = new System.Drawing.Point(0, 325);
            this.SubMenu_MainEntry_Panel.Name = "SubMenu_MainEntry_Panel";
            this.SubMenu_MainEntry_Panel.Size = new System.Drawing.Size(197, 86);
            this.SubMenu_MainEntry_Panel.TabIndex = 4;
            // 
            // Subject_btn
            // 
            this.SideBar_Transition.SetDecoration(this.Subject_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Subject_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Subject_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Subject_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Subject_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Subject_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Subject_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Subject_btn.ForeColor = System.Drawing.Color.White;
            this.Subject_btn.Location = new System.Drawing.Point(0, 45);
            this.Subject_btn.Name = "Subject_btn";
            this.Subject_btn.Size = new System.Drawing.Size(197, 45);
            this.Subject_btn.TabIndex = 3;
            this.Subject_btn.Text = "Subject";
            this.Subject_btn.Click += new System.EventHandler(this.Subject_btn_Click_1);
            // 
            // inbox_btn
            // 
            this.SideBar_Transition.SetDecoration(this.inbox_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.inbox_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.inbox_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.inbox_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.inbox_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.inbox_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.inbox_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inbox_btn.ForeColor = System.Drawing.Color.White;
            this.inbox_btn.Location = new System.Drawing.Point(0, 0);
            this.inbox_btn.Name = "inbox_btn";
            this.inbox_btn.Size = new System.Drawing.Size(197, 45);
            this.inbox_btn.TabIndex = 2;
            this.inbox_btn.Text = "Inbox";
            // 
            // MainEntry_btn
            // 
            this.SideBar_Transition.SetDecoration(this.MainEntry_btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.MainEntry_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MainEntry_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MainEntry_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MainEntry_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MainEntry_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainEntry_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.MainEntry_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainEntry_btn.ForeColor = System.Drawing.Color.White;
            this.MainEntry_btn.Image = ((System.Drawing.Image)(resources.GetObject("MainEntry_btn.Image")));
            this.MainEntry_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MainEntry_btn.Location = new System.Drawing.Point(0, 280);
            this.MainEntry_btn.Name = "MainEntry_btn";
            this.MainEntry_btn.Size = new System.Drawing.Size(197, 45);
            this.MainEntry_btn.TabIndex = 3;
            this.MainEntry_btn.Text = "Main Entry";
            this.MainEntry_btn.Click += new System.EventHandler(this.MainEntry_btn_Click);
            // 
            // Dashboard_BTN
            // 
            this.SideBar_Transition.SetDecoration(this.Dashboard_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Dashboard_BTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Dashboard_BTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Dashboard_BTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Dashboard_BTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Dashboard_BTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dashboard_BTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Dashboard_BTN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Dashboard_BTN.ForeColor = System.Drawing.Color.White;
            this.Dashboard_BTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Dashboard_BTN.Location = new System.Drawing.Point(0, 235);
            this.Dashboard_BTN.Name = "Dashboard_BTN";
            this.Dashboard_BTN.Size = new System.Drawing.Size(197, 45);
            this.Dashboard_BTN.TabIndex = 2;
            this.Dashboard_BTN.Text = "Dashboard";
            this.Dashboard_BTN.Click += new System.EventHandler(this.Dashboard_BTN_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Maroon;
            this.guna2Panel1.Controls.Add(this.Name_Label);
            this.guna2Panel1.Controls.Add(this.Lastname_Label);
            this.guna2Panel1.Controls.Add(this.label1);
            this.SideBar_Transition.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 177);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(197, 58);
            this.guna2Panel1.TabIndex = 1;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.SideBar_Transition.SetDecoration(this.Name_Label, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.ForeColor = System.Drawing.Color.White;
            this.Name_Label.Location = new System.Drawing.Point(35, 39);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(42, 15);
            this.Name_Label.TabIndex = 2;
            this.Name_Label.Text = "NAME";
            // 
            // Lastname_Label
            // 
            this.Lastname_Label.AutoSize = true;
            this.SideBar_Transition.SetDecoration(this.Lastname_Label, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Lastname_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname_Label.ForeColor = System.Drawing.Color.White;
            this.Lastname_Label.Location = new System.Drawing.Point(35, 22);
            this.Lastname_Label.Name = "Lastname_Label";
            this.Lastname_Label.Size = new System.Drawing.Size(71, 15);
            this.Lastname_Label.TabIndex = 1;
            this.Lastname_Label.Text = "LASTNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.SideBar_Transition.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME,";
            // 
            // Logo_Panel
            // 
            this.Logo_Panel.Controls.Add(this.guna2PictureBox1);
            this.SideBar_Transition.SetDecoration(this.Logo_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Logo_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo_Panel.Location = new System.Drawing.Point(0, 0);
            this.Logo_Panel.Name = "Logo_Panel";
            this.Logo_Panel.Size = new System.Drawing.Size(197, 177);
            this.Logo_Panel.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.SideBar_Transition.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(23, 20);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(152, 145);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.SideBar_Transition.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(0, 391);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(196, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Student";
            // 
            // Dashboard_Elipse
            // 
            this.Dashboard_Elipse.BorderRadius = 10;
            this.Dashboard_Elipse.TargetControl = this;
            // 
            // Left_Panel
            // 
            this.Left_Panel.BackColor = System.Drawing.Color.Green;
            this.SideBar_Transition.SetDecoration(this.Left_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Left_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Panel.Location = new System.Drawing.Point(201, 43);
            this.Left_Panel.Name = "Left_Panel";
            this.Left_Panel.Size = new System.Drawing.Size(40, 706);
            this.Left_Panel.TabIndex = 2;
            // 
            // Right_Panel
            // 
            this.Right_Panel.BackColor = System.Drawing.Color.Green;
            this.SideBar_Transition.SetDecoration(this.Right_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Right_Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right_Panel.Location = new System.Drawing.Point(1326, 43);
            this.Right_Panel.Name = "Right_Panel";
            this.Right_Panel.Size = new System.Drawing.Size(40, 706);
            this.Right_Panel.TabIndex = 3;
            // 
            // Bottom_Panel
            // 
            this.Bottom_Panel.BackColor = System.Drawing.Color.Green;
            this.SideBar_Transition.SetDecoration(this.Bottom_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Bottom_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_Panel.Location = new System.Drawing.Point(241, 706);
            this.Bottom_Panel.Name = "Bottom_Panel";
            this.Bottom_Panel.Size = new System.Drawing.Size(1085, 43);
            this.Bottom_Panel.TabIndex = 4;
            // 
            // Center_Panel
            // 
            this.Center_Panel.AutoScroll = true;
            this.Center_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Center_Panel.Controls.Add(this.studentGrade_UserControl1);
            this.Center_Panel.Controls.Add(this.printGrades_UserControl1);
            this.Center_Panel.Controls.Add(this.addSubject_UserControl1);
            this.Center_Panel.Controls.Add(this.settings_SecurityAcc_UserControl1);
            this.SideBar_Transition.SetDecoration(this.Center_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Center_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Center_Panel.Location = new System.Drawing.Point(241, 43);
            this.Center_Panel.Name = "Center_Panel";
            this.Center_Panel.Size = new System.Drawing.Size(1085, 663);
            this.Center_Panel.TabIndex = 5;
            this.Center_Panel.Visible = false;
            // 
            // studentGrade_UserControl1
            // 
            this.studentGrade_UserControl1.BackColor = System.Drawing.Color.White;
            this.SideBar_Transition.SetDecoration(this.studentGrade_UserControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.studentGrade_UserControl1.Location = new System.Drawing.Point(69, 6);
            this.studentGrade_UserControl1.Name = "studentGrade_UserControl1";
            this.studentGrade_UserControl1.Size = new System.Drawing.Size(949, 673);
            this.studentGrade_UserControl1.TabIndex = 3;
            // 
            // printGrades_UserControl1
            // 
            this.printGrades_UserControl1.BackColor = System.Drawing.Color.White;
            this.SideBar_Transition.SetDecoration(this.printGrades_UserControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.printGrades_UserControl1.Location = new System.Drawing.Point(136, 21);
            this.printGrades_UserControl1.Name = "printGrades_UserControl1";
            this.printGrades_UserControl1.Size = new System.Drawing.Size(828, 614);
            this.printGrades_UserControl1.TabIndex = 2;
            this.printGrades_UserControl1.Visible = false;
            // 
            // addSubject_UserControl1
            // 
            this.addSubject_UserControl1.BackColor = System.Drawing.Color.White;
            this.SideBar_Transition.SetDecoration(this.addSubject_UserControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.addSubject_UserControl1.Location = new System.Drawing.Point(182, 81);
            this.addSubject_UserControl1.Name = "addSubject_UserControl1";
            this.addSubject_UserControl1.Size = new System.Drawing.Size(743, 445);
            this.addSubject_UserControl1.TabIndex = 1;
            this.addSubject_UserControl1.Visible = false;
            // 
            // settings_SecurityAcc_UserControl1
            // 
            this.settings_SecurityAcc_UserControl1.BackColor = System.Drawing.Color.White;
            this.SideBar_Transition.SetDecoration(this.settings_SecurityAcc_UserControl1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.settings_SecurityAcc_UserControl1.Location = new System.Drawing.Point(222, 81);
            this.settings_SecurityAcc_UserControl1.Name = "settings_SecurityAcc_UserControl1";
            this.settings_SecurityAcc_UserControl1.Size = new System.Drawing.Size(672, 460);
            this.settings_SecurityAcc_UserControl1.TabIndex = 0;
            this.settings_SecurityAcc_UserControl1.Visible = false;
            // 
            // SideBar_Transition
            // 
            this.SideBar_Transition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
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
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Top_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Top_Panel.BackgroundImage")));
            this.Top_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Top_Panel.Controls.Add(this.Minimized_Btn);
            this.Top_Panel.Controls.Add(this.Close_Btn);
            this.SideBar_Transition.SetDecoration(this.Top_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(201, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(1165, 43);
            this.Top_Panel.TabIndex = 1;
            // 
            // Minimized_Btn
            // 
            this.SideBar_Transition.SetDecoration(this.Minimized_Btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Minimized_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Minimized_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Minimized_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Minimized_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Minimized_Btn.FillColor = System.Drawing.Color.DarkGreen;
            this.Minimized_Btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimized_Btn.ForeColor = System.Drawing.Color.White;
            this.Minimized_Btn.Location = new System.Drawing.Point(1090, 3);
            this.Minimized_Btn.Name = "Minimized_Btn";
            this.Minimized_Btn.Size = new System.Drawing.Size(40, 34);
            this.Minimized_Btn.TabIndex = 1;
            this.Minimized_Btn.Text = "-";
            this.Minimized_Btn.Click += new System.EventHandler(this.Minimized_Btn_Click);
            // 
            // Close_Btn
            // 
            this.SideBar_Transition.SetDecoration(this.Close_Btn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Close_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Close_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Close_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Close_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Close_Btn.FillColor = System.Drawing.Color.DarkGreen;
            this.Close_Btn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Btn.ForeColor = System.Drawing.Color.White;
            this.Close_Btn.Location = new System.Drawing.Point(1130, 3);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(40, 34);
            this.Close_Btn.TabIndex = 0;
            this.Close_Btn.Text = "X";
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // Dashboard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.Center_Panel);
            this.Controls.Add(this.Bottom_Panel);
            this.Controls.Add(this.Right_Panel);
            this.Controls.Add(this.Left_Panel);
            this.Controls.Add(this.Top_Panel);
            this.Controls.Add(this.Sidebar_Panel);
            this.SideBar_Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard_Form";
            this.Load += new System.EventHandler(this.Dashboard_Form_Load);
            this.Sidebar_Panel.ResumeLayout(false);
            this.SubMenu_Settings_Panel.ResumeLayout(false);
            this.SubMenu_Teacher_Panel.ResumeLayout(false);
            this.SubMenu_Student_Panel.ResumeLayout(false);
            this.SubMenu_MainEntry_Panel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.Logo_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.Center_Panel.ResumeLayout(false);
            this.Top_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Sidebar_Panel;
        private Guna.UI2.WinForms.Guna2Button Dashboard_BTN;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Lastname_Label;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel Logo_Panel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button MainEntry_btn;
        private Guna.UI2.WinForms.Guna2Button Student_btn;
        private Guna.UI2.WinForms.Guna2Panel SubMenu_MainEntry_Panel;
        private Guna.UI2.WinForms.Guna2Panel SubMenu_Student_Panel;
        private Guna.UI2.WinForms.Guna2Button Export_btn;
        private Guna.UI2.WinForms.Guna2Button Grades_btn;
        private Guna.UI2.WinForms.Guna2Button Register_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel Cursor_Panel;
        private Guna.UI2.WinForms.Guna2Button Logout_btn;
        private Guna.UI2.WinForms.Guna2Panel SubMenu_Settings_Panel;
        private Guna.UI2.WinForms.Guna2Button Settings_Security_Btn;
        private Guna.UI2.WinForms.Guna2Button Settings_btn;
        private Guna.UI2.WinForms.Guna2Panel SubMenu_Teacher_Panel;
        private Guna.UI2.WinForms.Guna2Button Print_btn;
        private Guna.UI2.WinForms.Guna2Button ClassSched_btn;
        private Guna.UI2.WinForms.Guna2Button Teacher_btn;
        private Guna.UI2.WinForms.Guna2Elipse Dashboard_Elipse;
        private Guna.UI2.WinForms.Guna2Panel Center_Panel;
        private Guna.UI2.WinForms.Guna2Panel Bottom_Panel;
        private Guna.UI2.WinForms.Guna2Panel Right_Panel;
        private Guna.UI2.WinForms.Guna2Panel Left_Panel;
        private Guna.UI2.WinForms.Guna2Panel Top_Panel;
        private Guna.UI2.WinForms.Guna2Button Minimized_Btn;
        private Guna.UI2.WinForms.Guna2Button Close_Btn;
        private UserControl_Forms.Settings_SecurityAcc_UserControl settings_SecurityAcc_UserControl1;
        private Guna.UI2.WinForms.Guna2Transition SideBar_Transition;
        private UserControl_Forms.AddSubject_UserControl addSubject_UserControl1;
        private UserControl_Forms.PrintGrades_UserControl printGrades_UserControl1;
        private UserControl_Forms.StudentGrade_UserControl studentGrade_UserControl1;
        private Guna.UI2.WinForms.Guna2Button Subject_btn;
        private Guna.UI2.WinForms.Guna2Button inbox_btn;
    }
}