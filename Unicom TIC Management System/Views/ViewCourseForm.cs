using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System.Views
{
    public partial class ViewCourseForm : Form
    {
        private readonly CourseController _controller = new CourseController();

        public ViewCourseForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            LoadCourses();

            dataGridViewCourses.ReadOnly = true;
            dataGridViewCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadCourses()
        {
            try
            {
                List<Course> courses = _controller.GetAllCourses();
                dataGridViewCourses.DataSource = courses;

                dataGridViewCourses.Columns["CourseID"].HeaderText = "Course ID";
                dataGridViewCourses.Columns["CourseName"].HeaderText = "Course Name";
                /*dataGridViewCourses.Columns["Duration"].HeaderText = "Duration";
                dataGridViewCourses.Columns["Description"].HeaderText = "Description";*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading course data: " + ex.Message);
            }
        }

        private void dataGridViewCourses_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
