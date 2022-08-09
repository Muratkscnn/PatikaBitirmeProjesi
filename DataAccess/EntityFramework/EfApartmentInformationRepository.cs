using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfApartmentInformationRepository : GenericRepository<ApartmentInformation>, IApartmentInformationRepository
    {
        public EfApartmentInformationRepository(DbContext context) : base(context)
        {

        }
        private ApartmentContext ApartmentContext
        {
            get { return _context as ApartmentContext; }
        }


    }
}
