using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice.Views
{
    public partial class SystemInformationMaintenance : Form
    {
        ClientInformation cI = ClientInformation.Instance();

        public SystemInformationMaintenance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void systemInformationButton_Click(object sender, EventArgs e)
        {
            cI.extraData.companyName = companyTextBox.Text;

            cI.extraData.firmRegNum = firmRegNum.Text;
            cI.extraData.addressLine1 = AddressLine1TextBox.Text;
            cI.extraData.addressLine2 = AddressLine2TextBox.Text;
            cI.extraData.city = CityTextBox.Text;
            cI.extraData.zip = ZipTextBox.Text;
            cI.extraData.state = StateTextBox.Text;
            cI.extraData.phone = WorkPhoneTextBox.Text;
            cI.Save();
            this.Refresh();
            this.Close();
        }

        private void systemInformationMaintenance_Activated(object sender, EventArgs e)
        {
            fillTextBox();

        }
        private void fillTextBox()
        {
            companyTextBox.Text = cI.extraData.companyName;
            firmRegNum.Text = cI.extraData.firmRegNum;
            AddressLine1TextBox.Text = cI.extraData.addressLine1;
            AddressLine2TextBox.Text = cI.extraData.addressLine2;
            CityTextBox.Text = cI.extraData.city;
            ZipTextBox.Text = cI.extraData.zip;
            StateTextBox.Text = cI.extraData.state;
            WorkPhoneTextBox.Text = cI.extraData.phone;

        }
    }
}
