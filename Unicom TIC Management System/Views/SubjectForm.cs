using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System.Views
{
    public partial class SubjectForm : Form
    {
        private readonly SubjectController _controller = new SubjectController();

        public SubjectForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch; 

            LoadCourses();
            LoadSubjects();

            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dataGridViewSubjects.SelectionChanged += DataGridViewSubjects_SelectionChanged;

            dataGridViewSubjects.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSubjects.MultiSelect = false;
            dataGridViewSubjects.ReadOnly = true;
            dataGridViewSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private readonly CourseController _courseController = new CourseController();

        private void LoadCourses()
        {
            var courses = _courseController.GetAllCourses();

            cmbCourseName.DataSource = courses;
            cmbCourseName.DisplayMember = "CourseName";
            cmbCourseName.ValueMember = "CourseID";
            cmbCourseName.SelectedIndex = -1; // முதலில் எந்த course select ஆகாது
        }

        private void LoadSubjects()
        {
            var subjects = _controller.GetAllSubjects();
            dataGridViewSubjects.DataSource = null;
            dataGridViewSubjects.DataSource = subjects;

            if (dataGridViewSubjects.Columns["CourseID"] != null)
                dataGridViewSubjects.Columns["CourseID"].Visible = false;

            if (dataGridViewSubjects.Columns["SubjectID"] != null)
                dataGridViewSubjects.Columns["SubjectID"].HeaderText = "Subject ID";

            if (dataGridViewSubjects.Columns["SubjectName"] != null)
                dataGridViewSubjects.Columns["SubjectName"].HeaderText = "Subject Name";

            if (dataGridViewSubjects.Columns["CourseName"] != null)
                dataGridViewSubjects.Columns["CourseName"].HeaderText = "Course";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                var subject = new Subject
                {
                    SubjectName = txtSubjectName.Text.Trim(),
                    CourseID = Convert.ToInt32(cmbCourseName.SelectedValue)
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
            if (dataGridViewSubjects.SelectedRows.Count == 0 || !ValidateInputs())
            {
                MessageBox.Show("Please select a subject and enter valid inputs.");
                return;
            }

            try
            {
                int subjectId = Convert.ToInt32(dataGridViewSubjects.SelectedRows[0].Cells["SubjectID"].Value);

                var subject = new Subject
                {
                    SubjectID = subjectId,
                    SubjectName = txtSubjectName.Text.Trim(),
                    CourseID = Convert.ToInt32(cmbCourseName.SelectedValue)
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

            if (MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int subjectId = Convert.ToInt32(dataGridViewSubjects.SelectedRows[0].Cells["SubjectID"].Value);
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
                txtSubjectName.Text = row.Cells["SubjectName"].Value?.ToString();
                cmbCourseName.SelectedValue = Convert.ToInt32(row.Cells["CourseID"].Value);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text))
            {
                MessageBox.Show("Please enter subject name.");
                return false;
            }

            if (cmbCourseName.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a course.");
                return false;
            }

            return true;
        }

        private void ClearInputs()
        {
            txtSubjectName.Clear();
            // cmbCourseName.SelectedIndex = -1;  // இதை comment பண்ணுங்க
            dataGridViewSubjects.ClearSelection();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                var subject = new Subject
                {
                    SubjectName = txtSubjectName.Text.Trim(),
                    CourseID = Convert.ToInt32(cmbCourseName.SelectedValue)
                };

                _controller.AddSubject(subject);
                MessageBox.Show("Subject added successfully!");
                LoadSubjects();

                // Add பண்ணிய Subject-இன் CourseID-ஐ comboBox select பண்ண
                cmbCourseName.SelectedValue = subject.CourseID;

                ClearInputs();  // இது comboBox select ஆக்குது, இதை இங்கு அழைக்க வேண்டாம்.
                                // அதனால் ClearInputs() அழிக்காமல் comboBox selection இருக்கும்.

                // அல்லது, ClearInputs() இல் comboBox-க்கு SelectedIndex = -1 செய்யாதீர்கள்.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding subject: " + ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.SelectedRows.Count == 0 || !ValidateInputs())
            {
                MessageBox.Show("Please select a subject and enter valid inputs.");
                return;
            }

            try
            {
                int subjectId = Convert.ToInt32(dataGridViewSubjects.SelectedRows[0].Cells["SubjectID"].Value);

                var subject = new Subject
                {
                    SubjectID = subjectId,
                    SubjectName = txtSubjectName.Text.Trim(),
                    CourseID = Convert.ToInt32(cmbCourseName.SelectedValue)
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

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    int subjectId = Convert.ToInt32(dataGridViewSubjects.SelectedRows[0].Cells["SubjectID"].Value);
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

        private void dataGridViewSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewSubjects.SelectedRows.Count > 0)
            {
                var row = dataGridViewSubjects.SelectedRows[0];
                txtSubjectName.Text = row.Cells["SubjectName"].Value?.ToString();
                cmbCourseName.SelectedValue = Convert.ToInt32(row.Cells["CourseID"].Value);
            }
        }
    }
}
