namespace Unicom_TIC_Management_System.Views
{
    partial class TimetableForm
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
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewTimetables = new DataGridView();
            cmbSubject = new ComboBox();
            cmbRoom = new ComboBox();
            txtTimeSlot = new TextBox();
            lblSubject = new Label();
            lblRoom = new Label();
            lblTimeSlot = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetables).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTimetables
            // 
            dataGridViewTimetables.AllowUserToAddRows = false;
            dataGridViewTimetables.AllowUserToDeleteRows = false;
            dataGridViewTimetables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTimetables.Location = new Point(10, 178);
            dataGridViewTimetables.Name = "dataGridViewTimetables";
            dataGridViewTimetables.ReadOnly = true;
            dataGridViewTimetables.RowHeadersWidth = 51;
            dataGridViewTimetables.RowTemplate.Height = 24;
            dataGridViewTimetables.Size = new Size(665, 234);
            dataGridViewTimetables.TabIndex = 0;
            dataGridViewTimetables.CellContentClick += dataGridViewTimetables_CellContentClick;
            // 
            // cmbSubject
            // 
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(105, 23);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(176, 23);
            cmbSubject.TabIndex = 1;
            // 
            // cmbRoom
            // 
            cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(105, 61);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(176, 23);
            cmbRoom.TabIndex = 2;
            // 
            // txtTimeSlot
            // 
            txtTimeSlot.Location = new Point(105, 98);
            txtTimeSlot.Name = "txtTimeSlot";
            txtTimeSlot.Size = new Size(176, 23);
            txtTimeSlot.TabIndex = 3;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubject.Location = new Point(35, 26);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(49, 15);
            lblSubject.TabIndex = 4;
            lblSubject.Text = "Subject";
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRoom.Location = new Point(35, 64);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(40, 15);
            lblRoom.TabIndex = 5;
            lblRoom.Text = "Room";
            // 
            // lblTimeSlot
            // 
            lblTimeSlot.AutoSize = true;
            lblTimeSlot.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTimeSlot.Location = new Point(35, 101);
            lblTimeSlot.Name = "lblTimeSlot";
            lblTimeSlot.Size = new Size(60, 15);
            lblTimeSlot.TabIndex = 6;
            lblTimeSlot.Text = "Time Slot";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(315, 23);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(79, 28);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(315, 61);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(79, 28);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(315, 98);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(79, 28);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // TimetableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 432);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblTimeSlot);
            Controls.Add(lblRoom);
            Controls.Add(lblSubject);
            Controls.Add(txtTimeSlot);
            Controls.Add(cmbRoom);
            Controls.Add(cmbSubject);
            Controls.Add(dataGridViewTimetables);
            Name = "TimetableForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timetable Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetables).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTimetables;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.TextBox txtTimeSlot;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
