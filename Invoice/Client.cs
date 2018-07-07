using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    [Serializable]
    public class Client
    {
        public DataTable dTable = new DataTable(); // = new DataTable();
        

        public Client()
        {
            //makeDataTable();
        }


        public DataTable GetTable()
        {

            dTable = new DataTable();
            dTable.Columns.Add("Rec#", typeof(string));
            dTable.Columns.Add("Date of Service", typeof(string));
            dTable.Columns.Add("Service Description", typeof(string));
            dTable.Columns.Add("Code", typeof(string));
            dTable.Columns.Add("Time", typeof(string));
            dTable.Columns.Add("Mileage", typeof(string));
            dTable.Columns.Add("Discount", typeof(string));
            dTable.Rows.Add("1", "2", "3", "4", "5", "6");

            return dTable;
           
        }

        // File info
        public string fileNumber { get; set; }
        public DateTime dateServiceBegin { get; set; }
        public string difficultyRating { get; set; }
        public string suspendInvoice { get; set; }

        // Client info
        public string clientFirstName { get; set; }
        public string clientLastName { get; set; }
        public string clientAddressLine1 { get; set; }
        public string clientAddressLine2 { get; set; }
        public string clientCity { get; set; }
        public string clientState { get; set; }
        public string clientZip { get; set; }
        public string clientHomeNumber { get; set; }
        public string clientWorkPhone { get; set; }
        public string clientDayBorn { get; set; }
        public string clientClaimNumber { get; set; }
        public string empleeCode { get; set; }
        public DateTime dateInjured { get; set; }
        public DateTime datePlFile { get; set;}
        public string serviceLimit { get; set; }
        public string servicePeriodMonths { get; set; }
        public string monthlyLimit { get; set; }

        // Carrier info
        public string carrierName { get; set; }
        public string carrierAddressLine1 { get; set; }
        public string carrierAddressLine2 { get; set; }
        public string carrierCity { get; set; }
        public string carrierState { get; set; }
        public string carrierZip { get; set; }
        public string carrierRepresentative { get; set; }
        public string carrierPhone { get; set; }
        public string carrierBillingRate { get; set; }
        public string carrierMillageRateDistance { get; set; }
        public string carrierMillageRatePercentage { get; set; }
        public string carrierFax { get; set; }
    
        // Attorney info
        public string attorneyFirstName { get; set; }
        public string attorneyLastName { get; set; }
        public string attorneyHomePhone { get; set; }
        public string attorneyWorkNumber { get; set; }
        public string attorneyFax { get; set; }
        public string attorneyParalegal { get; set; }
        public string attorneyAddressLine1 { get; set; }
        public string attorneyAddressLine2 { get; set; }
        public string attorneyCity { get; set; }
        public string attorneyState { get; set; }
        public string attorneyZip { get; set; }

        // QRC info 
        public string qrcFirstName { get; set; }
        public string qrcLastName { get; set; }
        public string qrcHomePhine { get; set; }
        public string qrcWorkPhone { get; set; }
        public string qrcFax { get; set; }
        public string qrcAddressLine1 { get; set; }
        public string qrcAddressLine2 { get; set; }
        public string qrcCity { get; set; }
        public string qrcState { get; set; }
        public string qrcZip { get; set; }
        public string qrcProviderRegNumber { get; set; }

        public string referralSourcePerson { get; set; }

        // Employer Info
        public string employerName { get; set; }
        public string employerPhone { get; set; }
        public string employerFax { get; set; }
        public string employerAddressLine1 { get; set; }
        public string employerAddressLine2 { get; set; }
        public string employerCity { get; set; }
        public string employerState { get; set; }
        public string employerZip { get; set; }
        public string employerContact { get; set; }

        // Doctor Name
        public string doctorFirstName { get; set; }
        public string doctorLastName { get; set; }
        public string doctorClinic { get; set; }
        public string doctorAddressLine1 { get; set; }
        public string doctorAddressLine2 { get; set; }
        public string doctorCity { get; set; }
        public string doctorState { get; set; }
        public string doctorZip { get; set; }
        public string doctorPhone { get; set; }
        public string doctorFax { get; set; }

    }
}
