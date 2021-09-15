using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        // Generic constraint 
        // class : referans tip
        // IEntity : IEntity olabilir veya IEntity implement eden bir nesne olabilir.
        // new() = new'lenebilir olmalı. Böylelikle IEntity açığı da kapandı
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}
