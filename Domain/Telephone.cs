using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Telephone:BaseEntity 
    {
        public string TelephoneNumber { get; set; }
        public virtual Person Person { get; set; }
    }
}
