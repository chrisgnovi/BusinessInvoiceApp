using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Invoice
{
    [Serializable]
    public class ExtraData
    {
        private Dictionary<string, Client> clientDictionary = new Dictionary<string, Client>();
        private Dictionary<String, Employee> empDic = new Dictionary<string, Employee>();

        //Service codes 
        ArrayList serviceCodeAList = new ArrayList();
        //Expense Codes 
        ArrayList expenseCodeAList = new ArrayList();

        //System Information Maintence; 
        public string companyName { get; set; }
        public string firmRegNum { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }


        public void addEmployee(string name, Employee emp)
        {
            // If we already had added a friend with this name
            if (this.empDic.ContainsKey(name))
            {
                MessageBox.Show("You had already added " + name);
            }

            else
            {
                this.empDic.Add(name, emp);
                MessageBox.Show("Client added successfully.");

            }
        }

        public void RemoveEmployeee(string name)
        {

            if (!this.empDic.ContainsKey(name))
            {
                MessageBox.Show(name + " had not been added before.");
            }

            else
            {
                if (this.empDic.Remove(name))
                {
                    MessageBox.Show(name + " had been removed successfully.");
                }
                else
                {
                    MessageBox.Show("Unable to remove " + name);
                }
            }
        }

        public void AddClient(string name, Client client)
        {
            // If we already had added a friend with this name
            if (this.clientDictionary.ContainsKey(name))
            {
                MessageBox.Show("You had already added " + name);
            }

            else
            {
                this.clientDictionary.Add(name, client);
                MessageBox.Show("Client added successfully.");

            }
        }


        public void RemoveClient(string name)
        {

            if (!this.clientDictionary.ContainsKey(name))
            {
                MessageBox.Show(name + " had not been added before.");
            }

            else
            {
                if (this.clientDictionary.Remove(name))
                {
                    MessageBox.Show(name + " had been removed successfully.");
                }
                else
                {
                    MessageBox.Show("Unable to remove " + name);
                }
            }
        }


        public List<string> ClientList()
        {

            List<string> keyList = new List<string>(this.clientDictionary.Keys);

            return keyList;
        }

        public Client getClient(string key)
        {
            if (clientDictionary.ContainsKey(key))
            {
                Client val = clientDictionary[key];
                return val;
            }
            return null;

        }


        public void Print()
        {
            // If we have saved information about friends
            if (this.clientDictionary.Count > 0)
            {
                //Console.WriteLine("Name, Email");
                foreach (Client client in this.clientDictionary.Values)
                {
                    //Console.WriteLine(friend.Name + ", " + friend.Email);
                }
            }
            else
            {
                MessageBox.Show("There are no saved information about your friends");
            }
        }

    }
}
