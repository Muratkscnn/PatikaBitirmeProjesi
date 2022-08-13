using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Jwt
{
    public interface IJwtAuthenticationService
    {
        public string Authenticate(string userId,string role, string apartmentInfoId = "0");
    }
}
