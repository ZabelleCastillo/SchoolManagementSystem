namespace SchoolManagementSystem.UserControl_Forms
{
    partial class DeactivateAccout_UserControl
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
            this.DeactivateAcc_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label = new System.Windows.Forms.Label();
            this.Continue_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.PASSWORD_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Username_Txbx = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // DeactivateAcc_Elipse
            // 
            this.DeactivateAcc_Elipse.BorderRadius = 10;
            this.DeactivateAcc_Elipse.TargetControl = this;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(21, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(364, 16);
            this.label.TabIndex = 0;
            this.label.Text = "For your security, please re-enter your password to continue.";
            // 
            // Continue_BTN
            // 
            this.Continue_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Continue_BTN.BorderRadius = 12;
            this.Continue_BTN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Continue_BTN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Continue_BTN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Continue_BTN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Continue_BTN.FillColor = System.Drawing.Color.Green;
            this.Continue_BTN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Continue_BTN.ForeColor = System.Drawing.Color.White;
            this.Continue_BTN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Continue_BTN.Location = new System.Drawing.Point(24, 124);
            this.Continue_BTN.Name = "Continue_BTN";
            this.Continue_BTN.Size = new System.Drawing.Size(361, 33);
            this.Continue_BTN.TabIndex = 6;
            this.Continue_BTN.Text = "CONTINUE";
            this.Continue_BTN.Click += new System.EventHandler(this.Continue_BTN_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.guna2Panel3.Location = new System.Drawing.Point(24, 104);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(361, 5);
            this.guna2Panel3.TabIndex = 7;
            // 
            // PASSWORD_TextBox
            // 
            this.PASSWORD_TextBox.BorderThickness = 0;
            this.PASSWORD_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PASSWORD_TextBox.DefaultText = "";
            this.PASSWORD_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PASSWORD_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PASSWORD_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PASSWORD_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PASSWORD_TextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PASSWORD_TextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD_TextBox.ForeColor = System.Drawing.Color.Green;
            this.PASSWORD_TextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PASSWORD_TextBox.Location = new System.Drawing.Point(24, 65);
            this.PASSWORD_TextBox.Name = "PASSWORD_TextBox";
            this.PASSWORD_TextBox.PasswordChar = '⬤';
            this.PASSWORD_TextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.PASSWORD_TextBox.PlaceholderText = "Password";
            this.PASSWORD_TextBox.SelectedText = "";
            this.PASSWORD_TextBox.Size = new System.Drawing.Size(361, 41);
            this.PASSWORD_TextBox.TabIndex = 5;
            this.PASSWORD_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Username_Txbx
            // 
            this.Username_Txbx.BorderThickness = 0;
            this.Username_Txbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_Txbx.DefaultText = "";
            this.Username_Txbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username_Txbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username_Txbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_Txbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_Txbx.FillColor = System.Drawing.Color.Black;
            this.Username_Txbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username_Txbx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Txbx.ForeColor = System.Drawing.Color.Green;
            this.Username_Txbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Username_Txbx.Location = new System.Drawing.Point(24, 208);
            this.Username_Txbx.Name = "Username_Txbx";
            this.Username_Txbx.PasswordChar = '\0';
            this.Username_Txbx.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.Username_Txbx.PlaceholderText = "Username";
            this.Username_Txbx.SelectedText = "";
            this.Username_Txbx.Size = new System.Drawing.Size(361, 41);
            this.Username_Txbx.TabIndex = 8;
            this.Username_Txbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DeactivateAccout_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Username_Txbx);
            this.Controls.Add(this.Continue_BTN);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.PASSWORD_TextBox);
            this.Controls.Add(this.label);
            this.Name = "DeactivateAccout_UserControl";
            this.Size = new System.Drawing.Size(413, 188);
            this.Load += new System.EventHandler(this.DeactivateAccout_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse DeactivateAcc_Elipse;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2Button Continue_BTN;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2TextBox PASSWORD_TextBox;
        private Guna.UI2.WinForms.Guna2TextBox Username_Txbx;
    }
}
