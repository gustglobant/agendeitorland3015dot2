using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repository
{
 public class AgendeitorlandContext : DbContext
    {
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
    }
}
