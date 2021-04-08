using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    //Context :Db tabloları ile proje classlarını bağlar.
    public class RentCarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentCar;Trusted_Connection=true");
        }
        public DbSet<Car> tblCars { get; set; }
        public DbSet<Brand> tblBrands { get; set; }
        public DbSet<Color> tblColors { get; set; }
        public DbSet<Customer> tblCustomers { get; set; }
        public DbSet<Rental> tblRentals { get; set; }
        public DbSet<CarImage> tblCarImage { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> tblUsers { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasDefaultSchema("admin") şema veriliyor
        //    modelBuilder.Entity<Car>().Property(x => x.Id).HasColumnName("test"); Column name farklıysa bu şekilde birbirine bağlayabiliyoruz.
        //    //ismi farklı olan propertiesi sql tablosuna bağlamak modelBuilder.Entity<Cars>().ToTable("Cars")
        //}
    }
}
