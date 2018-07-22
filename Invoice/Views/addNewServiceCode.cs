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
    public partial class AddNewServiceCode : Form
    {
        ClientInformation clientInformation = ClientInformation.Instance();

        public AddNewServiceCode()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (serviceCodeTextBox != null && descriptionTextBox != null)
            {

                string EC = serviceCodeTextBox.Text;
                string DS = descriptionTextBox.Text;
                clientInformation.extraData.addServiceCode(EC, DS);
            }
        }
    }
}
