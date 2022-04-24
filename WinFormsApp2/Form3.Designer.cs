namespace WinFormsApp2
{
    partial class Form3
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
            this.ReportTable = new System.Windows.Forms.DataGridView();
            this.Queue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportTable
            // 
            this.ReportTable.AllowUserToAddRows = false;
            this.ReportTable.AllowUserToDeleteRows = false;
            this.ReportTable.AllowUserToResizeColumns = false;
            this.ReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Queue,
            this.CallId,
            this.CustomerType,
            this.CustomerId,
            this.CallTime});
            this.ReportTable.Location = new System.Drawing.Point(12, 12);
            this.ReportTable.Name = "ReportTable";
            this.ReportTable.ReadOnly = true;
            this.ReportTable.RowTemplate.Height = 25;
            this.ReportTable.Size = new System.Drawing.Size(776, 247);
            this.ReportTable.TabIndex = 1;
            // 
            // Queue
            // 
            this.Queue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Queue.HeaderText = "Name";
            this.Queue.Name = "Queue";
            this.Queue.ReadOnly = true;
            this.Queue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Queue.Width = 45;
            // 
            // CallId
            // 
            this.CallId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CallId.HeaderText = "Id";
            this.CallId.Name = "CallId";
            this.CallId.ReadOnly = true;
            this.CallId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerType
            // 
            this.CustomerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerType.HeaderText = "Type of Service";
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.ReadOnly = true;
            this.CustomerType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerId
            // 
            this.CustomerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerId.HeaderText = "Call Count";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CallTime
            // 
            this.CallTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CallTime.HeaderText = "Current Call";
            this.CallTime.Name = "CallTime";
            this.CallTime.ReadOnly = true;
            this.CallTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 271);
            this.Controls.Add(this.ReportTable);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView ReportTable;
        private DataGridViewTextBoxColumn Queue;
        private DataGridViewTextBoxColumn CallId;
        private DataGridViewTextBoxColumn CustomerType;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn CallTime;
    }
}