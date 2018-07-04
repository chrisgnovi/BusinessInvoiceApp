namespace Invoice
{
    partial class addBilling
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
            this.addBillComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addBillComboBox
            // 
            this.addBillComboBox.FormattingEnabled = true;
            this.addBillComboBox.Location = new System.Drawing.Point(187, 149);
            this.addBillComboBox.Name = "addBillComboBox";
            this.addBillComboBox.Size = new System.Drawing.Size(870, 39);
            this.addBillComboBox.TabIndex = 0;
            this.addBillComboBox.SelectedIndexChanged += new System.EventHandler(this.addBillComboBox_SelectedIndexChanged);
            this.addBillComboBox.Click += new System.EventHandler(this.addBillComboBox_Click);
            // 
            // addBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 1082);
            this.Controls.Add(this.addBillComboBox);
            this.Name = "addBilling";
            this.Text = "addBilling";
            this.Activated += new System.EventHandler(this.addBilling_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox addBillComboBox;
    }
}