using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL;
using DAL.Interfaces;
using DAL.Repositories;
using Domain;

namespace BLL.Services
{
    public class CallService
    {
        private ICallRepository _repo;
        private Factories.CallFactory _factory;
        public CallService()
        {
            this._repo = new CallRepository(new ApplicationDbContext());
            this._factory = new Factories.CallFactory();
        }
        public List<CallDTO> getAllCalls()
        {
            return this._repo.All.Select(x => _factory.createBasicDTO(x)).ToList();
        }
        public CallDTO Find(int id)
        {
            return this._repo.All.Where(x => x.CallId.Equals(id)).Select(x => _factory.createBasicDTO(x)).FirstOrDefault();

        }
        

       

        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }

      

        public bool AddOrUpdate(Call call)
        {
            return _repo.AddOrUpdate(call);
        }


        public List<CallDTO> getCallsRange(DateTime @from, DateTime to)
        {
            return this._repo.All.Where(c => c.Created <= to
                                       && (c.Created) >= @from).Select(x => _factory.createBasicDTO(x)).ToList();
        }
    }
}
