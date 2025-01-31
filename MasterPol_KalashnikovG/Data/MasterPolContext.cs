using MasterPol_KalashnikovG.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPol_Danilenko.Data
{
    public class MasterPolContext: DbContext
    {
        public DbSet<Partner> Partners { get; set; }
        public DbSet<PartnerType> PartnerTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<SellHistory> SellHistories { get; set; }
        public DbSet<SellPoint> SellPoints { get; set; }
        public DbSet<Users> Users { get; set; }

        public MasterPolContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("путь до сервера");
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {

        }
    }
}
