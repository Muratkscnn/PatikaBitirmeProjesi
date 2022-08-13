using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.AuthorizationDTO
{
    public class PasswordChangeRequest
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public string RePassword { get; set; }
    }
}
