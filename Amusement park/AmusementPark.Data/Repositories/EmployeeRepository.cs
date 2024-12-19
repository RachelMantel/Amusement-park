
//using AmusementPark.Core.Entities;
//using AmusementPark.Core.InterfaceRepository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AmusementPark.Data.Repositories
//{
//    public class EmployeeRepository: IRepository<EmployeeEntity>
//    {
//        readonly DataContext _context;

//        public EmployeeRepository(DataContext dataContext)
//        {
//            _context = dataContext;
//        }
//        public List<EmployeeEntity> GetList()
//        {
//            return _context.employeeList;
//        }
//        public EmployeeEntity GetById(int id)
//        {
//            return _context.employeeList.Where(a => a.Id == id).FirstOrDefault();
//        }
//        public bool Add(EmployeeEntity e)
//        {
//            _context.employeeList.Add(e);
//            return _context.SaveData();
//        }
//        public bool Delete(int id)
//        {
//            int removedCount = _context.employeeList.RemoveAll(d => d.Id == id);
//            if (removedCount == 0)
//                return false;
//            return _context.SaveData();
//        }
//        public bool Update(int id, EmployeeEntity e)
//        {
//            for (int i = 0; i < _context.employeeList.Count; i++)
//            {
//                if (_context.employeeList[i].Id == id)
//                {
//                    _context.employeeList[i].Copy(e);
//                    return _context.SaveData();
//                }

//            }
//            return false;
//        }
//    }
//}
