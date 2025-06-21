namespace Unicom_TIC_Management_System.Views
{
    partial class RoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblRoomId = new Label();
            txtRoomId = new TextBox();
            lblRoomName = new Label();
            txtRoomName = new TextBox();
            lblRoomType = new Label();
            txtRoomType = new TextBox();
            dataGridViewRooms = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            SuspendLayout();
            // 
            // lblRoomId
            // 
            lblRoomId.AutoSize = true;
            lblRoomId.Location = new Point(53, 47);
            lblRoomId.Name = "lblRoomId";
            lblRoomId.Size = new Size(53, 15);
            lblRoomId.TabIndex = 0;
            lblRoomId.Text = "Room ID";
            // 
            // txtRoomId
            // 
            txtRoomId.Location = new Point(165, 44);
            txtRoomId.Name = "txtRoomId";
            txtRoomId.Size = new Size(100, 23);
            txtRoomId.TabIndex = 1;
            // 
            // lblRoomName
            // 
            lblRoomName.AutoSize = true;
            lblRoomName.Location = new Point(53, 85);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(74, 15);
            lblRoomName.TabIndex = 2;
            lblRoomName.Text = "Room Name";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(165, 82);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(100, 23);
            txtRoomName.TabIndex = 3;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(53, 131);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(65, 15);
            lblRoomType.TabIndex = 4;
            lblRoomType.Text = "Room type";
            // 
            // txtRoomType
            // 
            txtRoomType.Location = new Point(165, 131);
            txtRoomType.Name = "txtRoomType";
            txtRoomType.Size = new Size(100, 23);
            txtRoomType.TabIndex = 5;
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Location = new Point(25, 219);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.Size = new Size(568, 198);
            dataGridViewRooms.TabIndex = 6;
            dataGridViewRooms.CellContentClick += dataGridViewRooms_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(53, 175);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(175, 175);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(314, 175);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewRooms);
            Controls.Add(txtRoomType);
            Controls.Add(lblRoomType);
            Controls.Add(txtRoomName);
            Controls.Add(lblRoomName);
            Controls.Add(txtRoomId);
            Controls.Add(lblRoomId);
            Name = "RoomForm";
            Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoomId;
        private TextBox txtRoomId;
        private Label lblRoomName;
        private TextBox txtRoomName;
        private Label lblRoomType;
        private TextBox txtRoomType;
        private DataGridView dataGridViewRooms;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
    }
}