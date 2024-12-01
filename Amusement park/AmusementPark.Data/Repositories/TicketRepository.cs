
using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Data.Repositories
{
    public class TicketRepository: IRepository<TicketEntity>
    {
        readonly DataContext _context;

        public TicketRepository(DataContext dataContext)
        {
            _context = dataContext;
        }
        public List<TicketEntity> GetList()
        {
            return _context.ticketlist;
        }
        public TicketEntity GetById(int id)
        {
            return _context.ticketlist.Where(a => a.Id == id).FirstOrDefault();
        }
        public bool Add(TicketEntity t)
        {
            _context.ticketlist.Add(t);
            return _context.SaveData();
        }
        public bool Delete(int id)
        {
            int removedCount = _context.ticketlist.RemoveAll(d => d.Id == id);
            if (removedCount == 0)
                return false;
            return _context.SaveData();
        }
        public bool Update(int id, TicketEntity t)
        {
            for (int i = 0; i < _context.ticketlist.Count; i++)
            {
                if (_context.ticketlist[i].Id == id)
                {
                    _context.ticketlist[i].Copy(t);
                    return _context.SaveData();
                }

            }
            return false;
        }
    }
}
