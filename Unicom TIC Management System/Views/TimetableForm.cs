using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System.Views
{
    public partial class TimetableForm : Form
    {
        private readonly TimeTableController _controller = new TimeTableController();

        public TimetableForm()
        {
            InitializeComponent();
            LoadTimetables();
        }

        private void LoadTimetables()
        {
            var timetables = _controller.GetAllTimetables();
            dataGridViewTimetables.DataSource = null;
            dataGridViewTimetables.DataSource = timetables;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var timetable = new Timetable
            {
                SubjectId = int.Parse(txtSubjectId.Text),
                TimeSlot = txtTimeSlot.Text,
                RoomId = int.Parse(txtRoomtId.Text)
            };

            _controller.AddTimetable(timetable);
            LoadTimetables();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTimetables.SelectedRows.Count == 0 || !ValidateInputs())
            {
                MessageBox.Show("Please select a row and enter all fields.");
                return;
            }

            var selected = dataGridViewTimetables.SelectedRows[0];
            int timetableId = Convert.ToInt32(selected.Cells["TimetableId"].Value);

            var timetable = new Timetable
            {
                TimetableId = timetableId,
                SubjectId = int.Parse(txtSubjectId.Text),
                TimeSlot = txtTimeSlot.Text,
                RoomId = int.Parse(txtRoomtId.Text)
            };

            _controller.UpdateTimetable(timetable);
            LoadTimetables();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTimetables.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a timetable to delete.");
                return;
            }

            int timetableId = Convert.ToInt32(dataGridViewTimetables.SelectedRows[0].Cells["TimetableId"].Value);
            _controller.DeleteTimetable(timetableId);
            LoadTimetables();
            ClearInputs();
        }

        private void dataGridViewTimetables_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTimetables.SelectedRows.Count > 0)
            {
                var row = dataGridViewTimetables.SelectedRows[0];
                txtSubjectId.Text = row.Cells["SubjectId"].Value.ToString();
                txtTimeSlot.Text = row.Cells["TimeSlot"].Value.ToString();
                txtRoomtId.Text = row.Cells["RoomId"].Value.ToString();
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtSubjectId.Text) || string.IsNullOrWhiteSpace(txtTimeSlot.Text) || string.IsNullOrWhiteSpace(txtRoomtId.Text))
            {
                MessageBox.Show("All fields are required.");
                return false;
            }

            return int.TryParse(txtSubjectId.Text, out _) && int.TryParse(txtRoomtId.Text, out _);
        }

        private void ClearInputs()
        {
            txtSubjectId.Clear();
            txtTimeSlot.Clear();
            txtRoomtId.Clear();
        }
    }
}
