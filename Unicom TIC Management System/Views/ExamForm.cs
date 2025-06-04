using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;
using Unicom_TIC_Management_System;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System;

namespace Unicom_TIC_Management_System.Views
{
    public partial class ExamForm : Form
    {
        private ExamController examController = new ExamController();
        private SubjectController subjectController = new SubjectController();

        public ExamForm()
        {
            InitializeComponent();
            LoadSubjects();
            LoadExams();
        }

        private void LoadSubjects()
        {
            var subjects = subjectController.GetAllSubjects();
            comboBoxSubjects.DataSource = subjects;
            comboBoxSubjects.DisplayMember = "SubjectName";
            comboBoxSubjects.ValueMember = "SubjectID";
        }

        private void LoadExams()
        {
            var exams = examController.GetAllExams();
            dataGridViewExams.DataSource = null;
            dataGridViewExams.DataSource = exams;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExamName.Text))
            {
                MessageBox.Show("Please enter an exam name.");
                return;
            }

            var exam = new Exam
            {
                ExamName = txtExamName.Text.Trim(),
                SubjectID = Convert.ToInt32(comboBoxSubjects.SelectedValue)
            };

            examController.AddExam(exam);
            LoadExams();
            txtExamName.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewExams.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an exam to update.");
                return;
            }

            var row = dataGridViewExams.SelectedRows[0];
            int examId = Convert.ToInt32(row.Cells["ExamID"].Value);

            var exam = new Exam
            {
                ExamID = examId,
                ExamName = txtExamName.Text.Trim(),
                SubjectID = Convert.ToInt32(comboBoxSubjects.SelectedValue)
            };

            examController.UpdateExam(exam);
            LoadExams();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewExams.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an exam to delete.");
                return;
            }

            var row = dataGridViewExams.SelectedRows[0];
            int examId = Convert.ToInt32(row.Cells["ExamID"].Value);

            examController.DeleteExam(examId);
            LoadExams();
            txtExamName.Clear();
        }

        private void dataGridViewExams_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewExams.SelectedRows.Count > 0)
            {
                var row = dataGridViewExams.SelectedRows[0];
                txtExamName.Text = row.Cells["ExamName"].Value.ToString();
                comboBoxSubjects.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"].Value);
            }
        }
    }
}
