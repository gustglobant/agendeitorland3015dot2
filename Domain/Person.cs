using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Person :BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Telephone> Telephone { get; set; }
       
    }
}
