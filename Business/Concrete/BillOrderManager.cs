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

        public async Task<BillOrder> GetById(int id)
        {
            return await _unitOfWork.BillOrders.Get(x => x.BillOrderId == id);
        }

        public async Task<IEnumerable<BillOrder>> GetList()
        {
            return await _unitOfWork.BillOrders.GetAll();
        }

        public async Task<IEnumerable<BillOrder>> GetUnpaidAllApartment()
        {
            return await _unitOfWork.BillOrders.GetAll(x => x.PaymentDate == null);
        }

        public async Task<IEnumerable<BillOrder>> GetUnpaidByUser(int id)
        {
            return await _unitOfWork.BillOrders.GetAll(x => x.PaymentDate == null && x.ApartmentInformationId==id);
        }

        public void Update(BillOrder t)
        {
            _unitOfWork.BillOrders.Update(t);
            _unitOfWork.SaveAsync();
        }
    }
}
