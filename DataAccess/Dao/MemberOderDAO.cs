using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_StudentName_Repository.Dao
{
    public class MemberOderDAO : PetShopProjectContext
    {
        private static MemberOderDAO instance = null;
        private static readonly object instanceLock = new object();
        public MemberOderDAO()
        {
            InitalizeContext();
        }

        protected virtual void InitalizeContext()
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            
        }
        public static MemberOderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberOderDAO();
                    }
                    return instance;
                }
            }
        }
        public void AddOder(MemberOrder memberOrder)
        {
            this.MemberOrders.Add(memberOrder);
            this.SaveChanges();
            this.ChangeTracker.Clear();
        }
        public IEnumerable<MemberOrder> GetMemberOder()
         => this.MemberOrders.ToList();
    }
}
