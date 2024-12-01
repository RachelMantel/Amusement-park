using AmusementPark.Core.Entities;
using AmusementPark.Core.InterfaceRepository;
using AmusementPark.Core.InterfaceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmusementPark.Service
{
    public class TicketService:Iservice<TicketEntity>
    {
        readonly IRepository<TicketEntity> _ticketRepository;

        public TicketService(IRepository<TicketEntity> ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
        public List<TicketEntity> getall()
        {
            return _ticketRepository.GetList();
        }

        public TicketEntity getById(int id)
        {

            return _ticketRepository.GetById(id);
        }

        public bool add(TicketEntity ticket)
        {
            if (ticket == null)
                return false;

            return _ticketRepository.Add(ticket);
        }

        public bool update(int id, TicketEntity ticket)
        {
            return _ticketRepository.Update(id, ticket);
        }

        public bool delete(int id)
        {

            return _ticketRepository.Delete(id);
        }
    }
}
