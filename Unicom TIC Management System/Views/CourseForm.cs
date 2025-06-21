using System;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System.Views
{
    public partial class CourseForm : Form
    {
        private CourseController controller = new CourseController();

        public CourseForm()
        {
            InitializeComponent();
            LoadCourses();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Setup DataGridView selection
            dataGridViewCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCourses.MultiSelect = false;
            dataGridViewCourses.ReadOnly = true;
            dataGridViewCourses.AllowUserToAddRows = false;

            // Attach event
            dataGridViewCourses.SelectionChanged += dataGridViewCourses_SelectionChanged;
        }

        private void LoadCourses()
        {
            var courses = controller.GetAllCourses();
            dataGridViewCourses.DataSource = null;
            dataGridViewCourses.DataSource = courses;

            if (dataGridViewCourses.Columns["CourseID"] != null)
                dataGridViewCourses.Columns["CourseID"].HeaderText = "ID";
            if (dataGridViewCourses.Columns["CourseName"] != null)
                dataGridViewCourses.Columns["CourseName"].HeaderText = "Course Name";
        }

        private void dataGridViewCourses_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCourses.CurrentRow != null && dataGridViewCourses.CurrentRow.Index >= 0)
            {
                txtCourseName.Text = dataGridViewCourses.CurrentRow.Cells["CourseName"].Value?.ToString();
            }
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
            if (dataGridViewCourses.CurrentRow == null)
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }

            int courseId = Convert.ToInt32(dataGridViewCourses.CurrentRow.Cells["CourseID"].Value);

            var course = new Course
            {
                CourseID = courseId,
                CourseName = txtCourseName.Text.Trim()
            };

            controller.UpdateCourse(course);
            LoadCourses();
            txtCourseName.Clear();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewCourses.CurrentRow == null)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            int courseId = Convert.ToInt32(dataGridViewCourses.CurrentRow.Cells["CourseID"].Value);

            controller.DeleteCourse(courseId);
            LoadCourses();
            txtCourseName.Clear();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            // Optional Load logic
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            // Optional validation
        }

        // ❌ Remove this empty method if present
        // private void dataGridViewCourses_SelectionChanged_1(object sender, EventArgs e) { }
    }
}
