using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class CallDTO
    {
        public int CallId { get; set; }
        public string Anumber { get; set; }
        public string Bnumber { get; set; }
        public string Dir { get; set; }
        public string Duration { get; set; }
        public DateTime Created { get; set; }

        public string AudioFileName { get; set; }
        public string User{ get; set; }
        public int ServiceId { get; set; }
        public string AudioDir { get; set; }
        public string Custom1 { get; set; }
        public string  Service { get; set; }
    }
}
