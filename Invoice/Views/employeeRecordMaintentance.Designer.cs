namespace Invoice
{
    partial class employeeRecordMaintentance
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
            this.addEmloyeeRecordsButton = new System.Windows.Forms.Button();
            this.browseRmployeeRecordsButton = new System.Windows.Forms.Button();
            this.DeleteEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEmloyeeRecordsButton
            // 
            this.addEmloyeeRecordsButton.Location = new System.Drawing.Point(23, 31);
            this.addEmloyeeRecordsButton.Name = "addEmloyeeRecordsButton";
            this.addEmloyeeRecordsButton.Size = new System.Drawing.Size(389, 60);
            this.addEmloyeeRecordsButton.TabIndex = 0;
            this.addEmloyeeRecordsButton.Text = "Add New Employee Record ";
            this.addEmloyeeRecordsButton.UseVisualStyleBackColor = true;
            this.addEmloyeeRecordsButton.Click += new System.EventHandler(this.addEmloyeeRecordsButton_Click);
            // 
            // browseRmployeeRecordsButton
            // 
            this.browseRmployeeRecordsButton.Location = new System.Drawing.Point(23, 113);
            this.browseRmployeeRecordsButton.Name = "browseRmployeeRecordsButton";
            this.browseRmployeeRecordsButton.Size = new System.Drawing.Size(389, 57);
            this.browseRmployeeRecordsButton.TabIndex = 1;
            this.browseRmployeeRecordsButton.Text = "Browse Employee Records ";
            this.browseRmployeeRecordsButton.UseVisualStyleBackColor = true;
            this.browseRmployeeRecordsButton.Click += new System.EventHandler(this.browseRmployeeRecordsButton_Click);
            // 
            // DeleteEmployee
            // 
            this.DeleteEmployee.Location = new System.Drawing.Point(23, 189);
            this.DeleteEmployee.Name = "DeleteEmployee";
            this.DeleteEmployee.Size = new System.Drawing.Size(389, 57);
            this.DeleteEmployee.TabIndex = 2;
            this.DeleteEmployee.Text = "Delete Employee";
            this.DeleteEmployee.UseVisualStyleBackColor = true;
            this.DeleteEmployee.Click += new System.EventHandler(this.deleteEmployeeRecords_Click);
            // 
            // employeeRecordMaintentance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 264);
            this.Controls.Add(this.DeleteEmployee);
            this.Controls.Add(this.browseRmployeeRecordsButton);
            this.Controls.Add(this.addEmloyeeRecordsButton);
            this.Name = "employeeRecordMaintentance";
            this.Text = "employeeRecordMaintentance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEmloyeeRecordsButton;
        private System.Windows.Forms.Button browseRmployeeRecordsButton;
        private System.Windows.Forms.Button DeleteEmployee;
    }
}