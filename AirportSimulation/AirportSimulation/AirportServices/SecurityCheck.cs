using AirportSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSimulation.AirportServices
{
    sealed class SecurityCheck
    {
        public static string CheckForbiddenItem(SecurityEmployee security)
        {
        startloop:
            string answer = Console.ReadLine();
            answer.ToUpper();

            if (answer.Equals("yes"))
            {
                Console.WriteLine("One move and I'll shoot!");
                Environment.Exit(0);
            }
            else if (answer.Equals("no"))
            {
                Console.WriteLine("You may pass on.");
            }
            else
            {
                Console.WriteLine("Sorry, i dont understand your understrike, please try again (yes or no).");
                goto startloop;
            }
            return security.ForbiddenItem;
        }
    }
}
