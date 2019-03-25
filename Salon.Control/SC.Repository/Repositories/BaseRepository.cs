using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;
using SC.Core.Common;
using SC.Core.Repo;

namespace SC.Repository.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        public readonly AppDbContext _context;
        public readonly DbSet<T> dbSet;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }
        public Task<QueryResult> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<QueryResult> Delete(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetMany(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task<QueryResult> Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<QueryResult> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}