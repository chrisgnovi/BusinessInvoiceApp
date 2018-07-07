namespace Invoice.Views
{
    partial class BillingCodeMaintance
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
            this.deleteExpenseCodes = new System.Windows.Forms.Button();
            this.browseExpenseCodeButton = new System.Windows.Forms.Button();
            this.addENewExpenseCodesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteServiceCodesButton = new System.Windows.Forms.Button();
            this.browseServiceCodes = new System.Windows.Forms.Button();
            this.AddNewServiceCodes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteExpenseCodes
            // 
            this.deleteExpenseCodes.Location = new System.Drawing.Point(47, 276);
            this.deleteExpenseCodes.Name = "deleteExpenseCodes";
            this.deleteExpenseCodes.Size = new System.Drawing.Size(389, 57);
            this.deleteExpenseCodes.TabIndex = 5;
            this.deleteExpenseCodes.Text = "Delete Expense Codes";
            this.deleteExpenseCodes.UseVisualStyleBackColor = true;
            this.deleteExpenseCodes.Click += new System.EventHandler(this.deleteExpenseCodes_Click);
            // 
            // browseExpenseCodeButton
            // 
            this.browseExpenseCodeButton.Location = new System.Drawing.Point(47, 200);
            this.browseExpenseCodeButton.Name = "browseExpenseCodeButton";
            this.browseExpenseCodeButton.Size = new System.Drawing.Size(389, 57);
            this.browseExpenseCodeButton.TabIndex = 4;
            this.browseExpenseCodeButton.Text = "Browse Expense Code ";
            this.browseExpenseCodeButton.UseVisualStyleBackColor = true;
            this.browseExpenseCodeButton.Click += new System.EventHandler(this.browseExpenseCodeButton_Click);
            // 
            // addENewExpenseCodesButton
            // 
            this.addENewExpenseCodesButton.Location = new System.Drawing.Point(47, 118);
            this.addENewExpenseCodesButton.Name = "addENewExpenseCodesButton";
            this.addENewExpenseCodesButton.Size = new System.Drawing.Size(389, 60);
            this.addENewExpenseCodesButton.TabIndex = 3;
            this.addENewExpenseCodesButton.Text = "Add New Expense Code";
            this.addENewExpenseCodesButton.UseVisualStyleBackColor = true;
            this.addENewExpenseCodesButton.Click += new System.EventHandler(this.addENewExpenseCodesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Expense Codes";
            // 
            // deleteServiceCodesButton
            // 
            this.deleteServiceCodesButton.Location = new System.Drawing.Point(474, 276);
            this.deleteServiceCodesButton.Name = "deleteServiceCodesButton";
            this.deleteServiceCodesButton.Size = new System.Drawing.Size(389, 57);
            this.deleteServiceCodesButton.TabIndex = 9;
            this.deleteServiceCodesButton.Text = "Delete Service Codes";
            this.deleteServiceCodesButton.UseVisualStyleBackColor = true;
            this.deleteServiceCodesButton.Click += new System.EventHandler(this.editServiceCodesbutton_Click);
            // 
            // browseServiceCodes
            // 
            this.browseServiceCodes.Location = new System.Drawing.Point(474, 200);
            this.browseServiceCodes.Name = "browseServiceCodes";
            this.browseServiceCodes.Size = new System.Drawing.Size(389, 57);
            this.browseServiceCodes.TabIndex = 8;
            this.browseServiceCodes.Text = "Browse Service Codes";
            this.browseServiceCodes.UseVisualStyleBackColor = true;
            this.browseServiceCodes.Click += new System.EventHandler(this.browseServiceCodes_Click);
            // 
            // AddNewServiceCodes
            // 
            this.AddNewServiceCodes.Location = new System.Drawing.Point(474, 118);
            this.AddNewServiceCodes.Name = "AddNewServiceCodes";
            this.AddNewServiceCodes.Size = new System.Drawing.Size(389, 60);
            this.AddNewServiceCodes.TabIndex = 7;
            this.AddNewServiceCodes.Text = "Add New Service Codes";
            this.AddNewServiceCodes.UseVisualStyleBackColor = true;
            this.AddNewServiceCodes.Click += new System.EventHandler(this.AddNewServiceCodes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Service Codes";
            // 
            // BillingCodeMaintance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 377);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteServiceCodesButton);
            this.Controls.Add(this.browseServiceCodes);
            this.Controls.Add(this.AddNewServiceCodes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteExpenseCodes);
            this.Controls.Add(this.browseExpenseCodeButton);
            this.Controls.Add(this.addENewExpenseCodesButton);
            this.Name = "BillingCodeMaintance";
            this.Text = "BillingCodeMaintance";
            this.Load += new System.EventHandler(this.BillingCodeMaintance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteExpenseCodes;
        private System.Windows.Forms.Button browseExpenseCodeButton;
        private System.Windows.Forms.Button addENewExpenseCodesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteServiceCodesButton;
        private System.Windows.Forms.Button browseServiceCodes;
        private System.Windows.Forms.Button AddNewServiceCodes;
        private System.Windows.Forms.Label label2;
    }
}