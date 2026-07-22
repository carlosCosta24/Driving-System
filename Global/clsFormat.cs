using System;

namespace Driving_System.Global
{
    public class clsFormat
    {
        public static string DateToShort(DateTime Date)
        {
            return Date.ToString("dd/MMM/yyyy");

        }
    }
}
