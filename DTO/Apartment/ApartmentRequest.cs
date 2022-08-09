using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Apartment
{
    public class ApartmentRequest
    {
        public string BlockNo { get; set; }
        public string ApartmentType { get; set; }
        public int Floor { get; set; }
        public int ApartmentNo { get; set; }
        public int? AppUserId { get; set; }
    }
}
