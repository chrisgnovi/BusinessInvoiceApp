using Invoice.Views;
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
    public partial class employeeRecordMaintentance : Form
    {
        public employeeRecordMaintentance()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addEmloyeeRecordsButton_Click(object sender, EventArgs e)
        {
            addNewEmployeeRecord new_window = new addNewEmployeeRecord();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void browseRmployeeRecordsButton_Click(object sender, EventArgs e)
        {
            BrowseEmployeeRecords new_window = new BrowseEmployeeRecords();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void editEmployeeRecords_Click(object sender, EventArgs e)
        {
            EditEmployeeRecords new_window = new EditEmployeeRecords();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }
    }
}
