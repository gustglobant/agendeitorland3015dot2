using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class Repository:IRepository
    {
       AgendeitorlandContext _context;
       public Repository(AgendeitorlandContext sharedContext=default(AgendeitorlandContext))
       {
           if (sharedContext == default(AgendeitorlandContext))
           {
               _context = new AgendeitorlandContext();
           }
        
       }
        public IQueryable<T> Get<T>() where T : Domain.BaseEntity
        {
            return new AgendeitorlandContext().Set<T>();
        }

        public T GetById<T>(int id) where T : Domain.BaseEntity
        {
            return new AgendeitorlandContext().Set<T>().Find(id);
        }

        public T Create<T>(T _Insert) where T : Domain.BaseEntity
        {
            return _context.Set<T>().Add(_Insert);
        }

        public void Delete<T>(T _Delete) where T : Domain.BaseEntity
        {
            _context.Entry<T>(_Delete).State = System.Data.Entity.EntityState.Deleted;
        }

        public void Update<T>(T _Update) where T : Domain.BaseEntity
        {
             _context.Entry<T>(_Update).State = System.Data.Entity.EntityState.Modified;
         }
     public void SaveChanges()
        {
            _context.SaveChanges();
        }
   }
}
