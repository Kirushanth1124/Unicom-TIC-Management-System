namespace Unicom_TIC_Management_System.Views
{
    partial class StudentDashboardForm
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
            btnViewMarks = new Button();
            btnViewTimetable = new Button();
            btnLogout = new Button();
            dgvData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnViewMarks
            // 
            btnViewMarks.Location = new Point(28, 34);
            btnViewMarks.Name = "btnViewMarks";
            btnViewMarks.Size = new Size(110, 23);
            btnViewMarks.TabIndex = 1;
            btnViewMarks.Text = "View Marks";
            btnViewMarks.UseVisualStyleBackColor = true;
            btnViewMarks.Click += btnViewMarks_Click_1;
            // 
            // btnViewTimetable
            // 
            btnViewTimetable.Location = new Point(28, 87);
            btnViewTimetable.Name = "btnViewTimetable";
            btnViewTimetable.Size = new Size(110, 23);
            btnViewTimetable.TabIndex = 2;
            btnViewTimetable.Text = "View Timetable";
            btnViewTimetable.UseVisualStyleBackColor = true;
            btnViewTimetable.Click += btnViewTimetable_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(687, 396);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 196);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(389, 198);
            dgvData.TabIndex = 4;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // StudentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvData);
            Controls.Add(btnLogout);
            Controls.Add(btnViewTimetable);
            Controls.Add(btnViewMarks);
            Name = "StudentDashboardForm";
            Text = "StudentDashboardForm";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnViewMarks;
        private Button btnViewTimetable;
        private Button btnLogout;
        private DataGridView dgvData;
    }
}