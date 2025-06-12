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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtSubjectId = new TextBox();
            txtTimeSlot = new TextBox();
            txtRoomtId = new TextBox();
            label3 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dataGridViewTimetables = new DataGridView();
            grpInputs = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetables).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 22);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Subject ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 67);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Room ID";
            // 
            // txtSubjectId
            // 
            txtSubjectId.Location = new Point(136, 19);
            txtSubjectId.Name = "txtSubjectId";
            txtSubjectId.Size = new Size(100, 23);
            txtSubjectId.TabIndex = 2;
            // 
            // txtTimeSlot
            // 
            txtTimeSlot.Location = new Point(136, 112);
            txtTimeSlot.Name = "txtTimeSlot";
            txtTimeSlot.Size = new Size(100, 23);
            txtTimeSlot.TabIndex = 3;
            // 
            // txtRoomtId
            // 
            txtRoomtId.Location = new Point(136, 64);
            txtRoomtId.Name = "txtRoomtId";
            txtRoomtId.Size = new Size(100, 23);
            txtRoomtId.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 120);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Time Slot";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(324, 67);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(324, 120);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(324, 22);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTimetables
            // 
            dataGridViewTimetables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTimetables.Location = new Point(405, 22);
            dataGridViewTimetables.Name = "dataGridViewTimetables";
            dataGridViewTimetables.Size = new Size(383, 158);
            dataGridViewTimetables.TabIndex = 9;
            // 
            // grpInputs
            // 
            grpInputs.Location = new Point(12, 168);
            grpInputs.Name = "grpInputs";
            grpInputs.Size = new Size(387, 280);
            grpInputs.TabIndex = 10;
            grpInputs.TabStop = false;
            grpInputs.Text = "Time Table Information";
            // 
            // TimetableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpInputs);
            Controls.Add(dataGridViewTimetables);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(txtRoomtId);
            Controls.Add(txtTimeSlot);
            Controls.Add(txtSubjectId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TimetableForm";
            Text = "TimetableForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetables).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSubjectId;
        private TextBox txtTimeSlot;
        private TextBox txtRoomtId;
        private Label label3;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dataGridViewTimetables;
        private GroupBox grpInputs;
    }
}