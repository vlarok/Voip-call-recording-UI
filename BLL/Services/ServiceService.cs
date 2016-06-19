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
    public class ServiceService
    {
        private IServiceRepository _repo;
        private Factories.ServiceFactory _factory;
        public ServiceService()
        {
            this._repo = new ServiceRepository(new ApplicationDbContext());
            this._factory = new Factories.ServiceFactory();
        }

        public List<ServiceDTO> GetAllServices()
        {
            return this._repo.All.Select(x => _factory.createBasicDTO(x)).ToList();
        }
        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }
      
        public bool AddOrUpdate(Service service)
        {
            return _repo.AddOrUpdate(service);
        }
    }
}
