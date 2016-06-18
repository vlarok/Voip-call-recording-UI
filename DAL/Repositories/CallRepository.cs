using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using Domain;

namespace DAL.Repositories
{
    public class CallRepository : ICallRepository
    {
        private ApplicationDbContext _ctx;

        public CallRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public List<Call> All
        {
            get
            {
                return _ctx.Calls.ToList();
            }
        }
        /*
        public void Add(Call Call)
        {
            _ctx.Calls.Add(Call);
            _ctx.SaveChanges();
        }
        */
        public bool Delete(int id)
        {
            try
            {
                Call call = (from s in All
                                   where s.CallId == id
                                   select s).FirstOrDefault();
                _ctx.Calls.Remove(call);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool AddOrUpdate(Call call)
        {
            try
            {

                _ctx.Calls.AddOrUpdate(call);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {


                return false;
            }
        }

        public List<Call> AllWithComments
        {
            get
            {
                return _ctx.Calls.ToList();
            }
        }

    }
}
