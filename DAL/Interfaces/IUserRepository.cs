using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL.Interfaces
{
    public interface IUserRepository
    {
        List<User> All { get; }
      //  void Add(Call Call);
       // bool Delete(int Call);
       // bool AddOrUpdate(Call Call);
        bool AddOrUpdate(User user);
    }
}
