using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBillOrderService : IGenericService<BillOrder>
    {
        Task<IEnumerable<BillOrder>> GetUnpaidAllApartment();
        Task<IEnumerable<BillOrder>> GetUnpaidByUser(int id);
    }
}
