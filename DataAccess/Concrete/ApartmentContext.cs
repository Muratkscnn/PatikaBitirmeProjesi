using DataAccess.Concrete.EntityConfig;
using Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ApartmentContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public ApartmentContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ApartmentInformation> ApartmentInformations { get; set; }
        public DbSet<BillOrder> BillOrders { get; set; }
        public DbSet<Message> Messages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ApartmentInformationConfig());
            modelBuilder.ApplyConfiguration(new BillOrderConfig());
            modelBuilder.ApplyConfiguration(new AppRoleConfig());
        }
    }
}
