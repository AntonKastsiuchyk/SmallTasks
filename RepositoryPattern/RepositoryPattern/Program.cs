using Entities;
using Serilog;
using System;

namespace RepositoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid guidExample = new Guid("dddddddddddddddddddddddddddddddd");

            Motorcycle motorcycle = new Motorcycle(Guid.NewGuid()) { Model = "Honda", Name = "Shadow", Odometer = 1, Year = 2011 };
            Motorcycle motorcycle1 = new Motorcycle(Guid.Empty) { Model = "Minsk", Name = "Belarus", Odometer = 2, Year = 2012 };
            Motorcycle motorcycle2 = new Motorcycle(guidExample) { Model = "BMW", Name = "Wind", Odometer = 3, Year = 2013 };
            Motorcycle motorcycle3 = new Motorcycle(Guid.NewGuid()) { Model = "BMW", Name = "Spirit", Odometer = 3, Year = 2020 };
            Motorcycle motorcycle4 = new Motorcycle(guidExample) { Model = "BMW", Name = "Wind", Odometer = 150, Year = 2013 };

            IMotorcycleRepository<Motorcycle> motorcycleRepository = new MotorcycleRepository();

            motorcycleRepository.CreateMotorcycle(motorcycle);
            motorcycleRepository.CreateMotorcycle(motorcycle1);
            motorcycleRepository.CreateMotorcycle(motorcycle2);
            motorcycleRepository.CreateMotorcycle(motorcycle3);

            motorcycleRepository.UpdateMotorcycle(motorcycle4);

            motorcycleRepository.GetMotorcycleById(guidExample);

            motorcycleRepository.DeleteMotorcycle(guidExample);

            motorcycleRepository.GetMotorcycle();
        }
    }
}
