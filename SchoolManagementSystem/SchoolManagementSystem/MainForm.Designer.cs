namespace SchoolManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainForm_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Design_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.start_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Load_ProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.InitializingLabel = new System.Windows.Forms.Label();
            this.ProgressBar_Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Design_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainForm_Elipse
            // 
            this.MainForm_Elipse.BorderRadius = 8;
            this.MainForm_Elipse.TargetControl = this;
            // 
            // Design_Panel
            // 
            this.Design_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Design_Panel.BackgroundImage")));
            this.Design_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Design_Panel.Controls.Add(this.start_btn);
            this.Design_Panel.Controls.Add(this.guna2PictureBox1);
            this.Design_Panel.Location = new System.Drawing.Point(-1, -1);
            this.Design_Panel.Name = "Design_Panel";
            this.Design_Panel.Size = new System.Drawing.Size(452, 166);
            this.Design_Panel.TabIndex = 0;
            // 
            // start_btn
            // 
            this.start_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.start_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.start_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.start_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.start_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(13, 14);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(53, 29);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "strt";
            this.start_btn.Visible = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::SchoolManagementSystem.Properties.Resources.snhs_logo_2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(306, 13);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(133, 115);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Load_ProgressBar
            // 
            this.Load_ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.Load_ProgressBar.BorderRadius = 10;
            this.Load_ProgressBar.FillColor = System.Drawing.Color.Transparent;
            this.Load_ProgressBar.Location = new System.Drawing.Point(-1, 194);
            this.Load_ProgressBar.Name = "Load_ProgressBar";
            this.Load_ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Load_ProgressBar.Size = new System.Drawing.Size(452, 10);
            this.Load_ProgressBar.TabIndex = 1;
            this.Load_ProgressBar.Text = "Load_ProgressBar";
            this.Load_ProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // InitializingLabel
            // 
            this.InitializingLabel.AutoSize = true;
            this.InitializingLabel.BackColor = System.Drawing.Color.Transparent;
            this.InitializingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitializingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InitializingLabel.Location = new System.Drawing.Point(244, 169);
            this.InitializingLabel.Name = "InitializingLabel";
            this.InitializingLabel.Size = new System.Drawing.Size(0, 15);
            this.InitializingLabel.TabIndex = 2;
            // 
            // ProgressBar_Timer
            // 
            this.ProgressBar_Timer.Enabled = true;
            this.ProgressBar_Timer.Interval = 50;
            this.ProgressBar_Timer.Tick += new System.EventHandler(this.ProgressBar_Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(40, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sogod National High School | Developed by Zabelle Castillo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(134, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "© 2022 | All Rights Reserved.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 259);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InitializingLabel);
            this.Controls.Add(this.Load_ProgressBar);
            this.Controls.Add(this.Design_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Design_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse MainForm_Elipse;
        private Guna.UI2.WinForms.Guna2Panel Design_Panel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label InitializingLabel;
        private Guna.UI2.WinForms.Guna2ProgressBar Load_ProgressBar;
        private Guna.UI2.WinForms.Guna2Button start_btn;
        private System.Windows.Forms.Timer ProgressBar_Timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

