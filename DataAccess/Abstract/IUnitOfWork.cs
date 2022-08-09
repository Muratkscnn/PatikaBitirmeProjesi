using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IBillOrderRepository BillOrders { get; }
        IApartmentInformationRepository ApartmentInformations { get; }
        IMessageRepository Messages { get; }
        Task<int> SaveAsync();
    }
}
