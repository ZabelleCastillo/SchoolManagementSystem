namespace SchoolManagementSystem.UserControl_Forms
{
    partial class Inbox_UserControl
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
            this.Inbox_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Email_Groupbox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SEND_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Body_Txbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.subject_Txbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.to_txbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.FROM_tXBOX = new Guna.UI2.WinForms.Guna2TextBox();
            this.Close_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.Email_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Inbox_Elipse
            // 
            this.Inbox_Elipse.BorderRadius = 10;
            this.Inbox_Elipse.TargetControl = this;
            // 
            // Email_Groupbox
            // 
            this.Email_Groupbox.Controls.Add(this.label4);
            this.Email_Groupbox.Controls.Add(this.SEND_BTN);
            this.Email_Groupbox.Controls.Add(this.label3);
            this.Email_Groupbox.Controls.Add(this.label2);
            this.Email_Groupbox.Controls.Add(this.label1);
            this.Email_Groupbox.Controls.Add(this.Body_Txbx);
            this.Email_Groupbox.Controls.Add(this.subject_Txbx);
            this.Email_Groupbox.Controls.Add(this.to_txbx);
            this.Email_Groupbox.Controls.Add(this.FROM_tXBOX);
            this.Email_Groupbox.Controls.Add(this.Close_Btn);
            this.Email_Groupbox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Email_Groupbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email_Groupbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Groupbox.ForeColor = System.Drawing.Color.White;
            this.Email_Groupbox.Location = new System.Drawing.Point(-1, 0);
            this.Email_Groupbox.Name = "Email_Groupbox";
            this.Email_Groupbox.Size = new System.Drawing.Size(744, 450);
            this.Email_Groupbox.TabIndex = 2;
            this.Email_Groupbox.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "FROM :";
            // 
            // SEND_BTN
            // 
            this.SEND_BTN.BackColor = System.Drawing.Color.Transparent;
            this.SEND_BTN.BorderRadius = 9;
            this.SEND_BTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SEND_BTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SEND_BTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SEND_BTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SEND_BTN.FillColor = System.Drawing.Color.Green;
            this.SEND_BTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEND_BTN.ForeColor = System.Drawing.Color.White;
            this.SEND_BTN.Location = new System.Drawing.Point(282, 398);
            this.SEND_BTN.Name = "SEND_BTN";
            this.SEND_BTN.Size = new System.Drawing.Size(180, 38);
            this.SEND_BTN.TabIndex = 5;
            this.SEND_BTN.Text = "SEND";
            this.SEND_BTN.Click += new System.EventHandler(this.SEND_BTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "BODY :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "SUBJECT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "TO :";
            // 
            // Body_Txbx
            // 
            this.Body_Txbx.AutoScroll = true;
            this.Body_Txbx.BackColor = System.Drawing.Color.Transparent;
            this.Body_Txbx.BorderRadius = 10;
            this.Body_Txbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Body_Txbx.DefaultText = "";
            this.Body_Txbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Body_Txbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Body_Txbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Body_Txbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Body_Txbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Body_Txbx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Body_Txbx.ForeColor = System.Drawing.Color.Black;
            this.Body_Txbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Body_Txbx.Location = new System.Drawing.Point(128, 198);
            this.Body_Txbx.Multiline = true;
            this.Body_Txbx.Name = "Body_Txbx";
            this.Body_Txbx.PasswordChar = '\0';
            this.Body_Txbx.PlaceholderText = "";
            this.Body_Txbx.SelectedText = "";
            this.Body_Txbx.Size = new System.Drawing.Size(537, 178);
            this.Body_Txbx.TabIndex = 4;
            this.Body_Txbx.TextChanged += new System.EventHandler(this.Body_Txbx_TextChanged);
            // 
            // subject_Txbx
            // 
            this.subject_Txbx.BackColor = System.Drawing.Color.Transparent;
            this.subject_Txbx.BorderRadius = 10;
            this.subject_Txbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subject_Txbx.DefaultText = "";
            this.subject_Txbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.subject_Txbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.subject_Txbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subject_Txbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subject_Txbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subject_Txbx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subject_Txbx.ForeColor = System.Drawing.Color.Black;
            this.subject_Txbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subject_Txbx.Location = new System.Drawing.Point(128, 156);
            this.subject_Txbx.Name = "subject_Txbx";
            this.subject_Txbx.PasswordChar = '\0';
            this.subject_Txbx.PlaceholderText = "";
            this.subject_Txbx.SelectedText = "";
            this.subject_Txbx.Size = new System.Drawing.Size(296, 36);
            this.subject_Txbx.TabIndex = 3;
            this.subject_Txbx.TextChanged += new System.EventHandler(this.subject_Txbx_TextChanged);
            // 
            // to_txbx
            // 
            this.to_txbx.BackColor = System.Drawing.Color.Transparent;
            this.to_txbx.BorderRadius = 10;
            this.to_txbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.to_txbx.DefaultText = "";
            this.to_txbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.to_txbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.to_txbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.to_txbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.to_txbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.to_txbx.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_txbx.ForeColor = System.Drawing.Color.Black;
            this.to_txbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.to_txbx.Location = new System.Drawing.Point(128, 114);
            this.to_txbx.Name = "to_txbx";
            this.to_txbx.PasswordChar = '\0';
            this.to_txbx.PlaceholderText = "";
            this.to_txbx.SelectedText = "";
            this.to_txbx.Size = new System.Drawing.Size(296, 36);
            this.to_txbx.TabIndex = 2;
            this.to_txbx.TextChanged += new System.EventHandler(this.to_txbx_TextChanged);
            // 
            // FROM_tXBOX
            // 
            this.FROM_tXBOX.BackColor = System.Drawing.Color.Transparent;
            this.FROM_tXBOX.BorderRadius = 10;
            this.FROM_tXBOX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FROM_tXBOX.DefaultText = "castillobillyjess@gmail.com";
            this.FROM_tXBOX.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FROM_tXBOX.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FROM_tXBOX.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FROM_tXBOX.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FROM_tXBOX.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FROM_tXBOX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FROM_tXBOX.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FROM_tXBOX.Location = new System.Drawing.Point(128, 72);
            this.FROM_tXBOX.Name = "FROM_tXBOX";
            this.FROM_tXBOX.PasswordChar = '\0';
            this.FROM_tXBOX.PlaceholderText = "";
            this.FROM_tXBOX.SelectedText = "";
            this.FROM_tXBOX.Size = new System.Drawing.Size(296, 36);
            this.FROM_tXBOX.TabIndex = 1;
            this.FROM_tXBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Close_Btn.TabIndex = 6;
            this.Close_Btn.Text = "X";
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // Inbox_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Email_Groupbox);
            this.Name = "Inbox_UserControl";
            this.Size = new System.Drawing.Size(743, 449);
            this.Email_Groupbox.ResumeLayout(false);
            this.Email_Groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Inbox_Elipse;
        private Guna.UI2.WinForms.Guna2GroupBox Email_Groupbox;
        private Guna.UI2.WinForms.Guna2TextBox Body_Txbx;
        private Guna.UI2.WinForms.Guna2TextBox subject_Txbx;
        private Guna.UI2.WinForms.Guna2TextBox to_txbx;
        private Guna.UI2.WinForms.Guna2TextBox FROM_tXBOX;
        private Guna.UI2.WinForms.Guna2Button Close_Btn;
        private Guna.UI2.WinForms.Guna2Button SEND_BTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}
