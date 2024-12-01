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
    public class OrderService : Iservice<OrderEntity>
    {
        readonly IRepository<OrderEntity> _orderRepository;

        public OrderService(IRepository<OrderEntity> orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<OrderEntity> getall()
        {
            return _orderRepository.GetList();
        }

        public OrderEntity getById(int id)
        {

            return _orderRepository.GetById(id);
        }

        public bool add(OrderEntity order)
        {
            if (order == null)
                return false;

            return _orderRepository.Add(order);
        }

        public bool update(int id, OrderEntity order)
        {
            return _orderRepository.Update(id, order);
        }

        public bool delete(int id)
        {

            return _orderRepository.Delete(id);
        }
    }
}
