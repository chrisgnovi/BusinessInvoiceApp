using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class NewClient : Form
    {

        
    
        public NewClient()
        {
            InitializeComponent();
        }

        public NewClient(ClientInformation clientInformation)
        {
        }

        public void NewClienButton_Click(object sender, EventArgs e)
        {

            if (!clientFirstNameTextBox.Text.Equals("") && !carrierBillRateTextBox.Text.Equals("") && !carrierMileageRateTextBox.Text.Equals("")) {
                Client client = new Client();

                // File info
                client.fileNumber = fileNumberTextBox.Text;
                client.dateServiceBegin = serviceBeginDateTimePicker.Value;
                client.difficultyRating = difficultyRatingTextBox.Text;
                client.suspendInvoice = suspendInvoiceTextBox.Text;


                // Client info
                client.clientFirstName = clientFirstNameTextBox.Text;
                client.clientLastName = clientLastNameTextBox.Text;
                client.clientAddressLine1 = clientAddressLine1TextBox.Text;
                client.clientAddressLine2 = clientAddressLine2TextBox.Text;
                client.clientCity = clientCityTextBox.Text;
                client.clientState = clientStateTextBox.Text;
                client.clientZip = clientZipTextBox.Text;
                client.clientHomeNumber = clientHomePhoneTextBox.Text;
                client.clientWorkPhone = clientWorkPhoneTextBox.Text;
                client.clientDayBorn = clientDateBirthTextBox.Text;
                client.clientClaimNumber = clientClaimNumberTextBox.Text;
                client.empleeCode = clientEmpCodeTextBox.Text;
                client.dateInjured = clientDateInjureddateTimePicker.Value;
                client.datePlFile = clientPIFielddateTimePicker.Value;
                client.serviceLimit = clientSeriveLimitTextBox.Text;
                client.servicePeriodMonths = clientServicePeriodTextBox.Text;
                client.monthlyLimit = clientMontlyLimitTextBox.Text;

                // Carrier info
                client.carrierName = carrierNameTextBox.Text;
                client.carrierAddressLine1 = carrierAddressLine1TextBox.Text;
                client.carrierAddressLine2 = carrierAddressLine2TextBox.Text;
                client.carrierCity = carrierCityTextBox.Text;
                client.carrierState = carrierStateTextBox.Text;
                client.carrierZip = carrierZipTextBox.Text;
                client.carrierRepresentative = carrierRepresenativeTextBox.Text;
                client.carrierPhone = carrierPhoneTextBox.Text;
                client.carrierBillingRate = carrierBillRateTextBox.Text;
                client.carrierMillageRateDistance = carrierMileageRateTextBox.Text;
                client.carrierMillageRatePercentage = carrierMileageRateTextBox.Text;
                client.carrierFax = carrierFaxTextBox.Text;

                // Attorney info
                client.attorneyFirstName = attorneyFirstNameTextBox.Text;
                client.attorneyLastName = attorneyLastNameTextBox.Text;
                client.attorneyHomePhone = attoneyHomePhoneTextBox.Text;
                client.attorneyWorkNumber = attonryWorkPhoneTextBox.Text;
                client.attorneyFax = attoneyFaxTextBox.Text;
                client.attorneyParalegal = attorneyParalegalTextBox.Text;
                client.attorneyAddressLine1 = attoneyAddressLine1TextBox.Text;
                client.attorneyAddressLine2 = attorneyAdrressLine2TextBox.Text;
                client.attorneyCity = attorneyCityTextBox.Text;
                client.attorneyState = attorneyStateTextBox.Text;
                client.attorneyZip = attorneyZipTextBox.Text;

                // QRC info 
                client.qrcFirstName = qrcFirstNameTextBox.Text;
                client.qrcLastName = qrcLastNameTextBox.Text;
                client.qrcHomePhine = qrcHomePhoneTextBox.Text;
                client.qrcWorkPhone = qrcWorkPhoneTextBox.Text;
                client.qrcFax = qrcFacTextBox.Text;
                client.qrcAddressLine1 = qrcAddressLine1TextBox.Text;
                client.qrcAddressLine2 = qrcAddressLine2TextBox.Text;
                client.qrcCity = qrcCityTextBox.Text;
                client.qrcState = qrcStateTextBox.Text;
                client.qrcZip = qrcZipTextBox.Text;
                client.qrcProviderRegNumber = qrcProviderRegNumTextBox.Text;

                client.referralSourcePerson = qrcReferralSourcePersonTextBox.Text;

                // Employer Info
                client.employerName = employerNameTextBox.Text;
                client.employerPhone = employerPhoneTextBox.Text;
                client.employerFax = employerFaxTextBox.Text;
                client.employerAddressLine1 = employerAddressLine1TextBox.Text;
                client.employerAddressLine2 = EmployerAddressLine2TextBox.Text;
                client.employerCity = employerCityTextBox.Text;
                client.employerState = employerStateTextBox.Text;
                client.employerZip = employerZipTextBox.Text;
                client.employerContact = employerContactTextBox.Text;

                // Doctor Name
                client.doctorFirstName = doctorFirstNameTextBox.Text;
                client.doctorLastName = doctorLastNameTextBox.Text;
                client.doctorClinic = doctorClinicTextBox.Text;
                client.doctorAddressLine1 = doctorAdressLine1TextBox.Text;
                client.doctorAddressLine2 = doctorAddressLine2TextBox.Text;
                client.doctorCity = doctorCityTextBox.Text;
                client.doctorState = doctorStateTextBox.Text;
                client.doctorZip = doctorZipTextBox.Text;
                client.doctorPhone = doctorPhoneTextBox.Text;
                client.doctorFax = doctorFaxTextBox.Text;


                ClientInformation clientInformation = ClientInformation.Instance();

                clientInformation.extraData.AddClient(client.clientFirstName, client);
                clientInformation.Save();
                this.Refresh();

                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Must enter Client Name and Bill Rates");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void carrierTabPage_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void NewClient_Load(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientZipTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employerTab_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void doctotTabPage_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void clientTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void doctorFirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorLastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void doctorAdressLine1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorAddressLine2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorCityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void doctorStateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void doctorZipTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void doctorFaxTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void doctorPhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void clientAvgWklyWageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void suspendInvoiceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }
    }
}
