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
    public class GroupService
    {
        private IGroupRepository _repo;
        private Factories.GroupFactory _factory;
        public GroupService()
        {
            this._repo = new GroupRepository(new ApplicationDbContext());
            this._factory = new Factories.GroupFactory();
        }

        public List<GroupDTO> GetAllGroups()
        {
            return this._repo.All.Select(x => _factory.createBasicDTO(x)).ToList();
        }
        public bool Delete(int id)
        {
            return _repo.Delete(id);
        }
      
        public bool AddOrUpdate(Group group)
        {
            return _repo.AddOrUpdate(group);
        }
    }
}
