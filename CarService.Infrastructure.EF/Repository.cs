using ModelDesignFirst_L1;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace CarService.Infrastructure.EF
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<T> dbSet;

        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            dbSet = unitOfWork.Context.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            T existing = dbSet.Find(entity.Id);
            if (existing != null)
            {
                dbSet.Remove(entity);
            }
            dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
            dbSet.Attach(entity);
        }

        public IQueryable<T> Query()
        {
            return dbSet.AsQueryable();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> expression)
        {
            return dbSet.Where(expression).AsQueryable();
        }

        public IEnumerable<T> Get()
        {
            return dbSet.AsEnumerable<T>();
        }

        public IEnumerable<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate).AsEnumerable<T>();
        }
    }
}
