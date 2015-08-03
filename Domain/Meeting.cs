using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
   public  class Meeting :BaseEntity
    {
        [Required(ErrorMessage="The event needs a name, i.e: 'CAN I HAZ CHEEZBURGER'")
        ,MaxLength(80,ErrorMessage="YOU SHALL NOT PASS 80 CHARACTERS")]
        public string Name { get; set; }
        [Required(ErrorMessage="You need to write down a place,i.e: 'THE INTERWEBZ'")]
        public string Place { get; set; }
            public DbGeography GPSLocation { get; set; }
        [Required]
        public DateTime EventDate { get; set; }
        [Required]
        public virtual Person Organizer { get; set; }
        public virtual ICollection<Person> Members { get; set; }
    }
}
