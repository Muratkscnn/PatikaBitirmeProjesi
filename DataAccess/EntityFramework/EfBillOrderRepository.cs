using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfBillOrderRepository : GenericRepository<BillOrder>, IBillOrderRepository
    {
        public EfBillOrderRepository(DbContext context) : base(context)
        {

        }
        private ApartmentContext ApartmentContext
        {
            get { return _context as ApartmentContext; }
        }

        public async Task<List<BillOrder>> GetMonthPayment()
        {
            return await _context.Set<BillOrder>().Where(x => x.LastPaymentDate.Month == DateTime.Now.Month).ToListAsync();
        }

        public async Task<IEnumerable<BillOrder>> GetUnpaidAllApartment(Expression<Func<BillOrder, bool>> expression = null)
        {
            if (expression == null)
                return await _context.Set<BillOrder>().Include(x=>x.ApartmentInformation).ToListAsync();
            else
            {
                return await _context.Set<BillOrder>().Include(x => x.ApartmentInformation).Where(expression).ToListAsync();
            }
        }
    }
}
