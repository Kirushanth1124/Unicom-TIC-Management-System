using SchoolManageSystem.Controllers;
using System;
using System.Drawing;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System.Views
{
    public partial class ExamForm : Form
    {
        private ExamController examController = new ExamController();

        public ExamForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            LoadSubjectComboBox();   // Populate subjects in combo box
            LoadExams();             // Load exam data to grid
        }

        private void LoadSubjectComboBox()
        {
            cmbSubjects.Items.Clear();
            cmbSubjects.Items.Add("Python");
            cmbSubjects.Items.Add("C#");
            cmbSubjects.Items.Add("JavaScript");
            cmbSubjects.Items.Add("C++");
            cmbSubjects.Items.Add("HTML");

            cmbSubjects.SelectedIndex = 0; // Optional: Select the first item by default
        }

        private void LoadExams()
        {
            dgvExams.DataSource = null;
            dgvExams.DataSource = examController.GetAllExams();
        }

        private void ClearForm()
        {
            txtExamID.Clear();
            txtExamName.Clear();
            cmbSubjects.SelectedIndex = -1;
        }

        private void dgvExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvExams.Rows[e.RowIndex];
                txtExamID.Text = row.Cells["ExamID"].Value.ToString();
                txtExamName.Text = row.Cells["ExamName"].Value.ToString();
                cmbSubjects.SelectedItem = row.Cells["SubjectID"].Value.ToString(); // assumes SubjectID is a string like "Python"
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (/*string.IsNullOrWhiteSpace(txtExamID.Text) ||*/
                string.IsNullOrWhiteSpace(txtExamName.Text) ||
                cmbSubjects.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var exam = new Exam
            {
                /*ExamID = int.Parse(txtExamID.Text),*/
                ExamName = txtExamName.Text,
                SubjectID = GetSubjectID(cmbSubjects.SelectedItem.ToString())
            };

            examController.AddExam(exam);
            LoadExams();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExamID.Text))
            {
                MessageBox.Show("Please select or enter an ExamID to update.");
                return;
            }

            var exam = new Exam
            {
                ExamID = int.Parse(txtExamID.Text),
                ExamName = txtExamName.Text,
                SubjectID = GetSubjectID(cmbSubjects.SelectedItem.ToString())
            };

            examController.UpdateExam(exam);
            LoadExams();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExamID.Text))
            {
                MessageBox.Show("Please enter ExamID to delete.");
                return;
            }

            int examId = int.Parse(txtExamID.Text);
            examController.DeleteExam(examId);
            LoadExams();
            ClearForm();
        }

        // Map subject names to IDs if your DB expects numerical IDs
        private int GetSubjectID(string subjectName)
        {
            return subjectName switch
            {
                "Python" => 1,
                "C#" => 2,
                "JavaScript" => 3,
                "C++" => 4,
                "HTML" => 5,
                _ => 0,
            };
        }
    }
}
