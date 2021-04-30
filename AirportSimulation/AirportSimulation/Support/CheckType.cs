using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSimulation.Support
{
    sealed class CheckType
    {
        public static DateTime GetDateFromConsole()
        {

            bool isDateTime = false;
            DateTime result = default;

            while (!isDateTime)
            {
                if (DateTime.TryParse(Console.ReadLine(), out result))
                {
                    isDateTime = true;
                }
                else
                {
                    Console.WriteLine("Sorry, I dont understand you. Please try again.");
                }
            }
            return result;
        }

        public static Guid GetGuidFromConsole()
        {
            bool isGuid = false;
            Guid result = default;

            while (!isGuid)
            {
                if (Guid.TryParse(Console.ReadLine(), out result))
                {
                    isGuid = true;
                }
                else
                {
                    Console.WriteLine("This ticket is wrong. Please try again");

                }
            }
            return result;
        }
    }
}
