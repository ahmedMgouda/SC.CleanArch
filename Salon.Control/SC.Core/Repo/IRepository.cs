using System;
using SC.Core.Common;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SC.Core.Repo
{
    public interface IRepository<T> where T : class
    {
        Task<QueryResult> Insert(T entity);
        Task<QueryResult> Update(T entity);
        Task<QueryResult> Delete(T entity);
        Task<QueryResult> Delete(Expression<Func<T, bool>> where);
        Task<T> GetById(long id);
        Task<T> Get(Expression<Func<T, bool>> where);
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> GetMany(Expression<Func<T, bool>> where);
    }
}
