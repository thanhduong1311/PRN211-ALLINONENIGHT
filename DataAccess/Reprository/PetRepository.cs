using BusinessObject.Models;
using PetStore_StudentName_Repository.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_StudentName_Repository.Reprository
{
    public class PetRepository : IPetRepository
    {
        public void AddPet(Pet pet)
        {
            try
            {
                var db = PetDAO.Instance;
                db.AddPet(pet);
            }
            catch (Exception ex)
            {

            }
        }

        public void DeletePet(Pet pet)
        {
            throw new NotImplementedException();
        }

        public void DeletePet(int id)
        {
            PetDAO.Instance.DeletePet(id);
        }

        public IEnumerable<PetGroup> GetAllPetGroups()
        => PetDAO.Instance.GetPetGroups();

        public IEnumerable<Pet> GetAllPets()
        => PetDAO.Instance.GetAllPets();

        public Pet GetPetById(int id)
        => PetDAO.Instance.GetPetById(id);

        public void UpdatePet(Pet pet)
        {
            PetDAO.Instance.UpdatePet(pet);
        }
    }
}
