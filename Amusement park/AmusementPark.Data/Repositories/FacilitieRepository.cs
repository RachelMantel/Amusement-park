
//using AmusementPark.Core.Entities;
//using AmusementPark.Core.InterfaceRepository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace AmusementPark.Data.Repositories
//{
//    public class FacilitieRepository: IRepository<FacilitieEntity>
//    {
//        readonly DataContext _context;

//        public FacilitieRepository(DataContext dataContext)
//        {
//            _context = dataContext;
//        }
//        public List<FacilitieEntity> GetList()
//        {
//            return _context.facilitieList;
//        }
//        public FacilitieEntity GetById(int id)
//        {
//            return _context.facilitieList.Where(a => a.Id == id).FirstOrDefault();
//        }
//        public bool Add(FacilitieEntity f)
//        {
//            _context.facilitieList.Add(f);
//            return _context.SaveData();
//        }
//        public bool Delete(int id)
//        {
//            int removedCount = _context.facilitieList.RemoveAll(d => d.Id == id);
//            if (removedCount == 0)
//                return false;
//            return _context.SaveData();
//        }
//        public bool Update(int id, FacilitieEntity f)
//        {
//            for (int i = 0; i < _context.facilitieList.Count; i++)
//            {
//                if (_context.facilitieList[i].Id == id)
//                {
//                    _context.facilitieList[i].Copy(f);
//                    return _context.SaveData();
//                }

//            }
//            return false;
//        }
//    }
//}
