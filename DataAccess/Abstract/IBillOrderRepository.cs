using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBillOrderRepository : IGenericRepository<BillOrder>
    {
        Task<IEnumerable<BillOrder>> GetUnpaidAllApartment(Expression<Func<BillOrder, bool>> expression = null);
    }
}
