using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using System.Data;

namespace Invoice
{
    [Serializable]
    public class ExtraData
    {
        //Dictionaries of information 
        private Dictionary<string, Client> clientDictionary = new Dictionary<string, Client>();
        private Dictionary<string, Employee> empDic = new Dictionary<string, Employee>();
        private Dictionary<string, string> expenseCodeDic = new Dictionary<string, string>();
        public Dictionary<string, string> serviceCodeDic = new Dictionary<string, string>();

        //System Information Maintence; 
        public string companyName { get; set; }
        public string firmRegNum { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }

        //Methods 
        public void addExpenseCode(string key, string description)
        {
            // If we already had added a friend with this name
            if (this.expenseCodeDic == null)
            {
                expenseCodeDic = new Dictionary<string, string>();
                expenseCodeDic.Add(key, description);
                MessageBox.Show("Expense Code added successfully.");
            }
            else
            {
                if (expenseCodeDic.ContainsKey(key))
                {
                    MessageBox.Show("You had already added " + key);
                }
                else
                {
                    expenseCodeDic.Add(key, description);
                    MessageBox.Show("Expense Code added successfully.");

                }
            }
            
        }

        public void RemoveExpenseCode(string key)
        {
            if (this.expenseCodeDic == null)
            {

                MessageBox.Show("No expense codes in system.");

            }
            else
            {

                if (!this.expenseCodeDic.ContainsKey(key))
                {
                    MessageBox.Show(key + " had not been added before.");
                }

                else
                {
                    if (this.expenseCodeDic.Remove(key))
                    {
                        MessageBox.Show(key + " had been removed successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Unable to remove " + key);
                    }
                }
            }

            
        }

        public void addServiceCode(string key, string description)
        {
            // If we already had added a friend with this name
            if (this.expenseCodeDic == null)
            {
                serviceCodeDic = new Dictionary<string, string>();
                serviceCodeDic.Add(key, description);
                MessageBox.Show("Expense Code added successfully.");
            }
            else
            {
                if (serviceCodeDic.ContainsKey(key))
                {
                    MessageBox.Show("You had already added " + key);
                }
                else
                {
                    serviceCodeDic.Add(key, description);
                    MessageBox.Show("Expense Code added successfully.");

                }
            }

        }

        public void RemoveServiceCode(string key)
        {
            if (this.serviceCodeDic == null)
            {

                MessageBox.Show("No service codes in system.");

            }
            else
            {

                if (!this.serviceCodeDic.ContainsKey(key))
                {
                    MessageBox.Show(key + " had not been added before.");
                }

                else
                {
                    if (this.serviceCodeDic.Remove(key))
                    {
                        MessageBox.Show(key + " had been removed successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Unable to remove " + key);
                    }
                }
            }


        }

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
                MessageBox.Show("Employee added successfully.");

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
                this.clientDictionary[name].Instance();
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

        public List<string> EmployeeList()
        {

            List<string> keyList = new List<string>(this.empDic.Keys);

            return keyList;
        }

        public List<string> ServiceCodesList()
        {

            List<string> keyList = new List<string>(this.serviceCodeDic.Keys);

            return keyList;
        }

        public List<string> ExpenseCodesList()
        {

            List<string> keyList = new List<string>(this.expenseCodeDic.Keys);

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

        public Employee getEmployee(string key)
        {
            if (empDic.ContainsKey(key))
            {
                Employee val = empDic[key];
                return val;
            }
            return null;

        }

        public Dictionary<string, string> getExpenseCodes()
        {
            return expenseCodeDic;
        }

        public Dictionary<string, string> getServiceCodes()
        {
            return serviceCodeDic;
        }

        public DataTable getClientDataTable(string key)
        {
            if (!key.Equals(""))
            {
                return getClient(key).dTable;
            }
            return null;
        }


        public void addRowClientDataTable(string key, DateTime dt, string disc, string code, double time, double mil, double dis)
        {
            if (clientDictionary.ContainsKey(key))
            {
                clientDictionary[key].recNumber += 1;
                clientDictionary[key].dTable.Rows.Add(clientDictionary[key].recNumber, dt, disc, code, time, mil, dis);

            }

        }

        public void deleteRowClientDataTable(string key, int recNum)
        {

            if (clientDictionary.ContainsKey(key))
            {
                int index = -1;

                var ids = clientDictionary[key].dTable.AsEnumerable().Select(r => r.Field<int>("Rec#")).ToList();

                index = ids.FindIndex(x => x == recNum);

                if (index != -1)
                {
                   clientDictionary[key].dTable.Rows.Remove(clientDictionary[key].dTable.Rows[index]);

                }
                
            }
        }

        public void addCloumnClientDataTable(string key, string col, object type )
        {
            if (clientDictionary.ContainsKey(key))
            {
                clientDictionary[key].dTable.Columns.Add(col,type.GetType());
            }

        }

        public DataTable subClientDataTable(string key, DateTime start, DateTime end)
        {
            DataTable dtcopy = clientDictionary[key].dTable.Copy();
            dtcopy.DefaultView.Sort = "Date of Service";
            dtcopy = dtcopy.DefaultView.ToTable();

            int startID = 0;
            int endID = 0;

            var ids = dtcopy.AsEnumerable().Select(r => r.Field<DateTime>("Date of Service")).ToList();
            startID = ids.FindIndex(x => x > start);
            if(startID == -1) { startID = ids.Count; }
            endID = ids.FindIndex(x => x > end);
            if (endID == -1) { endID = ids.Count; }

            DataTable dt = new DataTable();
            dt.Columns.Add("Rec#", typeof(int));
            dt.Columns.Add("Date of Service", typeof(DateTime));
            dt.Columns.Add("Service Description", typeof(string));
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Time", typeof(double));
            dt.Columns.Add("Mileage", typeof(double));
            dt.Columns.Add("Discount", typeof(double));


       

            for (int i = startID; i < endID; i++)
            {
                DataRow dr = dtcopy.Rows[i];
                dt.Rows.Add(dr.ItemArray);
                
            }
            dtcopy.Clear(); 
            return dt;
        }

        public void setClientdTable(string key, string[] row)
        {
            if (clientDictionary.ContainsKey(key))
            {
                clientDictionary[key].dTable.Rows.Add(row);
                
            }
           

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
