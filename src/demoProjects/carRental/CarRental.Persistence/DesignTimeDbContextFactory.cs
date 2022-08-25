using System;
using CarRental.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace CarRental.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<CarRentalDbContext>
    {
        public CarRentalDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<CarRentalDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer("Server=127.0.0.1;Database=CarRental;User Id=sa;Password=MyPass@word;");
            return new (dbContextOptionsBuilder.Options);


        }
    }
}

