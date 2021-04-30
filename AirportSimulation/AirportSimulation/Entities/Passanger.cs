using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSimulation.Entities
{
    sealed class Passanger
    {
        public Passport Passport { get; set; }
        public string Name { get; set; }
        public Ticket Ticket { get; set; }
        public Visa Visa { get; set; }
        public Bag Bag { get; set; }

        public Passanger(string name, Passport passport, Ticket ticket, Visa visa, Bag bag)
        {
            Name = name;
            Passport = passport;
            Ticket = ticket;
            Visa = visa;
            Bag = bag;
        }
    }
}
