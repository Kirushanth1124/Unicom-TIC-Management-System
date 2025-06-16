namespace Unicom_TIC_Management_System.Views
{
    partial class TimetableForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtSubjectId = new TextBox();
            txtTimeSlot = new TextBox();
            txtRoomtId = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridViewTimetables = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetables).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Subject ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 65);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Room ID";
            // 
            // txtSubjectId
            // 
            txtSubjectId.Location = new Point(120, 19);
            txtSubjectId.Name = "txtSubjectId";
            txtSubjectId.Size = new Size(150, 23);
            txtSubjectId.TabIndex = 2;
            // 
            // txtTimeSlot
            // 
            txtTimeSlot.Location = new Point(120, 110);
            txtTimeSlot.Name = "txtTimeSlot";
            txtTimeSlot.Size = new Size(150, 23);
            txtTimeSlot.TabIndex = 3;
            // 
            // txtRoomtId
            // 
            txtRoomtId.Location = new Point(120, 62);
            txtRoomtId.Name = "txtRoomtId";
            txtRoomtId.Size = new Size(150, 23);
            txtRoomtId.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 113);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Time Slot";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(300, 19);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 27);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(300, 62);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 27);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(300, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 27);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewTimetables
            // 
            dataGridViewTimetables.AllowUserToAddRows = false;
            dataGridViewTimetables.AllowUserToDeleteRows = false;
            dataGridViewTimetables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTimetables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTimetables.Location = new Point(25, 162);
            dataGridViewTimetables.MultiSelect = false;
            dataGridViewTimetables.Name = "dataGridViewTimetables";
            dataGridViewTimetables.ReadOnly = true;
            dataGridViewTimetables.RowHeadersVisible = false;
            dataGridViewTimetables.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTimetables.Size = new Size(550, 200);
            dataGridViewTimetables.TabIndex = 9;
            dataGridViewTimetables.CellContentClick += dataGridViewTimetables_CellContentClick;
            dataGridViewTimetables.SelectionChanged += dataGridViewTimetables_SelectionChanged;
            // 
            // TimetableForm
            // 
            ClientSize = new Size(600, 400);
            Controls.Add(dataGridViewTimetables);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(txtRoomtId);
            Controls.Add(txtTimeSlot);
            Controls.Add(txtSubjectId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TimetableForm";
            Text = "Timetable Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetables).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubjectId;
        private System.Windows.Forms.TextBox txtTimeSlot;
        private System.Windows.Forms.TextBox txtRoomtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewTimetables;
    }
}
