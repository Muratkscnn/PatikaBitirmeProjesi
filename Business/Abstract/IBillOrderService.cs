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
        Task<IEnumerable<BillOrder>> GetpaidByUser(int id);
        Task<IEnumerable<BillOrder>> GetAllPaidBills();
        Task<IEnumerable<BillOrder>> GetPaidBill(string blockNo,int apartmentNo);
        Task<BillOrder> GetBillOrderByBlockNo(string blockNo, int apartmentNo);
        Task<double> GetTotalPayment();
        Task<double> GetTotalUnpaidBill();
        Task<List<BillOrder>> GetMonthUnPaid();
        Task<List<BillOrder>> GetMonthPaid();
    }
}
