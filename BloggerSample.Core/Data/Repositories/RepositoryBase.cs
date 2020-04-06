using BloggerSample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BloggerSample.Core.Data.Repositories
{
    public class RepositoryBase<T> : IRepository<T> where T : class, IEntity
    {
        private readonly DbContext context;
        public RepositoryBase(DbContext _context)
        {
            context = _context;
        }
        public T Add(T entity)
        {
            return context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            var dbSet = context.Set<T>();
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> filter = null,
            Expression<Func<T, object>> include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, int? skip = null, int? take = null)
        {
            IQueryable<T> query = context.Set<T>();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (include != null)
            {
                query = query.Include(include);
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            if (skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }
            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }
            return query;
        }

        public IQueryable<T> GetAll()
        {
            return Get();
        }

        public void Update(T entity)
        {
            context.Set<T>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
    }
}
