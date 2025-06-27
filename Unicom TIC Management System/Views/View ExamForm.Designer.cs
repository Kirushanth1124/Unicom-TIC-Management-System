namespace Unicom_TIC_Management_System.Views
{
    partial class ViewExamOnlyForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewExamOnly;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewExamOnly = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExamOnly).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewExamOnly
            // 
            dataGridViewExamOnly.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExamOnly.Location = new Point(12, 12);
            dataGridViewExamOnly.Name = "dataGridViewExamOnly";
            dataGridViewExamOnly.Size = new Size(460, 300);
            dataGridViewExamOnly.TabIndex = 0;
            dataGridViewExamOnly.CellContentClick += dataGridViewExamOnly_CellContentClick;
            // 
            // ViewExamOnlyForm
            // 
            ClientSize = new Size(484, 331);
            Controls.Add(dataGridViewExamOnly);
            Name = "ViewExamOnlyForm";
            Text = "Exam Details Viewer";
            ((System.ComponentModel.ISupportInitialize)dataGridViewExamOnly).EndInit();
            ResumeLayout(false);
        }
    }
}
