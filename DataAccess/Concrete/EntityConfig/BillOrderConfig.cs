using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityConfig
{
    public class BillOrderConfig : IEntityTypeConfiguration<BillOrder>
    {
        public void Configure(EntityTypeBuilder<BillOrder> builder)
        {
            builder.HasData(
                new BillOrder() { BillOrderId = 1, Name = "Aidat", Price = 100, LastPaymentDate = DateTime.Parse("31.08.2022"), ApartmentInformationId = 1, PaymentDate = null },
                new BillOrder() { BillOrderId = 2, Name = "Aidat", Price = 100, LastPaymentDate = DateTime.Parse("31.08.2022"), ApartmentInformationId = 2, PaymentDate = null },
                new BillOrder() { BillOrderId = 3, Name = "Aidat", Price = 100, LastPaymentDate = DateTime.Parse("31.08.2022"), ApartmentInformationId = 3, PaymentDate = null },
                new BillOrder() { BillOrderId = 4, Name = "Aidat", Price = 100, LastPaymentDate = DateTime.Parse("31.08.2022"), ApartmentInformationId = 4, PaymentDate = null },
                new BillOrder() { BillOrderId = 5, Name = "Aidat", Price = 100, LastPaymentDate = DateTime.Parse("31.08.2022"), ApartmentInformationId = 5, PaymentDate = null },
                new BillOrder() { BillOrderId = 6, Name = "Aidat", Price = 100, LastPaymentDate = DateTime.Parse("31.08.2022"), ApartmentInformationId = 6, PaymentDate = null },
                new BillOrder() { BillOrderId = 7, Name = "Aidat", Price = 100, LastPaymentDate = DateTime.Parse("31.08.2022"), ApartmentInformationId = 7, PaymentDate = null },
                new BillOrder() { BillOrderId = 8, Name = "Aidat", Price = 100, LastPaymentDate = DateTime.Parse("31.08.2022"), ApartmentInformationId = 8, PaymentDate = null },
                new BillOrder() { BillOrderId = 9, Name = "Aidat", Price = 100, LastPaymentDate = DateTime.Parse("31.08.2022"), ApartmentInformationId = 9, PaymentDate = null },
                new BillOrder() { BillOrderId = 10, Name= "Aidat", Price = 100,LastPaymentDate = DateTime.Parse ("31.08.2022"),ApartmentInformationId = 10, PaymentDate = null },
                new BillOrder() { BillOrderId = 11, Name= "Aidat", Price = 100,LastPaymentDate = DateTime.Parse ("31.08.2022"),ApartmentInformationId = 11, PaymentDate = null },
                new BillOrder() { BillOrderId = 12, Name= "Aidat", Price = 100,LastPaymentDate = DateTime.Parse ("31.08.2022"),ApartmentInformationId = 12, PaymentDate = null },
                new BillOrder() { BillOrderId = 13, Name= "Aidat", Price = 100,LastPaymentDate = DateTime.Parse ("31.08.2022"),ApartmentInformationId = 13, PaymentDate = null },
                new BillOrder() { BillOrderId = 14, Name= "Aidat", Price = 100,LastPaymentDate = DateTime.Parse ("31.08.2022"),ApartmentInformationId = 14, PaymentDate = null },
                new BillOrder() { BillOrderId = 15, Name= "Aidat", Price = 100,LastPaymentDate = DateTime.Parse ("31.08.2022"),ApartmentInformationId = 15, PaymentDate = null },
                new BillOrder() { BillOrderId = 16, Name= "Aidat", Price = 100,LastPaymentDate = DateTime.Parse ("31.08.2022"),ApartmentInformationId = 16, PaymentDate = null },
                new BillOrder() { BillOrderId = 17, Name= "Aidat", Price = 100,LastPaymentDate = DateTime.Parse ("31.08.2022"),ApartmentInformationId = 17, PaymentDate = null },
                new BillOrder() { BillOrderId = 18, Name= "Aidat", Price = 100,LastPaymentDate = DateTime.Parse ("31.08.2022"),ApartmentInformationId = 18, PaymentDate = null },
                new BillOrder() { BillOrderId = 19, Name= "Aidat", Price = 100,LastPaymentDate = DateTime.Parse ("31.08.2022"),ApartmentInformationId = 19, PaymentDate = null },
                new BillOrder() { BillOrderId = 20, Name= "Aidat", Price = 100,LastPaymentDate = DateTime.Parse ("31.08.2022"),ApartmentInformationId = 20, PaymentDate = null },
                new BillOrder() { BillOrderId = 21, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId =  1, PaymentDate = null },
                new BillOrder() { BillOrderId = 22, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId =  2, PaymentDate = null },
                new BillOrder() { BillOrderId = 23, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId =  3, PaymentDate = null },
                new BillOrder() { BillOrderId = 24, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId =  4, PaymentDate = null },
                new BillOrder() { BillOrderId = 25, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId =  5, PaymentDate = null },
                new BillOrder() { BillOrderId = 26, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId =  6, PaymentDate = null },
                new BillOrder() { BillOrderId = 27, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId =  7, PaymentDate = null },
                new BillOrder() { BillOrderId = 28, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId =  8, PaymentDate = null },
                new BillOrder() { BillOrderId = 29, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId =  9, PaymentDate = null },
                new BillOrder() { BillOrderId = 30, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId = 10, PaymentDate = null },
                new BillOrder() { BillOrderId = 31, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId = 11, PaymentDate = null },
                new BillOrder() { BillOrderId = 32, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId = 12, PaymentDate = null },
                new BillOrder() { BillOrderId = 33, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId = 13, PaymentDate = null },
                new BillOrder() { BillOrderId = 34, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId = 14, PaymentDate = null },
                new BillOrder() { BillOrderId = 35, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId = 15, PaymentDate = null },
                new BillOrder() { BillOrderId = 36, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId = 16, PaymentDate = null },
                new BillOrder() { BillOrderId = 37, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId = 17, PaymentDate = null },
                new BillOrder() { BillOrderId = 38, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId = 18, PaymentDate = null },
                new BillOrder() { BillOrderId = 39, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId = 19, PaymentDate = null },
                new BillOrder() { BillOrderId = 40, Name = "Su", Price = 25, LastPaymentDate = DateTime.Parse("30.09.2022"), ApartmentInformationId = 20, PaymentDate = null }
                );
        }
    }
}
