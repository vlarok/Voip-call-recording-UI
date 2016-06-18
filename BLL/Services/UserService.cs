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
    public class UserService
    {
        private IUserRepository _repo;
        private Factories.UserFactory _factory;
        public UserService()
        {
            this._repo = new UserRepository(new ApplicationDbContext());
            this._factory = new Factories.UserFactory();
        }
        public List<UserDTO> getAllUsers()
        {
            return this._repo.All.Select(x => _factory.createBasicDTO(x)).ToList();
        }

        public UserDTO Find(string id)
        {
            return this._repo.All.Where(x => x.Id.Equals(id)).Select(x => _factory.createBasicDTO(x)).FirstOrDefault();

        }

        public bool AddOrUpdate(User user)
        {
            return _repo.AddOrUpdate(user);
        }
    }
}
