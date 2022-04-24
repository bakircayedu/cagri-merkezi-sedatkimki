namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CallTable = new System.Windows.Forms.DataGridView();
            this.Queue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CallTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CustomerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.MakeCallBtn = new System.Windows.Forms.Button();
            this.AssignCallBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cr1TxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cr1Btn = new System.Windows.Forms.Button();
            this.Cr1Lbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cr2TxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cr2Btn = new System.Windows.Forms.Button();
            this.Cr2Lbl = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Cr3TxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cr3Btn = new System.Windows.Forms.Button();
            this.Cr3Lbl = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Cr4TxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cr4Btn = new System.Windows.Forms.Button();
            this.Cr4Lbl = new System.Windows.Forms.Label();
            this.SortedCallsBtn = new System.Windows.Forms.Button();
            this.EndedCallsLogBtn = new System.Windows.Forms.Button();
            this.LoadSampleDataBtn = new System.Windows.Forms.Button();
            this.SearchBySenteceBtn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CallTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // CallTable
            // 
            this.CallTable.AllowUserToAddRows = false;
            this.CallTable.AllowUserToDeleteRows = false;
            this.CallTable.AllowUserToResizeColumns = false;
            this.CallTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CallTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Queue,
            this.CallId,
            this.CustomerType,
            this.CustomerId,
            this.CallTime});
            this.CallTable.Location = new System.Drawing.Point(6, 32);
            this.CallTable.Name = "CallTable";
            this.CallTable.ReadOnly = true;
            this.CallTable.RowTemplate.Height = 25;
            this.CallTable.Size = new System.Drawing.Size(564, 239);
            this.CallTable.TabIndex = 0;
            // 
            // Queue
            // 
            this.Queue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Queue.HeaderText = "Queue";
            this.Queue.Name = "Queue";
            this.Queue.ReadOnly = true;
            this.Queue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Queue.Width = 48;
            // 
            // CallId
            // 
            this.CallId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CallId.HeaderText = "Call Id";
            this.CallId.Name = "CallId";
            this.CallId.ReadOnly = true;
            this.CallId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerType
            // 
            this.CustomerType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerType.HeaderText = "Customer Type";
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.ReadOnly = true;
            this.CustomerType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CustomerId
            // 
            this.CustomerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerId.HeaderText = "Customer Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            this.CustomerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CallTime
            // 
            this.CallTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CallTime.HeaderText = "Call Time";
            this.CallTime.Name = "CallTime";
            this.CallTime.ReadOnly = true;
            this.CallTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CallTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 315);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sıradaki çağrılar";
            // 
            // CustomerTypeComboBox
            // 
            this.CustomerTypeComboBox.FormattingEnabled = true;
            this.CustomerTypeComboBox.Items.AddRange(new object[] {
            "Individual\t",
            "Commercial"});
            this.CustomerTypeComboBox.Location = new System.Drawing.Point(23, 52);
            this.CustomerTypeComboBox.Name = "CustomerTypeComboBox";
            this.CustomerTypeComboBox.Size = new System.Drawing.Size(165, 23);
            this.CustomerTypeComboBox.TabIndex = 2;
            this.CustomerTypeComboBox.Text = "Servis Türü seçiniz";
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Location = new System.Drawing.Point(23, 22);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.PlaceholderText = "Lütfen bir id girin";
            this.CustomerIdTextBox.Size = new System.Drawing.Size(165, 23);
            this.CustomerIdTextBox.TabIndex = 3;
            // 
            // MakeCallBtn
            // 
            this.MakeCallBtn.Location = new System.Drawing.Point(23, 81);
            this.MakeCallBtn.Name = "MakeCallBtn";
            this.MakeCallBtn.Size = new System.Drawing.Size(165, 42);
            this.MakeCallBtn.TabIndex = 4;
            this.MakeCallBtn.Text = "Arama Yap";
            this.MakeCallBtn.UseVisualStyleBackColor = true;
            this.MakeCallBtn.Click += new System.EventHandler(this.MakeCallBtn_Click);
            // 
            // AssignCallBtn
            // 
            this.AssignCallBtn.Location = new System.Drawing.Point(15, 22);
            this.AssignCallBtn.Name = "AssignCallBtn";
            this.AssignCallBtn.Size = new System.Drawing.Size(129, 59);
            this.AssignCallBtn.TabIndex = 5;
            this.AssignCallBtn.Text = "Çağrı Ata";
            this.AssignCallBtn.UseVisualStyleBackColor = true;
            this.AssignCallBtn.Click += new System.EventHandler(this.AssignCallBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cr1TxtBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Cr1Btn);
            this.groupBox2.Controls.Add(this.Cr1Lbl);
            this.groupBox2.Location = new System.Drawing.Point(12, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 355);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri temsilcisi Sedat";
            // 
            // Cr1TxtBox
            // 
            this.Cr1TxtBox.Location = new System.Drawing.Point(6, 44);
            this.Cr1TxtBox.Multiline = true;
            this.Cr1TxtBox.Name = "Cr1TxtBox";
            this.Cr1TxtBox.Size = new System.Drawing.Size(259, 257);
            this.Cr1TxtBox.TabIndex = 0;
            this.Cr1TxtBox.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(34, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 50);
            this.label5.TabIndex = 8;
            this.label5.Text = "Şuan Boşta";
            // 
            // Cr1Btn
            // 
            this.Cr1Btn.Location = new System.Drawing.Point(6, 314);
            this.Cr1Btn.Name = "Cr1Btn";
            this.Cr1Btn.Size = new System.Drawing.Size(259, 23);
            this.Cr1Btn.TabIndex = 8;
            this.Cr1Btn.Text = "Aramayı bitir";
            this.Cr1Btn.UseVisualStyleBackColor = true;
            this.Cr1Btn.Visible = false;
            this.Cr1Btn.Click += new System.EventHandler(this.Cr1Btn_Click);
            // 
            // Cr1Lbl
            // 
            this.Cr1Lbl.AutoSize = true;
            this.Cr1Lbl.Location = new System.Drawing.Point(6, 26);
            this.Cr1Lbl.Name = "Cr1Lbl";
            this.Cr1Lbl.Size = new System.Drawing.Size(40, 15);
            this.Cr1Lbl.TabIndex = 7;
            this.Cr1Lbl.Text = "Notlar";
            this.Cr1Lbl.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Cr2TxtBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Cr2Btn);
            this.groupBox3.Controls.Add(this.Cr2Lbl);
            this.groupBox3.Location = new System.Drawing.Point(289, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 355);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri temsilcisi Ali";
            // 
            // Cr2TxtBox
            // 
            this.Cr2TxtBox.Location = new System.Drawing.Point(6, 44);
            this.Cr2TxtBox.Multiline = true;
            this.Cr2TxtBox.Name = "Cr2TxtBox";
            this.Cr2TxtBox.Size = new System.Drawing.Size(259, 257);
            this.Cr2TxtBox.TabIndex = 1;
            this.Cr2TxtBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(35, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 50);
            this.label6.TabIndex = 9;
            this.label6.Text = "Şuan Boşta";
            // 
            // Cr2Btn
            // 
            this.Cr2Btn.Location = new System.Drawing.Point(6, 314);
            this.Cr2Btn.Name = "Cr2Btn";
            this.Cr2Btn.Size = new System.Drawing.Size(259, 23);
            this.Cr2Btn.TabIndex = 9;
            this.Cr2Btn.Text = "Aramayı bitir";
            this.Cr2Btn.UseVisualStyleBackColor = true;
            this.Cr2Btn.Visible = false;
            this.Cr2Btn.Click += new System.EventHandler(this.Cr2Btn_Click);
            // 
            // Cr2Lbl
            // 
            this.Cr2Lbl.AutoSize = true;
            this.Cr2Lbl.Location = new System.Drawing.Point(6, 26);
            this.Cr2Lbl.Name = "Cr2Lbl";
            this.Cr2Lbl.Size = new System.Drawing.Size(40, 15);
            this.Cr2Lbl.TabIndex = 6;
            this.Cr2Lbl.Text = "Notlar";
            this.Cr2Lbl.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Cr3TxtBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.Cr3Btn);
            this.groupBox4.Controls.Add(this.Cr3Lbl);
            this.groupBox4.Location = new System.Drawing.Point(566, 333);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 355);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Müşteri temsilcisi Deniz";
            // 
            // Cr3TxtBox
            // 
            this.Cr3TxtBox.Location = new System.Drawing.Point(6, 44);
            this.Cr3TxtBox.Multiline = true;
            this.Cr3TxtBox.Name = "Cr3TxtBox";
            this.Cr3TxtBox.Size = new System.Drawing.Size(259, 257);
            this.Cr3TxtBox.TabIndex = 2;
            this.Cr3TxtBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(35, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 50);
            this.label7.TabIndex = 10;
            this.label7.Text = "Şuan Boşta";
            // 
            // Cr3Btn
            // 
            this.Cr3Btn.Location = new System.Drawing.Point(6, 314);
            this.Cr3Btn.Name = "Cr3Btn";
            this.Cr3Btn.Size = new System.Drawing.Size(259, 23);
            this.Cr3Btn.TabIndex = 10;
            this.Cr3Btn.Text = "Aramayı bitir";
            this.Cr3Btn.UseVisualStyleBackColor = true;
            this.Cr3Btn.Visible = false;
            this.Cr3Btn.Click += new System.EventHandler(this.Cr3Btn_Click);
            // 
            // Cr3Lbl
            // 
            this.Cr3Lbl.AutoSize = true;
            this.Cr3Lbl.Location = new System.Drawing.Point(6, 26);
            this.Cr3Lbl.Name = "Cr3Lbl";
            this.Cr3Lbl.Size = new System.Drawing.Size(40, 15);
            this.Cr3Lbl.TabIndex = 5;
            this.Cr3Lbl.Text = "Notlar";
            this.Cr3Lbl.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Cr4TxtBox);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.Cr4Btn);
            this.groupBox5.Controls.Add(this.Cr4Lbl);
            this.groupBox5.Location = new System.Drawing.Point(843, 333);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(271, 355);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Müşteri temsilcisi Okan";
            // 
            // Cr4TxtBox
            // 
            this.Cr4TxtBox.Location = new System.Drawing.Point(6, 44);
            this.Cr4TxtBox.Multiline = true;
            this.Cr4TxtBox.Name = "Cr4TxtBox";
            this.Cr4TxtBox.Size = new System.Drawing.Size(259, 257);
            this.Cr4TxtBox.TabIndex = 3;
            this.Cr4TxtBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(36, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 50);
            this.label8.TabIndex = 11;
            this.label8.Text = "Şuan Boşta";
            // 
            // Cr4Btn
            // 
            this.Cr4Btn.Location = new System.Drawing.Point(6, 314);
            this.Cr4Btn.Name = "Cr4Btn";
            this.Cr4Btn.Size = new System.Drawing.Size(259, 23);
            this.Cr4Btn.TabIndex = 11;
            this.Cr4Btn.Text = "Aramayı bitir";
            this.Cr4Btn.UseVisualStyleBackColor = true;
            this.Cr4Btn.Visible = false;
            this.Cr4Btn.Click += new System.EventHandler(this.Cr4Btn_Click);
            // 
            // Cr4Lbl
            // 
            this.Cr4Lbl.AutoSize = true;
            this.Cr4Lbl.Location = new System.Drawing.Point(6, 26);
            this.Cr4Lbl.Name = "Cr4Lbl";
            this.Cr4Lbl.Size = new System.Drawing.Size(40, 15);
            this.Cr4Lbl.TabIndex = 4;
            this.Cr4Lbl.Text = "Notlar";
            this.Cr4Lbl.Visible = false;
            // 
            // SortedCallsBtn
            // 
            this.SortedCallsBtn.Location = new System.Drawing.Point(15, 87);
            this.SortedCallsBtn.Name = "SortedCallsBtn";
            this.SortedCallsBtn.Size = new System.Drawing.Size(129, 70);
            this.SortedCallsBtn.TabIndex = 8;
            this.SortedCallsBtn.Text = "Tamamlanan Toplam Arama Raporu";
            this.SortedCallsBtn.UseVisualStyleBackColor = true;
            this.SortedCallsBtn.Click += new System.EventHandler(this.SortedCallsBtn_Click);
            // 
            // EndedCallsLogBtn
            // 
            this.EndedCallsLogBtn.Location = new System.Drawing.Point(163, 87);
            this.EndedCallsLogBtn.Name = "EndedCallsLogBtn";
            this.EndedCallsLogBtn.Size = new System.Drawing.Size(121, 70);
            this.EndedCallsLogBtn.TabIndex = 9;
            this.EndedCallsLogBtn.Text = "Tamamlanan Çağrıları Göster";
            this.EndedCallsLogBtn.UseVisualStyleBackColor = true;
            this.EndedCallsLogBtn.Click += new System.EventHandler(this.EndedCallsLogBtn_Click);
            // 
            // LoadSampleDataBtn
            // 
            this.LoadSampleDataBtn.Location = new System.Drawing.Point(162, 22);
            this.LoadSampleDataBtn.Name = "LoadSampleDataBtn";
            this.LoadSampleDataBtn.Size = new System.Drawing.Size(122, 59);
            this.LoadSampleDataBtn.TabIndex = 10;
            this.LoadSampleDataBtn.Text = "Örnek Verileri Yükle";
            this.LoadSampleDataBtn.UseVisualStyleBackColor = true;
            this.LoadSampleDataBtn.Click += new System.EventHandler(this.LoadSampleDataBtn_Click);
            // 
            // SearchBySenteceBtn
            // 
            this.SearchBySenteceBtn.Location = new System.Drawing.Point(305, 51);
            this.SearchBySenteceBtn.Name = "SearchBySenteceBtn";
            this.SearchBySenteceBtn.Size = new System.Drawing.Size(120, 60);
            this.SearchBySenteceBtn.TabIndex = 11;
            this.SearchBySenteceBtn.Text = "Notlarda Arama Yap";
            this.SearchBySenteceBtn.UseVisualStyleBackColor = true;
            this.SearchBySenteceBtn.Click += new System.EventHandler(this.SearchBySenteceBtn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CustomerIdTextBox);
            this.groupBox6.Controls.Add(this.CustomerTypeComboBox);
            this.groupBox6.Controls.Add(this.MakeCallBtn);
            this.groupBox6.Location = new System.Drawing.Point(605, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(232, 129);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Arama ekle";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.AssignCallBtn);
            this.groupBox7.Controls.Add(this.LoadSampleDataBtn);
            this.groupBox7.Controls.Add(this.SearchBySenteceBtn);
            this.groupBox7.Controls.Add(this.SortedCallsBtn);
            this.groupBox7.Controls.Add(this.EndedCallsLogBtn);
            this.groupBox7.Location = new System.Drawing.Point(605, 147);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(442, 180);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Çağrı İşlemleri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 700);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CallTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView CallTable;
        private GroupBox groupBox1;
        private ComboBox CustomerTypeComboBox;
        private TextBox CustomerIdTextBox;
        private Button MakeCallBtn;
        private DataGridViewTextBoxColumn Queue;
        private DataGridViewTextBoxColumn CallId;
        private DataGridViewTextBoxColumn CustomerType;
        private DataGridViewTextBoxColumn CustomerId;
        private DataGridViewTextBoxColumn CallTime;
        private Button AssignCallBtn;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label Cr1Lbl;
        private TextBox Cr1TxtBox;
        private Label Cr2Lbl;
        private TextBox Cr2TxtBox;
        private Label Cr3Lbl;
        private TextBox Cr3TxtBox;
        private Label Cr4Lbl;
        private TextBox Cr4TxtBox;
        private Button Cr1Btn;
        private Button Cr2Btn;
        private Button Cr3Btn;
        private Button Cr4Btn;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button SortedCallsBtn;
        private Button EndedCallsLogBtn;
        private Button LoadSampleDataBtn;
        private Button SearchBySenteceBtn;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
    }
}