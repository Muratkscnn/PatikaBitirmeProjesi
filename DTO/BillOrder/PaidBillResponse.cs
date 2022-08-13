using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.BillOrder
{
    public class PaidBillResponse
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string PaymentDate { get; set; }
        public string BlockNo { get; set; }
        public int ApartmentNo { get; set; }
    }
}
