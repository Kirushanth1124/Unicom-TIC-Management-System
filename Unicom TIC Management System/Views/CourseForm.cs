using System;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;
using Unicom_TIC_Management_System;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System;

namespace Unicom_TIC_Management_System.Views
{
    public partial class CourseForm : Form
    {
        private CourseController controller = new CourseController();

        public CourseForm()
        {
            InitializeComponent();
            LoadCourses();
        }

        private void LoadCourses()
        {
            var courses = controller.GetAllCourses();
            dataGridViewCourses.DataSource = null;
            dataGridViewCourses.DataSource = courses;
        }


        private void dataGridViewCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count > 0)
            {
                txtCourseName.Text = dataGridViewCourses.SelectedRows[0].Cells["CourseName"].Value.ToString();
            }
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Please enter a course name.");
                return;
            }

            var course = new Course { CourseName = txtCourseName.Text.Trim() };
            controller.AddCourse(course);
            LoadCourses();
            txtCourseName.Clear();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }

            var selectedRow = dataGridViewCourses.SelectedRows[0];
            int courseId = Convert.ToInt32(selectedRow.Cells["CourseID"].Value);

            var course = new Course
            {
                CourseId = courseId,
                CourseName = txtCourseName.Text.Trim()
            };

            controller.UpdateCourse(course);
            LoadCourses();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            if (dataGridViewCourses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            var selectedRow = dataGridViewCourses.SelectedRows[0];
            int courseId = Convert.ToInt32(selectedRow.Cells["CourseID"].Value);

            controller.DeleteCourse(courseId);
            LoadCourses();
            txtCourseName.Clear();
        }
    }
}
