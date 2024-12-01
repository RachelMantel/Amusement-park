using AmusementPark.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Core.InterfaceService
{
    public interface Iservice<T>
    {
        public List<T> getall();

        public T getById(int id);

        public bool add(T item);

        public bool update(int id, T item);

        public bool delete(int id);
    }
}
