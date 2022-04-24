namespace WinFormsApp2
{
    partial class Form2
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
            this.CustomerRepresentativeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBOx1 = new System.Windows.Forms.GroupBox();
            this.AssignCallBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AssignSpecificCallBtn = new System.Windows.Forms.Button();
            this.CustomerRepresentativeComboBox2 = new System.Windows.Forms.ComboBox();
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.groupBOx1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerRepresentativeComboBox
            // 
            this.CustomerRepresentativeComboBox.FormattingEnabled = true;
            this.CustomerRepresentativeComboBox.Location = new System.Drawing.Point(59, 70);
            this.CustomerRepresentativeComboBox.Name = "CustomerRepresentativeComboBox";
            this.CustomerRepresentativeComboBox.Size = new System.Drawing.Size(121, 23);
            this.CustomerRepresentativeComboBox.TabIndex = 3;
            // 
            // groupBOx1
            // 
            this.groupBOx1.Controls.Add(this.AssignCallBtn);
            this.groupBOx1.Controls.Add(this.CustomerRepresentativeComboBox);
            this.groupBOx1.Location = new System.Drawing.Point(12, 12);
            this.groupBOx1.Name = "groupBOx1";
            this.groupBOx1.Size = new System.Drawing.Size(243, 254);
            this.groupBOx1.TabIndex = 4;
            this.groupBOx1.TabStop = false;
            this.groupBOx1.Text = "Sıradaki Çağrıyı Aktar";
            // 
            // AssignCallBtn
            // 
            this.AssignCallBtn.Location = new System.Drawing.Point(59, 142);
            this.AssignCallBtn.Name = "AssignCallBtn";
            this.AssignCallBtn.Size = new System.Drawing.Size(121, 23);
            this.AssignCallBtn.TabIndex = 0;
            this.AssignCallBtn.Text = "Çağrıyı Ata";
            this.AssignCallBtn.UseVisualStyleBackColor = true;
            this.AssignCallBtn.Click += new System.EventHandler(this.AssignCallBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AssignSpecificCallBtn);
            this.groupBox2.Controls.Add(this.CustomerRepresentativeComboBox2);
            this.groupBox2.Controls.Add(this.CustomerIdTextBox);
            this.groupBox2.Location = new System.Drawing.Point(261, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 254);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçilen Çağrıyı Aktar";
            // 
            // AssignSpecificCallBtn
            // 
            this.AssignSpecificCallBtn.Location = new System.Drawing.Point(57, 142);
            this.AssignSpecificCallBtn.Name = "AssignSpecificCallBtn";
            this.AssignSpecificCallBtn.Size = new System.Drawing.Size(121, 23);
            this.AssignSpecificCallBtn.TabIndex = 4;
            this.AssignSpecificCallBtn.Text = "Çağrıyı Ata";
            this.AssignSpecificCallBtn.UseVisualStyleBackColor = true;
            this.AssignSpecificCallBtn.Click += new System.EventHandler(this.AssignSpecificCallBtn_Click);
            // 
            // CustomerRepresentativeComboBox2
            // 
            this.CustomerRepresentativeComboBox2.FormattingEnabled = true;
            this.CustomerRepresentativeComboBox2.Items.AddRange(new object[] {
            ""});
            this.CustomerRepresentativeComboBox2.Location = new System.Drawing.Point(57, 99);
            this.CustomerRepresentativeComboBox2.Name = "CustomerRepresentativeComboBox2";
            this.CustomerRepresentativeComboBox2.Size = new System.Drawing.Size(121, 23);
            this.CustomerRepresentativeComboBox2.TabIndex = 4;
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Location = new System.Drawing.Point(57, 70);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.PlaceholderText = "Lütfen bir id girin";
            this.CustomerIdTextBox.Size = new System.Drawing.Size(121, 23);
            this.CustomerIdTextBox.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 273);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBOx1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBOx1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox CustomerRepresentativeComboBox;
        private GroupBox groupBOx1;
        private Button AssignCallBtn;
        private GroupBox groupBox2;
        private ComboBox CustomerRepresentativeComboBox2;
        private TextBox CustomerIdTextBox;
        private Button AssignSpecificCallBtn;
    }
}