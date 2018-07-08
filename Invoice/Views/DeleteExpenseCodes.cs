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
    public partial class DeleteExpenseCodes : Form
    {

        ClientInformation clientInformation = ClientInformation.Instance();

        public DeleteExpenseCodes()
        {
            InitializeComponent();
        }

        private void FillListBox()
        {
            ComboBox.Items.Clear();
            foreach (string s in clientInformation.extraData.ExpenseCodesList())
            {
                ComboBox.Items.Add(s);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string s = this.ComboBox.Text;
            clientInformation.extraData.RemoveExpenseCode(s);
            clientInformation.Save();
            this.Refresh();
            this.Close();
        }

        private void DeleteExpenseCodes_Activated(object sender, EventArgs e)
        {
            FillListBox();
        }
    }
}
