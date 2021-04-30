using AirportSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSimulation.AirportServices
{
    sealed class CheckPassport
    {
        public static void CheckDatesOfPassport(Passport passport)
        {
            if (passport.Expired.Date == DateTime.Now.Date || passport.Expired.Date <= passport.Issued.Date || passport.DateOfBirth.Date == passport.Issued.Date)
            {
                Console.WriteLine("Your passport is not valid. Sorry, but you can not travel.");
                Environment.Exit(0);
            }
        }
    }
}
