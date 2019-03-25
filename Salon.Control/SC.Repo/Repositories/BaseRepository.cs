using System.Data.Entity;
using System.Threading.Tasks;
using SC.Core.Common;
using SC.Core.Domain;
using SC.Core.Repo;

namespace SC.Repo
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        #region Properties
        private ApplicationContext dataContext;
        private readonly IDbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }
        protected ApplicationContext DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }
        #endregion
        protected BaseRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
        }
        public Task<QueryResult> Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<QueryResult> Delete(System.Linq.Expressions.Expression<System.Func<T, bool>> where)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> Get(System.Linq.Expressions.Expression<System.Func<T, bool>> where)
        {
            throw new System.NotImplementedException();
        }

        public Task<System.Collections.Generic.IEnumerable<T>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<T> GetById(long id)
        {
            throw new System.NotImplementedException();
        }

        public Task<System.Collections.Generic.IEnumerable<T>> GetMany(System.Linq.Expressions.Expression<System.Func<T, bool>> where)
        {
            throw new System.NotImplementedException();
        }

        public Task<QueryResult> Insert(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<QueryResult> Update(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
