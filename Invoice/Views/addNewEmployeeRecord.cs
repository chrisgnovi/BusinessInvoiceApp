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
    public partial class AddNewEmployeeRecord : Form
    {
        public AddNewEmployeeRecord()
        {
            InitializeComponent();
        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void clientAvgWklyWageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clientZipTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();

            employee.firstName = employeeFirstNameTextBox.Text;
            employee.lastName = employeeLastNameTextBox.Text;
            employee.addressLine1 = employeeAddressLine1TextBox.Text;
            employee.addressLine2 = employeeAddressLine2TextBox.Text;
            employee.city = employeeCityTextBox.Text;
            employee.zip = employeeZipTextBox.Text;
            employee.state = employeeStateTextBox.Text;
            employee.phone = employeePhoneTextBox.Text;

            ClientInformation clientInformation = ClientInformation.Instance();

            clientInformation.extraData.addEmployee(employee.firstName, employee);
            clientInformation.Save();

            this.Refresh();

            this.Close();

        }
    }
}
