using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL.Interfaces
{
    public interface ICallRepository
    {
        List<Call> All { get; }
      //  void Add(Call Call);
        bool Delete(int product);
        bool AddOrUpdate(Call call);
    }
}
