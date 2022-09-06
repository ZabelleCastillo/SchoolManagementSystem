using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem.UserControl_Forms
{
    public partial class Dashboard_UserControl : UserControl
    {
        public Dashboard_UserControl()
        {
            InitializeComponent();

            //System.Windows.Forms.Timer Student_Timer = new System.Windows.Forms.Timer();
            Timer Student_Timer = new Timer();
            Student_Timer.Interval = 5000;//5 seconds
            Student_Timer.Tick += new System.EventHandler(Student_Timer_Tick);
            Student_Timer.Start();

            System.Windows.Forms.Timer Subject_Timer = new System.Windows.Forms.Timer();
            Subject_Timer.Interval = 5000;//5 seconds
            Subject_Timer.Tick += new System.EventHandler(Subject_Timer_Tick);
            Subject_Timer.Start();

            Timer Class_Timer = new Timer();
            Class_Timer.Interval = 5000;//5 seconds
            Class_Timer.Tick += new System.EventHandler(Class_Timer_Tick);
            Class_Timer.Start();

            Timer Teacher_Timer = new Timer();
            Teacher_Timer.Interval = 5000;//5 seconds
            Teacher_Timer.Tick += new System.EventHandler(Teacher_Timer_Tick);
            Teacher_Timer.Start();
        }

        private void Dashboard_UserControl_Load(object sender, EventArgs e)
        {
            DashboardStudent_Count();
            DashboardSubject_Count();
            DashboardClass_Count();
            DashboardTeacher_Count();
        }
        private void DashboardStudent_Count() // TO COUNT ALL THE STUDENTS THAT HAVE BEEN REGISTERED
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM STUDENT_INFO_TABLE", conn);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            //if (count > 0)
            //{
            //    StudentCount_label.Text = Convert.ToString(count.ToString()); //For example a Label
            //}
            //else
            //{
            //    StudentCount_label.Text = "0";
            //}
            if (count == 0)
            {
                StudentCount_label.Text = Convert.ToString(count.ToString());
                student_label.Text = "NO STUDENT";
            }
            if (count == 1)
            {
                StudentCount_label.Text = Convert.ToString(count.ToString());
                student_label.Text = "STUDENT";
            }
            if (count > 1)
            {
                StudentCount_label.Text = Convert.ToString(count.ToString());
                student_label.Text = "STUDENTS";
            }
            conn.Close(); //Remember close the connection
        }
        private void DashboardSubject_Count() // TO COUNT ALL THE SUBJECTS THAT HAVE BEEN ADDED
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(Subject) FROM TEACHER_CLASS_SCHEDULE_TABLE", conn);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            //if (count > 0)
            //{
            //    SubjectCount_label.Text = Convert.ToString(count.ToString()); //For example a Label
            //}
            //else
            //{
            //    SubjectCount_label.Text = "0";
            //}
            if (count == 0)
            {
                SubjectCount_label.Text = Convert.ToString(count.ToString());
                SUBJECT_LABEL.Text = "NO SUBJECT";
            }
            if (count == 1)
            {
                SubjectCount_label.Text = Convert.ToString(count.ToString());
                SUBJECT_LABEL.Text = "SUBJECT";
            }
            if (count > 1)
            {
                SubjectCount_label.Text = Convert.ToString(count.ToString());
                SUBJECT_LABEL.Text = "SUBJECTS";
            }
            conn.Close(); //Remember close the connection
        }
        private void DashboardClass_Count() // TO COUNT ALL THE CLASSES THAT HAVE BEEN ADDED TO THE TEACHER'S SCHEDULE
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(Class) FROM TEACHER_CLASS_SCHEDULE_TABLE", conn);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            //if (count > 0)
            //{
            //    Class_Label.Text = Convert.ToString(count.ToString()); //For example a Label
            //}
            //else
            //{
            //    Class_Label.Text = "0";
            //}
            if (count == 0)
            {
                ClassCount_Label.Text = Convert.ToString(count.ToString());
                Class_Label.Text = "NO CLASS";
            }
            if (count == 1)
            {
                ClassCount_Label.Text = Convert.ToString(count.ToString());
                Class_Label.Text = "CLASS";
            }
            if (count > 1)
            {
                ClassCount_Label.Text = Convert.ToString(count.ToString());
                Class_Label.Text = "CLASSES";
            }
            conn.Close(); //Remember close the connection
        }
        private void DashboardTeacher_Count() // TO COUNT IF HOW MANY TEACHER HAVE BEEN ADDED.
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\School_DB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(DISTINCT Username) FROM TEACHER_CLASS_SCHEDULE_TABLE", conn);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            //if (count > 0)
            //{
            //    Teacher_label.Text = Convert.ToString(count.ToString()); //For example a Label
            //}
            //else
            //{
            //    Teacher_label.Text = "0";
            //}
            if (count == 0)
            {
                TeacherCount_label.Text = Convert.ToString(count.ToString());
                Teacher_label.Text = "NONE";
            }
            if (count == 1)
            {
                TeacherCount_label.Text = Convert.ToString(count.ToString());
                Teacher_label.Text = "TEACHER";
            }
            if (count > 1)
            {
                TeacherCount_label.Text = Convert.ToString(count.ToString());
                Teacher_label.Text = "TEACHERS";
            }
            conn.Close(); //Remember close the connection
        }


        private void Student_Timer_Tick(object sender, EventArgs e)
        {
            DashboardStudent_Count();
        }
        private void Subject_Timer_Tick(object sender, EventArgs e)
        {
            DashboardSubject_Count();
        }
        private void Class_Timer_Tick(object sender, EventArgs e)
        {
            DashboardClass_Count();
        }
        private void Teacher_Timer_Tick(object sender, EventArgs e)
        {
            DashboardTeacher_Count();
        }
    }
}
