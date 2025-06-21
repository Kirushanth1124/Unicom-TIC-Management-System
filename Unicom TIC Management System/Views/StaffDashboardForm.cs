using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Modals;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Views
{
    public partial class StaffDashboardForm : Form
    {
        private readonly string _staffName;

        public StaffDashboardForm()
        {
            InitializeComponent();
            SetFormBackground();
        }

        public StaffDashboardForm(string staffName)
        {
            InitializeComponent();
            SetFormBackground();

            _staffName = staffName;
            lblWelcome.Text = $"Welcome, {_staffName}!";
        }

        private void SetFormBackground()
        {
            try
            {
                this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Background image load failed: " + ex.Message);
            }
        }

        // Load Students button click
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

        // View Timetable button click
        private void btnViewTimetable_Click(object sender, EventArgs e)
        {
            TimetableForm form = new TimetableForm();
            form.ShowDialog();
        }

        // Manage Exams button click
        private void btnManageExams_Click(object sender, EventArgs e)
        {
            ExamForm form = new ExamForm();
            form.ShowDialog();
        }

        // Manage Marks button click
        private void btnManageMarks_Click(object sender, EventArgs e)
        {
            MarkForm form = new MarkForm();
            form.ShowDialog();
        }

        // Logout button click
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
