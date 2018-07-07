namespace Invoice.Views
{
    partial class BrowseEmployeeRecords
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
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.Employee = new System.Windows.Forms.Label();
            this.employeeAddresslabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeePhoneLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(35, 71);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(695, 39);
            this.employeeComboBox.TabIndex = 0;
            this.employeeComboBox.Click += new System.EventHandler(this.employeeComboBox_Click);
            // 
            // Employee
            // 
            this.Employee.AutoSize = true;
            this.Employee.Location = new System.Drawing.Point(29, 25);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(150, 32);
            this.Employee.TabIndex = 2;
            this.Employee.Text = "Empolyee:";
            // 
            // employeeAddresslabel
            // 
            this.employeeAddresslabel.AutoSize = true;
            this.employeeAddresslabel.Location = new System.Drawing.Point(40, 180);
            this.employeeAddresslabel.Name = "employeeAddresslabel";
            this.employeeAddresslabel.Size = new System.Drawing.Size(0, 32);
            this.employeeAddresslabel.TabIndex = 18;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(40, 137);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(0, 32);
            this.employeeNameLabel.TabIndex = 17;
            // 
            // employeePhoneLabel
            // 
            this.employeePhoneLabel.AutoSize = true;
            this.employeePhoneLabel.Location = new System.Drawing.Point(40, 290);
            this.employeePhoneLabel.Name = "employeePhoneLabel";
            this.employeePhoneLabel.Size = new System.Drawing.Size(0, 32);
            this.employeePhoneLabel.TabIndex = 19;
            // 
            // BrowseEmployeeRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 373);
            this.Controls.Add(this.employeeAddresslabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.employeePhoneLabel);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.employeeComboBox);
            this.Name = "BrowseEmployeeRecords";
            this.Text = "BrowseEmployeeRecords";
            this.Activated += new System.EventHandler(this.BrowseEmployeeRecords_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.Label Employee;
        private System.Windows.Forms.Label employeeAddresslabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeePhoneLabel;
    }
}