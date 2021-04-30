using Entities;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    class MotorcycleRepository : IMotorcycleRepository<Motorcycle>
    {
        private static List<Motorcycle> _motorcycles = new List<Motorcycle>();

        #region CRUD
        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            if (!motorcycle.IsValid())
            {
                return;
            }

            if (_motorcycles.Where(i => i.Id == motorcycle.Id).Count() == 0)
            {
                _motorcycles.Add(motorcycle);
            }
            else throw new Exception($"You can not add Motorcycle with this Id {motorcycle.Id}. Duplicates are not allowed.");
        }

        public void DeleteMotorcycle(Guid id)
        {
            Motorcycle motorcycle = _motorcycles.Where(i => i.Id == id).FirstOrDefault();
            _motorcycles.Remove(motorcycle);
        }

        public List<Motorcycle> GetMotorcycle()
        {
            foreach (var item in _motorcycles)
            {
                Console.WriteLine($"Motorcycle. Id: {item.Id}. Model: {item.Model}. Name: {item.Name}." +
                   $" Odometer: {item.Odometer}. Year: {item.Year}.");
            }
            return _motorcycles;
        }

        public Motorcycle GetMotorcycleById(Guid id)
        {
            return _motorcycles.Where(i => i.Id == id).FirstOrDefault(); ;
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            if (!motorcycle.IsValid())
            {
                return;
            }

            Motorcycle motorcycleForUpdate = _motorcycles.Where(i => i.Id == motorcycle.Id).FirstOrDefault();
            _motorcycles.Remove(motorcycleForUpdate);
            _motorcycles.Add(motorcycle);
        }
        #endregion
    }
}