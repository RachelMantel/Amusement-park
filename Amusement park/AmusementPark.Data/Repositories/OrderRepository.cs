
//using AmusementPark.Core.Entities;
//using AmusementPark.Core.InterfaceRepository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AmusementPark.Data.Repositories
//{
//    public class OrderRepository: IRepository<OrderEntity>
//    {
//        readonly DataContext _context;

//        public OrderRepository(DataContext dataContext)
//        {
//            _context = dataContext;
//        }
//        public List<OrderEntity> GetList()
//        {
//            return _context.orderlist;
//        }
//        public OrderEntity GetById(int id)
//        {
//            return _context.orderlist.Where(a => a.Id == id).FirstOrDefault();
//        }
//        public bool Add(OrderEntity o)
//        {
//            _context.orderlist.Add(o);
//            return _context.SaveData();
//        }
//        public bool Delete(int id)
//        {
//            int removedCount = _context.orderlist.RemoveAll(d => d.Id == id);
//            if (removedCount == 0)
//                return false;
//            return _context.SaveData();
//        }
//        public bool Update(int id, OrderEntity e)
//        {
//            for (int i = 0; i < _context.orderlist.Count; i++)
//            {
//                if (_context.orderlist[i].Id == id)
//                {
//                    _context.orderlist[i].Copy(e);
//                    return _context.SaveData();
//                }

//            }
//            return false;
//        }
//    }
//}
