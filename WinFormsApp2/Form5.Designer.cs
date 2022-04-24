namespace WinFormsApp2
{
    partial class Form5
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
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            this.ResultTable = new System.Windows.Forms.DataGridView();
            this.CallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AraBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Location = new System.Drawing.Point(12, 24);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.PlaceholderText = "Lütfen aranacak kelimeyi giriniz.";
            this.SearchTxtBox.Size = new System.Drawing.Size(204, 23);
            this.SearchTxtBox.TabIndex = 0;
            // 
            // ResultTable
            // 
            this.ResultTable.AllowUserToAddRows = false;
            this.ResultTable.AllowUserToDeleteRows = false;
            this.ResultTable.AllowUserToResizeColumns = false;
            this.ResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CallId,
            this.CustomerId,
            this.Column3,
            this.Column2});
            this.ResultTable.Location = new System.Drawing.Point(12, 53);
            this.ResultTable.Name = "ResultTable";
            this.ResultTable.ReadOnly = true;
            this.ResultTable.RowTemplate.Height = 25;
            this.ResultTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultTable.Size = new System.Drawing.Size(845, 426);
            this.ResultTable.TabIndex = 3;
            // 
            // CallId
            // 
            this.CallId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CallId.HeaderText = "Id";
            this.CallId.Name = "CallId";
            this.CallId.ReadOnly = true;
            this.CallId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CallId.Width = 23;
            // 
            // CustomerId
            // 
            this.CustomerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CustomerId.HeaderText = "Call Time";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CustomerId.Width = 56;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.HeaderText = "Customer Representative";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column3.Width = 131;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Notes";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AraBtn
            // 
            this.AraBtn.Location = new System.Drawing.Point(222, 23);
            this.AraBtn.Name = "AraBtn";
            this.AraBtn.Size = new System.Drawing.Size(134, 23);
            this.AraBtn.TabIndex = 4;
            this.AraBtn.Text = "Kelimeyi Notlarda Ara";
            this.AraBtn.UseVisualStyleBackColor = true;
            this.AraBtn.Click += new System.EventHandler(this.AraBtn_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 507);
            this.Controls.Add(this.AraBtn);
            this.Controls.Add(this.ResultTable);
            this.Controls.Add(this.SearchTxtBox);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox SearchTxtBox;
        private DataGridView ResultTable;
        private DataGridViewTextBoxColumn CallId;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private Button AraBtn;
    }
}