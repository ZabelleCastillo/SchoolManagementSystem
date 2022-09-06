namespace SchoolManagementSystem.UserControl_Forms
{
    partial class AddSubject_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubject_UserControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddSubject_UserControl_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Subject_Groupbox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.name_label = new System.Windows.Forms.Label();
            this.count_label = new System.Windows.Forms.Label();
            this.ADDSUBJ_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.SearchSubj_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.AddSubj_Txbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Search_Subj_Txbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.Close_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Student_DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.sUBJECTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDNEWSUBJECTTABLEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
  //          this.sCHOOL_DB1DataSet_Subjects = new SchoolManagementSystem.SCHOOL_DB1DataSet_Subjects();
  //          this.aDD_NEW_SUBJECT_TABLETableAdapter1 = new SchoolManagementSystem.SCHOOL_DB1DataSet_SubjectsTableAdapters.ADD_NEW_SUBJECT_TABLETableAdapter();
            this.Subject_Timer = new System.Windows.Forms.Timer(this.components);
            this.SUBJECT_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LOAD_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Subject_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Student_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDNEWSUBJECTTABLEBindingSource1)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.sCHOOL_DB1DataSet_Subjects)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSubject_UserControl_Elipse
            // 
            this.AddSubject_UserControl_Elipse.BorderRadius = 10;
            this.AddSubject_UserControl_Elipse.TargetControl = this;
            // 
            // Subject_Groupbox
            // 
            this.Subject_Groupbox.Controls.Add(this.guna2Panel2);
            this.Subject_Groupbox.Controls.Add(this.ADDSUBJ_BTN);
            this.Subject_Groupbox.Controls.Add(this.SearchSubj_Btn);
            this.Subject_Groupbox.Controls.Add(this.guna2Panel1);
            this.Subject_Groupbox.Controls.Add(this.AddSubj_Txbox);
            this.Subject_Groupbox.Controls.Add(this.Search_Subj_Txbx);
            this.Subject_Groupbox.Controls.Add(this.Close_Btn);
            this.Subject_Groupbox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Subject_Groupbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_Groupbox.ForeColor = System.Drawing.Color.White;
            this.Subject_Groupbox.Location = new System.Drawing.Point(-1, 0);
            this.Subject_Groupbox.Name = "Subject_Groupbox";
            this.Subject_Groupbox.Size = new System.Drawing.Size(744, 123);
            this.Subject_Groupbox.TabIndex = 1;
            this.Subject_Groupbox.Text = "SUBJECTS";
            this.Subject_Groupbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.Black;
            this.name_label.Location = new System.Drawing.Point(401, 454);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(14, 20);
            this.name_label.TabIndex = 8;
            this.name_label.Text = ".";
            // 
            // count_label
            // 
            this.count_label.AutoSize = true;
            this.count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_label.ForeColor = System.Drawing.Color.Black;
            this.count_label.Location = new System.Drawing.Point(334, 454);
            this.count_label.Name = "count_label";
            this.count_label.Size = new System.Drawing.Size(54, 20);
            this.count_label.TabIndex = 7;
            this.count_label.Text = "result";
            // 
            // ADDSUBJ_BTN
            // 
            this.ADDSUBJ_BTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ADDSUBJ_BTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ADDSUBJ_BTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ADDSUBJ_BTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ADDSUBJ_BTN.FillColor = System.Drawing.Color.White;
            this.ADDSUBJ_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ADDSUBJ_BTN.ForeColor = System.Drawing.Color.White;
            this.ADDSUBJ_BTN.Image = ((System.Drawing.Image)(resources.GetObject("ADDSUBJ_BTN.Image")));
            this.ADDSUBJ_BTN.ImageSize = new System.Drawing.Size(18, 18);
            this.ADDSUBJ_BTN.Location = new System.Drawing.Point(354, 69);
            this.ADDSUBJ_BTN.Name = "ADDSUBJ_BTN";
            this.ADDSUBJ_BTN.Size = new System.Drawing.Size(35, 35);
            this.ADDSUBJ_BTN.TabIndex = 4;
            this.ADDSUBJ_BTN.Click += new System.EventHandler(this.ADDSUBJ_BTN_Click);
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
            this.SearchSubj_Btn.Location = new System.Drawing.Point(661, 68);
            this.SearchSubj_Btn.Name = "SearchSubj_Btn";
            this.SearchSubj_Btn.Size = new System.Drawing.Size(35, 35);
            this.SearchSubj_Btn.TabIndex = 2;
            this.SearchSubj_Btn.Click += new System.EventHandler(this.SearchSubj_Btn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(15, 101);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(335, 5);
            this.guna2Panel1.TabIndex = 6;
            // 
            // AddSubj_Txbox
            // 
            this.AddSubj_Txbox.BorderThickness = 0;
            this.AddSubj_Txbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddSubj_Txbox.DefaultText = "";
            this.AddSubj_Txbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddSubj_Txbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddSubj_Txbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddSubj_Txbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddSubj_Txbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddSubj_Txbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSubj_Txbox.ForeColor = System.Drawing.Color.Green;
            this.AddSubj_Txbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddSubj_Txbox.Location = new System.Drawing.Point(15, 62);
            this.AddSubj_Txbox.Name = "AddSubj_Txbox";
            this.AddSubj_Txbox.PasswordChar = '\0';
            this.AddSubj_Txbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.AddSubj_Txbox.PlaceholderText = "Add Subject";
            this.AddSubj_Txbox.SelectedText = "";
            this.AddSubj_Txbox.Size = new System.Drawing.Size(335, 41);
            this.AddSubj_Txbox.TabIndex = 3;
            this.AddSubj_Txbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddSubj_Txbox.TextChanged += new System.EventHandler(this.AddSubj_Txbox_TextChanged);
            // 
            // Search_Subj_Txbx
            // 
            this.Search_Subj_Txbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Search_Subj_Txbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Search_Subj_Txbx.BackColor = System.Drawing.Color.Transparent;
            this.Search_Subj_Txbx.BorderRadius = 5;
            this.Search_Subj_Txbx.BorderThickness = 0;
            this.Search_Subj_Txbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_Subj_Txbx.DefaultText = "";
            this.Search_Subj_Txbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_Subj_Txbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_Subj_Txbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_Subj_Txbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_Subj_Txbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_Subj_Txbx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Subj_Txbx.ForeColor = System.Drawing.Color.Green;
            this.Search_Subj_Txbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_Subj_Txbx.Location = new System.Drawing.Point(466, 68);
            this.Search_Subj_Txbx.Name = "Search_Subj_Txbx";
            this.Search_Subj_Txbx.PasswordChar = '\0';
            this.Search_Subj_Txbx.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Search_Subj_Txbx.PlaceholderText = "Search Subject";
            this.Search_Subj_Txbx.SelectedText = "";
            this.Search_Subj_Txbx.Size = new System.Drawing.Size(197, 35);
            this.Search_Subj_Txbx.TabIndex = 1;
            this.Search_Subj_Txbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Search_Subj_Txbx.TextChanged += new System.EventHandler(this.Search_Subj_Txbx_TextChanged);
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
            this.Close_Btn.Location = new System.Drawing.Point(699, 1);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(45, 39);
            this.Close_Btn.TabIndex = 0;
            this.Close_Btn.Text = "X";
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // Student_DataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.Student_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Student_DataGridView.AutoGenerateColumns = false;
            this.Student_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Student_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Student_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Student_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Student_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Student_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Student_DataGridView.ColumnHeadersHeight = 29;
            this.Student_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Student_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sUBJECTSDataGridViewTextBoxColumn});
            this.Student_DataGridView.DataSource = this.aDDNEWSUBJECTTABLEBindingSource1;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Student_DataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.Student_DataGridView.EnableHeadersVisualStyles = false;
            this.Student_DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Student_DataGridView.Location = new System.Drawing.Point(14, 129);
            this.Student_DataGridView.Name = "Student_DataGridView";
            this.Student_DataGridView.RowHeadersVisible = false;
            this.Student_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Student_DataGridView.Size = new System.Drawing.Size(712, 312);
            this.Student_DataGridView.TabIndex = 5;
            this.Student_DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Student_DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Student_DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Student_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Student_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Student_DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Student_DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Student_DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Student_DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Student_DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Student_DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Student_DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Student_DataGridView.ThemeStyle.HeaderStyle.Height = 29;
            this.Student_DataGridView.ThemeStyle.ReadOnly = false;
            this.Student_DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Student_DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Student_DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Student_DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Student_DataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.Student_DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Student_DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Student_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Student_DataGridView_CellContentClick);
            // 
            // sUBJECTSDataGridViewTextBoxColumn
            // 
            this.sUBJECTSDataGridViewTextBoxColumn.DataPropertyName = "SUBJECTS";
            this.sUBJECTSDataGridViewTextBoxColumn.HeaderText = "SUBJECTS";
            this.sUBJECTSDataGridViewTextBoxColumn.Name = "sUBJECTSDataGridViewTextBoxColumn";
            // 
            // aDDNEWSUBJECTTABLEBindingSource1
            // 
            this.aDDNEWSUBJECTTABLEBindingSource1.DataMember = "ADD_NEW_SUBJECT_TABLE";
   //         this.aDDNEWSUBJECTTABLEBindingSource1.DataSource = this.sCHOOL_DB1DataSet_Subjects;
            // 
            // sCHOOL_DB1DataSet_Subjects
            // 
  //          this.sCHOOL_DB1DataSet_Subjects.DataSetName = "SCHOOL_DB1DataSet_Subjects";
  //          this.sCHOOL_DB1DataSet_Subjects.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aDD_NEW_SUBJECT_TABLETableAdapter1
            // 
  //          this.aDD_NEW_SUBJECT_TABLETableAdapter1.ClearBeforeFill = true;
            // 
            // Subject_Timer
            // 
            this.Subject_Timer.Tick += new System.EventHandler(this.Subject_Timer_Tick);
            // 
            // SUBJECT_Elipse
            // 
            this.SUBJECT_Elipse.BorderRadius = 10;
            this.SUBJECT_Elipse.TargetControl = this.Student_DataGridView;
            // 
            // LOAD_BTN
            // 
            this.LOAD_BTN.BorderRadius = 12;
            this.LOAD_BTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LOAD_BTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LOAD_BTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LOAD_BTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LOAD_BTN.FillColor = System.Drawing.Color.Green;
            this.LOAD_BTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOAD_BTN.ForeColor = System.Drawing.Color.White;
            this.LOAD_BTN.Location = new System.Drawing.Point(573, 447);
            this.LOAD_BTN.Name = "LOAD_BTN";
            this.LOAD_BTN.Size = new System.Drawing.Size(141, 36);
            this.LOAD_BTN.TabIndex = 9;
            this.LOAD_BTN.Text = "REFRESH";
            this.LOAD_BTN.Click += new System.EventHandler(this.LOAD_BTN_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Location = new System.Drawing.Point(466, 101);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(230, 5);
            this.guna2Panel2.TabIndex = 10;
            // 
            // AddSubject_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.LOAD_BTN);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.Student_DataGridView);
            this.Controls.Add(this.Subject_Groupbox);
            this.Controls.Add(this.count_label);
            this.Name = "AddSubject_UserControl";
            this.Size = new System.Drawing.Size(743, 492);
            this.Load += new System.EventHandler(this.AddSubject_UserControl_Load);
            this.Subject_Groupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Student_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aDDNEWSUBJECTTABLEBindingSource1)).EndInit();
  //          ((System.ComponentModel.ISupportInitialize)(this.sCHOOL_DB1DataSet_Subjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse AddSubject_UserControl_Elipse;
        private Guna.UI2.WinForms.Guna2GroupBox Subject_Groupbox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox AddSubj_Txbox;
        private Guna.UI2.WinForms.Guna2TextBox Search_Subj_Txbx;
        private Guna.UI2.WinForms.Guna2Button Close_Btn;
        private Guna.UI2.WinForms.Guna2Button SearchSubj_Btn;
        private Guna.UI2.WinForms.Guna2DataGridView Student_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBJECTSDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button ADDSUBJ_BTN;
        private System.Windows.Forms.BindingSource aDDNEWSUBJECTTABLEBindingSource1;
//        private SCHOOL_DB1DataSet_Subjects sCHOOL_DB1DataSet_Subjects;
 //       private SCHOOL_DB1DataSet_SubjectsTableAdapters.ADD_NEW_SUBJECT_TABLETableAdapter aDD_NEW_SUBJECT_TABLETableAdapter1;
        private System.Windows.Forms.Label count_label;
        private System.Windows.Forms.Timer Subject_Timer;
        private System.Windows.Forms.Label name_label;
        private Guna.UI2.WinForms.Guna2Button LOAD_BTN;
        private Guna.UI2.WinForms.Guna2Elipse SUBJECT_Elipse;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
