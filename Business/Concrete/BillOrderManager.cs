using Business.Abstract;
using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BillOrderManager : IBillOrderService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BillOrderManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Add(BillOrder t)
        {
            await _unitOfWork.BillOrders.Create(t);
            await _unitOfWork.SaveAsync();
        }

        public void Delete(BillOrder t)
        {
             _unitOfWork.BillOrders.Delete(t);
             _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<BillOrder>> GetAllPaidBills()
        {
            return await _unitOfWork.BillOrders.GetAllWithApartmentInfo(x=>x.PaymentDate!=null);
        }

        public async Task<BillOrder> GetBillOrderByBlockNo(string blockNo, int apartmentNo)
        {
            return await _unitOfWork.BillOrders.Get(x => x.ApartmentInformation.BlockNo == blockNo && x.ApartmentInformation.ApartmentNo == apartmentNo);
        }

        public async Task<BillOrder> GetById(int id)
        {
            return await _unitOfWork.BillOrders.Get(x => x.BillOrderId == id);
        }

        public async Task<IEnumerable<BillOrder>> GetList()
        {
            return await _unitOfWork.BillOrders.GetAll();
        }

        public async Task<List<BillOrder>> GetMonthPaid()
        {
            return (List<BillOrder>)await _unitOfWork.BillOrders.GetAllWithApartmentInfo(x=>x.PaymentDate.Value.Month == DateTime.Now.Month);
        }
        public async Task<List<BillOrder>> GetMonthUnPaid()
        {
            return (List<BillOrder>)await _unitOfWork.BillOrders.GetAllWithApartmentInfo(x => x.LastPaymentDate.Month == DateTime.Now.Month && x.PaymentDate == null);
        }

        public async Task<IEnumerable<BillOrder>> GetPaidBill(string blockNo, int apartmentNo)
        {
            return await _unitOfWork.BillOrders.GetAllWithApartmentInfo(x => x.PaymentDate != null && x.ApartmentInformation.BlockNo==blockNo && x.ApartmentInformation.ApartmentNo==apartmentNo);
        }

        public async Task<IEnumerable<BillOrder>> GetpaidByUser(int id)
        {
            return await _unitOfWork.BillOrders.GetAllWithApartmentInfo(x => x.PaymentDate != null);
        }

        public async Task<double> GetTotalPayment()
        {
            var value = await _unitOfWork.BillOrders.GetAll(x => x.PaymentDate != null);
            if (value==null)
            {
                return 0;
            }
            return value.ToList().Sum(x => x.Price);
        }

        public async Task<double> GetTotalUnpaidBill()
        {
            var value = await _unitOfWork.BillOrders.GetAll(x => x.PaymentDate == null);
            if (value == null)
            {
                return 0;
            }
            return value.ToList().Sum(x => x.Price);
        }

        public async Task<IEnumerable<BillOrder>> GetUnpaidAllApartment()
        {
            return await _unitOfWork.BillOrders.GetAllWithApartmentInfo(x => x.PaymentDate == null);
        }

        public async Task<IEnumerable<BillOrder>> GetUnpaidByUser(int id)
        {
            return await _unitOfWork.BillOrders.GetAllWithApartmentInfo(x => x.PaymentDate == null && x.ApartmentInformationId==id);
        }

        public void Update(BillOrder t)
        {
            _unitOfWork.BillOrders.Update(t);
            _unitOfWork.SaveAsync();
        }
    }
}
