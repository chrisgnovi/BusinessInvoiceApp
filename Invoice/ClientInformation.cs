using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public class ClientInformation
    {
        private static ClientInformation clientInformation;

        public ExtraData extraData;
        private BinaryFormatter formatter;

        private const string DATA_FILENAME = "clientinformation.dat";


        public static ClientInformation Instance()
        {
            if (clientInformation == null)
            {
                clientInformation = new ClientInformation();
            } 

            return clientInformation;
        } 

        private ClientInformation()
        {
            
            // Create a Dictionary to store clients at runtime
            this.extraData = new ExtraData();
            this.formatter = new BinaryFormatter();
        }

        
        public void Save()
        {
            // Gain code access to the file 
            try
            {
                // Create a FileStream that will write data to file.
                FileStream writerFileStream = new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write);
                // Save our dictionary of friends to file
                this.formatter.Serialize(writerFileStream, this.extraData);

                // Close the writerFileStream when we are done.
                writerFileStream.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to save client' information");
            } 
        } 

        public void Load()
        {

            // Check if we had previously Save information of our friends
            // previously
            if (File.Exists(DATA_FILENAME))
            {

                try
                {
                    // Create a FileStream will gain read access to the 
                    // data file.
                    FileStream readerFileStream = new FileStream(DATA_FILENAME,
                        FileMode.Open, FileAccess.Read);
                    // Reconstruct information of our friends from file.
                    this.extraData = (ExtraData)
                        this.formatter.Deserialize(readerFileStream);
                    // Close the readerFileStream when we are done
                    readerFileStream.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("There seems to be a file that contains " +
                        "client information but somehow there is a problem " +
                        "with reading it.");
                } 

            } 

        } 

    }
}
