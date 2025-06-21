using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Repositories;

namespace Unicom_TIC_Management_System.Views
{
    public partial class StudentDashboardForm : Form
    {
        private readonly string _studentName;
        private readonly int _studentId;

        public StudentDashboardForm(int studentId, string studentName)
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
            _studentId = studentId;
            _studentName = studentName;


            btnViewMarks.Click += BtnViewMarks_Click;
            btnViewTimetable.Click += BtnViewTimetable_Click;
            btnLogout.Click += BtnLogout_Click;
        }

        public StudentDashboardForm()
        {
        }

        private void BtnViewMarks_Click(object sender, EventArgs e)
        {
            try
            {
                var marks = DatabaseManager.Instance.GetStudentMarks(_studentId);
                dgvData.DataSource = marks;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading marks: {ex.Message}");
            }
        }

        private void BtnViewTimetable_Click(object sender, EventArgs e)
        {
            try
            {
                var timetable = DatabaseManager.Instance.GetStudentTimetable(_studentId);
                dgvData.DataSource = timetable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading timetable: {ex.Message}");
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            
        }

        private void btnViewTimetable_Click_1(object sender, EventArgs e)
        {
            try
            {
                var timetable = DatabaseManager.Instance.GetStudentTimetable(_studentId);
                dgvData.DataSource = timetable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading timetable: {ex.Message}");
            }
        }

        private void btnViewMarks_Click_1(object sender, EventArgs e)
        {
            try
            {
                var marks = DatabaseManager.Instance.GetStudentMarks(_studentId);
                dgvData.DataSource = marks;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading marks: {ex.Message}");
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            btnLogout.Enabled = false;


            var loginform = new LoginForm();
            loginform.Show();


            btnLogout.Enabled = true;
        }
    }
}
