using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AuthorizationDTO
{
    public class RegisterModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string TcNo { get; set; }
        public string PlateNo { get; set; }
        public string BlockNo { get; set; }
        public int ApartmentNo { get; set; }
    }
}
