using SchoolManageSystem.Controllers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controllers;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System.Views
{
    public partial class StudentForm : Form
    {
        private StudentController studentController = new StudentController();
        private int selectedStudentId = -1;

        private int currentUserId = 1; // Replace this dynamically after login

        public StudentForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dataGridView1.CellClick += DataGridView1_CellClick;

            LoadSubjects();
            LoadStudents();
        }

        private void LoadSubjects()
        {
            var subjects = new List<string> { "Python", "C#", "JavaScript", "C++", "HTML" };
            cmbCourse.DataSource = subjects;
            cmbCourse.SelectedIndex = -1;
        }

        private void LoadStudents()
        {
            try
            {
                var students = studentController.GetAllStudents();
                dataGridView1.DataSource = students;

                if (dataGridView1.Columns["StudentId"] != null)
                    dataGridView1.Columns["StudentId"].HeaderText = "ID";

                if (dataGridView1.Columns["Name"] != null)
                    dataGridView1.Columns["Name"].HeaderText = "Name";

                if (dataGridView1.Columns["Address"] != null)
                    dataGridView1.Columns["Address"].HeaderText = "Address";

                if (dataGridView1.Columns["DOB"] != null)
                    dataGridView1.Columns["DOB"].HeaderText = "DOB";

                if (dataGridView1.Columns["Gender"] != null)
                    dataGridView1.Columns["Gender"].HeaderText = "Gender";

                if (dataGridView1.Columns["CourseName"] != null)
                    dataGridView1.Columns["CourseName"].HeaderText = "Subject";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student
                {
                    Name = txtStName.Text.Trim(),
                    Address = txtStAddress.Text.Trim(),
                    DOB = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    Gender = radMale.Checked ? "Male" : radFemale.Checked ? "Female" : null,
                    CourseName = cmbCourse.SelectedItem?.ToString(),
                    UserID = currentUserId
                };

                studentController.AddStudent(student);
                MessageBox.Show("Student added successfully!");
                LoadStudents();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add student: " + ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentId <= 0)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            try
            {
                var student = new Student
                {
                    StudentID = selectedStudentId,
                    Name = txtStName.Text.Trim(),
                    Address = txtStAddress.Text.Trim(),
                    DOB = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    Gender = radMale.Checked ? "Male" : radFemale.Checked ? "Female" : null,
                    CourseName = cmbCourse.SelectedItem?.ToString()
                };

                studentController.UpdateStudent(student);
                MessageBox.Show("Student updated successfully!");
                LoadStudents();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update student: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId <= 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this student?",
                                          "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    studentController.DeleteStudent(selectedStudentId);
                    MessageBox.Show("Student deleted successfully!");
                    LoadStudents();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete student: " + ex.Message);
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                selectedStudentId = Convert.ToInt32(row.Cells["StudentId"].Value);
                txtStName.Text = row.Cells["Name"].Value?.ToString();
                txtStAddress.Text = row.Cells["Address"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["DOB"].Value?.ToString(), out DateTime dob))
                    dateTimePicker1.Value = dob;

                string gender = row.Cells["Gender"].Value?.ToString();
                radMale.Checked = gender == "Male";
                radFemale.Checked = gender == "Female";

                cmbCourse.SelectedItem = row.Cells["CourseName"].Value?.ToString();
            }
        }

        private void ClearFields()
        {
            txtStName.Clear();
            txtStAddress.Clear();
            dateTimePicker1.Value = DateTime.Today;
            radMale.Checked = false;
            radFemale.Checked = false;
            cmbCourse.SelectedIndex = -1;
            selectedStudentId = -1;
        }

        private void txtStName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
