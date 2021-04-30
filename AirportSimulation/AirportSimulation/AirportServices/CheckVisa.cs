using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSimulation.AirportServices
{
    sealed class CheckVisa
    {
        public static string CheckOfVisa()
        {
            string status = "Available";

        startloop:
            string answer = Console.ReadLine();
            answer.ToUpper();

            if (answer.Equals("yes"))
            {
                Console.WriteLine("Thank you. Please answer next questions.");
            }
            else if (answer.Equals("no"))
            {
                Console.WriteLine("Sorry, you can not travel without visa.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Sorry, I dont understand you. Please try again (yes or no).");
                goto startloop;
            }
            return status;
        }
    }
}
