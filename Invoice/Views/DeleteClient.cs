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
    public partial class DeleteClient : Form
    {
        ClientInformation clientInformation = ClientInformation.Instance();

        public DeleteClient()
        {
            InitializeComponent();
            
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
        }

        private void FillListBox()
        {
            deleteClientComboBox.Items.Clear();
            foreach (string s in clientInformation.extraData.ClientList())
            {
               deleteClientComboBox.Items.Add(s);
            }
        }

       private void deleteClientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DeleteClient_Activated(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string s = this.deleteClientComboBox.Text;
            clientInformation.extraData.RemoveClient(s);
            clientInformation.Save();
            this.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deleteClientComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
