namespace Unicom_TIC_Management_System
{
    partial class TimetableView
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
            this.dataGridViewTimetable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTimetable
            // 
            this.dataGridViewTimetable.AllowUserToAddRows = false;
            this.dataGridViewTimetable.AllowUserToDeleteRows = false;
            this.dataGridViewTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTimetable.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewTimetable.Name = "dataGridViewTimetable";
            this.dataGridViewTimetable.ReadOnly = true;
            this.dataGridViewTimetable.RowHeadersWidth = 51;
            this.dataGridViewTimetable.RowTemplate.Height = 29;
            this.dataGridViewTimetable.Size = new System.Drawing.Size(740, 400);
            this.dataGridViewTimetable.TabIndex = 0;
            // 
            // TimetableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridViewTimetable);
            this.Name = "TimetableView";
            this.Text = "Student Timetable View";
            this.Load += new System.EventHandler(this.StudentTimetableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTimetable)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTimetable;
    }
}
