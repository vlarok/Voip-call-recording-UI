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
    public class RoleService
    {
        private IRoleRepository _repo;
        private Factories.RoleFactory _factory;
        public RoleService()
        {
            this._repo = new RoleRepository(new ApplicationDbContext());
            this._factory = new Factories.RoleFactory();
        }

        public List<RoleDTO> GetAllRoles()
        {
            return this._repo.All.Select(x => _factory.createBasicDTO(x)).ToList();
        }
      
    }
}
