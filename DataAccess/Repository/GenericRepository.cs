using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext _context;

        public GenericRepository(DbContext context)
        {
            _context = context;
        }

        public async Task Create(T entity)
        {
             await _context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
             _context.Set<T>().Remove(entity);

        }

        public async Task<T> Get(Expression<Func<T, bool>> expression)
        {
             return await _context.Set<T>().FirstOrDefaultAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> expression = null)
        {
            if (expression == null)
                return await _context.Set<T>().ToListAsync();
            else
            {
                return await _context.Set<T>().Where(expression).ToListAsync();
            }
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
