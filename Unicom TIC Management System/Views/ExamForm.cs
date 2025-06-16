using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;
using Unicom_TIC_Management_System.Controllers;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System.Views
{
    public partial class ExamForm : Form
    {
        private ExamController examController = new ExamController();
        private SubjectController subjectController = new SubjectController(); // Assuming this exists
        private int selectedExamId = -1;

        public ExamForm()
        {
            InitializeComponent();
            LoadSubjects();   
            LoadExams();      
        }

        private void LoadSubjects()
        {
            var subjects = subjectController.GetAllSubjects();
            cmbSubjects.DataSource = subjects;
            cmbSubjects.DisplayMember = "SubjectName";
            cmbSubjects.ValueMember = "SubjectID";
        }

        private void LoadExams()
        {
            dgvExams.DataSource = null;
            dgvExams.DataSource = examController.GetAllExams();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExamName.Text) || cmbSubjects.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter exam name and select subject.");
                return;
            }

            var exam = new Exam
            {
                ExamName = txtExamName.Text,
                SubjectID = (int)cmbSubjects.SelectedValue
            };

            examController.AddExam(exam);
            LoadExams();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to update.");
                return;
            }

            var exam = new Exam
            {
                ExamID = selectedExamId,
                ExamName = txtExamName.Text,
                SubjectID = (int)cmbSubjects.SelectedValue
            };

            examController.UpdateExam(exam);
            LoadExams();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to delete.");
                return;
            }

            examController.DeleteExam(selectedExamId);
            LoadExams();
            ClearForm();
        }

        private void dgvExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvExams.Rows[e.RowIndex];
                selectedExamId = Convert.ToInt32(row.Cells["ExamID"].Value);
                txtExamName.Text = row.Cells["ExamName"].Value.ToString();
                cmbSubjects.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"].Value);
            }
        }

        private void ClearForm()
        {
            txtExamName.Clear();
            cmbSubjects.SelectedIndex = 0;
            selectedExamId = -1;
        }
    }
}
