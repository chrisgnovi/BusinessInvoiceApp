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
    public partial class BrowseServiceCodes : Form
    {
        ClientInformation clientInformation = ClientInformation.Instance();

        public BrowseServiceCodes()
        {
            InitializeComponent();
        }

        private void BrowseServiceCodes_Activated(object sender, EventArgs e)
        {

            Dictionary<string, string> dic = clientInformation.extraData.getServiceCodes();

            string[] key = dic.Keys.ToArray<string>();
            string[] values = dic.Values.ToArray<string>();
            for (int i = 0; i < key.Length; i++)
            {

                this.dataGridView1.Rows.Add(values[i], key[i]);
            }
        }
    }
}
