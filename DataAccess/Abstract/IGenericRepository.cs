using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IGenericRepository<T>
    {
        Task Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> Get(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> expression = null);
    }
}
