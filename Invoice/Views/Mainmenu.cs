using System;
using System.Data;
using System.Windows.Forms;
using Invoice.Views;

namespace Invoice
{
    public partial class Mainmenu : Form
    {
        ClientInformation clientInformation = ClientInformation.Instance();

        public Mainmenu()
        {
            InitializeComponent();
        }

        private void Mainmenu_Activated(object sender, EventArgs e)
        {
            FillListBox();
            activityFillData();
            FillCodeBox();
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
            systemInformationMaintenance new_window = new systemInformationMaintenance();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }


        private void editClientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClient new_window = new EditClient();
            var dialogResult = new_window.ShowDialog();
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

            string s = this.ClientslistBox.Text;
            string[] row = new string[] { activityBillingCodeComboBox.Text, "7/14/17", activityTimeTextBox.Text, activityDiscountTextBox.Text, activityMileageTextBox.Text };

            clientInformation.extraData.addRowClientDataTable(s, row);

        }

    }
}
