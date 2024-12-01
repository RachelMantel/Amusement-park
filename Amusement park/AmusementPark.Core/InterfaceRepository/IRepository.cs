using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Core.InterfaceRepository
{
    public interface IRepository<T>
    {
        public List<T> GetList();

        public T GetById(int id);

        public bool Add(T val);

        public bool Update(int id, T val);

        public bool Delete(int id);
    }
}
