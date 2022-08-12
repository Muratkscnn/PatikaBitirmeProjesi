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
    public class ApartmentInformationManager : IApartmentInformationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ApartmentInformationManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task Add(ApartmentInformation t)
        {
            await _unitOfWork.ApartmentInformations.Create(t);
            await _unitOfWork.SaveAsync();
        }

        public void Delete(ApartmentInformation t)
        {
             _unitOfWork.ApartmentInformations.Delete(t);
             _unitOfWork.SaveAsync();
        }

        public async Task<ApartmentInformation> GetById(int id)
        {
            return await _unitOfWork.ApartmentInformations.Get(x=>x.ApartmentInformationId==id);
        }

        public async Task<IEnumerable<ApartmentInformation>> GetList()
        {
            return await _unitOfWork.ApartmentInformations.GetAll();
        }

        public async Task<ApartmentInformation> GetApartmentIdByUserId(int userId)
        {
            return await _unitOfWork.ApartmentInformations.Get(x => x.AppUserId == userId);
        }

        public void Update(ApartmentInformation t)
        {
             _unitOfWork.ApartmentInformations.Update(t);
             _unitOfWork.SaveAsync();
        }

        public async Task<ApartmentInformation> GetApartmentByBlockAndApartmentNo(string blockNo, int apartmentNo)
        {
            return await _unitOfWork.ApartmentInformations.Get(x => x.BlockNo == blockNo && x.ApartmentNo == apartmentNo);
        }
    }
}
