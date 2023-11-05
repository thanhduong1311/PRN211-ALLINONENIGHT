using BusinessObject.Models;
using PetStore_StudentName_Repository.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_StudentName_Repository.Reprository
{
    public class MemberOderRepo : IMemberOderRepo
    {
        public void AddOder(MemberOrder memberOrder)
        {
            try
            {
                var db = MemberOderDAO.Instance;
                db.AddOder(memberOrder);
            }
            catch (Exception ex)
            {
               
            }
        }

    }
}
