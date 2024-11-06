using Microsoft.AspNetCore.Mvc;

namespace Amusement_park.Services
{
    public class TicketsService
    {

        public List<Ticket> Get()
        {
            return DataManager.dataContext.dataTickets;
        }

        public Ticket GetById(int id)
        {
            return DataManager.dataContext.dataTickets.FirstOrDefault(x => x.Id == id);
        }
        public ActionResult<bool> Add(Ticket ticket)
        {
            DataManager.dataContext.dataTickets.Add(new Ticket(ticket));
            return true;
        }

        public ActionResult<bool> Update(int id, Ticket ticket)
        {
            int index = DataManager.dataContext.dataTickets.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                DataManager.dataContext.dataTickets[index] = new Ticket(id, ticket);
                return true;
            }
            return false;

        }

        public ActionResult<bool> Remove(int id)
        {
            return DataManager.dataContext.dataTickets.Remove(DataManager.dataContext.dataTickets.FirstOrDefault(x => x.Id == id));
        }

    }
}
