using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_StudentName_Repository.Reprository
{
    public interface IShopMemberRepository
    {
        IEnumerable<PetShopMember> GetPetShopMembers();

        void UpdatePetShopMemmber(PetShopMember petShopMember);
        void AddPetShopMember(PetShopMember petShopMember);
        PetShopMember GetPetShopMemberById(String id);
    }
}
