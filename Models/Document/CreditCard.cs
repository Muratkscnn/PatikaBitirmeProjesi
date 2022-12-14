using Models.Document.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Document
{
    public class CreditCard : DocumentBaseEntity
    {
        public string CustomerName { get; set; }
        public string CardNumber { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }
        public double Amount { get; set; }
    }
}
