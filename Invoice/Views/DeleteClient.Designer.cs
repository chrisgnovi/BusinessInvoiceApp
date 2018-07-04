namespace Invoice
{
    partial class DeleteClient
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
            this.deleteClientComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteClientComboBox
            // 
            this.deleteClientComboBox.FormattingEnabled = true;
            this.deleteClientComboBox.Location = new System.Drawing.Point(54, 82);
            this.deleteClientComboBox.Name = "deleteClientComboBox";
            this.deleteClientComboBox.Size = new System.Drawing.Size(602, 39);
            this.deleteClientComboBox.TabIndex = 0;
            this.deleteClientComboBox.SelectedIndexChanged += new System.EventHandler(this.deleteClientComboBox_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clients:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(474, 146);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(182, 50);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // DeleteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 230);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteClientComboBox);
            this.Name = "DeleteClient";
            this.Text = "DeleteClient";
            this.Activated += new System.EventHandler(this.DeleteClient_Activated);
            this.Click += new System.EventHandler(this.DeleteClient_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deleteClientComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
    }
}