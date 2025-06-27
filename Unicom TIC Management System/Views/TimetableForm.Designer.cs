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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimetableForm));
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
            resources.ApplyResources(dataGridViewTimetables, "dataGridViewTimetables");
            dataGridViewTimetables.Name = "dataGridViewTimetables";
            dataGridViewTimetables.ReadOnly = true;
            dataGridViewTimetables.RowTemplate.Height = 24;
            dataGridViewTimetables.CellContentClick += dataGridViewTimetables_CellContentClick;
            dataGridViewTimetables.SelectionChanged += dataGridViewTimetables_SelectionChanged_1;
            // 
            // cmbSubject
            // 
            cmbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSubject.FormattingEnabled = true;
            resources.ApplyResources(cmbSubject, "cmbSubject");
            cmbSubject.Name = "cmbSubject";
            // 
            // cmbRoom
            // 
            cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoom.FormattingEnabled = true;
            resources.ApplyResources(cmbRoom, "cmbRoom");
            cmbRoom.Name = "cmbRoom";
            // 
            // txtTimeSlot
            // 
            resources.ApplyResources(txtTimeSlot, "txtTimeSlot");
            txtTimeSlot.Name = "txtTimeSlot";
            // 
            // lblSubject
            // 
            resources.ApplyResources(lblSubject, "lblSubject");
            lblSubject.Name = "lblSubject";
            // 
            // lblRoom
            // 
            resources.ApplyResources(lblRoom, "lblRoom");
            lblRoom.Name = "lblRoom";
            // 
            // lblTimeSlot
            // 
            resources.ApplyResources(lblTimeSlot, "lblTimeSlot");
            lblTimeSlot.Name = "lblTimeSlot";
            // 
            // btnAdd
            // 
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.Name = "btnAdd";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            resources.ApplyResources(btnUpdate, "btnUpdate");
            btnUpdate.Name = "btnUpdate";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.Name = "btnDelete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // TimetableForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "TimetableForm";
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
