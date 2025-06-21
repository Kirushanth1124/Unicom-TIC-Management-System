using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;  // Adjust namespace
using Unicom_TIC_Management_System.Modals;  // Your models namespace

namespace Unicom_TIC_Management_System.Views
{
    public partial class SubjectForm : Form
    {
        private readonly SubjectController _controller = new SubjectController();
        private List<Course> _courses;  // To hold courses list

        public SubjectForm()
        {
            InitializeComponent();

            LoadCourses();
            LoadSubjects();

            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dataGridViewSubjects.SelectionChanged += DataGridViewSubjects_SelectionChanged;

            dataGridViewSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSubjects.MultiSelect = false;
            dataGridViewSubjects.ReadOnly = true;
        }

        private void LoadCourses()
        {
            try
            {
                // Hardcoded course list
                _courses = new List<Course>
                {
                    new Course { CourseID = 1, CourseName = "Python" },
                    new Course { CourseID = 2, CourseName = "C#" },
                    new Course { CourseID = 3, CourseName = "C++" },
                    new Course { CourseID = 4, CourseName = "JavaScript" }
                };

                cmbCourseName.DataSource = _courses;
                cmbCourseName.DisplayMember = "CourseName";
                cmbCourseName.ValueMember = "CourseID";
                cmbCourseName.SelectedIndex = -1; // No selection initially
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message);
            }
        }

        private void LoadSubjects()
        {
            var subjects = _controller.GetAllSubjects();
            dataGridViewSubjects.DataSource = null;
            dataGridViewSubjects.DataSource = subjects;

            // Rename headers for clarity
            if (dataGridViewSubjects.Columns["SubjectID"] != null)
                dataGridViewSubjects.Columns["SubjectID"].HeaderText = "Subject ID";

            if (dataGridViewSubjects.Columns["SubjectName"] != null)
                dataGridViewSubjects.Columns["SubjectName"].HeaderText = "Subject Name";

            if (dataGridViewSubjects.Columns["CourseName"] != null)
                dataGridViewSubjects.Columns["CourseName"].HeaderText = "Course Name";

            // Hide CourseID column if needed
            if (dataGridViewSubjects.Columns["CourseID"] != null)
                dataGridViewSubjects.Columns["CourseID"].Visible = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                var subject = new Subject
                {
                    SubjectName = txtSubjectName.Text.Trim(),
                    CourseID = (int)cmbCourseName.SelectedValue
                };

                _controller.AddSubject(subject);
                MessageBox.Show("Subject added successfully!");
                LoadSubjects();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding subject: " + ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a subject to update.");
                return;
            }

            if (!ValidateInputs())
                return;

            try
            {
                var selectedRow = dataGridViewSubjects.SelectedRows[0];
                int subjectId = Convert.ToInt32(selectedRow.Cells["SubjectID"].Value);

                var subject = new Subject
                {
                    SubjectID = subjectId,
                    SubjectName = txtSubjectName.Text.Trim(),
                    CourseID = (int)cmbCourseName.SelectedValue
                };

                _controller.UpdateSubject(subject);
                MessageBox.Show("Subject updated successfully!");
                LoadSubjects();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating subject: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var selectedRow = dataGridViewSubjects.SelectedRows[0];
                    int subjectId = Convert.ToInt32(selectedRow.Cells["SubjectID"].Value);

                    _controller.DeleteSubject(subjectId);
                    MessageBox.Show("Subject deleted successfully!");
                    LoadSubjects();
                    ClearInputs();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting subject: " + ex.Message);
                }
            }
        }

        private void DataGridViewSubjects_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.SelectedRows.Count > 0)
            {
                var row = dataGridViewSubjects.SelectedRows[0];

                txtSubjectName.Text = row.Cells["SubjectName"].Value?.ToString() ?? "";
                int courseId = Convert.ToInt32(row.Cells["CourseID"].Value);
                cmbCourseName.SelectedValue = courseId;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show("Please enter Subject Name.");
                return false;
            }
            if (cmbCourseName.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a Course.");
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            txtSubjectName.Clear();
            cmbCourseName.SelectedIndex = -1;
            dataGridViewSubjects.ClearSelection();
        }
    }
}
