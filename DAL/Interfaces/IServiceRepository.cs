using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL.Interfaces
{
    public interface IServiceRepository
    {
        List<Service> All { get; }
      
        bool AddOrUpdate(Service service);
        bool Delete(int id);
    }
}
