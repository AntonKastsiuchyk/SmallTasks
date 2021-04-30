using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSimulation.Entities
{
    sealed class Ticket
    {
        public Guid NumberOfTicket { get; set; }

        public static Guid CreateTicket()
        {
            Guid result = new Guid();
            Console.Write("Please take your boarding pass: " + result.ToString());
            return result;
        }
    }
}
