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

        public StudentForm()
        {
            InitializeComponent();


            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dataGridView1.CellClick += DataGridView1_CellClick;

            LoadStudents();
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

                if (dataGridView1.Columns["CourseId"] != null)
                    dataGridView1.Columns["CourseId"].HeaderText = "Course ID";


                if (dataGridView1.Columns["CourseName"] != null)
                    dataGridView1.Columns["CourseName"].Visible = false;
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
                    Gender = radMale.Checked ? "Male" : radFemale.Checked ? "Female" : ""


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
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            try
            {
                var student = new Student
                {
                    StudentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["StudentId"].Value),
                    Name = txtStName.Text.Trim(),
                    Address = txtStAddress.Text.Trim(),
                    DOB = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    Gender = radMale.Checked ? "Male" : radFemale.Checked ? "Female" : ""

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
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            int studentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["StudentId"].Value);

            var confirmResult = MessageBox.Show("Are you sure to delete this student?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    studentController.DeleteStudent(studentId);
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
                txtStName.Text = row.Cells["Name"].Value?.ToString();
                txtStAddress.Text = row.Cells["Address"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["DOB"]?.Value?.ToString(), out DateTime dob))
                    dateTimePicker1.Value = dob;
                else
                    dateTimePicker1.Value = DateTime.Today;

                var gender = row.Cells["Gender"]?.Value?.ToString();
                radMale.Checked = gender == "Male";
                radFemale.Checked = gender == "Female";


            }
        }

        private void ClearFields()
        {
            txtStName.Clear();
            txtStAddress.Clear();
            dateTimePicker1.Value = DateTime.Today;
            radMale.Checked = false;
            radFemale.Checked = false;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtStName.Text = row.Cells["Name"].Value?.ToString();
                txtStAddress.Text = row.Cells["Address"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["DOB"]?.Value?.ToString(), out DateTime dob))
                    dateTimePicker1.Value = dob;
                else
                    dateTimePicker1.Value = DateTime.Today;

                var gender = row.Cells["Gender"]?.Value?.ToString();
                radMale.Checked = gender == "Male";
                radFemale.Checked = gender == "Female";


            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            int studentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["StudentId"].Value);

            var confirmResult = MessageBox.Show("Are you sure to delete this student?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    studentController.DeleteStudent(studentId);
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

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            try
            {
                var student = new Student
                {
                    StudentId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["StudentId"].Value),
                    Name = txtStName.Text.Trim(),
                    Address = txtStAddress.Text.Trim(),
                    DOB = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    Gender = radMale.Checked ? "Male" : radFemale.Checked ? "Female" : ""

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

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                var student = new Student
                {
                    Name = txtStName.Text.Trim(),
                    Address = txtStAddress.Text.Trim(),
                    DOB = dateTimePicker1.Value.ToString("yyyy-MM-dd"),
                    Gender = radMale.Checked ? "Male" : radFemale.Checked ? "Female" : ""


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

        private void radMale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}