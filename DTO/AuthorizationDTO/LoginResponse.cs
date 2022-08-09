using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AuthorizationDTO
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public int ApartmentInfoId { get; set; }
    }
}
