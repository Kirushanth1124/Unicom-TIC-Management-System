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
            dataGridViewTimetable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetable).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTimetable
            // 
            dataGridViewTimetable.AllowUserToAddRows = false;
            dataGridViewTimetable.AllowUserToDeleteRows = false;
            dataGridViewTimetable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTimetable.Location = new Point(18, 62);
            dataGridViewTimetable.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTimetable.Name = "dataGridViewTimetable";
            dataGridViewTimetable.ReadOnly = true;
            dataGridViewTimetable.RowHeadersWidth = 51;
            dataGridViewTimetable.RowTemplate.Height = 29;
            dataGridViewTimetable.Size = new Size(550, 253);
            dataGridViewTimetable.TabIndex = 0;
            dataGridViewTimetable.CellContentClick += dataGridViewTimetable_CellContentClick;
            // 
            // TimetableView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 346);
            Controls.Add(dataGridViewTimetable);
            Margin = new Padding(3, 2, 3, 2);
            Name = "TimetableView";
            Load += StudentTimetableForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTimetable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTimetable;
    }
}
