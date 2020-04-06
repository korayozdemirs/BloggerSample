﻿using BloggerSample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BloggerSample.Core.Data.Repositories
{
    public interface IRepository<T> where T : class, IEntity
    {
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> Get
            (
                    Expression<Func<T, bool>> filter = null,
                    Expression<Func<T, object>> include = null,
                    Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                    int? skip = null,
                    int? take = null
            );
    }
}
