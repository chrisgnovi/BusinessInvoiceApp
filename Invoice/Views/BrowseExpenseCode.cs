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
    public partial class BrowseExpenseCode : Form
    {
        ClientInformation clientInformation = ClientInformation.Instance();
        

        public BrowseExpenseCode()
        {
            InitializeComponent();
        }

        private void BrowseExpenseCode_Activated(object sender, EventArgs e)
        {
            Dictionary<string, string> dic = clientInformation.extraData.getExpenseCodes();

            string[] key = dic.Keys.ToArray<string>();
            string[] values = dic.Values.ToArray<string>();
            for (int i = 0; i < key.Length; i++) {

                this.dataGridView1.Rows.Add(values[i], key[i]);
            }
        }
    }
}
