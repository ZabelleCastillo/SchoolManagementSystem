namespace SchoolManagementSystem.UserControl_Forms
{
    partial class DeleteStudent_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStudent_UserControl));
            this.DeleteStud_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.StudID_Groupbox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Close_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.STUDENT_ID_TXBX = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchSTUDid_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.StudID_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeleteStud_Elipse
            // 
            this.DeleteStud_Elipse.BorderRadius = 10;
            this.DeleteStud_Elipse.TargetControl = this;
            // 
            // StudID_Groupbox
            // 
            this.StudID_Groupbox.BackColor = System.Drawing.Color.DimGray;
            this.StudID_Groupbox.Controls.Add(this.SearchSTUDid_Btn);
            this.StudID_Groupbox.Controls.Add(this.Close_Btn);
            this.StudID_Groupbox.Controls.Add(this.STUDENT_ID_TXBX);
            this.StudID_Groupbox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StudID_Groupbox.FillColor = System.Drawing.Color.Transparent;
            this.StudID_Groupbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudID_Groupbox.ForeColor = System.Drawing.Color.White;
            this.StudID_Groupbox.Location = new System.Drawing.Point(-1, 0);
            this.StudID_Groupbox.Name = "StudID_Groupbox";
            this.StudID_Groupbox.Size = new System.Drawing.Size(389, 205);
            this.StudID_Groupbox.TabIndex = 2;
            this.StudID_Groupbox.Text = "Delete student";
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
            this.Close_Btn.Location = new System.Drawing.Point(341, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(45, 39);
            this.Close_Btn.TabIndex = 0;
            this.Close_Btn.Text = "X";
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // STUDENT_ID_TXBX
            // 
            this.STUDENT_ID_TXBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.STUDENT_ID_TXBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.STUDENT_ID_TXBX.BorderRadius = 5;
            this.STUDENT_ID_TXBX.BorderThickness = 0;
            this.STUDENT_ID_TXBX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.STUDENT_ID_TXBX.DefaultText = "";
            this.STUDENT_ID_TXBX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.STUDENT_ID_TXBX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.STUDENT_ID_TXBX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STUDENT_ID_TXBX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.STUDENT_ID_TXBX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STUDENT_ID_TXBX.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STUDENT_ID_TXBX.ForeColor = System.Drawing.Color.Green;
            this.STUDENT_ID_TXBX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.STUDENT_ID_TXBX.Location = new System.Drawing.Point(40, 94);
            this.STUDENT_ID_TXBX.Name = "STUDENT_ID_TXBX";
            this.STUDENT_ID_TXBX.PasswordChar = '\0';
            this.STUDENT_ID_TXBX.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.STUDENT_ID_TXBX.PlaceholderText = "Search Student ID";
            this.STUDENT_ID_TXBX.SelectedText = "";
            this.STUDENT_ID_TXBX.Size = new System.Drawing.Size(256, 35);
            this.STUDENT_ID_TXBX.TabIndex = 1;
            this.STUDENT_ID_TXBX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchSTUDid_Btn
            // 
            this.SearchSTUDid_Btn.BorderRadius = 6;
            this.SearchSTUDid_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchSTUDid_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchSTUDid_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchSTUDid_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchSTUDid_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchSTUDid_Btn.ForeColor = System.Drawing.Color.White;
            this.SearchSTUDid_Btn.Image = ((System.Drawing.Image)(resources.GetObject("SearchSTUDid_Btn.Image")));
            this.SearchSTUDid_Btn.ImageSize = new System.Drawing.Size(18, 18);
            this.SearchSTUDid_Btn.Location = new System.Drawing.Point(298, 94);
            this.SearchSTUDid_Btn.Name = "SearchSTUDid_Btn";
            this.SearchSTUDid_Btn.Size = new System.Drawing.Size(41, 35);
            this.SearchSTUDid_Btn.TabIndex = 2;
            this.SearchSTUDid_Btn.Click += new System.EventHandler(this.SearchSTUDid_Btn_Click);
            // 
            // DeleteStudent_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.StudID_Groupbox);
            this.Name = "DeleteStudent_UserControl";
            this.Size = new System.Drawing.Size(388, 204);
            this.StudID_Groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse DeleteStud_Elipse;
        private Guna.UI2.WinForms.Guna2GroupBox StudID_Groupbox;
        private Guna.UI2.WinForms.Guna2Button SearchSTUDid_Btn;
        private Guna.UI2.WinForms.Guna2TextBox STUDENT_ID_TXBX;
        private Guna.UI2.WinForms.Guna2Button Close_Btn;
    }
}
