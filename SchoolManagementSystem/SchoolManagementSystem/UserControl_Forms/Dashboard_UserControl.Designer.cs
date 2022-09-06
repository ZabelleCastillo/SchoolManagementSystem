namespace SchoolManagementSystem.UserControl_Forms
{
    partial class Dashboard_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_UserControl));
            this.DashUser_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.class_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.Class_Label = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ClassCount_Label = new System.Windows.Forms.Label();
            this.Subject_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.SUBJECT_LABEL = new System.Windows.Forms.Label();
            this.SubjectCount_label = new System.Windows.Forms.Label();
            this.Teacher_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TeacherCount_label = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Teacher_label = new System.Windows.Forms.Label();
            this.Student_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.StudentCount_label = new System.Windows.Forms.Label();
            this.Student_Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.student_label = new System.Windows.Forms.Label();
            this.Student_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Teacher_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Subject_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Class_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Student_Timer = new System.Windows.Forms.Timer(this.components);
            this.Subject_Timer = new System.Windows.Forms.Timer(this.components);
            this.Class_Timer = new System.Windows.Forms.Timer(this.components);
            this.Teacher_Timer = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.class_panel.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.Subject_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.guna2Panel5.SuspendLayout();
            this.Teacher_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.Student_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.Student_Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashUser_Elipse
            // 
            this.DashUser_Elipse.BorderRadius = 10;
            this.DashUser_Elipse.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.class_panel);
            this.guna2Panel1.Controls.Add(this.Subject_Panel);
            this.guna2Panel1.Controls.Add(this.Teacher_Panel);
            this.guna2Panel1.Controls.Add(this.Student_Panel);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(670, 600);
            this.guna2Panel1.TabIndex = 0;
            // 
            // class_panel
            // 
            this.class_panel.Controls.Add(this.guna2Panel3);
            this.class_panel.Controls.Add(this.guna2PictureBox3);
            this.class_panel.Controls.Add(this.ClassCount_Label);
            this.class_panel.FillColor = System.Drawing.Color.Green;
            this.class_panel.Location = new System.Drawing.Point(363, 314);
            this.class_panel.Name = "class_panel";
            this.class_panel.Size = new System.Drawing.Size(245, 209);
            this.class_panel.TabIndex = 6;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.Class_Label);
            this.guna2Panel3.FillColor = System.Drawing.Color.Black;
            this.guna2Panel3.Location = new System.Drawing.Point(-1, 149);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(245, 60);
            this.guna2Panel3.TabIndex = 5;
            // 
            // Class_Label
            // 
            this.Class_Label.AutoSize = true;
            this.Class_Label.BackColor = System.Drawing.Color.Transparent;
            this.Class_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_Label.ForeColor = System.Drawing.Color.White;
            this.Class_Label.Location = new System.Drawing.Point(76, 19);
            this.Class_Label.Name = "Class_Label";
            this.Class_Label.Size = new System.Drawing.Size(75, 24);
            this.Class_Label.TabIndex = 0;
            this.Class_Label.Text = "CLASS";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.BackgroundImage")));
            this.guna2PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(34, 38);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(91, 72);
            this.guna2PictureBox3.TabIndex = 1;
            this.guna2PictureBox3.TabStop = false;
            // 
            // ClassCount_Label
            // 
            this.ClassCount_Label.AutoSize = true;
            this.ClassCount_Label.BackColor = System.Drawing.Color.Transparent;
            this.ClassCount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassCount_Label.ForeColor = System.Drawing.Color.White;
            this.ClassCount_Label.Location = new System.Drawing.Point(185, 65);
            this.ClassCount_Label.Name = "ClassCount_Label";
            this.ClassCount_Label.Size = new System.Drawing.Size(29, 31);
            this.ClassCount_Label.TabIndex = 0;
            this.ClassCount_Label.Text = "0";
            // 
            // Subject_Panel
            // 
            this.Subject_Panel.Controls.Add(this.guna2PictureBox4);
            this.Subject_Panel.Controls.Add(this.guna2Panel5);
            this.Subject_Panel.Controls.Add(this.SubjectCount_label);
            this.Subject_Panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Subject_Panel.Location = new System.Drawing.Point(54, 314);
            this.Subject_Panel.Name = "Subject_Panel";
            this.Subject_Panel.Size = new System.Drawing.Size(245, 209);
            this.Subject_Panel.TabIndex = 4;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.BackgroundImage")));
            this.guna2PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox4.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(34, 38);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(91, 72);
            this.guna2PictureBox4.TabIndex = 1;
            this.guna2PictureBox4.TabStop = false;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Panel5.Controls.Add(this.SUBJECT_LABEL);
            this.guna2Panel5.Location = new System.Drawing.Point(0, 149);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(245, 60);
            this.guna2Panel5.TabIndex = 3;
            // 
            // SUBJECT_LABEL
            // 
            this.SUBJECT_LABEL.AutoSize = true;
            this.SUBJECT_LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBJECT_LABEL.ForeColor = System.Drawing.Color.White;
            this.SUBJECT_LABEL.Location = new System.Drawing.Point(71, 19);
            this.SUBJECT_LABEL.Name = "SUBJECT_LABEL";
            this.SUBJECT_LABEL.Size = new System.Drawing.Size(101, 24);
            this.SUBJECT_LABEL.TabIndex = 0;
            this.SUBJECT_LABEL.Text = "SUBJECT";
            // 
            // SubjectCount_label
            // 
            this.SubjectCount_label.AutoSize = true;
            this.SubjectCount_label.BackColor = System.Drawing.Color.Transparent;
            this.SubjectCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectCount_label.Location = new System.Drawing.Point(185, 65);
            this.SubjectCount_label.Name = "SubjectCount_label";
            this.SubjectCount_label.Size = new System.Drawing.Size(29, 31);
            this.SubjectCount_label.TabIndex = 0;
            this.SubjectCount_label.Text = "0";
            // 
            // Teacher_Panel
            // 
            this.Teacher_Panel.Controls.Add(this.guna2PictureBox2);
            this.Teacher_Panel.Controls.Add(this.TeacherCount_label);
            this.Teacher_Panel.Controls.Add(this.guna2Panel2);
            this.Teacher_Panel.FillColor = System.Drawing.Color.Navy;
            this.Teacher_Panel.Location = new System.Drawing.Point(363, 64);
            this.Teacher_Panel.Name = "Teacher_Panel";
            this.Teacher_Panel.Size = new System.Drawing.Size(245, 209);
            this.Teacher_Panel.TabIndex = 2;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.BackgroundImage")));
            this.guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(34, 38);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(91, 72);
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // TeacherCount_label
            // 
            this.TeacherCount_label.AutoSize = true;
            this.TeacherCount_label.BackColor = System.Drawing.Color.Transparent;
            this.TeacherCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherCount_label.ForeColor = System.Drawing.Color.White;
            this.TeacherCount_label.Location = new System.Drawing.Point(185, 65);
            this.TeacherCount_label.Name = "TeacherCount_label";
            this.TeacherCount_label.Size = new System.Drawing.Size(29, 31);
            this.TeacherCount_label.TabIndex = 0;
            this.TeacherCount_label.Text = "0";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.Teacher_label);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 149);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(245, 60);
            this.guna2Panel2.TabIndex = 1;
            // 
            // Teacher_label
            // 
            this.Teacher_label.AutoSize = true;
            this.Teacher_label.BackColor = System.Drawing.Color.Transparent;
            this.Teacher_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_label.ForeColor = System.Drawing.Color.White;
            this.Teacher_label.Location = new System.Drawing.Point(71, 19);
            this.Teacher_label.Name = "Teacher_label";
            this.Teacher_label.Size = new System.Drawing.Size(108, 24);
            this.Teacher_label.TabIndex = 0;
            this.Teacher_label.Text = "TEACHER";
            // 
            // Student_Panel
            // 
            this.Student_Panel.Controls.Add(this.guna2PictureBox1);
            this.Student_Panel.Controls.Add(this.StudentCount_label);
            this.Student_Panel.Controls.Add(this.Student_Panel2);
            this.Student_Panel.FillColor = System.Drawing.Color.Red;
            this.Student_Panel.Location = new System.Drawing.Point(54, 64);
            this.Student_Panel.Name = "Student_Panel";
            this.Student_Panel.Size = new System.Drawing.Size(245, 209);
            this.Student_Panel.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.BackgroundImage")));
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(34, 38);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(91, 72);
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // StudentCount_label
            // 
            this.StudentCount_label.AutoSize = true;
            this.StudentCount_label.BackColor = System.Drawing.Color.Transparent;
            this.StudentCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentCount_label.Location = new System.Drawing.Point(185, 65);
            this.StudentCount_label.Name = "StudentCount_label";
            this.StudentCount_label.Size = new System.Drawing.Size(29, 31);
            this.StudentCount_label.TabIndex = 0;
            this.StudentCount_label.Text = "0";
            // 
            // Student_Panel2
            // 
            this.Student_Panel2.Controls.Add(this.student_label);
            this.Student_Panel2.FillColor = System.Drawing.Color.Yellow;
            this.Student_Panel2.Location = new System.Drawing.Point(0, 149);
            this.Student_Panel2.Name = "Student_Panel2";
            this.Student_Panel2.Size = new System.Drawing.Size(245, 60);
            this.Student_Panel2.TabIndex = 0;
            // 
            // student_label
            // 
            this.student_label.AutoSize = true;
            this.student_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_label.Location = new System.Drawing.Point(71, 19);
            this.student_label.Name = "student_label";
            this.student_label.Size = new System.Drawing.Size(106, 24);
            this.student_label.TabIndex = 0;
            this.student_label.Text = "STUDENT";
            // 
            // Student_Elipse
            // 
            this.Student_Elipse.BorderRadius = 10;
            this.Student_Elipse.TargetControl = this.Student_Panel;
            // 
            // Teacher_Elipse
            // 
            this.Teacher_Elipse.BorderRadius = 10;
            this.Teacher_Elipse.TargetControl = this.Teacher_Panel;
            // 
            // Subject_Elipse
            // 
            this.Subject_Elipse.BorderRadius = 10;
            this.Subject_Elipse.TargetControl = this.Subject_Panel;
            // 
            // Class_Elipse
            // 
            this.Class_Elipse.BorderRadius = 10;
            this.Class_Elipse.TargetControl = this.class_panel;
            // 
            // Student_Timer
            // 
            this.Student_Timer.Enabled = true;
            this.Student_Timer.Interval = 120;
            this.Student_Timer.Tick += new System.EventHandler(this.Student_Timer_Tick);
            // 
            // Subject_Timer
            // 
            this.Subject_Timer.Enabled = true;
            this.Subject_Timer.Interval = 120;
            this.Subject_Timer.Tick += new System.EventHandler(this.Subject_Timer_Tick);
            // 
            // Class_Timer
            // 
            this.Class_Timer.Enabled = true;
            this.Class_Timer.Interval = 120;
            this.Class_Timer.Tick += new System.EventHandler(this.Class_Timer_Tick);
            // 
            // Teacher_Timer
            // 
            this.Teacher_Timer.Enabled = true;
            this.Teacher_Timer.Interval = 120;
            this.Teacher_Timer.Tick += new System.EventHandler(this.Teacher_Timer_Tick);
            // 
            // Dashboard_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Dashboard_UserControl";
            this.Size = new System.Drawing.Size(668, 583);
            this.Load += new System.EventHandler(this.Dashboard_UserControl_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.class_panel.ResumeLayout(false);
            this.class_panel.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.Subject_Panel.ResumeLayout(false);
            this.Subject_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.Teacher_Panel.ResumeLayout(false);
            this.Teacher_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.Student_Panel.ResumeLayout(false);
            this.Student_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.Student_Panel2.ResumeLayout(false);
            this.Student_Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse DashUser_Elipse;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label Teacher_label;
        private Guna.UI2.WinForms.Guna2Panel Teacher_Panel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label TeacherCount_label;
        private Guna.UI2.WinForms.Guna2Panel Student_Panel2;
        private System.Windows.Forms.Label student_label;
        private Guna.UI2.WinForms.Guna2Panel Student_Panel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label StudentCount_label;
        private Guna.UI2.WinForms.Guna2Elipse Student_Elipse;
        private Guna.UI2.WinForms.Guna2Elipse Teacher_Elipse;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label Class_Label;
        private Guna.UI2.WinForms.Guna2Panel class_panel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label ClassCount_Label;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label SUBJECT_LABEL;
        private Guna.UI2.WinForms.Guna2Panel Subject_Panel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label SubjectCount_label;
        private Guna.UI2.WinForms.Guna2Elipse Subject_Elipse;
        private Guna.UI2.WinForms.Guna2Elipse Class_Elipse;
        private System.Windows.Forms.Timer Student_Timer;
        private System.Windows.Forms.Timer Subject_Timer;
        private System.Windows.Forms.Timer Class_Timer;
        private System.Windows.Forms.Timer Teacher_Timer;
    }
}
