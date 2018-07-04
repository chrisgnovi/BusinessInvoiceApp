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
    public partial class addBilling : Form
    {

        ClientInformation clientInformation = ClientInformation.Instance();

        public addBilling()
        {
            InitializeComponent();
        }

        private void FillListBox()
        {
            addBillComboBox.Items.Clear();
            foreach (string s in clientInformation.extraData.ClientList())
            {
                addBillComboBox.Items.Add(s);
            }
        }

        private void addBillComboBox_Click(object sender, EventArgs e)
        {

        }

        private void addBillComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addBilling_Activated(object sender, EventArgs e)
        {
            FillListBox();
        }
    }
}
