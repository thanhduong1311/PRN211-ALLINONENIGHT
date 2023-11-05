using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace PetStore_StudentName_Repository.Dao
{
    public class PetDAO : PetShopProjectContext
    {
        private static PetDAO instance = null;
        private static readonly object instanceLock = new object();
        private PetDAO()
        {
            InitalizeContext();
        }

        protected virtual void InitalizeContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public static PetDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new PetDAO();
                    }
                    return instance;
                }
            }
        }
        public Pet GetPetById(int id)
        {
            return this.Pets.FirstOrDefault(m => m.PetId.Equals(id));

        }
        public IEnumerable<Pet> GetAllPets()
        {
            return this.Pets.Include(p => p.PetGroup).ToList();
        }
        public void UpdatePet(Pet pet)
        {
            this.Pets.Update(pet);
            this.SaveChanges();
            this.ChangeTracker.Clear();

        }
        public void DeletePet(int id)
        {
            var pet = this.Pets.FirstOrDefault(p => p.PetId == id);
            if (pet != null)
            {
                this.Pets.Remove(pet);
            }


        }

        public void AddPet(Pet pet)
        {
            this.Pets.Add(pet);
            this.SaveChanges();
            this.ChangeTracker.Clear();
        }
        /*Lay ra all petgroup*/
        public IEnumerable<PetGroup> GetPetGroups()
         => this.PetGroups.ToList();

    }
}
