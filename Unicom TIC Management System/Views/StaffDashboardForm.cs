using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Views;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Views
{
    public partial class StaffDashboardForm : Form
    {
        private readonly string _staffName;

        public StaffDashboardForm(string staffName)
        {
            InitializeComponent();
            _staffName = staffName;
            lblWelcome.Text = $"Welcome, {_staffName}!";

            // Attach event handlers
            btnLoadStudents.Click += btnLoadStudents_Click;
            btnViewTimetable.Click += btnViewTimetable_Click;
            btnManageExams.Click += btnManageExams_Click;
            btnManageMarks.Click += btnManageMarks_Click;
            btnLogout.Click += btnLogout_Click;
        }

        public StaffDashboardForm()
        {
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            try
            {
                List<Student> students = DatabaseManager.Instance.GetAllStudents();
                dgvStudents.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}");
            }
        }

        private void btnViewTimetable_Click(object sender, EventArgs e)
        {
            TimetableForm form = new TimetableForm();
            form.ShowDialog();
        }

        private void btnManageExams_Click(object sender, EventArgs e)
        {
            ExamForm form = new ExamForm();
            form.ShowDialog();
        }

        private void btnManageMarks_Click(object sender, EventArgs e)
        {
            MarkForm form = new MarkForm();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
