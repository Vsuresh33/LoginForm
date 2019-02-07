using System.Windows.Forms;
using System.IO;
using System;
namespace DLL
{
    internal class DataAccessLayer
    { 
        public void Store(string Name, string Password,string Gender,string Address,string Phone)
        {
            try
            {
                StreamWriter sw = new StreamWriter(@"C:\Users\Suresh.vakkalakula\Desktop\Forms\3-tierArchitecture\3-tierArchitecture\RegisteredDetails.txt", true);
                sw.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",Name,Password,Gender,Address,Phone);
                MessageBox.Show("Username: " + Name + "\nPassword: " + Password + "\n\n\nYou have successfully registered");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}