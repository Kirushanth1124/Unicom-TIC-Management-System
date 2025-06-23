using System;
using System.Windows.Forms;
using SchoolManageSystem.Controllers;
using Unicom_TIC_Management_System.Modals;
using System.Collections.Generic;

namespace Unicom_TIC_Management_System.Views
{
    public partial class RoomForm : Form
    {
        private readonly RoomController _controller = new RoomController();

        public RoomForm()
        {
            InitializeComponent();
            LoadRooms();
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            dataGridViewRooms.SelectionChanged += DataGridViewRooms_SelectionChanged;
        }

        private void LoadRooms()
        {
            var rooms = _controller.GetAllRooms();
            dataGridViewRooms.DataSource = null;
            dataGridViewRooms.DataSource = rooms;

            if (dataGridViewRooms.Columns["RoomId"] != null)
                dataGridViewRooms.Columns["RoomId"].HeaderText = "Room ID";
            if (dataGridViewRooms.Columns["RoomName"] != null)
                dataGridViewRooms.Columns["RoomName"].HeaderText = "Room Name";
            if (dataGridViewRooms.Columns["RoomType"] != null)
                dataGridViewRooms.Columns["RoomType"].HeaderText = "Room Type";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (/*string.IsNullOrWhiteSpace(txtRoomId.Text) ||*/ string.IsNullOrWhiteSpace(txtRoomName.Text) || string.IsNullOrWhiteSpace(txtRoomType.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var room = new Room
            {
                /*RoomID = int.Parse(txtRoomId.Text),*/
                RoomName = txtRoomName.Text.Trim(),
                RoomType = txtRoomType.Text.Trim()
            };

            _controller.AddRoom(room);
            LoadRooms();
            ClearInputs();
            MessageBox.Show("Room added successfully!");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a room to update.");
                return;
            }

            var room = new Room
            {
                /*RoomID = int.Parse(txtRoomId.Text),*/
                RoomName = txtRoomName.Text.Trim(),
                RoomType = txtRoomType.Text.Trim()
            };

            _controller.UpdateRoom(room);
            LoadRooms();
            ClearInputs();
            MessageBox.Show("Room updated successfully!");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a room to delete.");
                return;
            }

            var selectedRow = dataGridViewRooms.SelectedRows[0];
            int roomId = Convert.ToInt32(selectedRow.Cells["RoomId"].Value);

            _controller.DeleteRoom(roomId);
            LoadRooms();
            ClearInputs();
            MessageBox.Show("Room deleted successfully!");
        }

        private void DataGridViewRooms_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                var row = dataGridViewRooms.SelectedRows[0];
                /*txtRoomId.Text = row.Cells["RoomId"].Value.ToString();*/
                txtRoomName.Text = row.Cells["RoomName"].Value.ToString();
                txtRoomType.Text = row.Cells["RoomType"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtRoomId.Clear();
            txtRoomName.Clear();
            txtRoomType.Clear();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text) || string.IsNullOrWhiteSpace(txtRoomType.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var room = new Room
            {
                RoomName = txtRoomName.Text.Trim(),
                RoomType = txtRoomType.Text.Trim()
            };

            _controller.AddRoom(room);
            LoadRooms();
            ClearInputs();
            MessageBox.Show("Room added successfully!");
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a room to update.");
                return;
            }

            // Ensure that RoomID is correctly passed
            int roomId;
            if (!int.TryParse(txtRoomId.Text, out roomId))  // This prevents crash if RoomID is not an integer
            {
                MessageBox.Show("Invalid Room ID.");
                return;
            }

            var room = new Room
            {
                RoomID = roomId,
                RoomName = txtRoomName.Text.Trim(),
                RoomType = txtRoomType.Text.Trim()
            };

            // Pass Room object to controller to update
            _controller.UpdateRoom(room);
            LoadRooms();  // Reload rooms to reflect changes
            ClearInputs();  // Clear input fields
            MessageBox.Show("Room updated successfully!");  // Show success message
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a room to delete.");
                return;
            }

            var selectedRow = dataGridViewRooms.SelectedRows[0];
            int roomId = Convert.ToInt32(selectedRow.Cells["RoomId"].Value);

            _controller.DeleteRoom(roomId);
            LoadRooms();
            ClearInputs();
            MessageBox.Show("Room deleted successfully!");
        }

        private void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                var row = dataGridViewRooms.SelectedRows[0];
                txtRoomId.Text = row.Cells["RoomId"].Value.ToString();
                txtRoomName.Text = row.Cells["RoomName"].Value.ToString();
                txtRoomType.Text = row.Cells["RoomType"].Value.ToString();
            }
        }
    }
}
