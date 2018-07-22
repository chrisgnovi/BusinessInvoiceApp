using System.Windows.Forms;

namespace Invoice
{
    partial class Mainmenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editClientInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingCodesMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeRecordMaintentanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemInfomationMaintentanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.ClientslistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.carrierAddresslabel = new System.Windows.Forms.Label();
            this.carrierNamelabel = new System.Windows.Forms.Label();
            this.carrierPhonelabel = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.attroneyNamelabel = new System.Windows.Forms.Label();
            this.attorneyAddresslabel = new System.Windows.Forms.Label();
            this.AttorneyPhonelabel = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.qrcAddresslabel = new System.Windows.Forms.Label();
            this.qrcNamelabel = new System.Windows.Forms.Label();
            this.qrcPhonelabel = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.ClientAddresslabel = new System.Windows.Forms.Label();
            this.claimNumberlabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientPhoneLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteDailyActivityTextBox = new System.Windows.Forms.TextBox();
            this.deleteDailyActivity = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.activityAmountTextBox = new System.Windows.Forms.TextBox();
            this.activityExpenseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.activityServiceDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.activityMileageTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.activityBillingCodeComboBox = new System.Windows.Forms.ComboBox();
            this.AddDailyActivityButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activityTimeTextBox = new System.Windows.Forms.TextBox();
            this.activityDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activityDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.summaryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.printInvoiceButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.generateInvoiceButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.invoiceDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.endingDateActivityDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startingDateActivtyDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.invoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.companynameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(2699, 49);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(75, 45);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.newToolStripMenuItem.Text = "New Client";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(396, 46);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteClientToolStripMenuItem,
            this.editClientInformationToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(80, 45);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(429, 46);
            this.deleteClientToolStripMenuItem.Text = "Delete Client";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // editClientInformationToolStripMenuItem
            // 
            this.editClientInformationToolStripMenuItem.Name = "editClientInformationToolStripMenuItem";
            this.editClientInformationToolStripMenuItem.Size = new System.Drawing.Size(429, 46);
            this.editClientInformationToolStripMenuItem.Text = "Edit Client Information";
            this.editClientInformationToolStripMenuItem.Click += new System.EventHandler(this.editClientInformationToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.billingCodesMaintenanceToolStripMenuItem,
            this.employeeRecordMaintentanceToolStripMenuItem,
            this.systemInfomationMaintentanceToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(128, 45);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // billingCodesMaintenanceToolStripMenuItem
            // 
            this.billingCodesMaintenanceToolStripMenuItem.Name = "billingCodesMaintenanceToolStripMenuItem";
            this.billingCodesMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(569, 46);
            this.billingCodesMaintenanceToolStripMenuItem.Text = "Billing Codes Maintenance";
            this.billingCodesMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.billingCodesMaintenanceToolStripMenuItem_Click);
            // 
            // employeeRecordMaintentanceToolStripMenuItem
            // 
            this.employeeRecordMaintentanceToolStripMenuItem.Name = "employeeRecordMaintentanceToolStripMenuItem";
            this.employeeRecordMaintentanceToolStripMenuItem.Size = new System.Drawing.Size(569, 46);
            this.employeeRecordMaintentanceToolStripMenuItem.Text = "Employee Record Maintentance";
            this.employeeRecordMaintentanceToolStripMenuItem.Click += new System.EventHandler(this.employeeRecordMaintentanceToolStripMenuItem_Click);
            // 
            // systemInfomationMaintentanceToolStripMenuItem
            // 
            this.systemInfomationMaintentanceToolStripMenuItem.Name = "systemInfomationMaintentanceToolStripMenuItem";
            this.systemInfomationMaintentanceToolStripMenuItem.Size = new System.Drawing.Size(569, 46);
            this.systemInfomationMaintentanceToolStripMenuItem.Text = "System Infomation Maintentance";
            this.systemInfomationMaintentanceToolStripMenuItem.Click += new System.EventHandler(this.systemInfomationMaintentanceToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(92, 45);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(214, 46);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ClientslistBox
            // 
            this.ClientslistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientslistBox.FormattingEnabled = true;
            this.ClientslistBox.ItemHeight = 31;
            this.ClientslistBox.Location = new System.Drawing.Point(45, 176);
            this.ClientslistBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientslistBox.Name = "ClientslistBox";
            this.ClientslistBox.Size = new System.Drawing.Size(300, 1213);
            this.ClientslistBox.TabIndex = 2;
            this.ClientslistBox.Click += new System.EventHandler(this.ClientslistBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Clients";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(389, 176);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2283, 1219);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.groupBox10);
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(2263, 1161);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.carrierAddresslabel);
            this.groupBox11.Controls.Add(this.carrierNamelabel);
            this.groupBox11.Controls.Add(this.carrierPhonelabel);
            this.groupBox11.Location = new System.Drawing.Point(1256, 615);
            this.groupBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox11.Size = new System.Drawing.Size(901, 529);
            this.groupBox11.TabIndex = 30;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Carrier Information";
            // 
            // carrierAddresslabel
            // 
            this.carrierAddresslabel.AutoSize = true;
            this.carrierAddresslabel.Location = new System.Drawing.Point(21, 93);
            this.carrierAddresslabel.Name = "carrierAddresslabel";
            this.carrierAddresslabel.Size = new System.Drawing.Size(199, 32);
            this.carrierAddresslabel.TabIndex = 18;
            this.carrierAddresslabel.Text = "carrierAddress";
            // 
            // carrierNamelabel
            // 
            this.carrierNamelabel.AutoSize = true;
            this.carrierNamelabel.Location = new System.Drawing.Point(19, 50);
            this.carrierNamelabel.Name = "carrierNamelabel";
            this.carrierNamelabel.Size = new System.Drawing.Size(170, 32);
            this.carrierNamelabel.TabIndex = 17;
            this.carrierNamelabel.Text = "carrierName";
            // 
            // carrierPhonelabel
            // 
            this.carrierPhonelabel.AutoSize = true;
            this.carrierPhonelabel.Location = new System.Drawing.Point(19, 203);
            this.carrierPhonelabel.Name = "carrierPhonelabel";
            this.carrierPhonelabel.Size = new System.Drawing.Size(178, 32);
            this.carrierPhonelabel.TabIndex = 19;
            this.carrierPhonelabel.Text = "carrierPhone";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.attroneyNamelabel);
            this.groupBox10.Controls.Add(this.attorneyAddresslabel);
            this.groupBox10.Controls.Add(this.AttorneyPhonelabel);
            this.groupBox10.Location = new System.Drawing.Point(43, 615);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox10.Size = new System.Drawing.Size(1171, 529);
            this.groupBox10.TabIndex = 29;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Attorney Information";
            // 
            // attroneyNamelabel
            // 
            this.attroneyNamelabel.AutoSize = true;
            this.attroneyNamelabel.Location = new System.Drawing.Point(16, 50);
            this.attroneyNamelabel.Name = "attroneyNamelabel";
            this.attroneyNamelabel.Size = new System.Drawing.Size(193, 32);
            this.attroneyNamelabel.TabIndex = 23;
            this.attroneyNamelabel.Text = "attorneyName";
            // 
            // attorneyAddresslabel
            // 
            this.attorneyAddresslabel.AutoSize = true;
            this.attorneyAddresslabel.Location = new System.Drawing.Point(16, 93);
            this.attorneyAddresslabel.Name = "attorneyAddresslabel";
            this.attorneyAddresslabel.Size = new System.Drawing.Size(222, 32);
            this.attorneyAddresslabel.TabIndex = 24;
            this.attorneyAddresslabel.Text = "attorneyAddress";
            // 
            // AttorneyPhonelabel
            // 
            this.AttorneyPhonelabel.AutoSize = true;
            this.AttorneyPhonelabel.Location = new System.Drawing.Point(16, 205);
            this.AttorneyPhonelabel.Name = "AttorneyPhonelabel";
            this.AttorneyPhonelabel.Size = new System.Drawing.Size(201, 32);
            this.AttorneyPhonelabel.TabIndex = 25;
            this.AttorneyPhonelabel.Text = "attorneyPhone";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.qrcAddresslabel);
            this.groupBox9.Controls.Add(this.qrcNamelabel);
            this.groupBox9.Controls.Add(this.qrcPhonelabel);
            this.groupBox9.Location = new System.Drawing.Point(1256, 38);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox9.Size = new System.Drawing.Size(901, 529);
            this.groupBox9.TabIndex = 28;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "QRC Information";
            // 
            // qrcAddresslabel
            // 
            this.qrcAddresslabel.AutoSize = true;
            this.qrcAddresslabel.Location = new System.Drawing.Point(21, 95);
            this.qrcAddresslabel.Name = "qrcAddresslabel";
            this.qrcAddresslabel.Size = new System.Drawing.Size(158, 32);
            this.qrcAddresslabel.TabIndex = 21;
            this.qrcAddresslabel.Text = "qrcAddress";
            // 
            // qrcNamelabel
            // 
            this.qrcNamelabel.AutoSize = true;
            this.qrcNamelabel.Location = new System.Drawing.Point(27, 48);
            this.qrcNamelabel.Name = "qrcNamelabel";
            this.qrcNamelabel.Size = new System.Drawing.Size(129, 32);
            this.qrcNamelabel.TabIndex = 20;
            this.qrcNamelabel.Text = "qrcName";
            // 
            // qrcPhonelabel
            // 
            this.qrcPhonelabel.AutoSize = true;
            this.qrcPhonelabel.Location = new System.Drawing.Point(27, 205);
            this.qrcPhonelabel.Name = "qrcPhonelabel";
            this.qrcPhonelabel.Size = new System.Drawing.Size(137, 32);
            this.qrcPhonelabel.TabIndex = 22;
            this.qrcPhonelabel.Text = "qrcPhone";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.ClientAddresslabel);
            this.groupBox8.Controls.Add(this.claimNumberlabel);
            this.groupBox8.Controls.Add(this.clientNameLabel);
            this.groupBox8.Controls.Add(this.clientPhoneLabel);
            this.groupBox8.Location = new System.Drawing.Point(43, 38);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox8.Size = new System.Drawing.Size(1171, 529);
            this.groupBox8.TabIndex = 27;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Client Information";
            // 
            // ClientAddresslabel
            // 
            this.ClientAddresslabel.AutoSize = true;
            this.ClientAddresslabel.Location = new System.Drawing.Point(16, 138);
            this.ClientAddresslabel.Name = "ClientAddresslabel";
            this.ClientAddresslabel.Size = new System.Drawing.Size(187, 32);
            this.ClientAddresslabel.TabIndex = 15;
            this.ClientAddresslabel.Text = "cleintAddress";
            // 
            // claimNumberlabel
            // 
            this.claimNumberlabel.AutoSize = true;
            this.claimNumberlabel.Location = new System.Drawing.Point(16, 48);
            this.claimNumberlabel.Name = "claimNumberlabel";
            this.claimNumberlabel.Size = new System.Drawing.Size(182, 32);
            this.claimNumberlabel.TabIndex = 26;
            this.claimNumberlabel.Text = "claimNumber";
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.AutoSize = true;
            this.clientNameLabel.Location = new System.Drawing.Point(16, 95);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(158, 32);
            this.clientNameLabel.TabIndex = 0;
            this.clientNameLabel.Text = "clientName";
            // 
            // clientPhoneLabel
            // 
            this.clientPhoneLabel.AutoSize = true;
            this.clientPhoneLabel.Location = new System.Drawing.Point(21, 248);
            this.clientPhoneLabel.Name = "clientPhoneLabel";
            this.clientPhoneLabel.Size = new System.Drawing.Size(166, 32);
            this.clientPhoneLabel.TabIndex = 16;
            this.clientPhoneLabel.Text = "cleintPhone";
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(2263, 1161);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Activity Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteDailyActivityTextBox);
            this.groupBox3.Controls.Add(this.deleteDailyActivity);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(1864, 703);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(355, 420);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Daily Activity";
            // 
            // deleteDailyActivityTextBox
            // 
            this.deleteDailyActivityTextBox.Location = new System.Drawing.Point(32, 114);
            this.deleteDailyActivityTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.deleteDailyActivityTextBox.Name = "deleteDailyActivityTextBox";
            this.deleteDailyActivityTextBox.Size = new System.Drawing.Size(287, 38);
            this.deleteDailyActivityTextBox.TabIndex = 6;
            // 
            // deleteDailyActivity
            // 
            this.deleteDailyActivity.Location = new System.Drawing.Point(32, 260);
            this.deleteDailyActivity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteDailyActivity.Name = "deleteDailyActivity";
            this.deleteDailyActivity.Size = new System.Drawing.Size(285, 86);
            this.deleteDailyActivity.TabIndex = 5;
            this.deleteDailyActivity.Text = "Delete Daily Activity ";
            this.deleteDailyActivity.UseVisualStyleBackColor = true;
            this.deleteDailyActivity.Click += new System.EventHandler(this.deleteDailyActivity_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Rec#";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.activityAmountTextBox);
            this.groupBox2.Controls.Add(this.activityExpenseCodeComboBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.activityServiceDescriptionTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.activityMileageTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.activityBillingCodeComboBox);
            this.groupBox2.Controls.Add(this.AddDailyActivityButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.activityTimeTextBox);
            this.groupBox2.Controls.Add(this.activityDateTimePicker);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(5, 703);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1720, 420);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Daily Activity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1493, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 32);
            this.label14.TabIndex = 17;
            this.label14.Text = "amount";
            // 
            // activityAmountTextBox
            // 
            this.activityAmountTextBox.Location = new System.Drawing.Point(1501, 112);
            this.activityAmountTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityAmountTextBox.Name = "activityAmountTextBox";
            this.activityAmountTextBox.Size = new System.Drawing.Size(169, 38);
            this.activityAmountTextBox.TabIndex = 16;
            // 
            // activityExpenseCodeComboBox
            // 
            this.activityExpenseCodeComboBox.FormattingEnabled = true;
            this.activityExpenseCodeComboBox.Location = new System.Drawing.Point(1259, 112);
            this.activityExpenseCodeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityExpenseCodeComboBox.Name = "activityExpenseCodeComboBox";
            this.activityExpenseCodeComboBox.Size = new System.Drawing.Size(167, 39);
            this.activityExpenseCodeComboBox.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1251, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(201, 32);
            this.label13.TabIndex = 14;
            this.label13.Text = "Expense Code";
            // 
            // activityServiceDescriptionTextBox
            // 
            this.activityServiceDescriptionTextBox.Location = new System.Drawing.Point(29, 212);
            this.activityServiceDescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityServiceDescriptionTextBox.Multiline = true;
            this.activityServiceDescriptionTextBox.Name = "activityServiceDescriptionTextBox";
            this.activityServiceDescriptionTextBox.Size = new System.Drawing.Size(1185, 149);
            this.activityServiceDescriptionTextBox.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(260, 32);
            this.label12.TabIndex = 12;
            this.label12.Text = "Service Description";
            // 
            // activityMileageTextBox
            // 
            this.activityMileageTextBox.Location = new System.Drawing.Point(1045, 114);
            this.activityMileageTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityMileageTextBox.Name = "activityMileageTextBox";
            this.activityMileageTextBox.Size = new System.Drawing.Size(169, 38);
            this.activityMileageTextBox.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1037, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 32);
            this.label11.TabIndex = 10;
            this.label11.Text = "Mileage (mi)";
            // 
            // activityBillingCodeComboBox
            // 
            this.activityBillingCodeComboBox.FormattingEnabled = true;
            this.activityBillingCodeComboBox.Location = new System.Drawing.Point(29, 117);
            this.activityBillingCodeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityBillingCodeComboBox.Name = "activityBillingCodeComboBox";
            this.activityBillingCodeComboBox.Size = new System.Drawing.Size(249, 39);
            this.activityBillingCodeComboBox.TabIndex = 2;
            // 
            // AddDailyActivityButton
            // 
            this.AddDailyActivityButton.Location = new System.Drawing.Point(1392, 281);
            this.AddDailyActivityButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDailyActivityButton.Name = "AddDailyActivityButton";
            this.AddDailyActivityButton.Size = new System.Drawing.Size(285, 86);
            this.AddDailyActivityButton.TabIndex = 1;
            this.AddDailyActivityButton.Text = "Add Daily Activity ";
            this.AddDailyActivityButton.UseVisualStyleBackColor = true;
            this.AddDailyActivityButton.Click += new System.EventHandler(this.addDailyActivity_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(797, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Service Code";
            // 
            // activityTimeTextBox
            // 
            this.activityTimeTextBox.Location = new System.Drawing.Point(805, 114);
            this.activityTimeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityTimeTextBox.Name = "activityTimeTextBox";
            this.activityTimeTextBox.Size = new System.Drawing.Size(204, 38);
            this.activityTimeTextBox.TabIndex = 6;
            // 
            // activityDateTimePicker
            // 
            this.activityDateTimePicker.Location = new System.Drawing.Point(312, 114);
            this.activityDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityDateTimePicker.Name = "activityDateTimePicker";
            this.activityDateTimePicker.Size = new System.Drawing.Size(457, 38);
            this.activityDateTimePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.activityDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(-11, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(2267, 670);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity Log";
            // 
            // activityDataGridView
            // 
            this.activityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activityDataGridView.Location = new System.Drawing.Point(3, 33);
            this.activityDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityDataGridView.Name = "activityDataGridView";
            this.activityDataGridView.ReadOnly = true;
            this.activityDataGridView.RowTemplate.Height = 40;
            this.activityDataGridView.Size = new System.Drawing.Size(2261, 635);
            this.activityDataGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(2263, 1161);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Invoice";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.summaryRichTextBox);
            this.groupBox6.Controls.Add(this.printInvoiceButton);
            this.groupBox6.Location = new System.Drawing.Point(27, 820);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox6.Size = new System.Drawing.Size(2208, 281);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Summary ";
            // 
            // summaryRichTextBox
            // 
            this.summaryRichTextBox.Location = new System.Drawing.Point(3, 33);
            this.summaryRichTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.summaryRichTextBox.Name = "summaryRichTextBox";
            this.summaryRichTextBox.ReadOnly = true;
            this.summaryRichTextBox.Size = new System.Drawing.Size(1588, 240);
            this.summaryRichTextBox.TabIndex = 8;
            this.summaryRichTextBox.Text = "";
            // 
            // printInvoiceButton
            // 
            this.printInvoiceButton.Location = new System.Drawing.Point(1680, 114);
            this.printInvoiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printInvoiceButton.Name = "printInvoiceButton";
            this.printInvoiceButton.Size = new System.Drawing.Size(293, 74);
            this.printInvoiceButton.TabIndex = 7;
            this.printInvoiceButton.Text = "Print Invoice";
            this.printInvoiceButton.UseVisualStyleBackColor = true;
            this.printInvoiceButton.Click += new System.EventHandler(this.printInvoiceButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.generateInvoiceButton);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.invoiceDateDateTimePicker);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.endingDateActivityDateTimePicker);
            this.groupBox5.Controls.Add(this.startingDateActivtyDateTimePicker);
            this.groupBox5.Location = new System.Drawing.Point(27, 33);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(1973, 200);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Generate Inovice";
            // 
            // generateInvoiceButton
            // 
            this.generateInvoiceButton.Location = new System.Drawing.Point(1637, 79);
            this.generateInvoiceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generateInvoiceButton.Name = "generateInvoiceButton";
            this.generateInvoiceButton.Size = new System.Drawing.Size(293, 74);
            this.generateInvoiceButton.TabIndex = 6;
            this.generateInvoiceButton.Text = "Generate Invoice";
            this.generateInvoiceButton.UseVisualStyleBackColor = true;
            this.generateInvoiceButton.Click += new System.EventHandler(this.generateInvoiceButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1088, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 32);
            this.label9.TabIndex = 5;
            this.label9.Text = "Invoice Date";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // invoiceDateDateTimePicker
            // 
            this.invoiceDateDateTimePicker.Location = new System.Drawing.Point(1093, 114);
            this.invoiceDateDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceDateDateTimePicker.Name = "invoiceDateDateTimePicker";
            this.invoiceDateDateTimePicker.Size = new System.Drawing.Size(497, 38);
            this.invoiceDateDateTimePicker.TabIndex = 4;
            this.invoiceDateDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker4_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(563, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Ending Date Activity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 32);
            this.label7.TabIndex = 2;
            this.label7.Text = "Starting Date Activity";
            // 
            // endingDateActivityDateTimePicker
            // 
            this.endingDateActivityDateTimePicker.Location = new System.Drawing.Point(568, 114);
            this.endingDateActivityDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.endingDateActivityDateTimePicker.Name = "endingDateActivityDateTimePicker";
            this.endingDateActivityDateTimePicker.Size = new System.Drawing.Size(492, 38);
            this.endingDateActivityDateTimePicker.TabIndex = 1;
            // 
            // startingDateActivtyDateTimePicker
            // 
            this.startingDateActivtyDateTimePicker.Location = new System.Drawing.Point(27, 114);
            this.startingDateActivtyDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startingDateActivtyDateTimePicker.Name = "startingDateActivtyDateTimePicker";
            this.startingDateActivtyDateTimePicker.Size = new System.Drawing.Size(511, 38);
            this.startingDateActivtyDateTimePicker.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.invoiceDataGridView);
            this.groupBox4.Location = new System.Drawing.Point(-11, 253);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(2267, 539);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Invoice Log";
            // 
            // invoiceDataGridView
            // 
            this.invoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoiceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoiceDataGridView.Location = new System.Drawing.Point(3, 33);
            this.invoiceDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.invoiceDataGridView.Name = "invoiceDataGridView";
            this.invoiceDataGridView.ReadOnly = true;
            this.invoiceDataGridView.RowTemplate.Height = 40;
            this.invoiceDataGridView.Size = new System.Drawing.Size(2261, 504);
            this.invoiceDataGridView.TabIndex = 0;
            // 
            // companynameLabel
            // 
            this.companynameLabel.AutoSize = true;
            this.companynameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companynameLabel.Location = new System.Drawing.Point(1165, 100);
            this.companynameLabel.Name = "companynameLabel";
            this.companynameLabel.Size = new System.Drawing.Size(537, 78);
            this.companynameLabel.TabIndex = 5;
            this.companynameLabel.Text = "Company Name";
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(2699, 1426);
            this.Controls.Add(this.companynameLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClientslistBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Mainmenu";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Activated += new System.EventHandler(this.Mainmenu_Activated);
            this.Load += new System.EventHandler(this.Mainmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activityDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.ListBox ClientslistBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.Label ClientAddresslabel;
        private System.Windows.Forms.Label clientPhoneLabel;
        private System.Windows.Forms.Label AttorneyPhonelabel;
        private System.Windows.Forms.Label attorneyAddresslabel;
        private System.Windows.Forms.Label attroneyNamelabel;
        private System.Windows.Forms.Label qrcPhonelabel;
        private System.Windows.Forms.Label qrcAddresslabel;
        private System.Windows.Forms.Label qrcNamelabel;
        private System.Windows.Forms.Label carrierPhonelabel;
        private System.Windows.Forms.Label carrierAddresslabel;
        private System.Windows.Forms.Label carrierNamelabel;
        private System.Windows.Forms.Label claimNumberlabel;
        private TabPage tabPage3;
        private ToolStripMenuItem utilitiesToolStripMenuItem;
        private ToolStripMenuItem billingCodesMaintenanceToolStripMenuItem;
        private ToolStripMenuItem employeeRecordMaintentanceToolStripMenuItem;
        private ToolStripMenuItem systemInfomationMaintentanceToolStripMenuItem;
        private GroupBox groupBox1;
        private DataGridView activityDataGridView;
        private GroupBox groupBox3;
        private Button deleteDailyActivity;
        private Label label5;
        private GroupBox groupBox2;
        private ComboBox activityBillingCodeComboBox;
        private Button AddDailyActivityButton;
        private Label label4;
        private Label label2;
        private TextBox activityTimeTextBox;
        private DateTimePicker activityDateTimePicker;
        private Label label3;
        private GroupBox groupBox5;
        private Button generateInvoiceButton;
        private Label label9;
        private DateTimePicker invoiceDateDateTimePicker;
        private Label label8;
        private Label label7;
        private DateTimePicker endingDateActivityDateTimePicker;
        private DateTimePicker startingDateActivtyDateTimePicker;
        private GroupBox groupBox4;
        private DataGridView invoiceDataGridView;
        private GroupBox groupBox6;
        private Label companynameLabel;
        private ToolStripMenuItem editClientInformationToolStripMenuItem;
        private GroupBox groupBox11;
        private GroupBox groupBox10;
        private GroupBox groupBox9;
        private GroupBox groupBox8;
        private Button printInvoiceButton;
        private TextBox activityMileageTextBox;
        private Label label11;
        private TextBox activityServiceDescriptionTextBox;
        private Label label12;
        private ToolStripMenuItem saveToolStripMenuItem;
        private TextBox deleteDailyActivityTextBox;
        private RichTextBox summaryRichTextBox;
        private Label label14;
        private TextBox activityAmountTextBox;
        private ComboBox activityExpenseCodeComboBox;
        private Label label13;
    }
}

