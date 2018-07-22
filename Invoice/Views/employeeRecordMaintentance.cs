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
            AddNewEmployeeRecord new_window = new AddNewEmployeeRecord();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }

        private void browseRmployeeRecordsButton_Click(object sender, EventArgs e)
        {
            BrowseEmployeeRecords new_window = new BrowseEmployeeRecords();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }


        private void deleteEmployeeRecords_Click(object sender, EventArgs e)
        {
            DeleteEmployeeRecords new_window = new DeleteEmployeeRecords();
            var dialogResult = new_window.ShowDialog();
            new_window.Dispose();
        }
    }
}
