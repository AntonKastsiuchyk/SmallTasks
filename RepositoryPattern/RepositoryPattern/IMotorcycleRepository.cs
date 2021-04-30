using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    interface IMotorcycleRepository<T>
    {
        #region CRUD
        List<T> GetMotorcycle();

        T GetMotorcycleById(Guid id);

        void CreateMotorcycle(T motorcycle);

        void UpdateMotorcycle(T motorcycle);

        void DeleteMotorcycle(Guid id);
        #endregion
    }
}
