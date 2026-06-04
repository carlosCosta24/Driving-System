using BusinessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_System.Global
{
    internal class clsGlobal
    {
        public static clsUserBusiness _User;

        public static bool SaveCredentials(string UserName, string Password) 
        {
            try
            {
                string CurrentFolder = System.IO.Directory.GetCurrentDirectory();

                string FilePath = CurrentFolder + "\\Credentials.txt";

                if (UserName == "" && File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                    return true;
                }

                string Credentials = UserName + "//" + Password;

                using (StreamWriter Writer = new StreamWriter(FilePath))
                {
                    Writer.WriteLine(Credentials);
                    return true;
                }
            }
            catch (Exception Error) 
            {
                MessageBox.Show($"An Error occured: { Error.Message}");
                return false;
            }
        }

        public static bool GetCredentials(ref string UserName, ref string Password) 
        {
            try
            {
                string Folder = System.IO.Directory.GetCurrentDirectory();

                string FilePath = Folder + "\\Credentials.txt";

                if (File.Exists(FilePath))
                {
                    using (StreamReader Reader = new StreamReader(FilePath))
                    {
                        string Line;
                        while ((Line = Reader.ReadLine()) != null)
                        {
                            string[] Result = Line.Split(new string[] { "//" }, StringSplitOptions.None);

                            UserName = Result[0];
                            Password = Result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception Error) 
            {
                MessageBox.Show($"An Error occured: {Error.Message}");
                return false;
            }
        }

    }
}
