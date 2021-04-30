using Serilog;
using System;

namespace Entities
{
    public class Motorcycle
    {
        string _name;
        string _model;
        Guid _id;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == null)
                {
                    value = "null";
                }
                _name = value;
            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                if (value == null)
                {
                    value = "null";
                }
                _model = value;
            }
        }

        public Guid Id { get { return _id; } }
        public int Year { get; set; }
        public int Odometer { get; set; }

        public bool IsValid()
        {
            if(Id.Equals(Guid.Empty) || Name.Equals(string.Empty) || Name.Equals("null") ||
                Model.Equals(string.Empty) || Model.Equals("null") || Year.Equals(default) || Year >= DateTime.Now.Year)
            {
                if (Id.Equals(Guid.Empty))
                {
                    Console.WriteLine("Id is not valid.");
                }

                if (Name.Equals(string.Empty) || Name.Equals("null"))
                {
                    Console.WriteLine("Name is not valid.");
                }

                if (Model.Equals(string.Empty) || Model.Equals("null"))
                {
                    Console.WriteLine("Model is not valid.");
                }

                if (Year.Equals(default) || Year >= DateTime.Now.Year)
                {
                    Console.WriteLine("Year is not valid.");
                }

                if (Odometer.Equals(default) || Odometer >= 10000)
                {
                    Console.WriteLine("Odometer is not valid.");
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public Motorcycle(Guid id)
        {
            _id = id;
        }
    }
    
}
