﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.BillOrder
{
    public class BillOrderAddAllApartmentRequest
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string LastPaymentDate { get; set; }
    }
}
