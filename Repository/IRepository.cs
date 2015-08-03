using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository
    {
        IQueryable<T> Get<T>() where T : BaseEntity;
        T GetById<T>(int id) where T : BaseEntity;
        T Create<T>(T _Insert) where T : BaseEntity;
        void Delete<T>(T _Delete) where T : BaseEntity;
        void Update<T>(T _Update) where T : BaseEntity;
    }
}
