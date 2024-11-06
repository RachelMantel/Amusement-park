using Microsoft.AspNetCore.Mvc;

namespace Amusement_park.Services
{
    public class OrderService
    {
        public List<Order> Get()
        {
            return DataManager.dataContext.dataOrders;
        }

        public Order GetById(int id)
        {
            return DataManager.dataContext.dataOrders.FirstOrDefault(x => x.Id == id);
        }


        public ActionResult<bool> Add(Order order)
        {
            DataManager.dataContext.dataOrders.Add(new Order(order));
            return true;
        }

        public ActionResult<bool> Update(int id, Order order)
        {
            int index = DataManager.dataContext.dataOrders.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                DataManager.dataContext.dataOrders[index] = new Order(id, order);
                return true;
            }
            return false;

        }

        public ActionResult<bool> Remove(int id)
        {
            return DataManager.dataContext.dataOrders.Remove(DataManager.dataContext.dataOrders.FirstOrDefault(x => x.Id == id));
        }
    }
}
