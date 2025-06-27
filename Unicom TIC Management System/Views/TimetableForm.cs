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
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\C.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            LoadSubjects();
            LoadRooms();
            LoadTimetables();

            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dataGridViewTimetables.SelectionChanged += DataGridViewTimetables_SelectionChanged;

            dataGridViewTimetables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTimetables.ReadOnly = true;
            dataGridViewTimetables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadSubjects()
        {
            cmbSubject.DataSource = _controller.GetAllSubjects();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.SelectedIndex = -1;
        }

        private void LoadRooms()
        {
            cmbRoom.DataSource = _controller.GetAllRooms();
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomID";
            cmbRoom.SelectedIndex = -1;
        }

        private void LoadTimetables()
        {
            var list = _controller.GetAllTimetables();
            dataGridViewTimetables.DataSource = list;

            dataGridViewTimetables.Columns["TimetableID"].HeaderText = "Timetable ID";
            dataGridViewTimetables.Columns["SubjectName"].HeaderText = "Subject";
            dataGridViewTimetables.Columns["TimeSlot"].HeaderText = "Time Slot";
            dataGridViewTimetables.Columns["RoomName"].HeaderText = "Room";
            dataGridViewTimetables.Columns["RoomType"].HeaderText = "Room Type";

            dataGridViewTimetables.Columns["SubjectID"].Visible = false;
            dataGridViewTimetables.Columns["RoomID"].Visible = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var t = new Timetable
            {
                SubjectID = (int)cmbSubject.SelectedValue,
                RoomID = (int)cmbRoom.SelectedValue,
                TimeSlot = txtTimeSlot.Text.Trim()
            };

            try
            {
                _controller.AddTimetable(t);
                MessageBox.Show("Added successfully!");
                LoadTimetables();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewTimetables.SelectedRows.Count == 0 || !ValidateInputs())
            {
                MessageBox.Show("Select a row and fill all fields.");
                return;
            }

            var id = Convert.ToInt32(dataGridViewTimetables.SelectedRows[0].Cells["TimetableID"].Value);

            var t = new Timetable
            {
                TimetableID = id,
                SubjectID = (int)cmbSubject.SelectedValue,
                RoomID = (int)cmbRoom.SelectedValue,
                TimeSlot = txtTimeSlot.Text.Trim()
            };

            try
            {
                _controller.UpdateTimetable(t);
                MessageBox.Show("Updated successfully.");
                LoadTimetables();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTimetables.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a timetable to delete.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewTimetables.SelectedRows[0].Cells["TimetableID"].Value);

            if (MessageBox.Show("Confirm delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _controller.DeleteTimetable(id);
                MessageBox.Show("Deleted successfully.");
                LoadTimetables();
                ClearInputs();
            }
        }

        private void DataGridViewTimetables_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTimetables.SelectedRows.Count > 0)
            {
                var row = dataGridViewTimetables.SelectedRows[0];
                txtTimeSlot.Text = row.Cells["TimeSlot"].Value?.ToString();
                cmbSubject.SelectedValue = row.Cells["SubjectID"].Value;
                cmbRoom.SelectedValue = row.Cells["RoomID"].Value;
            }
        }

        private bool ValidateInputs()
        {
            if (cmbSubject.SelectedIndex < 0 || cmbRoom.SelectedIndex < 0 || string.IsNullOrWhiteSpace(txtTimeSlot.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            cmbSubject.SelectedIndex = -1;
            cmbRoom.SelectedIndex = -1;
            txtTimeSlot.Clear();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            var t = new Timetable
            {
                SubjectID = (int)cmbSubject.SelectedValue,
                RoomID = (int)cmbRoom.SelectedValue,
                TimeSlot = txtTimeSlot.Text.Trim()
            };

            try
            {
                _controller.AddTimetable(t);
                MessageBox.Show("Added successfully!");
                LoadTimetables();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewTimetables.SelectedRows.Count == 0 || !ValidateInputs())
            {
                MessageBox.Show("Select a row and fill all fields.");
                return;
            }

            var id = Convert.ToInt32(dataGridViewTimetables.SelectedRows[0].Cells["TimetableID"].Value);

            var t = new Timetable
            {
                TimetableID = id,
                SubjectID = (int)cmbSubject.SelectedValue,
                RoomID = (int)cmbRoom.SelectedValue,
                TimeSlot = txtTimeSlot.Text.Trim()
            };

            try
            {
                _controller.UpdateTimetable(t);
                MessageBox.Show("Updated successfully.");
                LoadTimetables();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewTimetables.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a timetable to delete.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewTimetables.SelectedRows[0].Cells["TimetableID"].Value);

            if (MessageBox.Show("Confirm delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _controller.DeleteTimetable(id);
                MessageBox.Show("Deleted successfully.");
                LoadTimetables();
                ClearInputs();
            }
        }

        private void dataGridViewTimetables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridViewTimetables_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewTimetables.SelectedRows.Count > 0)
            {
                var row = dataGridViewTimetables.SelectedRows[0];
                txtTimeSlot.Text = row.Cells["TimeSlot"].Value?.ToString();
                cmbSubject.SelectedValue = row.Cells["SubjectID"].Value;
                cmbRoom.SelectedValue = row.Cells["RoomID"].Value;
            }
        }
    }
}
