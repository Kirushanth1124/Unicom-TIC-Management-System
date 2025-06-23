using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;
using Unicom_TIC_Management_System;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Controllers;

namespace Unicom_TIC_Management_System.Views
{
    public partial class MarkForm : Form
    {
        private MarkController markController = new MarkController();
        private StudentController studentController = new StudentController();
        private ExamController examController = new ExamController();
        private AdminPermissionController controller = new AdminPermissionController();

        public MarkForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            LoadStudents();
            LoadExams();
            LoadMarks();
        }

        private void LoadStudents()
        {
            var allUsers = controller.GetAllUsers();  
            var students = allUsers.Where(user => user.Role == "Student").ToList(); 

            comboBoxStudents.DataSource = null;  
            comboBoxStudents.DataSource = students;  
            comboBoxStudents.DisplayMember = "Username"; 
            comboBoxStudents.ValueMember = "UserID"; 
        }

        private void LoadExams()
        {
            var exams = examController.GetAllExams();
            comboBoxExams.DataSource = null;  // Reset the ComboBox
            comboBoxExams.DataSource = exams;
            comboBoxExams.DisplayMember = "ExamName";
            comboBoxExams.ValueMember = "ExamID";
        }

        private void LoadMarks()
        {
            var marks = markController.GetAllMarks();
            dataGridViewMarks.DataSource = null;
            dataGridViewMarks.DataSource = marks;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedValue == null || comboBoxExams.SelectedValue == null)
            {
                MessageBox.Show("Please select both a student and an exam.");
                return;
            }

            if (!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Please enter a valid score.");
                return;
            }

            var mark = new Mark
            {
                StudentID = (int)comboBoxStudents.SelectedValue,
                ExamID = (int)comboBoxExams.SelectedValue,
                Score = score
            };

            markController.AddMark(mark);
            LoadMarks();
            txtScore.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewMarks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a mark to update.");
                return;
            }

            if (!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Please enter a valid score.");
                return;
            }

            var row = dataGridViewMarks.SelectedRows[0];
            int markId = Convert.ToInt32(row.Cells["MarkId"].Value);

            var mark = new Mark
            {
                MarkID = markId,
                StudentID = (int)comboBoxStudents.SelectedValue,
                ExamID = (int)comboBoxExams.SelectedValue,
                Score = score
            };

            markController.UpdateMark(mark);
            LoadMarks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMarks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a mark to delete.");
                return;
            }

            var row = dataGridViewMarks.SelectedRows[0];
            int markId = Convert.ToInt32(row.Cells["MarkId"].Value);

            markController.DeleteMark(markId);
            LoadMarks();
            txtScore.Clear();
        }

        private void dataGridViewMarks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMarks.SelectedRows.Count > 0)
            {
                var row = dataGridViewMarks.SelectedRows[0];

                txtScore.Text = row.Cells["Score"].Value.ToString();

                comboBoxStudents.SelectedValue = row.Cells["StudentId"].Value;
                comboBoxExams.SelectedValue = row.Cells["ExamId"].Value;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedValue == null || comboBoxExams.SelectedValue == null)
            {
                MessageBox.Show("Please select both a student and an exam.");
                return;
            }

            if (!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Please enter a valid score.");
                return;
            }

            var mark = new Mark
            {
                StudentID = (int)comboBoxStudents.SelectedValue,
                ExamID = (int)comboBoxExams.SelectedValue,
                Score = score
            };

            markController.AddMark(mark);
            LoadMarks();
            txtScore.Clear();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewMarks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a mark to update.");
                return;
            }

            if (!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Please enter a valid score.");
                return;
            }

            var row = dataGridViewMarks.SelectedRows[0];
            int markId = Convert.ToInt32(row.Cells["MarkId"].Value);

            var mark = new Mark
            {
                MarkID = markId,
                StudentID = (int)comboBoxStudents.SelectedValue,
                ExamID = (int)comboBoxExams.SelectedValue,
                Score = score
            };

            markController.UpdateMark(mark);
            LoadMarks();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewMarks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a mark to delete.");
                return;
            }

            var row = dataGridViewMarks.SelectedRows[0];
            int markId = Convert.ToInt32(row.Cells["MarkId"].Value);

            markController.DeleteMark(markId);
            LoadMarks();
            txtScore.Clear();
        }

        private void dataGridViewMarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMarks.SelectedRows.Count > 0)
            {
                var row = dataGridViewMarks.SelectedRows[0];

                txtScore.Text = row.Cells["Score"].Value.ToString();

                comboBoxStudents.SelectedValue = row.Cells["StudentId"].Value;
                comboBoxExams.SelectedValue = row.Cells["ExamId"].Value;
            }
        }
    }
}
