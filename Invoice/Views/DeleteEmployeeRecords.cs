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
    public partial class DeleteEmployeeRecords : Form
    {
        ClientInformation clientInformation = ClientInformation.Instance();

        public DeleteEmployeeRecords()
        {
            InitializeComponent();
        }

        private void employeeComboBox_Click(object sender, EventArgs e)
        {

        }

        private void FillListBox()
        {
            employeeComboBox.Items.Clear();
            foreach (string s in clientInformation.extraData.EmployeeList())
            {
                employeeComboBox.Items.Add(s);
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            string s = this.employeeComboBox.Text;

            if (s != null)
            {
                Employee empy = clientInformation.extraData.getEmployee(s);

                if (empy != null)
                {
                    clientInformation.extraData.RemoveEmployeee(s);
                    clientInformation.Save();
                    this.Refresh();
                }
            }
        }

        private void DeleteEmployeeRecords_Activated(object sender, EventArgs e)
        {
            FillListBox();
        }
    }
}
