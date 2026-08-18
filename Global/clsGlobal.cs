using BusinessLayer;
using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Driving_System.Global
{
    internal class clsGlobal
    {
        public static clsUserBusiness _User;

        public static bool SaveCredentials(string UserName, string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DrivingSys";
            string Value = UserName;
            string ValueData = Password;
            try
            {
                Registry.SetValue(KeyPath, Value, ValueData);
                //string CurrentFolder = System.IO.Directory.GetCurrentDirectory();

                //string FilePath = CurrentFolder + "\\Credentials.txt";

                //if (UserName == "" && File.Exists(FilePath))
                //{
                //    File.Delete(FilePath);
                //    return true;
                //}

                //string Credentials = UserName + "//" + Password;

                //using (StreamWriter Writer = new StreamWriter(FilePath))
                //{
                //    Writer.WriteLine(Credentials);
                //    return true;
                //}
                return true;
            }
            catch (Exception Error)
            {
                MessageBox.Show($"An Error occured: {Error.Message}");
                return false;
            }
        }

        public static bool GetCredentials(ref string UserName, ref string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DrivingSys";
            string Value = UserName;
            string ValueData = Password;
            try
            {
                Registry.GetValue(KeyPath, Value, ValueData);
                UserName = Value;
                Password = ValueData;


                //string Folder = System.IO.Directory.GetCurrentDirectory();

                //string FilePath = Folder + "\\Credentials.txt";

                //if (File.Exists(FilePath))
                //{
                //    using (StreamReader Reader = new StreamReader(FilePath))
                //    {
                //        string Line;
                //        while ((Line = Reader.ReadLine()) != null)
                //        {
                //            string[] Result = Line.Split(new string[] { "//" }, StringSplitOptions.None);

                //            UserName = Result[0];
                //            Password = Result[1];
                //        }
                //        return true;
                //    }
                //}
                //else
                //{
                //    return false;
                //}
                return true;
            }
            catch (Exception Error)
            {
                MessageBox.Show($"An Error occured: {Error.Message}");
                return false;
            }
        }

    }
}
