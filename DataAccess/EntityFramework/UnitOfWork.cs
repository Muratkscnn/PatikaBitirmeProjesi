using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly ApartmentContext _context;

        public UnitOfWork(ApartmentContext context)
        {
            _context = context;
        }
        private EfApartmentInformationRepository _apartmentInformationRepository;
        private EfBillOrderRepository _billOrderRepository;
        private EfMessageRepository _messageRepository;

        public IBillOrderRepository BillOrders => _billOrderRepository = _billOrderRepository ?? new EfBillOrderRepository(_context);


        public IApartmentInformationRepository ApartmentInformations => _apartmentInformationRepository = _apartmentInformationRepository ?? new EfApartmentInformationRepository(_context);

        public IMessageRepository Messages => _messageRepository = _messageRepository ?? new EfMessageRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
