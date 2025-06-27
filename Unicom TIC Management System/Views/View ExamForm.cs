using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System.Views
{
    public partial class ViewExamOnlyForm : Form
    {
        private readonly ExamController _controller = new ExamController();

        public ViewExamOnlyForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            LoadExamData();

            dataGridViewExamOnly.ReadOnly = true;
            dataGridViewExamOnly.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewExamOnly.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadExamData()
        {
            try
            {
                List<Exam> exams = _controller.GetAllExamsWithSubjectNames();
                dataGridViewExamOnly.DataSource = exams;

                dataGridViewExamOnly.Columns["ExamID"].HeaderText = "Exam ID";
                dataGridViewExamOnly.Columns["ExamName"].HeaderText = "Exam Name";
                dataGridViewExamOnly.Columns["SubjectID"].HeaderText = "Subject ID";
                dataGridViewExamOnly.Columns["SubjectName"].HeaderText = "Subject Name";

                // Hide unwanted columns
                /* if (dataGridViewExamOnly.Columns["SubjectID"] != null)
                     dataGridViewExamOnly.Columns["SubjectID"].Visible = false;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading exams: " + ex.Message);
            }
        }

        private void dataGridViewExamOnly_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
