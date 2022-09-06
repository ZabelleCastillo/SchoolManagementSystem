namespace SchoolManagementSystem.Forms
{
    partial class ForgotPassword_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword_Form));
            this.ForgotPass_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ForgotPass_Groupbox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.SENDEMAIL_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Email_Txbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Close_Btn = new Guna.UI2.WinForms.Guna2Button();
            this.VerifyCode_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.VerifyCode_btn = new Guna.UI2.WinForms.Guna2Button();
            this.VerifyCode_Txbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.ForgotPass_Groupbox.SuspendLayout();
            this.VerifyCode_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ForgotPass_Elipse
            // 
            this.ForgotPass_Elipse.BorderRadius = 10;
            this.ForgotPass_Elipse.TargetControl = this;
            // 
            // ForgotPass_Groupbox
            // 
            this.ForgotPass_Groupbox.Controls.Add(this.VerifyCode_Panel);
            this.ForgotPass_Groupbox.Controls.Add(this.SENDEMAIL_BTN);
            this.ForgotPass_Groupbox.Controls.Add(this.guna2Panel1);
            this.ForgotPass_Groupbox.Controls.Add(this.Email_Txbox);
            this.ForgotPass_Groupbox.Controls.Add(this.Close_Btn);
            this.ForgotPass_Groupbox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ForgotPass_Groupbox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPass_Groupbox.ForeColor = System.Drawing.Color.White;
            this.ForgotPass_Groupbox.Location = new System.Drawing.Point(-1, 0);
            this.ForgotPass_Groupbox.Name = "ForgotPass_Groupbox";
            this.ForgotPass_Groupbox.Size = new System.Drawing.Size(416, 209);
            this.ForgotPass_Groupbox.TabIndex = 2;
            this.ForgotPass_Groupbox.Text = "Forgot Password";
            // 
            // SENDEMAIL_BTN
            // 
            this.SENDEMAIL_BTN.BorderRadius = 5;
            this.SENDEMAIL_BTN.Cursor = System.Windows.Forms.Cursors.Help;
            this.SENDEMAIL_BTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SENDEMAIL_BTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SENDEMAIL_BTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SENDEMAIL_BTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SENDEMAIL_BTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.SENDEMAIL_BTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SENDEMAIL_BTN.ForeColor = System.Drawing.Color.White;
            this.SENDEMAIL_BTN.Image = ((System.Drawing.Image)(resources.GetObject("SENDEMAIL_BTN.Image")));
            this.SENDEMAIL_BTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SENDEMAIL_BTN.ImageSize = new System.Drawing.Size(18, 18);
            this.SENDEMAIL_BTN.Location = new System.Drawing.Point(129, 140);
            this.SENDEMAIL_BTN.Name = "SENDEMAIL_BTN";
            this.SENDEMAIL_BTN.Size = new System.Drawing.Size(173, 35);
            this.SENDEMAIL_BTN.TabIndex = 2;
            this.SENDEMAIL_BTN.Text = "Send";
            this.SENDEMAIL_BTN.Click += new System.EventHandler(this.SENDEMAIL_BTN_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(38, 112);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(335, 5);
            this.guna2Panel1.TabIndex = 6;
            // 
            // Email_Txbox
            // 
            this.Email_Txbox.BorderThickness = 0;
            this.Email_Txbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_Txbox.DefaultText = "";
            this.Email_Txbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email_Txbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email_Txbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_Txbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_Txbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_Txbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Txbox.ForeColor = System.Drawing.Color.Green;
            this.Email_Txbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email_Txbox.Location = new System.Drawing.Point(38, 73);
            this.Email_Txbox.Name = "Email_Txbox";
            this.Email_Txbox.PasswordChar = '\0';
            this.Email_Txbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Email_Txbox.PlaceholderText = "Email Address";
            this.Email_Txbox.SelectedText = "";
            this.Email_Txbox.Size = new System.Drawing.Size(335, 41);
            this.Email_Txbox.TabIndex = 1;
            this.Email_Txbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Close_Btn.Location = new System.Drawing.Point(371, 0);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(45, 39);
            this.Close_Btn.TabIndex = 0;
            this.Close_Btn.Text = "X";
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // VerifyCode_Panel
            // 
            this.VerifyCode_Panel.BackColor = System.Drawing.Color.White;
            this.VerifyCode_Panel.Controls.Add(this.VerifyCode_btn);
            this.VerifyCode_Panel.Controls.Add(this.VerifyCode_Txbox);
            this.VerifyCode_Panel.Controls.Add(this.guna2Panel2);
            this.VerifyCode_Panel.Location = new System.Drawing.Point(-1, 70);
            this.VerifyCode_Panel.Name = "VerifyCode_Panel";
            this.VerifyCode_Panel.Size = new System.Drawing.Size(416, 123);
            this.VerifyCode_Panel.TabIndex = 4;
            this.VerifyCode_Panel.Visible = false;
            // 
            // VerifyCode_btn
            // 
            this.VerifyCode_btn.BorderRadius = 5;
            this.VerifyCode_btn.Cursor = System.Windows.Forms.Cursors.Help;
            this.VerifyCode_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.VerifyCode_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.VerifyCode_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.VerifyCode_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.VerifyCode_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.VerifyCode_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyCode_btn.ForeColor = System.Drawing.Color.White;
            this.VerifyCode_btn.Image = ((System.Drawing.Image)(resources.GetObject("VerifyCode_btn.Image")));
            this.VerifyCode_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.VerifyCode_btn.ImageSize = new System.Drawing.Size(18, 18);
            this.VerifyCode_btn.Location = new System.Drawing.Point(120, 74);
            this.VerifyCode_btn.Name = "VerifyCode_btn";
            this.VerifyCode_btn.Size = new System.Drawing.Size(173, 35);
            this.VerifyCode_btn.TabIndex = 2;
            this.VerifyCode_btn.Text = "VerifyCode";
            this.VerifyCode_btn.Click += new System.EventHandler(this.VerifyCode_btn_Click);
            // 
            // VerifyCode_Txbox
            // 
            this.VerifyCode_Txbox.BorderThickness = 0;
            this.VerifyCode_Txbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VerifyCode_Txbox.DefaultText = "";
            this.VerifyCode_Txbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.VerifyCode_Txbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.VerifyCode_Txbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VerifyCode_Txbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.VerifyCode_Txbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VerifyCode_Txbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyCode_Txbox.ForeColor = System.Drawing.Color.Green;
            this.VerifyCode_Txbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.VerifyCode_Txbox.Location = new System.Drawing.Point(29, 7);
            this.VerifyCode_Txbox.Name = "VerifyCode_Txbox";
            this.VerifyCode_Txbox.PasswordChar = '\0';
            this.VerifyCode_Txbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.VerifyCode_Txbox.PlaceholderText = "Verify Code";
            this.VerifyCode_Txbox.SelectedText = "";
            this.VerifyCode_Txbox.Size = new System.Drawing.Size(335, 41);
            this.VerifyCode_Txbox.TabIndex = 1;
            this.VerifyCode_Txbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Location = new System.Drawing.Point(29, 46);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(335, 5);
            this.guna2Panel2.TabIndex = 6;
            // 
            // ForgotPassword_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 205);
            this.Controls.Add(this.ForgotPass_Groupbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword_Form";
            this.ForgotPass_Groupbox.ResumeLayout(false);
            this.VerifyCode_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ForgotPass_Elipse;
        private Guna.UI2.WinForms.Guna2Panel VerifyCode_Panel;
        private Guna.UI2.WinForms.Guna2Button VerifyCode_btn;
        private Guna.UI2.WinForms.Guna2TextBox VerifyCode_Txbox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2GroupBox ForgotPass_Groupbox;
        private Guna.UI2.WinForms.Guna2Button SENDEMAIL_BTN;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox Email_Txbox;
        private Guna.UI2.WinForms.Guna2Button Close_Btn;
    }
}