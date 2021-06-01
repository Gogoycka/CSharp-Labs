using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Labs
{
    public static class IOUtils
    {
        public static int SafeReadInteger(string message = null, bool ZeroAcceptable = true)
        {
            if (!string.IsNullOrEmpty(message))
            {
                WriteString(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                int iValue = 0;
                if (Int32.TryParse(sValue, out iValue) && (ZeroAcceptable || iValue != 0))
                {
                    return iValue;
                }
                Console.WriteLine("ERROR: Incorrect value. Enter integer value...");
            }
        }

        public static double SafeReadDouble(string message, bool ZeroAcceptable = true)
        {
            if (!string.IsNullOrEmpty(message))
            {
                WriteString(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                double iValue = 0;
                if (Double.TryParse(sValue, out iValue) && (ZeroAcceptable || iValue != 0))
                {
                    return iValue;
                }
                Console.WriteLine("ERROR: Incorrect value. Enter double value...");
            }
        }

        private static DateTime ReadDateTime(string message = null)
        {
            if (!string.IsNullOrEmpty(message))
            {
                WriteString(message);
            }
            while (true)
            {
                string sValue = Console.ReadLine();
                DateTime date;
                if (DateTime.TryParseExact(sValue, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
                {
                    return date;
                }

                WriteString("ERROR: Incorrect format. Enter correct date...");
            }
        }
        public static List<DateTime> ReadDataSegment()
        {
            List<DateTime> aBuffer = new List<DateTime>();
            while (true)
            {
                WriteString("Enter first date");
                DateTime dtFirstDate = ReadDateTime();
                WriteString("Enter second date");
                DateTime dtSecondDate = ReadDateTime();
                if ((dtSecondDate - dtFirstDate).TotalDays >= 0)
                {
                    aBuffer.Add(dtFirstDate);
                    aBuffer.Add(dtSecondDate);
                    return aBuffer;
                }
                WriteString("First date later than second, try again...");
            }
        }

        public static void WriteString(string sMessage)
        {
            Console.WriteLine(sMessage);
        }

        public static string ReadString()
        {
            return Console.ReadLine();
        }
    }    
}
