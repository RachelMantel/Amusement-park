
//using AmusementPark.Core.Entities;
//using AmusementPark.Core.InterfaceRepository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AmusementPark.Data.Repositories
//{
//    public class CustomerRepository:IRepository<CustomerEntity>
//    {
//        readonly DataContext _context;

//        public CustomerRepository(DataContext dataContext)
//        {
//            _context = dataContext;
//        }
//        public List<CustomerEntity> GetList()
//        {
//            return _context.customerList;
//        }
//        public CustomerEntity GetById(int id)
//        {
//            return _context.customerList.Where(a => a.Id == id).FirstOrDefault();
//        }
//        public bool Add(CustomerEntity c)
//        {
//            _context.customerList.Add(c);
//            return _context.SaveData();
//        }
//        public bool Delete(int id)
//        {
//            int removedCount = _context.customerList.RemoveAll(d => d.Id == id);
//            if (removedCount == 0)
//                return false;
//            return _context.SaveData();
//        }
//        public bool Update(int id, CustomerEntity c)
//        {
//            for (int i = 0; i < _context.customerList.Count; i++)
//            {
//                if (_context.customerList[i].Id == id)
//                {
//                    _context.customerList[i].Copy(c);
//                    return _context.SaveData();
//                }

//            }
//            return false;
//        }

//    }
//}
