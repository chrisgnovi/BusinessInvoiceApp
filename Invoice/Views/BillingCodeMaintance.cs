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
    public partial class BillingCodeMaintance : Form
    {
        public BillingCodeMaintance()
        {
            InitializeComponent();
        }

        private void BillingCodeMaintance_Load(object sender, EventArgs e)
        {

        }

        private void addENewExpenseCodesButton_Click(object sender, EventArgs e)
        {
            AddNewExpenseCodes new_window = new AddNewExpenseCodes();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void browseExpenseCodeButton_Click(object sender, EventArgs e)
        {
            BrowseExpenseCode new_window = new BrowseExpenseCode();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void AddNewServiceCodes_Click(object sender, EventArgs e)
        {
            AddNewServiceCode new_window = new AddNewServiceCode();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void browseServiceCodes_Click(object sender, EventArgs e)
        {
            BrowseServiceCodes new_window = new BrowseServiceCodes();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void editServiceCodesbutton_Click(object sender, EventArgs e)
        {
            DeleteServiceCodes new_window = new DeleteServiceCodes();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void deleteExpenseCodes_Click(object sender, EventArgs e)
        {
            DeleteExpenseCodes new_window = new DeleteExpenseCodes();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }
    }
}
