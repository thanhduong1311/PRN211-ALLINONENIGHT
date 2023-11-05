using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_StudentName_Repository.DAO
{
    public class MemberDAO : PetShopProjectContext
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO()
        {

        }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        //methods

        public void UpdatePetShopMemmber(PetShopMember petShopMember)
        {
            this.PetShopMembers.Update(petShopMember);
            this.SaveChanges();
            this.ChangeTracker.Clear();

        }
        public PetShopMember GetPetShopMemberById(string id)
        {
            return this.PetShopMembers.FirstOrDefault(p => p.MemberId.Equals(id));

        }
        public void AddPetShopMemmber(PetShopMember petShopMember)
        {
            this.PetShopMembers.Add(petShopMember);
            this.SaveChanges();
            this.ChangeTracker.Clear();
        }

        public IEnumerable<PetShopMember> GetAllMembers()
            => this.PetShopMembers.ToList();
    }
}
