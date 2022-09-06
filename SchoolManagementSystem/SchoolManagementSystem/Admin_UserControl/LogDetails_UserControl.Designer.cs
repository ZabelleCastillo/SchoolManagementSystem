namespace SchoolManagementSystem.Admin_UserControl
{
    partial class LogDetails_UserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LogDetails_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UserGroupbox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.nav_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.USERNAME_TXBX = new Guna.UI2.WinForms.Guna2TextBox();
            this.DEL_ALL_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.TeacherTime_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DELETE_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.DATE_TXBX = new Guna.UI2.WinForms.Guna2TextBox();
            this.TeacherTime_DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rOLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tEACHERLOGINTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_DBDataSet_TeacherLog = new SchoolManagementSystem.School_DBDataSet_TeacherLog();
            this.tEACHER_LOGIN_TABLETableAdapter = new SchoolManagementSystem.School_DBDataSet_TeacherLogTableAdapters.TEACHER_LOGIN_TABLETableAdapter();
            this.dATAgridView_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.nav_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.UserGroupbox.SuspendLayout();
            this.nav_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherTime_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERLOGINTABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DBDataSet_TeacherLog)).BeginInit();
            this.SuspendLayout();
            // 
            // LogDetails_Elipse
            // 
            this.LogDetails_Elipse.BorderRadius = 10;
            this.LogDetails_Elipse.TargetControl = this;
            // 
            // UserGroupbox
            // 
            this.UserGroupbox.Controls.Add(this.nav_panel);
            this.UserGroupbox.Controls.Add(this.TeacherTime_DataGridView);
            this.UserGroupbox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.UserGroupbox.FillColor = System.Drawing.Color.Yellow;
            this.UserGroupbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGroupbox.ForeColor = System.Drawing.Color.White;
            this.UserGroupbox.Location = new System.Drawing.Point(-1, 1);
            this.UserGroupbox.Name = "UserGroupbox";
            this.UserGroupbox.Size = new System.Drawing.Size(971, 482);
            this.UserGroupbox.TabIndex = 0;
            this.UserGroupbox.Text = "User\'s log";
            this.UserGroupbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nav_panel
            // 
            this.nav_panel.BackColor = System.Drawing.Color.White;
            this.nav_panel.Controls.Add(this.USERNAME_TXBX);
            this.nav_panel.Controls.Add(this.DEL_ALL_BTN);
            this.nav_panel.Controls.Add(this.TeacherTime_label);
            this.nav_panel.Controls.Add(this.label1);
            this.nav_panel.Controls.Add(this.DELETE_BTN);
            this.nav_panel.Controls.Add(this.DATE_TXBX);
            this.nav_panel.Location = new System.Drawing.Point(15, 68);
            this.nav_panel.Name = "nav_panel";
            this.nav_panel.Size = new System.Drawing.Size(245, 383);
            this.nav_panel.TabIndex = 6;
            // 
            // USERNAME_TXBX
            // 
            this.USERNAME_TXBX.BackColor = System.Drawing.Color.Transparent;
            this.USERNAME_TXBX.BorderRadius = 10;
            this.USERNAME_TXBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.USERNAME_TXBX.DefaultText = "";
            this.USERNAME_TXBX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.USERNAME_TXBX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.USERNAME_TXBX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.USERNAME_TXBX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.USERNAME_TXBX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.USERNAME_TXBX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USERNAME_TXBX.ForeColor = System.Drawing.Color.Black;
            this.USERNAME_TXBX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.USERNAME_TXBX.Location = new System.Drawing.Point(24, 58);
            this.USERNAME_TXBX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.USERNAME_TXBX.Name = "USERNAME_TXBX";
            this.USERNAME_TXBX.PasswordChar = '\0';
            this.USERNAME_TXBX.PlaceholderText = "";
            this.USERNAME_TXBX.SelectedText = "";
            this.USERNAME_TXBX.Size = new System.Drawing.Size(200, 36);
            this.USERNAME_TXBX.TabIndex = 1;
            this.USERNAME_TXBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.USERNAME_TXBX.TextChanged += new System.EventHandler(this.USERNAME_TXBX_TextChanged);
            // 
            // DEL_ALL_BTN
            // 
            this.DEL_ALL_BTN.BackColor = System.Drawing.Color.Transparent;
            this.DEL_ALL_BTN.BorderRadius = 10;
            this.DEL_ALL_BTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DEL_ALL_BTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DEL_ALL_BTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DEL_ALL_BTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DEL_ALL_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DEL_ALL_BTN.ForeColor = System.Drawing.Color.White;
            this.DEL_ALL_BTN.Location = new System.Drawing.Point(24, 304);
            this.DEL_ALL_BTN.Name = "DEL_ALL_BTN";
            this.DEL_ALL_BTN.Size = new System.Drawing.Size(200, 45);
            this.DEL_ALL_BTN.TabIndex = 4;
            this.DEL_ALL_BTN.Text = "DELETE ALL LOGS";
            this.DEL_ALL_BTN.Click += new System.EventHandler(this.DEL_ALL_BTN_Click);
            // 
            // TeacherTime_label
            // 
            this.TeacherTime_label.AutoSize = true;
            this.TeacherTime_label.BackColor = System.Drawing.Color.Transparent;
            this.TeacherTime_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherTime_label.ForeColor = System.Drawing.Color.Black;
            this.TeacherTime_label.Location = new System.Drawing.Point(83, 177);
            this.TeacherTime_label.Name = "TeacherTime_label";
            this.TeacherTime_label.Size = new System.Drawing.Size(67, 15);
            this.TeacherTime_label.TabIndex = 0;
            this.TeacherTime_label.Text = "Time Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(91, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // DELETE_BTN
            // 
            this.DELETE_BTN.BackColor = System.Drawing.Color.Transparent;
            this.DELETE_BTN.BorderRadius = 10;
            this.DELETE_BTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DELETE_BTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DELETE_BTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DELETE_BTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DELETE_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DELETE_BTN.ForeColor = System.Drawing.Color.White;
            this.DELETE_BTN.Location = new System.Drawing.Point(24, 254);
            this.DELETE_BTN.Name = "DELETE_BTN";
            this.DELETE_BTN.Size = new System.Drawing.Size(200, 45);
            this.DELETE_BTN.TabIndex = 3;
            this.DELETE_BTN.Text = "DELETE USER\'S TIME";
            this.DELETE_BTN.Click += new System.EventHandler(this.DELETE_BTN_Click);
            // 
            // DATE_TXBX
            // 
            this.DATE_TXBX.BackColor = System.Drawing.Color.Transparent;
            this.DATE_TXBX.BorderRadius = 10;
            this.DATE_TXBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DATE_TXBX.DefaultText = "";
            this.DATE_TXBX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DATE_TXBX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DATE_TXBX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DATE_TXBX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DATE_TXBX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DATE_TXBX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATE_TXBX.ForeColor = System.Drawing.Color.Black;
            this.DATE_TXBX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DATE_TXBX.Location = new System.Drawing.Point(24, 130);
            this.DATE_TXBX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DATE_TXBX.Name = "DATE_TXBX";
            this.DATE_TXBX.PasswordChar = '\0';
            this.DATE_TXBX.PlaceholderText = "";
            this.DATE_TXBX.SelectedText = "";
            this.DATE_TXBX.Size = new System.Drawing.Size(200, 36);
            this.DATE_TXBX.TabIndex = 2;
            this.DATE_TXBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DATE_TXBX.TextChanged += new System.EventHandler(this.DATE_TXBX_TextChanged);
            // 
            // TeacherTime_DataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.TeacherTime_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TeacherTime_DataGridView.AutoGenerateColumns = false;
            this.TeacherTime_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TeacherTime_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TeacherTime_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TeacherTime_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TeacherTime_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeacherTime_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TeacherTime_DataGridView.ColumnHeadersHeight = 25;
            this.TeacherTime_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.dATEDataGridViewTextBoxColumn,
            this.rOLEDataGridViewTextBoxColumn});
            this.TeacherTime_DataGridView.DataSource = this.tEACHERLOGINTABLEBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherTime_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TeacherTime_DataGridView.EnableHeadersVisualStyles = false;
            this.TeacherTime_DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TeacherTime_DataGridView.Location = new System.Drawing.Point(279, 68);
            this.TeacherTime_DataGridView.Name = "TeacherTime_DataGridView";
            this.TeacherTime_DataGridView.RowHeadersVisible = false;
            this.TeacherTime_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TeacherTime_DataGridView.Size = new System.Drawing.Size(670, 383);
            this.TeacherTime_DataGridView.TabIndex = 2;
            this.TeacherTime_DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TeacherTime_DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TeacherTime_DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TeacherTime_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TeacherTime_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TeacherTime_DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TeacherTime_DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TeacherTime_DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TeacherTime_DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TeacherTime_DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TeacherTime_DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TeacherTime_DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TeacherTime_DataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.TeacherTime_DataGridView.ThemeStyle.ReadOnly = false;
            this.TeacherTime_DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TeacherTime_DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TeacherTime_DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TeacherTime_DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TeacherTime_DataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.TeacherTime_DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TeacherTime_DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TeacherTime_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherTime_DataGridView_CellClick);
            this.TeacherTime_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeacherTime_DataGridView_CellContentClick);
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            this.dATEDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            // 
            // rOLEDataGridViewTextBoxColumn
            // 
            this.rOLEDataGridViewTextBoxColumn.DataPropertyName = "ROLE";
            this.rOLEDataGridViewTextBoxColumn.HeaderText = "ROLE";
            this.rOLEDataGridViewTextBoxColumn.Name = "rOLEDataGridViewTextBoxColumn";
            // 
            // tEACHERLOGINTABLEBindingSource
            // 
            this.tEACHERLOGINTABLEBindingSource.DataMember = "TEACHER_LOGIN_TABLE";
            this.tEACHERLOGINTABLEBindingSource.DataSource = this.school_DBDataSet_TeacherLog;
            // 
            // school_DBDataSet_TeacherLog
            // 
            this.school_DBDataSet_TeacherLog.DataSetName = "School_DBDataSet_TeacherLog";
            this.school_DBDataSet_TeacherLog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tEACHER_LOGIN_TABLETableAdapter
            // 
            this.tEACHER_LOGIN_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // dATAgridView_Elipse
            // 
            this.dATAgridView_Elipse.BorderRadius = 10;
            this.dATAgridView_Elipse.TargetControl = this.TeacherTime_DataGridView;
            // 
            // nav_Elipse
            // 
            this.nav_Elipse.BorderRadius = 10;
            this.nav_Elipse.TargetControl = this.nav_panel;
            // 
            // LogDetails_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.UserGroupbox);
            this.Name = "LogDetails_UserControl";
            this.Size = new System.Drawing.Size(970, 480);
            this.Load += new System.EventHandler(this.LogDetails_UserControl_Load);
            this.UserGroupbox.ResumeLayout(false);
            this.nav_panel.ResumeLayout(false);
            this.nav_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherTime_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEACHERLOGINTABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DBDataSet_TeacherLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse LogDetails_Elipse;
        private Guna.UI2.WinForms.Guna2GroupBox UserGroupbox;
        private System.Windows.Forms.Label TeacherTime_label;
        private Guna.UI2.WinForms.Guna2DataGridView TeacherTime_DataGridView;
        private Guna.UI2.WinForms.Guna2TextBox USERNAME_TXBX;
        private Guna.UI2.WinForms.Guna2TextBox DATE_TXBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rOLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tEACHERLOGINTABLEBindingSource;
        private School_DBDataSet_TeacherLog school_DBDataSet_TeacherLog;
        private School_DBDataSet_TeacherLogTableAdapters.TEACHER_LOGIN_TABLETableAdapter tEACHER_LOGIN_TABLETableAdapter;
        private Guna.UI2.WinForms.Guna2Button DELETE_BTN;
        private Guna.UI2.WinForms.Guna2Button DEL_ALL_BTN;
        private Guna.UI2.WinForms.Guna2Elipse dATAgridView_Elipse;
        private Guna.UI2.WinForms.Guna2Panel nav_panel;
        private Guna.UI2.WinForms.Guna2Elipse nav_Elipse;
    }
}
