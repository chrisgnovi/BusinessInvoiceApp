using System;
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

        private void ClientslistBox_Click(object sender, EventArgs e)
        {

            string s = this.ClientslistBox.Text;
            Client client = clientInformation.extraData.getClient(s);

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

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteClient new_window = new DeleteClient();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void addBill_Click(object sender, EventArgs e)
        {

        }




        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void clientStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Mainmenu_Activated(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }



        private void ClientslistBox_Enter(object sender, EventArgs e)
        {

        }

        private void AttorneyPhonelabel_Click(object sender, EventArgs e)
        {

        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {

        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            addBilling new_window = new addBilling();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void billingCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

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

        private void label9_Click(object sender, EventArgs e)
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


        void activityFillData()
        {

            string s = this.ClientslistBox.Text;
            Client client = clientInformation.extraData.getClient(s);

            client.dTable.Columns.Add("Rec#");
            client.dTable.Columns.Add("Date of Service");
            client.dTable.Columns.Add("Service Description");
            client.dTable.Columns.Add("Code");
            client.dTable.Columns.Add("Time");
            client.dTable.Columns.Add("Mileage");
            client.dTable.Columns.Add("Expenses");
            client.dTable.NewRow();

            //activityDataGridView = client.dTable; 
        }

        

        private void addDailyActivity_Click(object sender, EventArgs e)
        {


        }
    }
}
