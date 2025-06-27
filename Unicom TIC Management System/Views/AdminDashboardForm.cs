using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicom_TIC_Management_System.Views
{
    public partial class AdminDashboardForm : Form
    {

        public AdminDashboardForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;


        }

        private void button6_Click(object sender, EventArgs e)
        {

            btnManageExam.Enabled = false;


            var examForm = new ExamForm();
            examForm.Show();


            btnManageExam.Enabled = true;
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {

            /*btnManageStudents.Enabled = false;


            var studentForm = new StudentForm();
            studentForm.Show();


            btnManageStudents.Enabled = true;*/
        }

        private void btnManageCourses_Click(object sender, EventArgs e)
        {


            btnManageCourses.Enabled = false;


            var courseForm = new CourseForm();
            courseForm.Show();


            btnManageCourses.Enabled = true;

        }

        private void btnManageMarks_Click(object sender, EventArgs e)
        {
            btnManageMarks.Enabled = true;

            var markForm = new MarkForm();
            markForm.Show();

            btnManageMarks.Enabled = true;

        }

        private void btnManageTimeTable_Click(object sender, EventArgs e)
        {
            btnManageTimeTable.Enabled = true;

            var timetableForm = new TimetableForm();
            timetableForm.Show();

            btnManageTimeTable.Enabled = true;

        }

        private void btnManageLecturers_Click(object sender, EventArgs e)
        {
            btnManageLecturers.Enabled = true;

            var lecturerDashboardForm = new LecturerDashboardForm();
            lecturerDashboardForm.Show();

            btnManageLecturers.Enabled = true;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            btnLogout.Enabled = false;


            var loginform = new LoginForm();
            loginform.Show();


            btnLogout.Enabled = true;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;


            var adminPermissionForm = new AdminPermissionForm();
            adminPermissionForm.Show();


            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;


            var adminPermissionForm = new AdminPermissionForm();
            adminPermissionForm.Show();


            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnSTDash.Enabled = false;


            var studentDashboardForm = new StudentDashboardForm();
            studentDashboardForm.Show();


            btnSTDash.Enabled = true;
        }
    }
}
