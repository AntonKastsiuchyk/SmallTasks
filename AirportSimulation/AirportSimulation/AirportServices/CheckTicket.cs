using AirportSimulation.Entities;
using AirportSimulation.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSimulation.AirportServices
{
    sealed class CheckTicket
    {
        public static Guid CheckOnlineRegistration(Ticket ticket)
        {
        startloop:
            string answer = Console.ReadLine();
            answer.ToUpper();

            if (answer.Equals("yes"))
            {
                Console.WriteLine("Please input your ticket (00000000-0000-0000-0000-000000000000): ");
                Guid numberOfTicket = CheckType.GetGuidFromConsole();
                ticket.NumberOfTicket = numberOfTicket;
            }
            else if (answer.Equals("no"))
            {
                Console.WriteLine("Ok, i have your passport data.");
                ticket.NumberOfTicket = Ticket.CreateTicket();
            }
            else
            {
                Console.WriteLine("Sorry, I dont understand you. Please try again (yes or no).");
                goto startloop;
            }
            return ticket.NumberOfTicket;
        }
    }
}
