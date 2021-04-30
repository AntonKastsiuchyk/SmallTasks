using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportSimulation.Entities
{
    sealed class Passport
    {
        public string Number { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Expired { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
