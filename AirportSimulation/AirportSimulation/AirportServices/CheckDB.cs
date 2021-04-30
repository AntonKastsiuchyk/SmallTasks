using AirportSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSimulation.AirportServices
{
    sealed class CheckDB
    {
        public static DateTime CheckDateOfBirth(Passport passport)
        {
            if (DateTime.Now.Year - passport.DateOfBirth.Year <= Constants.Const.MinAge)
            {
                Console.WriteLine("You are cannot fly alone. Unaccompanied minor service required.");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Unaccompanied minor service unrequired.");
            }
            return passport.DateOfBirth;
        }
    }
}
