using BusinessObject.Models;
using PetStore_StudentName_Repository.Dao;
using PetStore_StudentName_Repository.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_StudentName_Repository.Reprository
{
    public class ShopMemberRepository : IShopMemberRepository
    {
        public void AddPetShopMember(PetShopMember petShopMember)
        {
            try
            {
                var db = MemberDAO.Instance;
                db.AddPetShopMemmber(petShopMember);
            }
            catch (Exception ex)
            {

            }
        }

        public PetShopMember GetPetShopMemberById(string id)
        => MemberDAO.Instance.GetPetShopMemberById(id);
        

        public IEnumerable<PetShopMember> GetPetShopMembers()
       => MemberDAO.Instance.GetAllMembers();

        public void UpdatePetShopMemmber(PetShopMember petShopMember)
        {
            MemberDAO.Instance.UpdatePetShopMemmber(petShopMember);
        }
    }
}
