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
    public class FacilitieService: Iservice<FacilitieEntity>
    {
        readonly IRepository<FacilitieEntity> _facilityRepository;

        public FacilitieService(IRepository<FacilitieEntity> facilityRepository)
        {
            _facilityRepository = facilityRepository;
        }
        public List<FacilitieEntity> getall()
        {
            return _facilityRepository.GetList();
        }

        public FacilitieEntity getById(int id)
        {

            return _facilityRepository.GetById(id);
        }

        public bool add(FacilitieEntity facilitie)
        {
            if (facilitie == null)
                return false;

            return _facilityRepository.Add(facilitie);
        }

        public bool update(int id, FacilitieEntity facilitie)
        {
            return _facilityRepository.Update(id, facilitie);
        }

        public bool delete(int id)
        {

            return _facilityRepository.Delete(id);
        }
    }
}
