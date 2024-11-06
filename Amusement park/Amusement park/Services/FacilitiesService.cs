using Microsoft.AspNetCore.Mvc;

namespace Amusement_park.Services
{
    public class FacilitiesService
    {
        public List<Facilitie> Get()
        {
            return DataManager.dataContext.dataFacilities;
        }

        public Facilitie GetById(int id)
        {
            return DataManager.dataContext.dataFacilities.FirstOrDefault(x => x.Id == id);
        }


        public ActionResult<bool> Add(Facilitie facilitie)
        {
            DataManager.dataContext.dataFacilities.Add(new Facilitie(facilitie));
              return true;
        }

        public ActionResult<bool> Update(int id,Facilitie facilitie)
        {
            int index = DataManager.dataContext.dataFacilities.FindIndex(x => x.Id == id);
            if (index != -1)
            {
                DataManager.dataContext.dataFacilities[index] = new Facilitie(id, facilitie);
                return true;
            }
            return false;

        }

        public ActionResult<bool> Remove(int id)
        {
            return DataManager.dataContext.dataFacilities.Remove(DataManager.dataContext.dataFacilities.FirstOrDefault(x => x.Id == id));
        }

    }
}
