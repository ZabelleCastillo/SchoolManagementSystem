namespace SchoolManagementSystem.Admin_UserControl
{
    partial class TeacherSched_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherSched_UserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Teacher_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TEACHER_Groupbx = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Prev_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Next_btn = new Guna.UI2.WinForms.Guna2Button();
            this.DEL_aLL_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.Subj_label = new System.Windows.Forms.Label();
            this.Teacher_label = new System.Windows.Forms.Label();
            this.Subject_Txbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.RESULT_TXBX = new Guna.UI2.WinForms.Guna2TextBox();
            this.EXPORT_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.DEL_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Teacher_DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suffixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEACHERCLASSSCHEDULETABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_DBDataSet_TeacherSched = new SchoolManagementSystem.School_DBDataSet_TeacherSched();
            this.addyearsec_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.Suffix_Txbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.MiddleNme_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.LastNme_Txbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.TeacherName_Txbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.UsernameTeacher_Txbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.tEACHER_CLASS_SCHEDULE_TABLETableAdapter = new SchoolManagementSystem.School_DBDataSet_TeacherSchedTableAdapters.TEACHER_CLASS_SCHEDULE_TABLETableAdapter();
            this.Teacher_Timer = new System.Windows.Forms.Timer(this.components);
            this.TEACHER_Groupbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERCLASSSCHEDULETABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DBDataSet_TeacherSched)).BeginInit();
            this.addyearsec_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Teacher_Elipse
            // 
            this.Teacher_Elipse.BorderRadius = 10;
            this.Teacher_Elipse.TargetControl = this;
            // 
            // TEACHER_Groupbx
            // 
            this.TEACHER_Groupbx.BackColor = System.Drawing.Color.Transparent;
            this.TEACHER_Groupbx.Controls.Add(this.Prev_btn);
            this.TEACHER_Groupbx.Controls.Add(this.Next_btn);
            this.TEACHER_Groupbx.Controls.Add(this.DEL_aLL_BTN);
            this.TEACHER_Groupbx.Controls.Add(this.Subj_label);
            this.TEACHER_Groupbx.Controls.Add(this.Teacher_label);
            this.TEACHER_Groupbx.Controls.Add(this.Subject_Txbx);
            this.TEACHER_Groupbx.Controls.Add(this.RESULT_TXBX);
            this.TEACHER_Groupbx.Controls.Add(this.EXPORT_BTN);
            this.TEACHER_Groupbx.Controls.Add(this.DEL_btn);
            this.TEACHER_Groupbx.Controls.Add(this.Teacher_DataGridView);
            this.TEACHER_Groupbx.Controls.Add(this.addyearsec_panel);
            this.TEACHER_Groupbx.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TEACHER_Groupbx.FillColor = System.Drawing.Color.Yellow;
            this.TEACHER_Groupbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEACHER_Groupbx.ForeColor = System.Drawing.Color.White;
            this.TEACHER_Groupbx.Location = new System.Drawing.Point(-1, 0);
            this.TEACHER_Groupbx.Name = "TEACHER_Groupbx";
            this.TEACHER_Groupbx.Size = new System.Drawing.Size(894, 532);
            this.TEACHER_Groupbx.TabIndex = 4;
            this.TEACHER_Groupbx.Text = "TEACHER SCHEDULE";
            this.TEACHER_Groupbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Prev_btn
            // 
            this.Prev_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Prev_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Prev_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Prev_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Prev_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Prev_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Prev_btn.ForeColor = System.Drawing.Color.White;
            this.Prev_btn.HoverState.FillColor = System.Drawing.Color.Lime;
            this.Prev_btn.Image = ((System.Drawing.Image)(resources.GetObject("Prev_btn.Image")));
            this.Prev_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Prev_btn.Location = new System.Drawing.Point(219, 3);
            this.Prev_btn.Name = "Prev_btn";
            this.Prev_btn.Size = new System.Drawing.Size(82, 32);
            this.Prev_btn.TabIndex = 16;
            this.Prev_btn.Text = "Prev";
            this.Prev_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Prev_btn.Click += new System.EventHandler(this.Prev_btn_Click);
            // 
            // Next_btn
            // 
            this.Next_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Next_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Next_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Next_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Next_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Next_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Next_btn.ForeColor = System.Drawing.Color.White;
            this.Next_btn.HoverState.FillColor = System.Drawing.Color.Lime;
            this.Next_btn.Image = ((System.Drawing.Image)(resources.GetObject("Next_btn.Image")));
            this.Next_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Next_btn.Location = new System.Drawing.Point(630, 3);
            this.Next_btn.Name = "Next_btn";
            this.Next_btn.Size = new System.Drawing.Size(82, 32);
            this.Next_btn.TabIndex = 15;
            this.Next_btn.Text = "Next";
            this.Next_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Next_btn.Click += new System.EventHandler(this.Next_btn_Click);
            // 
            // DEL_aLL_BTN
            // 
            this.DEL_aLL_BTN.BackColor = System.Drawing.Color.Transparent;
            this.DEL_aLL_BTN.BorderRadius = 10;
            this.DEL_aLL_BTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DEL_aLL_BTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DEL_aLL_BTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DEL_aLL_BTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DEL_aLL_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DEL_aLL_BTN.ForeColor = System.Drawing.Color.White;
            this.DEL_aLL_BTN.Location = new System.Drawing.Point(586, 466);
            this.DEL_aLL_BTN.Name = "DEL_aLL_BTN";
            this.DEL_aLL_BTN.Size = new System.Drawing.Size(126, 45);
            this.DEL_aLL_BTN.TabIndex = 13;
            this.DEL_aLL_BTN.Text = "DELETE ALL";
            this.DEL_aLL_BTN.Click += new System.EventHandler(this.DEL_aLL_BTN_Click);
            // 
            // Subj_label
            // 
            this.Subj_label.AutoSize = true;
            this.Subj_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subj_label.ForeColor = System.Drawing.Color.Black;
            this.Subj_label.Location = new System.Drawing.Point(238, 477);
            this.Subj_label.Name = "Subj_label";
            this.Subj_label.Size = new System.Drawing.Size(82, 21);
            this.Subj_label.TabIndex = 12;
            this.Subj_label.Text = "SUBJECTS";
            // 
            // Teacher_label
            // 
            this.Teacher_label.AutoSize = true;
            this.Teacher_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_label.ForeColor = System.Drawing.Color.Black;
            this.Teacher_label.Location = new System.Drawing.Point(25, 477);
            this.Teacher_label.Name = "Teacher_label";
            this.Teacher_label.Size = new System.Drawing.Size(87, 21);
            this.Teacher_label.TabIndex = 11;
            this.Teacher_label.Text = "TEACHERS";
            this.Teacher_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Subject_Txbx
            // 
            this.Subject_Txbx.BorderRadius = 11;
            this.Subject_Txbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Subject_Txbx.DefaultText = "";
            this.Subject_Txbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Subject_Txbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Subject_Txbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Subject_Txbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Subject_Txbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Subject_Txbx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_Txbx.ForeColor = System.Drawing.Color.Black;
            this.Subject_Txbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Subject_Txbx.Location = new System.Drawing.Point(361, 466);
            this.Subject_Txbx.Margin = new System.Windows.Forms.Padding(4);
            this.Subject_Txbx.Multiline = true;
            this.Subject_Txbx.Name = "Subject_Txbx";
            this.Subject_Txbx.PasswordChar = '\0';
            this.Subject_Txbx.PlaceholderText = "";
            this.Subject_Txbx.SelectedText = "";
            this.Subject_Txbx.Size = new System.Drawing.Size(80, 45);
            this.Subject_Txbx.TabIndex = 10;
            this.Subject_Txbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RESULT_TXBX
            // 
            this.RESULT_TXBX.BorderRadius = 11;
            this.RESULT_TXBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RESULT_TXBX.DefaultText = "";
            this.RESULT_TXBX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RESULT_TXBX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RESULT_TXBX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RESULT_TXBX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RESULT_TXBX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RESULT_TXBX.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESULT_TXBX.ForeColor = System.Drawing.Color.Black;
            this.RESULT_TXBX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RESULT_TXBX.Location = new System.Drawing.Point(152, 466);
            this.RESULT_TXBX.Multiline = true;
            this.RESULT_TXBX.Name = "RESULT_TXBX";
            this.RESULT_TXBX.PasswordChar = '\0';
            this.RESULT_TXBX.PlaceholderText = "";
            this.RESULT_TXBX.SelectedText = "";
            this.RESULT_TXBX.Size = new System.Drawing.Size(80, 45);
            this.RESULT_TXBX.TabIndex = 9;
            this.RESULT_TXBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EXPORT_BTN
            // 
            this.EXPORT_BTN.BackColor = System.Drawing.Color.Transparent;
            this.EXPORT_BTN.BorderRadius = 10;
            this.EXPORT_BTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EXPORT_BTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EXPORT_BTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EXPORT_BTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EXPORT_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EXPORT_BTN.ForeColor = System.Drawing.Color.White;
            this.EXPORT_BTN.Location = new System.Drawing.Point(730, 466);
            this.EXPORT_BTN.Name = "EXPORT_BTN";
            this.EXPORT_BTN.Size = new System.Drawing.Size(126, 45);
            this.EXPORT_BTN.TabIndex = 8;
            this.EXPORT_BTN.Text = "EXPORT SCHEDULE";
            this.EXPORT_BTN.Click += new System.EventHandler(this.EXPORT_BTN_Click);
            // 
            // DEL_btn
            // 
            this.DEL_btn.BackColor = System.Drawing.Color.Transparent;
            this.DEL_btn.BorderRadius = 10;
            this.DEL_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DEL_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DEL_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DEL_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DEL_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DEL_btn.ForeColor = System.Drawing.Color.White;
            this.DEL_btn.Location = new System.Drawing.Point(448, 466);
            this.DEL_btn.Name = "DEL_btn";
            this.DEL_btn.Size = new System.Drawing.Size(126, 45);
            this.DEL_btn.TabIndex = 7;
            this.DEL_btn.Text = "DELETE";
            this.DEL_btn.Click += new System.EventHandler(this.DEL_btn_Click);
            // 
            // Teacher_DataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Teacher_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Teacher_DataGridView.AutoGenerateColumns = false;
            this.Teacher_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Teacher_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Teacher_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Teacher_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Teacher_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Teacher_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Teacher_DataGridView.ColumnHeadersHeight = 25;
            this.Teacher_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.suffixDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.yearLevelDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.Teacher_DataGridView.DataSource = this.tEACHERCLASSSCHEDULETABLEBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Teacher_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Teacher_DataGridView.EnableHeadersVisualStyles = false;
            this.Teacher_DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Teacher_DataGridView.Location = new System.Drawing.Point(28, 134);
            this.Teacher_DataGridView.Name = "Teacher_DataGridView";
            this.Teacher_DataGridView.RowHeadersVisible = false;
            this.Teacher_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Teacher_DataGridView.Size = new System.Drawing.Size(828, 317);
            this.Teacher_DataGridView.TabIndex = 6;
            this.Teacher_DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Teacher_DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Teacher_DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Teacher_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Teacher_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Teacher_DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Teacher_DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Teacher_DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Teacher_DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Teacher_DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Teacher_DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Teacher_DataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.Teacher_DataGridView.ThemeStyle.ReadOnly = false;
            this.Teacher_DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Teacher_DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Teacher_DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.Teacher_DataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.Teacher_DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Teacher_DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Teacher_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Teacher_DataGridView_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // suffixDataGridViewTextBoxColumn
            // 
            this.suffixDataGridViewTextBoxColumn.DataPropertyName = "Suffix";
            this.suffixDataGridViewTextBoxColumn.HeaderText = "Suffix";
            this.suffixDataGridViewTextBoxColumn.Name = "suffixDataGridViewTextBoxColumn";
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            // 
            // yearLevelDataGridViewTextBoxColumn
            // 
            this.yearLevelDataGridViewTextBoxColumn.DataPropertyName = "Year Level";
            this.yearLevelDataGridViewTextBoxColumn.HeaderText = "Year Level";
            this.yearLevelDataGridViewTextBoxColumn.Name = "yearLevelDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // tEACHERCLASSSCHEDULETABLEBindingSource
            // 
            this.tEACHERCLASSSCHEDULETABLEBindingSource.DataMember = "TEACHER_CLASS_SCHEDULE_TABLE";
            this.tEACHERCLASSSCHEDULETABLEBindingSource.DataSource = this.school_DBDataSet_TeacherSched;
            // 
            // school_DBDataSet_TeacherSched
            // 
            this.school_DBDataSet_TeacherSched.DataSetName = "School_DBDataSet_TeacherSched";
            this.school_DBDataSet_TeacherSched.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addyearsec_panel
            // 
            this.addyearsec_panel.BackColor = System.Drawing.Color.White;
            this.addyearsec_panel.Controls.Add(this.guna2Panel5);
            this.addyearsec_panel.Controls.Add(this.Suffix_Txbox);
            this.addyearsec_panel.Controls.Add(this.guna2Panel4);
            this.addyearsec_panel.Controls.Add(this.MiddleNme_TextBox);
            this.addyearsec_panel.Controls.Add(this.guna2Panel3);
            this.addyearsec_panel.Controls.Add(this.LastNme_Txbx);
            this.addyearsec_panel.Controls.Add(this.guna2Panel2);
            this.addyearsec_panel.Controls.Add(this.TeacherName_Txbx);
            this.addyearsec_panel.Controls.Add(this.guna2Panel1);
            this.addyearsec_panel.Controls.Add(this.UsernameTeacher_Txbx);
            this.addyearsec_panel.Location = new System.Drawing.Point(28, 50);
            this.addyearsec_panel.Name = "addyearsec_panel";
            this.addyearsec_panel.Size = new System.Drawing.Size(828, 78);
            this.addyearsec_panel.TabIndex = 5;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel5.Location = new System.Drawing.Point(704, 52);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(82, 5);
            this.guna2Panel5.TabIndex = 24;
            // 
            // Suffix_Txbox
            // 
            this.Suffix_Txbox.BorderThickness = 0;
            this.Suffix_Txbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Suffix_Txbox.DefaultText = "";
            this.Suffix_Txbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Suffix_Txbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Suffix_Txbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Suffix_Txbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Suffix_Txbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Suffix_Txbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suffix_Txbox.ForeColor = System.Drawing.Color.Green;
            this.Suffix_Txbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Suffix_Txbox.Location = new System.Drawing.Point(704, 13);
            this.Suffix_Txbox.Name = "Suffix_Txbox";
            this.Suffix_Txbox.PasswordChar = '\0';
            this.Suffix_Txbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Suffix_Txbox.PlaceholderText = "Suffix";
            this.Suffix_Txbox.SelectedText = "";
            this.Suffix_Txbox.Size = new System.Drawing.Size(82, 41);
            this.Suffix_Txbox.TabIndex = 5;
            this.Suffix_Txbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel4.Location = new System.Drawing.Point(526, 52);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(167, 5);
            this.guna2Panel4.TabIndex = 23;
            // 
            // MiddleNme_TextBox
            // 
            this.MiddleNme_TextBox.BorderThickness = 0;
            this.MiddleNme_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MiddleNme_TextBox.DefaultText = "";
            this.MiddleNme_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MiddleNme_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MiddleNme_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MiddleNme_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MiddleNme_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MiddleNme_TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleNme_TextBox.ForeColor = System.Drawing.Color.Green;
            this.MiddleNme_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MiddleNme_TextBox.Location = new System.Drawing.Point(526, 13);
            this.MiddleNme_TextBox.Name = "MiddleNme_TextBox";
            this.MiddleNme_TextBox.PasswordChar = '\0';
            this.MiddleNme_TextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.MiddleNme_TextBox.PlaceholderText = "Middle Name";
            this.MiddleNme_TextBox.SelectedText = "";
            this.MiddleNme_TextBox.Size = new System.Drawing.Size(167, 41);
            this.MiddleNme_TextBox.TabIndex = 4;
            this.MiddleNme_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MiddleNme_TextBox.TextChanged += new System.EventHandler(this.MiddleNme_TextBox_TextChanged);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel3.Location = new System.Drawing.Point(353, 52);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(167, 5);
            this.guna2Panel3.TabIndex = 22;
            // 
            // LastNme_Txbx
            // 
            this.LastNme_Txbx.BorderThickness = 0;
            this.LastNme_Txbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastNme_Txbx.DefaultText = "";
            this.LastNme_Txbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LastNme_Txbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LastNme_Txbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastNme_Txbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastNme_Txbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastNme_Txbx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNme_Txbx.ForeColor = System.Drawing.Color.Green;
            this.LastNme_Txbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastNme_Txbx.Location = new System.Drawing.Point(353, 13);
            this.LastNme_Txbx.Name = "LastNme_Txbx";
            this.LastNme_Txbx.PasswordChar = '\0';
            this.LastNme_Txbx.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.LastNme_Txbx.PlaceholderText = "Lastname";
            this.LastNme_Txbx.SelectedText = "";
            this.LastNme_Txbx.Size = new System.Drawing.Size(167, 41);
            this.LastNme_Txbx.TabIndex = 3;
            this.LastNme_Txbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LastNme_Txbx.TextChanged += new System.EventHandler(this.LastNme_Txbx_TextChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Location = new System.Drawing.Point(180, 52);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(167, 5);
            this.guna2Panel2.TabIndex = 21;
            // 
            // TeacherName_Txbx
            // 
            this.TeacherName_Txbx.BorderThickness = 0;
            this.TeacherName_Txbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TeacherName_Txbx.DefaultText = "";
            this.TeacherName_Txbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TeacherName_Txbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TeacherName_Txbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TeacherName_Txbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TeacherName_Txbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TeacherName_Txbx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherName_Txbx.ForeColor = System.Drawing.Color.Green;
            this.TeacherName_Txbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TeacherName_Txbx.Location = new System.Drawing.Point(180, 13);
            this.TeacherName_Txbx.Name = "TeacherName_Txbx";
            this.TeacherName_Txbx.PasswordChar = '\0';
            this.TeacherName_Txbx.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.TeacherName_Txbx.PlaceholderText = "Name";
            this.TeacherName_Txbx.SelectedText = "";
            this.TeacherName_Txbx.Size = new System.Drawing.Size(167, 41);
            this.TeacherName_Txbx.TabIndex = 2;
            this.TeacherName_Txbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TeacherName_Txbx.TextChanged += new System.EventHandler(this.TeacherName_Txbx_TextChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(22, 52);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(142, 5);
            this.guna2Panel1.TabIndex = 20;
            // 
            // UsernameTeacher_Txbx
            // 
            this.UsernameTeacher_Txbx.BorderThickness = 0;
            this.UsernameTeacher_Txbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTeacher_Txbx.DefaultText = "";
            this.UsernameTeacher_Txbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTeacher_Txbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTeacher_Txbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTeacher_Txbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTeacher_Txbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTeacher_Txbx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.UsernameTeacher_Txbx.ForeColor = System.Drawing.Color.Green;
            this.UsernameTeacher_Txbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsernameTeacher_Txbx.Location = new System.Drawing.Point(22, 13);
            this.UsernameTeacher_Txbx.Name = "UsernameTeacher_Txbx";
            this.UsernameTeacher_Txbx.PasswordChar = '\0';
            this.UsernameTeacher_Txbx.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.UsernameTeacher_Txbx.PlaceholderText = "Username";
            this.UsernameTeacher_Txbx.SelectedText = "";
            this.UsernameTeacher_Txbx.Size = new System.Drawing.Size(142, 41);
            this.UsernameTeacher_Txbx.TabIndex = 1;
            this.UsernameTeacher_Txbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsernameTeacher_Txbx.TextChanged += new System.EventHandler(this.UsernameTeacher_Txbx_TextChanged);
            // 
            // tEACHER_CLASS_SCHEDULE_TABLETableAdapter
            // 
            this.tEACHER_CLASS_SCHEDULE_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // Teacher_Timer
            // 
            this.Teacher_Timer.Enabled = true;
            this.Teacher_Timer.Interval = 120;
            this.Teacher_Timer.Tick += new System.EventHandler(this.Teacher_Timer_Tick);
            // 
            // TeacherSched_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TEACHER_Groupbx);
            this.Name = "TeacherSched_UserControl";
            this.Size = new System.Drawing.Size(892, 532);
            this.Load += new System.EventHandler(this.TeacherSched_UserControl_Load);
            this.TEACHER_Groupbx.ResumeLayout(false);
            this.TEACHER_Groupbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Teacher_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERCLASSSCHEDULETABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DBDataSet_TeacherSched)).EndInit();
            this.addyearsec_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Teacher_Elipse;
        private Guna.UI2.WinForms.Guna2GroupBox TEACHER_Groupbx;
        private Guna.UI2.WinForms.Guna2Panel addyearsec_panel;
        private Guna.UI2.WinForms.Guna2DataGridView Teacher_DataGridView;
        private Guna.UI2.WinForms.Guna2TextBox RESULT_TXBX;
        private Guna.UI2.WinForms.Guna2Button EXPORT_BTN;
        private Guna.UI2.WinForms.Guna2Button DEL_btn;
        private System.Windows.Forms.BindingSource tEACHERCLASSSCHEDULETABLEBindingSource;
        private School_DBDataSet_TeacherSched school_DBDataSet_TeacherSched;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2TextBox Suffix_Txbox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2TextBox MiddleNme_TextBox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TextBox LastNme_Txbx;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox TeacherName_Txbx;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox UsernameTeacher_Txbx;
        private School_DBDataSet_TeacherSchedTableAdapters.TEACHER_CLASS_SCHEDULE_TABLETableAdapter tEACHER_CLASS_SCHEDULE_TABLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suffixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer Teacher_Timer;
        private Guna.UI2.WinForms.Guna2TextBox Subject_Txbx;
        private System.Windows.Forms.Label Subj_label;
        private System.Windows.Forms.Label Teacher_label;
        private Guna.UI2.WinForms.Guna2Button DEL_aLL_BTN;
        private Guna.UI2.WinForms.Guna2Button Prev_btn;
        private Guna.UI2.WinForms.Guna2Button Next_btn;
    }
}
