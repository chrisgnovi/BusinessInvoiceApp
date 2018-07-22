using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Invoice.Views;


namespace Invoice
{
    public partial class Mainmenu : Form
    {
        ClientInformation clientInformation = ClientInformation.Instance();
        PDF pdf = new PDF();
        private double number;

        public Mainmenu()
        {
            InitializeComponent();
            this.companynameLabel.Text = clientInformation.extraData.companyName;

        }

        private void Mainmenu_Activated(object sender, EventArgs e)
        {
            FillListBox();
            activityFillData();
            FillCodeBox();
            FillExpCodeBox();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewClient new_window = new NewClient();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClient edit_window = new EditClient();
            var dialogResult = edit_window.ShowDialog();
            edit_window.Dispose();
        }

        private void FillListBox()
        {
            ClientslistBox.Items.Clear();
            foreach (string s in clientInformation.extraData.ClientList())
            {
                ClientslistBox.Items.Add(s);
            }
        }

        private void FillCodeBox()
        {
            activityBillingCodeComboBox.Items.Clear();
            foreach (string s in clientInformation.extraData.ServiceCodesList())
            {
                activityBillingCodeComboBox.Items.Add(s);
            }
        }

        private void FillExpCodeBox()
        {
            activityExpenseCodeComboBox.Items.Clear();
            foreach (string s in clientInformation.extraData.ExpenseCodesList())
            {
                activityExpenseCodeComboBox.Items.Add(s);
            }
        }

        private void ClientslistBox_Click(object sender, EventArgs e)
        {

            string s = this.ClientslistBox.Text;
            Client client = clientInformation.extraData.getClient(s);
            if (client != null)
            {

                claimNumberlabel.Text = "Claim Number: " + client.clientClaimNumber;

                clientNameLabel.Text = "Client: " + client.clientFirstName + " " + client.clientLastName;
                ClientAddresslabel.Text = "Address: " + client.clientAddressLine1 + "\n               " + client.clientAddressLine2 + "\n               " + client.clientCity +
                    ", " + client.clientState + ", " + client.clientZip;
                clientPhoneLabel.Text = "Home Phone: " + client.clientHomeNumber + "\nWork Phone: " + client.clientWorkPhone;

                carrierNamelabel.Text = "Carrier: " + client.carrierName;
                carrierAddresslabel.Text = "Address: " + client.carrierAddressLine1 + "\n               " + client.carrierAddressLine2 + "\n               " + client.carrierCity +
                    ", " + client.carrierState + ", " + client.carrierZip;
                carrierPhonelabel.Text = "Phone: " + client.carrierPhone;

                qrcNamelabel.Text = "QRC: " + client.qrcFirstName + " " + client.qrcLastName;
                qrcAddresslabel.Text = "Address: " + client.qrcAddressLine1 + "\n               " + client.qrcAddressLine2 + "\n               " + client.qrcCity +
                    ", " + client.qrcState + ", " + client.qrcZip;
                qrcPhonelabel.Text = "Work Phone: " + client.qrcWorkPhone + "\nHome Phone: " + client.qrcHomePhine;

                attroneyNamelabel.Text = "Attorney: " + client.attorneyFirstName + " " + client.attorneyLastName;
                attorneyAddresslabel.Text = "Address: " + client.attorneyAddressLine1 + "\n               " + client.attorneyAddressLine2 + "\n               " + client.attorneyCity +
                    ", " + client.attorneyState + ", " + client.attorneyZip;
                AttorneyPhonelabel.Text = "Work Phone: " + client.attorneyWorkNumber + "\nHome Phone: " + client.attorneyHomePhone;
            }
            DataTable dt = clientInformation.extraData.getClientDataTable(s);
            this.activityDataGridView.DataSource = dt;
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteClient new_window = new DeleteClient();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void employeeRecordMaintentanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeRecordMaintentance new_window = new employeeRecordMaintentance();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void billingCodesMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BillingCodeMaintance new_window = new BillingCodeMaintance();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void systemInfomationMaintentanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemInformationMaintenance new_window = new SystemInformationMaintenance();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void editClientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClient new_window = new EditClient();
            var dialogResult = new_window.ShowDialog();
            new_window.BringToFront();
            new_window.Dispose();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About new_window = new About();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void activityFillData()
        {

            string s = this.ClientslistBox.Text;
            Client client = clientInformation.extraData.getClient(s);
        }

        private void addDailyActivity_Click(object sender, EventArgs e)
        {

            double time = 0;
            double mil = 0;
            double amt = 0;
            string s = this.ClientslistBox.Text;
            ArrayList row = new ArrayList();

            DateTime dt = activityDateTimePicker.Value.Date;
            string disc = activityServiceDescriptionTextBox.Text;
            string code = activityBillingCodeComboBox.Text;
            if (Double.TryParse(activityTimeTextBox.Text, out number)) { time = Convert.ToDouble(activityTimeTextBox.Text); }
            if (Double.TryParse(activityMileageTextBox.Text, out number)) { mil = Convert.ToDouble(activityMileageTextBox.Text); }
            string exCode = activityExpenseCodeComboBox.Text;
            if (Double.TryParse(activityAmountTextBox.Text, out number)) { amt = Convert.ToDouble(activityAmountTextBox.Text); }

            if (activityBillingCodeComboBox.Text.Equals("") && activityTimeTextBox.Text.Equals("") ||
               !activityBillingCodeComboBox.Text.Equals("") && !activityTimeTextBox.Text.Equals("")) {
                clientInformation.extraData.addRowClientDataTable(s, dt, disc, code, time, mil, exCode, amt);
            }
            else
            {
                MessageBox.Show("Error: must enter a service code with a time");
            }
        }

        private void deleteDailyActivity_Click(object sender, EventArgs e)
        {
            string s = this.ClientslistBox.Text;
            string r = this.deleteDailyActivityTextBox.Text;

            clientInformation.extraData.deleteRowClientDataTable(s, int.Parse(r));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientInformation.Save();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }      

        private void generateInvoiceButton_Click(object sender, EventArgs e)
        {
            if (!ClientslistBox.Text.Equals(""))
            {
                DateTime startDate = startingDateActivtyDateTimePicker.Value.Date;
                DateTime endDate = endingDateActivityDateTimePicker.Value.Date;
                DateTime invDate = invoiceDateDateTimePicker.Value.Date;
                string s = this.ClientslistBox.Text;

                DataTable dt = clientInformation.extraData.subClientDataTable(s, startDate, endDate);
                this.invoiceDataGridView.DataSource = dt;

                string[] codes = dt.AsEnumerable().Select(x => x.Field<string>("Service Code")).Distinct<string>().ToArray<string>();
                double[] times = new double[codes.Length];
                double[] billHours = new double[codes.Length];
                double mileage = 0;
                double totalExpense = 0;
                double grandTotal = 0;
                string output;

                for (int i = 0; i < codes.Length; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[3].Equals(codes[i].ToString()))
                        {
                            times[i] += Convert.ToDouble(dr[4]);
                        }
                    }
   
                }


                foreach (DataRow dr in dt.Rows)
                {
                    totalExpense += Convert.ToDouble(dr[7]);
                    mileage += Convert.ToDouble(dr[5]);
                }

                    // Bill hours

                    double hourRate = double.Parse(clientInformation.extraData.getClient(s).carrierBillingRate);
                

                for (int i = 0; i < codes.Length; i++)
                {
                    billHours[i] = times[i] * hourRate;
                }

                double totalBill = billHours.Sum();
                double billmileage = double.Parse(clientInformation.extraData.getClient(s).carrierMillageRateDistance)* mileage;
                grandTotal = billmileage + totalBill + totalExpense;

                clear();
                addSummaryStatus(String.Format("{0,-30}\t{1,15:N0}\t{2,-15:N0}", "Service Code", "Time (hr)", "Billing ($)"));
                for (int i = 0; i < times.Length; i++)
                {

                    if (!codes[i].Equals(""))
                    {
                        output = String.Format("{0,-30}\t{1,15:N0}\t{2,-15:N0}",
                            clientInformation.extraData.serviceCodeDic[codes[i]], times[i], billHours[i]);

                        addSummaryStatus(output);
                    }
                }
                addSummaryStatus("");
                addSummaryStatus(String.Format("{0,-30}\t{1,15:N0}\t{2,-15:N0}", "Mileage", "Miles", "\t"));
                addSummaryStatus(String.Format("{0,-30}\t{1,15:N0}\t{2,-15:N0}", "\t", mileage, billmileage));
                addSummaryStatus("");
                addSummaryStatus(String.Format("{0,-30}\t{1,15:N0}\t{2,-15:N0}", "Expense", "\t", "\t"));
                addSummaryStatus(String.Format("{0,-30}\t{1,15:N0}\t{2,-15:N0}", "\t", "\t", totalExpense));
                addSummaryStatus("------------------------------------------------------------------------------------------");
                addSummaryStatus(String.Format("{0,-30}\t{1,15:N0}\t{2,-15:N0}", "Total", "\t", grandTotal));
            }
        }

        private void addSummaryStatus(string message)
        {
            this.summaryRichTextBox.Visible = true;
            this.summaryRichTextBox.Text += message + "\n";
            this.summaryRichTextBox.SelectionStart = this.summaryRichTextBox.TextLength;
            this.summaryRichTextBox.ScrollToCaret();
            this.summaryRichTextBox.Refresh();
        }

        private void clear()
        {
            this.summaryRichTextBox.Clear();
        }

        private void printInvoiceButton_Click(object sender, EventArgs e)
        {
            if (!ClientslistBox.Text.Equals(""))
            {

                DateTime startDate = startingDateActivtyDateTimePicker.Value.Date;
                DateTime endDate = endingDateActivityDateTimePicker.Value.Date;
                DateTime invDate = invoiceDateDateTimePicker.Value.Date;
                string s = this.ClientslistBox.Text;

                DataTable dt = clientInformation.extraData.subClientDataTable(s, startDate, endDate);


                string[] codes = dt.AsEnumerable().Select(x => x.Field<string>("Service Code")).Distinct<string>().ToArray<string>();
                double[] times = new double[codes.Length];
                double[] billHours = new double[codes.Length];
                double mileage = 0;
                double totalExpense = 0;
                double grandTotal = 0;


                for (int i = 0; i < codes.Length; i++)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[3].Equals(codes[i].ToString()))
                        {
                            times[i] += Convert.ToDouble(dr[4]);
                        }
                    }

                }

                foreach (DataRow dr in dt.Rows)
                {
                    totalExpense += Convert.ToDouble(dr[7]);
                    mileage += Convert.ToDouble(dr[5]);
                }

                // Bill hours

                double hourRate = double.Parse(clientInformation.extraData.getClient(s).carrierBillingRate);

            
                for (int i = 0; i < codes.Length; i++)
                {
                    billHours[i] = times[i] * hourRate;
                }

                double totalBill = billHours.Sum();
                double billmileage = double.Parse(clientInformation.extraData.getClient(s).carrierMillageRateDistance) * mileage;
                grandTotal = billmileage + totalBill + totalExpense;

                pdf.Make(s, dt, startDate.Date, endDate.Date, invDate.Date, codes, times, totalExpense, billHours, mileage, totalBill, billmileage, grandTotal);

            }
        }
     
        private void Mainmenu_FormClosing(object sender, FormClosingEventArgs e)
        {
           

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    
                   
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Mainmenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            clientInformation.Save();
        }
    }
}
