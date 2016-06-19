using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL.Interfaces
{
    public interface IGroupRepository
    {
        List<Group> All { get; }
      
        bool AddOrUpdate(Group group);
        bool Delete(int id);
    }
}
