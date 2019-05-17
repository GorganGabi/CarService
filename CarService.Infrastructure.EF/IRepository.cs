using ModelDesignFirst_L1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CarService.Infrastructure.EF
{
    public interface IRepository<T> where T : Entity
    {
        IQueryable<T> Query();
        IQueryable<T> Query(Expression<Func<T, bool>> expression);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
