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
    public class EmployeeService: Iservice<EmployeeEntity>
    {
        readonly IRepository<EmployeeEntity> _employeeRepository;

        public EmployeeService(IRepository<EmployeeEntity> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public List<EmployeeEntity> getall()
        {
            return _employeeRepository.GetList();
        }

        public EmployeeEntity getById(int id)
        {

            return _employeeRepository.GetById(id);
        }

        public bool add(EmployeeEntity employee )
        {
            if (employee == null)
                return false;

            return _employeeRepository.Add(employee);
        }

        public bool update(int id, EmployeeEntity employee)
        {
            return _employeeRepository.Update(id, employee);
        }

        public bool delete(int id)
        {

            return _employeeRepository.Delete(id);
        }
    }
}
