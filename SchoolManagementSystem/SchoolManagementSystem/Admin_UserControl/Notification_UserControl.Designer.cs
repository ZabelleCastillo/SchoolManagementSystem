namespace SchoolManagementSystem.Admin_UserControl
{
    partial class Notification_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification_UserControl));
            this.Notify_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Email_Txbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.msg_txbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.FeedBack_User_DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.uSERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mESSAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dELETEACCOUNTTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_DBDataSet_Feedback = new SchoolManagementSystem.School_DBDataSet_Feedback();
            this.school_DBDataSet_DELETE_ACC = new SchoolManagementSystem.School_DBDataSet_DELETE_ACC();
            this.NotifyGroupbox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LOAD_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.inbox_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.inbox_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dELETE_ACCOUNT_TABLETableAdapter = new SchoolManagementSystem.School_DBDataSet_DELETE_ACCTableAdapters.DELETE_ACCOUNT_TABLETableAdapter();
            this.dELETE_ACCOUNT_TABLETableAdapter1 = new SchoolManagementSystem.School_DBDataSet_FeedbackTableAdapters.DELETE_ACCOUNT_TABLETableAdapter();
            this.dATAgRiDvIEW_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DEL_BTN = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.FeedBack_User_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELETEACCOUNTTABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DBDataSet_Feedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DBDataSet_DELETE_ACC)).BeginInit();
            this.NotifyGroupbox.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.inbox_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Notify_Elipse
            // 
            this.Notify_Elipse.BorderRadius = 10;
            this.Notify_Elipse.TargetControl = this;
            // 
            // Email_Txbox
            // 
            this.Email_Txbox.BackColor = System.Drawing.Color.Transparent;
            this.Email_Txbox.BorderColor = System.Drawing.Color.Transparent;
            this.Email_Txbox.BorderRadius = 10;
            this.Email_Txbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_Txbox.DefaultText = "";
            this.Email_Txbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email_Txbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email_Txbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_Txbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_Txbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_Txbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Txbox.ForeColor = System.Drawing.Color.Black;
            this.Email_Txbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_Txbox.Location = new System.Drawing.Point(18, 16);
            this.Email_Txbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Email_Txbox.Name = "Email_Txbox";
            this.Email_Txbox.PasswordChar = '\0';
            this.Email_Txbox.PlaceholderText = "";
            this.Email_Txbox.SelectedText = "";
            this.Email_Txbox.Size = new System.Drawing.Size(277, 44);
            this.Email_Txbox.TabIndex = 1;
            // 
            // msg_txbx
            // 
            this.msg_txbx.BackColor = System.Drawing.Color.Transparent;
            this.msg_txbx.BorderColor = System.Drawing.Color.Transparent;
            this.msg_txbx.BorderRadius = 10;
            this.msg_txbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.msg_txbx.DefaultText = "";
            this.msg_txbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.msg_txbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.msg_txbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.msg_txbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.msg_txbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.msg_txbx.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_txbx.ForeColor = System.Drawing.Color.Black;
            this.msg_txbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.msg_txbx.Location = new System.Drawing.Point(18, 66);
            this.msg_txbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msg_txbx.Multiline = true;
            this.msg_txbx.Name = "msg_txbx";
            this.msg_txbx.PasswordChar = '\0';
            this.msg_txbx.PlaceholderText = "";
            this.msg_txbx.SelectedText = "";
            this.msg_txbx.Size = new System.Drawing.Size(277, 181);
            this.msg_txbx.TabIndex = 2;
            // 
            // FeedBack_User_DataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.FeedBack_User_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FeedBack_User_DataGridView.AutoGenerateColumns = false;
            this.FeedBack_User_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FeedBack_User_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.FeedBack_User_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FeedBack_User_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FeedBack_User_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FeedBack_User_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FeedBack_User_DataGridView.ColumnHeadersHeight = 25;
            this.FeedBack_User_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FeedBack_User_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uSERNAMEDataGridViewTextBoxColumn,
            this.eMAILADDRESSDataGridViewTextBoxColumn,
            this.mESSAGEDataGridViewTextBoxColumn,
            this.dATEDataGridViewTextBoxColumn});
            this.FeedBack_User_DataGridView.DataSource = this.dELETEACCOUNTTABLEBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FeedBack_User_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.FeedBack_User_DataGridView.EnableHeadersVisualStyles = false;
            this.FeedBack_User_DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FeedBack_User_DataGridView.Location = new System.Drawing.Point(347, 72);
            this.FeedBack_User_DataGridView.Name = "FeedBack_User_DataGridView";
            this.FeedBack_User_DataGridView.RowHeadersVisible = false;
            this.FeedBack_User_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FeedBack_User_DataGridView.Size = new System.Drawing.Size(580, 337);
            this.FeedBack_User_DataGridView.TabIndex = 3;
            this.FeedBack_User_DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FeedBack_User_DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.FeedBack_User_DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.FeedBack_User_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.FeedBack_User_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.FeedBack_User_DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.FeedBack_User_DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FeedBack_User_DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FeedBack_User_DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FeedBack_User_DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.FeedBack_User_DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FeedBack_User_DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.FeedBack_User_DataGridView.ThemeStyle.HeaderStyle.Height = 25;
            this.FeedBack_User_DataGridView.ThemeStyle.ReadOnly = false;
            this.FeedBack_User_DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FeedBack_User_DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FeedBack_User_DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.FeedBack_User_DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FeedBack_User_DataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.FeedBack_User_DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FeedBack_User_DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FeedBack_User_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeedBack_User_DataGridView_CellClick);
//            this.FeedBack_User_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeedBack_User_DataGridView_CellContentClick);
            // 
            // uSERNAMEDataGridViewTextBoxColumn
            // 
            this.uSERNAMEDataGridViewTextBoxColumn.DataPropertyName = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.HeaderText = "USERNAME";
            this.uSERNAMEDataGridViewTextBoxColumn.Name = "uSERNAMEDataGridViewTextBoxColumn";
            // 
            // eMAILADDRESSDataGridViewTextBoxColumn
            // 
            this.eMAILADDRESSDataGridViewTextBoxColumn.DataPropertyName = "EMAIL ADDRESS";
            this.eMAILADDRESSDataGridViewTextBoxColumn.HeaderText = "EMAIL ADDRESS";
            this.eMAILADDRESSDataGridViewTextBoxColumn.Name = "eMAILADDRESSDataGridViewTextBoxColumn";
            // 
            // mESSAGEDataGridViewTextBoxColumn
            // 
            this.mESSAGEDataGridViewTextBoxColumn.DataPropertyName = "MESSAGE";
            this.mESSAGEDataGridViewTextBoxColumn.HeaderText = "MESSAGE";
            this.mESSAGEDataGridViewTextBoxColumn.Name = "mESSAGEDataGridViewTextBoxColumn";
            // 
            // dATEDataGridViewTextBoxColumn
            // 
            this.dATEDataGridViewTextBoxColumn.DataPropertyName = "DATE";
            this.dATEDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.dATEDataGridViewTextBoxColumn.Name = "dATEDataGridViewTextBoxColumn";
            // 
            // dELETEACCOUNTTABLEBindingSource
            // 
            this.dELETEACCOUNTTABLEBindingSource.DataMember = "DELETE_ACCOUNT_TABLE";
            this.dELETEACCOUNTTABLEBindingSource.DataSource = this.school_DBDataSet_Feedback;
            // 
            // school_DBDataSet_Feedback
            // 
            this.school_DBDataSet_Feedback.DataSetName = "School_DBDataSet_Feedback";
            this.school_DBDataSet_Feedback.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // school_DBDataSet_DELETE_ACC
            // 
            this.school_DBDataSet_DELETE_ACC.DataSetName = "School_DBDataSet_DELETE_ACC";
            this.school_DBDataSet_DELETE_ACC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NotifyGroupbox
            // 
            this.NotifyGroupbox.Controls.Add(this.DEL_BTN);
            this.NotifyGroupbox.Controls.Add(this.guna2Panel1);
            this.NotifyGroupbox.Controls.Add(this.LOAD_BTN);
            this.NotifyGroupbox.Controls.Add(this.FeedBack_User_DataGridView);
            this.NotifyGroupbox.Controls.Add(this.inbox_panel);
            this.NotifyGroupbox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NotifyGroupbox.FillColor = System.Drawing.Color.Yellow;
            this.NotifyGroupbox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotifyGroupbox.ForeColor = System.Drawing.Color.White;
            this.NotifyGroupbox.Location = new System.Drawing.Point(-1, 0);
            this.NotifyGroupbox.Name = "NotifyGroupbox";
            this.NotifyGroupbox.Size = new System.Drawing.Size(952, 489);
            this.NotifyGroupbox.TabIndex = 3;
            this.NotifyGroupbox.Text = "Notification";
            this.NotifyGroupbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(17, 72);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(313, 68);
            this.guna2Panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER\'S FEEDBACK";
            // 
            // LOAD_BTN
            // 
            this.LOAD_BTN.BackColor = System.Drawing.Color.Transparent;
            this.LOAD_BTN.BorderRadius = 10;
            this.LOAD_BTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LOAD_BTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LOAD_BTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LOAD_BTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LOAD_BTN.FillColor = System.Drawing.Color.Green;
            this.LOAD_BTN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOAD_BTN.ForeColor = System.Drawing.Color.White;
            this.LOAD_BTN.Image = ((System.Drawing.Image)(resources.GetObject("LOAD_BTN.Image")));
            this.LOAD_BTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LOAD_BTN.Location = new System.Drawing.Point(447, 425);
            this.LOAD_BTN.Name = "LOAD_BTN";
            this.LOAD_BTN.Size = new System.Drawing.Size(343, 45);
            this.LOAD_BTN.TabIndex = 4;
            this.LOAD_BTN.Text = "LOAD TABLE";
            this.LOAD_BTN.Click += new System.EventHandler(this.LOAD_BTN_Click);
            // 
            // inbox_panel
            // 
            this.inbox_panel.BackColor = System.Drawing.Color.Navy;
            this.inbox_panel.BorderColor = System.Drawing.Color.White;
            this.inbox_panel.Controls.Add(this.Email_Txbox);
            this.inbox_panel.Controls.Add(this.msg_txbx);
            this.inbox_panel.Location = new System.Drawing.Point(17, 146);
            this.inbox_panel.Name = "inbox_panel";
            this.inbox_panel.Size = new System.Drawing.Size(313, 263);
            this.inbox_panel.TabIndex = 3;
            // 
            // inbox_Elipse
            // 
            this.inbox_Elipse.BorderRadius = 10;
            this.inbox_Elipse.TargetControl = this.inbox_panel;
            // 
            // dELETE_ACCOUNT_TABLETableAdapter
            // 
            this.dELETE_ACCOUNT_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // dELETE_ACCOUNT_TABLETableAdapter1
            // 
            this.dELETE_ACCOUNT_TABLETableAdapter1.ClearBeforeFill = true;
            // 
            // dATAgRiDvIEW_Elipse
            // 
            this.dATAgRiDvIEW_Elipse.BorderRadius = 10;
            this.dATAgRiDvIEW_Elipse.TargetControl = this.FeedBack_User_DataGridView;
            // 
            // DEL_BTN
            // 
            this.DEL_BTN.BackColor = System.Drawing.Color.Transparent;
            this.DEL_BTN.BorderRadius = 10;
            this.DEL_BTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DEL_BTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DEL_BTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DEL_BTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DEL_BTN.FillColor = System.Drawing.Color.Green;
            this.DEL_BTN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEL_BTN.ForeColor = System.Drawing.Color.White;
            this.DEL_BTN.Image = ((System.Drawing.Image)(resources.GetObject("DEL_BTN.Image")));
            this.DEL_BTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DEL_BTN.Location = new System.Drawing.Point(35, 425);
            this.DEL_BTN.Name = "DEL_BTN";
            this.DEL_BTN.Size = new System.Drawing.Size(277, 45);
            this.DEL_BTN.TabIndex = 6;
            this.DEL_BTN.Text = "DELETE";
            this.DEL_BTN.Click += new System.EventHandler(this.DEL_BTN_Click);
            // 
            // Notification_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NotifyGroupbox);
            this.Name = "Notification_UserControl";
            this.Size = new System.Drawing.Size(951, 489);
            ((System.ComponentModel.ISupportInitialize)(this.FeedBack_User_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dELETEACCOUNTTABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DBDataSet_Feedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DBDataSet_DELETE_ACC)).EndInit();
            this.NotifyGroupbox.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.inbox_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Notify_Elipse;
        private Guna.UI2.WinForms.Guna2TextBox Email_Txbox;
        private Guna.UI2.WinForms.Guna2TextBox msg_txbx;
        private Guna.UI2.WinForms.Guna2DataGridView FeedBack_User_DataGridView;
        private Guna.UI2.WinForms.Guna2GroupBox NotifyGroupbox;
        private Guna.UI2.WinForms.Guna2Panel inbox_panel;
        private Guna.UI2.WinForms.Guna2Elipse inbox_Elipse;
        private School_DBDataSet_DELETE_ACC school_DBDataSet_DELETE_ACC;
        private School_DBDataSet_DELETE_ACCTableAdapters.DELETE_ACCOUNT_TABLETableAdapter dELETE_ACCOUNT_TABLETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESSAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dELETEACCOUNTTABLEBindingSource;
        private School_DBDataSet_Feedback school_DBDataSet_Feedback;
        private School_DBDataSet_FeedbackTableAdapters.DELETE_ACCOUNT_TABLETableAdapter dELETE_ACCOUNT_TABLETableAdapter1;
        private Guna.UI2.WinForms.Guna2Button LOAD_BTN;
        private Guna.UI2.WinForms.Guna2Elipse dATAgRiDvIEW_Elipse;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button DEL_BTN;
    }
}
