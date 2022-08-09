using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenericService<T>
    {
        Task Add(T t);
        void Delete(T t);
        void Update(T t);
        Task<IEnumerable<T>> GetList();
        Task<T> GetById(int id);
    }
}
