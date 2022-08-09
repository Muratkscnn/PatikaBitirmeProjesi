using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class BillOrder
    {
        public int BillOrderId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime LastPaymentDate { get; set; }
        public int ApartmentInformationId { get; set; }
        public ApartmentInformation ApartmentInformation { get; set; }
        public DateTime? PaymentDate { get; set; }
    }
}
