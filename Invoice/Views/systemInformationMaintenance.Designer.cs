namespace Invoice.Views
{
    partial class SystemInformationMaintenance
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddressLine2TextBox = new System.Windows.Forms.TextBox();
            this.AddressLine1TextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.ZipTextBox = new System.Windows.Forms.TextBox();
            this.firmRegNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WorkPhoneTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.systemInformationButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firm Reg. #";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 19;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 32);
            this.label4.TabIndex = 22;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(511, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(716, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "Zip";
            // 
            // AddressLine2TextBox
            // 
            this.AddressLine2TextBox.Location = new System.Drawing.Point(223, 248);
            this.AddressLine2TextBox.Name = "AddressLine2TextBox";
            this.AddressLine2TextBox.Size = new System.Drawing.Size(755, 38);
            this.AddressLine2TextBox.TabIndex = 17;
            // 
            // AddressLine1TextBox
            // 
            this.AddressLine1TextBox.Location = new System.Drawing.Point(223, 188);
            this.AddressLine1TextBox.Name = "AddressLine1TextBox";
            this.AddressLine1TextBox.Size = new System.Drawing.Size(755, 38);
            this.AddressLine1TextBox.TabIndex = 15;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(223, 304);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(272, 38);
            this.CityTextBox.TabIndex = 18;
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(599, 301);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(100, 38);
            this.StateTextBox.TabIndex = 20;
            // 
            // ZipTextBox
            // 
            this.ZipTextBox.Location = new System.Drawing.Point(778, 307);
            this.ZipTextBox.Name = "ZipTextBox";
            this.ZipTextBox.Size = new System.Drawing.Size(200, 38);
            this.ZipTextBox.TabIndex = 21;
            // 
            // firmRegNum
            // 
            this.firmRegNum.Location = new System.Drawing.Point(223, 123);
            this.firmRegNum.Name = "firmRegNum";
            this.firmRegNum.Size = new System.Drawing.Size(755, 38);
            this.firmRegNum.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WorkPhoneTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.companyTextBox);
            this.groupBox1.Controls.Add(this.firmRegNum);
            this.groupBox1.Controls.Add(this.ZipTextBox);
            this.groupBox1.Controls.Add(this.StateTextBox);
            this.groupBox1.Controls.Add(this.CityTextBox);
            this.groupBox1.Controls.Add(this.AddressLine1TextBox);
            this.groupBox1.Controls.Add(this.AddressLine2TextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 439);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // WorkPhoneTextBox
            // 
            this.WorkPhoneTextBox.Location = new System.Drawing.Point(223, 370);
            this.WorkPhoneTextBox.Name = "WorkPhoneTextBox";
            this.WorkPhoneTextBox.Size = new System.Drawing.Size(224, 38);
            this.WorkPhoneTextBox.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 32);
            this.label9.TabIndex = 28;
            this.label9.Text = "Phone";
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(223, 55);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(755, 38);
            this.companyTextBox.TabIndex = 26;
            // 
            // systemInformationButton
            // 
            this.systemInformationButton.Location = new System.Drawing.Point(910, 481);
            this.systemInformationButton.Name = "systemInformationButton";
            this.systemInformationButton.Size = new System.Drawing.Size(195, 58);
            this.systemInformationButton.TabIndex = 1;
            this.systemInformationButton.Text = "Edit";
            this.systemInformationButton.UseVisualStyleBackColor = true;
            this.systemInformationButton.Click += new System.EventHandler(this.systemInformationButton_Click);
            // 
            // systemInformationMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 562);
            this.Controls.Add(this.systemInformationButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "systemInformationMaintenance";
            this.Text = "System Information Maintenance";
            this.Activated += new System.EventHandler(this.systemInformationMaintenance_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddressLine2TextBox;
        private System.Windows.Forms.TextBox AddressLine1TextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.TextBox ZipTextBox;
        private System.Windows.Forms.TextBox firmRegNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.Button systemInformationButton;
        private System.Windows.Forms.TextBox WorkPhoneTextBox;
        private System.Windows.Forms.Label label9;
    }
}