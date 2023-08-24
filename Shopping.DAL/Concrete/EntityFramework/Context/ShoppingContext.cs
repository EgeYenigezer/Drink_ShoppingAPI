using Microsoft.EntityFrameworkCore;
using Shopping.DAL.Concrete.EntityFramework.Mapping;

namespace Shopping.DAL.Concrete.EntityFramework.Context
{
    public class ShoppingContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("data source=DESKTOP-SF00I43;initial catalog=DrinkShoppingDB;integrated security=True; TrustServerCertificate=true");

            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new OrderDetailMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new UserMap());


            base.OnModelCreating(modelBuilder);
        }
    }
}
