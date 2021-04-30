using AirportSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSimulation.AirportServices
{
    sealed class PassportControl
    {
        public static Passanger CheckPassanger(Passanger passanger)
        {
        startloop:
            string answer = Console.ReadLine();
            answer.ToUpper();

            if (answer.Equals("yes"))
            {
                Console.WriteLine("Thank you. You may pass on. Have a good flight.");
                Environment.Exit(0);
            }
            else if (answer.Equals("no"))
            {
                Console.WriteLine("I must call security.");
            }
            else
            {
                Console.WriteLine("Sorry, i dont understand you, please try again (yes or no).");
                goto startloop;
            }
            return passanger;
        }
    }
}
