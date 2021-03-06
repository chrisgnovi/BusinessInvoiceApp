﻿using System;
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
    public partial class BrowseEmployeeRecords : Form
    {

        ClientInformation clientInformation = ClientInformation.Instance();

        public BrowseEmployeeRecords()
        {
            InitializeComponent();
        }


        private void FillListBox()
        {
           employeeComboBox.Items.Clear();
            foreach (string s in clientInformation.extraData.EmployeeList())
            {
                employeeComboBox.Items.Add(s);
            }
        }

        private void BrowseEmployeeRecords_Activated(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void employeeComboBox_Click(object sender, EventArgs e)
        {
            
            string s = this.employeeComboBox.Text;

            if (s != null)
            {
                Employee empy = clientInformation.extraData.getEmployee(s);

                if (empy != null)
                {

                    employeeNameLabel.Text = "Employee: " + empy.firstName + " " + empy.lastName;
                    employeeAddresslabel.Text = "Address: " + empy.addressLine1 + "\n" + empy.addressLine2 + "\n" + empy.city + ", " + empy.state + ", " + empy.zip;
                    employeePhoneLabel.Text = "Phone: " + empy.phone;
                }
            }

        }
    }

}
