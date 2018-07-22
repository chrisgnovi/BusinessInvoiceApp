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
    public partial class AddNewExpenseCodes : Form
    {

        ClientInformation clientInformation = ClientInformation.Instance();


        public AddNewExpenseCodes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            if (expenseCodeTextBox != null && descriptionTextBox != null){

                string EC = expenseCodeTextBox.Text;
                string DS = descriptionTextBox.Text;
                clientInformation.extraData.addExpenseCode(EC, DS);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
