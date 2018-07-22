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
    public partial class EditClient : Form
    {

        ClientInformation clientInformation = ClientInformation.Instance();

        public EditClient()
        {
            InitializeComponent();
        }

        private void FillListBox()
        {
            editClientComboBox.Items.Clear();
            foreach (string s in clientInformation.extraData.ClientList())
            {
                editClientComboBox.Items.Add(s);
            }
        }

        private void EditClient_Activated(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void editClientComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Client client = clientInformation.extraData.getClient(editClientComboBox.Text);

            // File info
            fileNumberTextBox.Text = client.fileNumber;
            serviceBeginDateTimePicker.Value = client.dateServiceBegin;
            difficultyRatingTextBox.Text = client.difficultyRating;
            suspendInvoiceTextBox.Text = client.suspendInvoice;


            // Client info
            clientFirstNameTextBox.Text = client.clientFirstName;
            clientLastNameTextBox.Text = client.clientLastName;
            clientAddressLine1TextBox.Text = client.clientAddressLine1;
            clientAddressLine2TextBox.Text = client.clientAddressLine2;
            clientCityTextBox.Text = client.clientCity;
            clientStateTextBox.Text = client.clientState;
            clientZipTextBox.Text = client.clientZip;
            clientHomePhoneTextBox.Text = client.clientHomeNumber;
            clientWorkPhoneTextBox.Text = client.clientWorkPhone;
            clientDateBirthTextBox.Text = client.clientDayBorn;
            clientClaimNumberTextBox.Text = client.clientClaimNumber;
            clientEmpCodeTextBox.Text = client.empleeCode;
            clientInsuredTextBox.Text = client.clientInsured;
            clientDateInjureddateTimePicker.Value = client.dateInjured;
            clientPIFielddateTimePicker.Value = client.datePlFile;
            clientSeriveLimitTextBox.Text = client.serviceLimit;
            clientServicePeriodTextBox.Text = client.servicePeriodMonths;
            clientMontlyLimitTextBox.Text = client.monthlyLimit;

            // Carrier info
            carrierNameTextBox.Text = client.carrierName;
            carrierAddressLine1TextBox.Text = client.carrierAddressLine1;
            carrierAddressLine2TextBox.Text = client.carrierAddressLine2;
            carrierCityTextBox.Text = client.carrierCity;
            carrierStateTextBox.Text = client.carrierState;
            carrierZipTextBox.Text = client.carrierZip;
            carrierRepresenativeTextBox.Text = client.carrierRepresentative;
            carrierPhoneTextBox.Text = client.carrierPhone;
            carrierBillRateTextBox.Text = client.carrierBillingRate;
            carrierMileageRateTextBox.Text = client.carrierMillageRateDistance;
            carrierBillRatePercentTextBox.Text = client.carrierMillageRatePercentage;
            carrierFaxTextBox.Text = client.carrierFax;

            // Attorney info
            attorneyFirstNameTextBox.Text = client.attorneyFirstName;
            attorneyLastNameTextBox.Text = client.attorneyLastName;
            attoneyHomePhoneTextBox.Text = client.attorneyHomePhone;
            attonryWorkPhoneTextBox.Text = client.attorneyWorkNumber;
            attoneyFaxTextBox.Text = client.attorneyFax;
            attorneyParalegalTextBox.Text = client.attorneyParalegal;
            attoneyAddressLine1TextBox.Text = client.attorneyAddressLine1;
            attorneyAdrressLine2TextBox.Text = client.attorneyAddressLine2;
            attorneyCityTextBox.Text = client.attorneyCity;
            attorneyStateTextBox.Text = client.attorneyState;
            attorneyZipTextBox.Text = client.attorneyZip;

            // QRC info 
            qrcFirstNameTextBox.Text = client.qrcFirstName;
            qrcLastNameTextBox.Text = client.qrcLastName;
            qrcHomePhoneTextBox.Text = client.qrcHomePhine;
            qrcWorkPhoneTextBox.Text = client.qrcWorkPhone;
            qrcFacTextBox.Text = client.qrcFax;
            qrcAddressLine1TextBox.Text = client.qrcAddressLine1;
            qrcAddressLine2TextBox.Text = client.qrcAddressLine2;
            qrcCityTextBox.Text = client.qrcCity;
            qrcStateTextBox.Text = client.qrcState;
            qrcZipTextBox.Text = client.qrcZip;
            qrcProviderRegNumTextBox.Text = client.qrcProviderRegNumber;

            qrcReferralSourcePersonTextBox.Text = client.referralSourcePerson;

            // Employer Info
            employerNameTextBox.Text = client.employerName;
            employerPhoneTextBox.Text = client.employerPhone;
            employerFaxTextBox.Text = client.employerFax;
            employerAddressLine1TextBox.Text = client.employerAddressLine1;
            EmployerAddressLine2TextBox.Text = client.employerAddressLine2;
            employerCityTextBox.Text = client.employerCity;
            employerStateTextBox.Text = client.employerState;
            employerZipTextBox.Text = client.employerZip;
            employerContactTextBox.Text = client.employerContact;

            // Doctor Name
            doctorFirstNameTextBox.Text = client.doctorFirstName;
            doctorLastNameTextBox.Text = client.doctorLastName;
            doctorClinicTextBox.Text = client.doctorClinic;
            doctorAdressLine1TextBox.Text = client.doctorAddressLine1;
            doctorAddressLine2TextBox.Text = client.doctorAddressLine2;
            doctorCityTextBox.Text = client.doctorCity;
            doctorStateTextBox.Text = client.doctorState;
            doctorZipTextBox.Text = client.doctorZip;
            doctorPhoneTextBox.Text = client.doctorPhone;
            doctorFaxTextBox.Text = client.doctorFax;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string key = editClientComboBox.Text;
            if (clientInformation.extraData.clientDictionary.ContainsKey(key))
            {
                // File info
                clientInformation.extraData.clientDictionary[key].fileNumber = fileNumberTextBox.Text;
                clientInformation.extraData.clientDictionary[key].dateServiceBegin = serviceBeginDateTimePicker.Value;
                clientInformation.extraData.clientDictionary[key].difficultyRating = difficultyRatingTextBox.Text;
                clientInformation.extraData.clientDictionary[key].suspendInvoice = suspendInvoiceTextBox.Text;

                // Client info
                clientInformation.extraData.clientDictionary[key].clientFirstName = clientFirstNameTextBox.Text;
                clientInformation.extraData.clientDictionary[key].clientLastName = clientLastNameTextBox.Text;
                clientInformation.extraData.clientDictionary[key].clientAddressLine1 = clientAddressLine1TextBox.Text;
                clientInformation.extraData.clientDictionary[key].clientAddressLine2 = clientAddressLine2TextBox.Text;
                clientInformation.extraData.clientDictionary[key].clientCity = clientCityTextBox.Text;
                clientInformation.extraData.clientDictionary[key].clientState = clientStateTextBox.Text;
                clientInformation.extraData.clientDictionary[key].clientZip = clientZipTextBox.Text;
                clientInformation.extraData.clientDictionary[key].clientHomeNumber = clientHomePhoneTextBox.Text;
                clientInformation.extraData.clientDictionary[key].clientWorkPhone = clientWorkPhoneTextBox.Text;
                clientInformation.extraData.clientDictionary[key].clientDayBorn = clientDateBirthTextBox.Text;
                clientInformation.extraData.clientDictionary[key].clientClaimNumber = clientClaimNumberTextBox.Text;
                clientInformation.extraData.clientDictionary[key].empleeCode = clientEmpCodeTextBox.Text;
                clientInformation.extraData.clientDictionary[key].clientInsured = clientInsuredTextBox.Text;
                clientInformation.extraData.clientDictionary[key].dateInjured = clientDateInjureddateTimePicker.Value;
                clientInformation.extraData.clientDictionary[key].datePlFile = clientPIFielddateTimePicker.Value;
                clientInformation.extraData.clientDictionary[key].serviceLimit = clientSeriveLimitTextBox.Text;
                clientInformation.extraData.clientDictionary[key].servicePeriodMonths = clientServicePeriodTextBox.Text;
                clientInformation.extraData.clientDictionary[key].monthlyLimit = clientMontlyLimitTextBox.Text;

                // Carrier info
                clientInformation.extraData.clientDictionary[key].carrierName = carrierNameTextBox.Text;
                clientInformation.extraData.clientDictionary[key].carrierAddressLine1 = carrierAddressLine1TextBox.Text;
                clientInformation.extraData.clientDictionary[key].carrierAddressLine2 = carrierAddressLine2TextBox.Text;
                clientInformation.extraData.clientDictionary[key].carrierCity = carrierCityTextBox.Text;
                clientInformation.extraData.clientDictionary[key].carrierState = carrierStateTextBox.Text;
                clientInformation.extraData.clientDictionary[key].carrierZip = carrierZipTextBox.Text;
                clientInformation.extraData.clientDictionary[key].carrierRepresentative = carrierRepresenativeTextBox.Text;
                clientInformation.extraData.clientDictionary[key].carrierPhone = carrierPhoneTextBox.Text;
                clientInformation.extraData.clientDictionary[key].carrierBillingRate = carrierBillRateTextBox.Text;
                clientInformation.extraData.clientDictionary[key].carrierMillageRateDistance = carrierMileageRateTextBox.Text;
                clientInformation.extraData.clientDictionary[key].carrierMillageRatePercentage = carrierMileageRateTextBox.Text;
                clientInformation.extraData.clientDictionary[key].carrierFax = carrierFaxTextBox.Text;

                // Attorney info
                clientInformation.extraData.clientDictionary[key].attorneyFirstName = attorneyFirstNameTextBox.Text;
                clientInformation.extraData.clientDictionary[key].attorneyLastName = attorneyLastNameTextBox.Text;
                clientInformation.extraData.clientDictionary[key].attorneyHomePhone = attoneyHomePhoneTextBox.Text;
                clientInformation.extraData.clientDictionary[key].attorneyWorkNumber = attonryWorkPhoneTextBox.Text;
                clientInformation.extraData.clientDictionary[key].attorneyFax = attoneyFaxTextBox.Text;
                clientInformation.extraData.clientDictionary[key].attorneyParalegal = attorneyParalegalTextBox.Text;
                clientInformation.extraData.clientDictionary[key].attorneyAddressLine1 = attoneyAddressLine1TextBox.Text;
                clientInformation.extraData.clientDictionary[key].attorneyAddressLine2 = attorneyAdrressLine2TextBox.Text;
                clientInformation.extraData.clientDictionary[key].attorneyCity = attorneyCityTextBox.Text;
                clientInformation.extraData.clientDictionary[key].attorneyState = attorneyStateTextBox.Text;
                clientInformation.extraData.clientDictionary[key].attorneyZip = attorneyZipTextBox.Text;

                // QRC info 
                clientInformation.extraData.clientDictionary[key].qrcFirstName = qrcFirstNameTextBox.Text;
                clientInformation.extraData.clientDictionary[key].qrcLastName = qrcLastNameTextBox.Text;
                clientInformation.extraData.clientDictionary[key].qrcHomePhine = qrcHomePhoneTextBox.Text;
                clientInformation.extraData.clientDictionary[key].qrcWorkPhone = qrcWorkPhoneTextBox.Text;
                clientInformation.extraData.clientDictionary[key].qrcFax = qrcFacTextBox.Text;
                clientInformation.extraData.clientDictionary[key].qrcAddressLine1 = qrcAddressLine1TextBox.Text;
                clientInformation.extraData.clientDictionary[key].qrcAddressLine2 = qrcAddressLine2TextBox.Text;
                clientInformation.extraData.clientDictionary[key].qrcCity = qrcCityTextBox.Text;
                clientInformation.extraData.clientDictionary[key].qrcState = qrcStateTextBox.Text;
                clientInformation.extraData.clientDictionary[key].qrcZip = qrcZipTextBox.Text;
                clientInformation.extraData.clientDictionary[key].qrcProviderRegNumber = qrcProviderRegNumTextBox.Text;

                clientInformation.extraData.clientDictionary[key].referralSourcePerson = qrcReferralSourcePersonTextBox.Text;

                // Employer Info
                clientInformation.extraData.clientDictionary[key].employerName = employerNameTextBox.Text;
                clientInformation.extraData.clientDictionary[key].employerPhone = employerPhoneTextBox.Text;
                clientInformation.extraData.clientDictionary[key].employerFax = employerFaxTextBox.Text;
                clientInformation.extraData.clientDictionary[key].employerAddressLine1 = employerAddressLine1TextBox.Text;
                clientInformation.extraData.clientDictionary[key].employerAddressLine2 = EmployerAddressLine2TextBox.Text;
                clientInformation.extraData.clientDictionary[key].employerCity = employerCityTextBox.Text;
                clientInformation.extraData.clientDictionary[key].employerState = employerStateTextBox.Text;
                clientInformation.extraData.clientDictionary[key].employerZip = employerZipTextBox.Text;
                clientInformation.extraData.clientDictionary[key].employerContact = employerContactTextBox.Text;

                // Doctor Name
                clientInformation.extraData.clientDictionary[key].doctorFirstName = doctorFirstNameTextBox.Text;
                clientInformation.extraData.clientDictionary[key].doctorLastName = doctorLastNameTextBox.Text;
                clientInformation.extraData.clientDictionary[key].doctorClinic = doctorClinicTextBox.Text;
                clientInformation.extraData.clientDictionary[key].doctorAddressLine1 = doctorAdressLine1TextBox.Text;
                clientInformation.extraData.clientDictionary[key].doctorAddressLine2 = doctorAddressLine2TextBox.Text;
                clientInformation.extraData.clientDictionary[key].doctorCity = doctorCityTextBox.Text;
                clientInformation.extraData.clientDictionary[key].doctorState = doctorStateTextBox.Text;
                clientInformation.extraData.clientDictionary[key].doctorZip = doctorZipTextBox.Text;
                clientInformation.extraData.clientDictionary[key].doctorPhone = doctorPhoneTextBox.Text;
                clientInformation.extraData.clientDictionary[key].doctorFax = doctorFaxTextBox.Text;

                clientInformation.Save();
                MessageBox.Show("Client information edited");
                this.Refresh();

            }
        }
    }
}
