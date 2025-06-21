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
            this.dataGridViewTimetables = new System.Windows.Forms.DataGridView();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.txtTimeSlot = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetables)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTimetables
            // 
            this.dataGridViewTimetables.AllowUserToAddRows = false;
            this.dataGridViewTimetables.AllowUserToDeleteRows = false;
            this.dataGridViewTimetables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimetables.Location = new System.Drawing.Point(12, 190);
            this.dataGridViewTimetables.Name = "dataGridViewTimetables";
            this.dataGridViewTimetables.ReadOnly = true;
            this.dataGridViewTimetables.RowHeadersWidth = 51;
            this.dataGridViewTimetables.RowTemplate.Height = 24;
            this.dataGridViewTimetables.Size = new System.Drawing.Size(760, 250);
            this.dataGridViewTimetables.TabIndex = 0;
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(120, 25);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(200, 24);
            this.cmbSubject.TabIndex = 1;
            // 
            // cmbRoom
            // 
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(120, 65);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(200, 24);
            this.cmbRoom.TabIndex = 2;
            // 
            // txtTimeSlot
            // 
            this.txtTimeSlot.Location = new System.Drawing.Point(120, 105);
            this.txtTimeSlot.Name = "txtTimeSlot";
            this.txtTimeSlot.Size = new System.Drawing.Size(200, 22);
            this.txtTimeSlot.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSubject.Location = new System.Drawing.Point(40, 28);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(59, 20);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRoom.Location = new System.Drawing.Point(40, 68);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(51, 20);
            this.lblRoom.TabIndex = 5;
            this.lblRoom.Text = "Room";
            // 
            // lblTimeSlot
            // 
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTimeSlot.Location = new System.Drawing.Point(40, 108);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Size = new System.Drawing.Size(73, 20);
            this.lblTimeSlot.TabIndex = 6;
            this.lblTimeSlot.Text = "Time Slot";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(360, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(360, 65);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(360, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // TimetableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTimeSlot);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtTimeSlot);
            this.Controls.Add(this.cmbRoom);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.dataGridViewTimetables);
            this.Name = "TimetableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timetable Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
