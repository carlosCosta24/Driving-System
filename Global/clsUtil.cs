using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Driving_System.Global
{
    internal class clsUtil
    {
        public static string GenerateGUID()
        {
            Guid newGuid = Guid.NewGuid();

            return newGuid.ToString();

        }

        public static bool CreateFolderIfDoesNotExist(string FolderPath) {

            if (!Directory.Exists(FolderPath)) 
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                    return true;
                }
                catch (Exception Error) {
                    MessageBox.Show("Error whil creating the folder: " + Error.Message);
                    return false;
                }
            }
            return true;
        }

        public static string ReplaceFileNameWithGUID(string SourceFile) 
        {
            string FileName = SourceFile;
            FileInfo FI = new FileInfo(FileName);
            string Extn = FI.Extension;
            return GenerateGUID() + Extn;
        }

        public static bool CopyImageToProjectFolder(ref string SourceFile) {

            string Destination = @"C:\Driving-System-Images\";
            if (!CreateFolderIfDoesNotExist(Destination)) { 
                return false;
            }
            string DestinationFile = Destination + ReplaceFileNameWithGUID(SourceFile);
            try
            {
                File.Copy(SourceFile, DestinationFile, true);
            }
            catch (IOException Error) 
            {
                MessageBox.Show(Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            SourceFile = DestinationFile;
            return true;
        }
    }
}
