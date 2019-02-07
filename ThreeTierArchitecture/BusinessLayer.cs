using System.Windows.Forms;
using System.IO;
namespace BLL
{
    internal class BusinessLayer
    {
        int flag = 0;
        public void Check(string Name, string Password)
        {
            string line; 
            StreamReader file = new StreamReader(@"C:\Users\Suresh.vakkalakula\Desktop\Forms\ThreeTierArchitecture\ThreeTierArchitecture\RegisteredDetails.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] subStr= line.Split('\t');
                if(string.Equals(Name,subStr[0]))
                {
                    if (string.Equals(Password, subStr[1]))
                    {
                        MessageBox.Show("Login Successful"+ "\n\nName        : "+subStr[0]+"\nGender      : "+ subStr[2]+ "\nAddress     : "+ subStr[3]+"\nPhone No  : "+ subStr[4]);
                        flag = 1;
                        return;
                    }
                }
            }
            if (flag == 0)
            {
                MessageBox.Show("Username or Password is incorrect");
            }
        }
    }
}