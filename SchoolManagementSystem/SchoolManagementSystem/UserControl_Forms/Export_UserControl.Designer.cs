namespace SchoolManagementSystem.UserControl_Forms
{
    partial class Export_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_UserControl));
            this.ExportUserControl_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Subject_Groupbox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CountID_label = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudGrade_DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIDDLENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBJECTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRELIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIDTERMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pREFINALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fINALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVERAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEMARKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTUDENTGRADESYSTEMTABLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_DBDataSetFullGrades = new SchoolManagementSystem.School_DBDataSetFullGrades();
            this.EXPORT_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.SearchSubj_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Search_sTUDENT_Txbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.Close_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.sTUDENT_GRADE_SYSTEM_TABLETableAdapter = new SchoolManagementSystem.School_DBDataSetFullGradesTableAdapters.STUDENT_GRADE_SYSTEM_TABLETableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Subject_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudGrade_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTGRADESYSTEMTABLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DBDataSetFullGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportUserControl_Elipse
            // 
            this.ExportUserControl_Elipse.BorderRadius = 10;
            this.ExportUserControl_Elipse.TargetControl = this;
            // 
            // Subject_Groupbox
            // 
            this.Subject_Groupbox.Controls.Add(this.CountID_label);
            this.Subject_Groupbox.Controls.Add(this.result_label);
            this.Subject_Groupbox.Controls.Add(this.label1);
            this.Subject_Groupbox.Controls.Add(this.StudGrade_DataGridView);
            this.Subject_Groupbox.Controls.Add(this.EXPORT_BTN);
            this.Subject_Groupbox.Controls.Add(this.SearchSubj_Btn);
            this.Subject_Groupbox.Controls.Add(this.Search_sTUDENT_Txbx);
            this.Subject_Groupbox.Controls.Add(this.Close_Btn);
            this.Subject_Groupbox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Subject_Groupbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_Groupbox.ForeColor = System.Drawing.Color.White;
            this.Subject_Groupbox.Location = new System.Drawing.Point(0, 0);
            this.Subject_Groupbox.Name = "Subject_Groupbox";
            this.Subject_Groupbox.Size = new System.Drawing.Size(998, 466);
            this.Subject_Groupbox.TabIndex = 2;
            this.Subject_Groupbox.Text = "Student\'s Files";
            // 
            // CountID_label
            // 
            this.CountID_label.AutoSize = true;
            this.CountID_label.BackColor = System.Drawing.Color.Transparent;
            this.CountID_label.ForeColor = System.Drawing.Color.Black;
            this.CountID_label.Location = new System.Drawing.Point(99, 106);
            this.CountID_label.Name = "CountID_label";
            this.CountID_label.Size = new System.Drawing.Size(71, 15);
            this.CountID_label.TabIndex = 17;
            this.CountID_label.Text = "all grades";
            this.CountID_label.Visible = false;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.BackColor = System.Drawing.Color.Transparent;
            this.result_label.ForeColor = System.Drawing.Color.Black;
            this.result_label.Location = new System.Drawing.Point(81, 78);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(67, 15);
            this.result_label.TabIndex = 16;
            this.result_label.Text = "+ result +";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "There is";
            this.label1.Visible = false;
            // 
            // StudGrade_DataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.StudGrade_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudGrade_DataGridView.AutoGenerateColumns = false;
            this.StudGrade_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudGrade_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.StudGrade_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudGrade_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudGrade_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudGrade_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudGrade_DataGridView.ColumnHeadersHeight = 35;
            this.StudGrade_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StudGrade_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nAMEDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.mIDDLENAMEDataGridViewTextBoxColumn,
            this.sUBJECTDataGridViewTextBoxColumn,
            this.pRELIMDataGridViewTextBoxColumn,
            this.mIDTERMDataGridViewTextBoxColumn,
            this.pREFINALDataGridViewTextBoxColumn,
            this.fINALDataGridViewTextBoxColumn,
            this.aVERAGEDataGridViewTextBoxColumn,
            this.rEMARKDataGridViewTextBoxColumn});
            this.StudGrade_DataGridView.DataSource = this.sTUDENTGRADESYSTEMTABLEBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudGrade_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.StudGrade_DataGridView.EnableHeadersVisualStyles = false;
            this.StudGrade_DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudGrade_DataGridView.Location = new System.Drawing.Point(19, 133);
            this.StudGrade_DataGridView.Name = "StudGrade_DataGridView";
            this.StudGrade_DataGridView.RowHeadersVisible = false;
            this.StudGrade_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudGrade_DataGridView.Size = new System.Drawing.Size(958, 267);
            this.StudGrade_DataGridView.TabIndex = 3;
            this.StudGrade_DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StudGrade_DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StudGrade_DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StudGrade_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StudGrade_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StudGrade_DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.StudGrade_DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudGrade_DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StudGrade_DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StudGrade_DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StudGrade_DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StudGrade_DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.StudGrade_DataGridView.ThemeStyle.HeaderStyle.Height = 35;
            this.StudGrade_DataGridView.ThemeStyle.ReadOnly = false;
            this.StudGrade_DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StudGrade_DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudGrade_DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.StudGrade_DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudGrade_DataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.StudGrade_DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudGrade_DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LASTNAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "LASTNAME";
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            // 
            // mIDDLENAMEDataGridViewTextBoxColumn
            // 
            this.mIDDLENAMEDataGridViewTextBoxColumn.DataPropertyName = "MIDDLE NAME";
            this.mIDDLENAMEDataGridViewTextBoxColumn.HeaderText = "MIDDLE NAME";
            this.mIDDLENAMEDataGridViewTextBoxColumn.Name = "mIDDLENAMEDataGridViewTextBoxColumn";
            // 
            // sUBJECTDataGridViewTextBoxColumn
            // 
            this.sUBJECTDataGridViewTextBoxColumn.DataPropertyName = "SUBJECT";
            this.sUBJECTDataGridViewTextBoxColumn.HeaderText = "SUBJECT";
            this.sUBJECTDataGridViewTextBoxColumn.Name = "sUBJECTDataGridViewTextBoxColumn";
            // 
            // pRELIMDataGridViewTextBoxColumn
            // 
            this.pRELIMDataGridViewTextBoxColumn.DataPropertyName = "PRELIM";
            this.pRELIMDataGridViewTextBoxColumn.HeaderText = "PRELIM";
            this.pRELIMDataGridViewTextBoxColumn.Name = "pRELIMDataGridViewTextBoxColumn";
            // 
            // mIDTERMDataGridViewTextBoxColumn
            // 
            this.mIDTERMDataGridViewTextBoxColumn.DataPropertyName = "MIDTERM";
            this.mIDTERMDataGridViewTextBoxColumn.HeaderText = "MIDTERM";
            this.mIDTERMDataGridViewTextBoxColumn.Name = "mIDTERMDataGridViewTextBoxColumn";
            // 
            // pREFINALDataGridViewTextBoxColumn
            // 
            this.pREFINALDataGridViewTextBoxColumn.DataPropertyName = "PRE FINAL";
            this.pREFINALDataGridViewTextBoxColumn.HeaderText = "PRE FINAL";
            this.pREFINALDataGridViewTextBoxColumn.Name = "pREFINALDataGridViewTextBoxColumn";
            // 
            // fINALDataGridViewTextBoxColumn
            // 
            this.fINALDataGridViewTextBoxColumn.DataPropertyName = "FINAL";
            this.fINALDataGridViewTextBoxColumn.HeaderText = "FINAL";
            this.fINALDataGridViewTextBoxColumn.Name = "fINALDataGridViewTextBoxColumn";
            // 
            // aVERAGEDataGridViewTextBoxColumn
            // 
            this.aVERAGEDataGridViewTextBoxColumn.DataPropertyName = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.HeaderText = "AVERAGE";
            this.aVERAGEDataGridViewTextBoxColumn.Name = "aVERAGEDataGridViewTextBoxColumn";
            // 
            // rEMARKDataGridViewTextBoxColumn
            // 
            this.rEMARKDataGridViewTextBoxColumn.DataPropertyName = "REMARK";
            this.rEMARKDataGridViewTextBoxColumn.HeaderText = "REMARK";
            this.rEMARKDataGridViewTextBoxColumn.Name = "rEMARKDataGridViewTextBoxColumn";
            // 
            // sTUDENTGRADESYSTEMTABLEBindingSource
            // 
            this.sTUDENTGRADESYSTEMTABLEBindingSource.DataMember = "STUDENT_GRADE_SYSTEM_TABLE";
            this.sTUDENTGRADESYSTEMTABLEBindingSource.DataSource = this.school_DBDataSetFullGrades;
            // 
            // school_DBDataSetFullGrades
            // 
            this.school_DBDataSetFullGrades.DataSetName = "School_DBDataSetFullGrades";
            this.school_DBDataSetFullGrades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EXPORT_BTN
            // 
            this.EXPORT_BTN.BackColor = System.Drawing.Color.Transparent;
            this.EXPORT_BTN.BorderRadius = 12;
            this.EXPORT_BTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.EXPORT_BTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.EXPORT_BTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.EXPORT_BTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.EXPORT_BTN.FillColor = System.Drawing.Color.Green;
            this.EXPORT_BTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.EXPORT_BTN.ForeColor = System.Drawing.Color.White;
            this.EXPORT_BTN.Image = ((System.Drawing.Image)(resources.GetObject("EXPORT_BTN.Image")));
            this.EXPORT_BTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EXPORT_BTN.Location = new System.Drawing.Point(384, 421);
            this.EXPORT_BTN.Name = "EXPORT_BTN";
            this.EXPORT_BTN.Size = new System.Drawing.Size(208, 33);
            this.EXPORT_BTN.TabIndex = 4;
            this.EXPORT_BTN.Text = "EXPORT";
            this.EXPORT_BTN.Click += new System.EventHandler(this.EXPORT_BTN_Click);
            // 
            // SearchSubj_Btn
            // 
            this.SearchSubj_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchSubj_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchSubj_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchSubj_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchSubj_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchSubj_Btn.ForeColor = System.Drawing.Color.White;
            this.SearchSubj_Btn.Image = ((System.Drawing.Image)(resources.GetObject("SearchSubj_Btn.Image")));
            this.SearchSubj_Btn.ImageSize = new System.Drawing.Size(18, 18);
            this.SearchSubj_Btn.Location = new System.Drawing.Point(794, 2);
            this.SearchSubj_Btn.Name = "SearchSubj_Btn";
            this.SearchSubj_Btn.Size = new System.Drawing.Size(35, 35);
            this.SearchSubj_Btn.TabIndex = 2;
            this.SearchSubj_Btn.Visible = false;
            // 
            // Search_sTUDENT_Txbx
            // 
            this.Search_sTUDENT_Txbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Search_sTUDENT_Txbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Search_sTUDENT_Txbx.BorderRadius = 5;
            this.Search_sTUDENT_Txbx.BorderThickness = 0;
            this.Search_sTUDENT_Txbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_sTUDENT_Txbx.DefaultText = "";
            this.Search_sTUDENT_Txbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_sTUDENT_Txbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_sTUDENT_Txbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_sTUDENT_Txbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_sTUDENT_Txbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_sTUDENT_Txbx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_sTUDENT_Txbx.ForeColor = System.Drawing.Color.Green;
            this.Search_sTUDENT_Txbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_sTUDENT_Txbx.Location = new System.Drawing.Point(546, 2);
            this.Search_sTUDENT_Txbx.Name = "Search_sTUDENT_Txbx";
            this.Search_sTUDENT_Txbx.PasswordChar = '\0';
            this.Search_sTUDENT_Txbx.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Search_sTUDENT_Txbx.PlaceholderText = "Student ID or Name";
            this.Search_sTUDENT_Txbx.SelectedText = "";
            this.Search_sTUDENT_Txbx.Size = new System.Drawing.Size(248, 35);
            this.Search_sTUDENT_Txbx.TabIndex = 1;
            this.Search_sTUDENT_Txbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search_sTUDENT_Txbx.Visible = false;
            // 
            // Close_Btn
            // 
            this.Close_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Close_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Close_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Close_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Close_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Close_Btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Btn.ForeColor = System.Drawing.Color.White;
            this.Close_Btn.Location = new System.Drawing.Point(950, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(45, 39);
            this.Close_Btn.TabIndex = 5;
            this.Close_Btn.Text = "X";
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // sTUDENT_GRADE_SYSTEM_TABLETableAdapter
            // 
            this.sTUDENT_GRADE_SYSTEM_TABLETableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Export_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Subject_Groupbox);
            this.Name = "Export_UserControl";
            this.Size = new System.Drawing.Size(998, 466);
            this.Load += new System.EventHandler(this.Export_UserControl_Load);
            this.Subject_Groupbox.ResumeLayout(false);
            this.Subject_Groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudGrade_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTGRADESYSTEMTABLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_DBDataSetFullGrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ExportUserControl_Elipse;
        private Guna.UI2.WinForms.Guna2GroupBox Subject_Groupbox;
        private Guna.UI2.WinForms.Guna2Button SearchSubj_Btn;
        private Guna.UI2.WinForms.Guna2TextBox Search_sTUDENT_Txbx;
        private Guna.UI2.WinForms.Guna2Button Close_Btn;
        private Guna.UI2.WinForms.Guna2Button EXPORT_BTN;
        private Guna.UI2.WinForms.Guna2DataGridView StudGrade_DataGridView;
        private System.Windows.Forms.Label CountID_label;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDDLENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBJECTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRELIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIDTERMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pREFINALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fINALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVERAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEMARKDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sTUDENTGRADESYSTEMTABLEBindingSource;
        private School_DBDataSetFullGrades school_DBDataSetFullGrades;
        private School_DBDataSetFullGradesTableAdapters.STUDENT_GRADE_SYSTEM_TABLETableAdapter sTUDENT_GRADE_SYSTEM_TABLETableAdapter;
        private System.Windows.Forms.Timer timer1;
    }
}
