using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Service
    {
        public int ServiceId { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Created { get; set; }
        //public int CallId { get; set; }
    }
}
