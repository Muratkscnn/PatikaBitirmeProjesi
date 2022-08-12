using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApartmentInformationService : IGenericService<ApartmentInformation>
    {
        Task<ApartmentInformation> GetApartmentIdByUserId(int userId);
        Task<ApartmentInformation> GetApartmentByBlockAndApartmentNo(string blockNo, int apartmentNo);
    }
}
