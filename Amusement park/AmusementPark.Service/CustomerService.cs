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
    public class CustomerService : Iservice<CustomerEntity>
    {
        readonly IRepository<CustomerEntity> _customerRepository;

        public CustomerService(IRepository<CustomerEntity> customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public List<CustomerEntity> getall()
        {
            return _customerRepository.GetList();
        }

        public CustomerEntity getById(int id)
        {

            return _customerRepository.GetById(id);
        }

        public bool add(CustomerEntity customer)
        {
            if (customer == null)
                return false;

            return _customerRepository.Add(customer);
        }

        public bool update(int id, CustomerEntity customer)
        {
            return _customerRepository.Update(id, customer);
        }

        public bool delete(int id)
        {

            return _customerRepository.Delete(id);
        }
    }
}
