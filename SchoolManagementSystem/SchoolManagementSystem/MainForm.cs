using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        /*THE MAIN FORM WILL HIDE AFTER PROGRESSING THE BAR INTO 100%
         AND THE SECURITY FORM WILL SHOW */
            start_btn.Location = new Point(0, -100);
        }

        private void ProgressBar_Timer_Tick(object sender, EventArgs e)
        {
            Load_ProgressBar.Value++;
            if (Load_ProgressBar.Value == 100)
            {
                ProgressBar_Timer.Stop();
                start_btn.PerformClick();
            }
            if (Load_ProgressBar.Value == 10)
            {
                InitializingLabel.Location = new Point(160, 170); /* NEW POINT, IS TO ALIGN AND ASSIGN ALL LABEL TEXT WHERE ITS LOCATED */
                InitializingLabel.Text = "Welcome to SNHS";
            }
            if (Load_ProgressBar.Value == 30)
            {
                InitializingLabel.Location = new Point(160, 170);
                InitializingLabel.Text = "Application Loading...";
            }
            if (Load_ProgressBar.Value == 60)
            {
                InitializingLabel.Location = new Point(170, 170);
                InitializingLabel.Text = "Preparing data...";
            }
            if (Load_ProgressBar.Value == 90)
            {
                InitializingLabel.Location = new Point(170, 170);
                InitializingLabel.Text = "Initializing data...";
            }
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            /* AFTER THE PROGRESS BAR WILL GO TO 100, THE MAIN FORM WILL HIDE AND THE
         SECURITY FORM WILL SHOW */
            Forms.SecurityLogin_Form form = new Forms.SecurityLogin_Form();
            form.Show();
            this.Hide();
        }
    }
}
