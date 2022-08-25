using System;
using CarRental.Application.Services.Repositories;
using CarRental.Domain.Entities;
using CarRental.Persistence.Contexts;
using Core.Persistence.Repositories;

namespace CarRental.Persistence.Repositories
{
    public class BrandRepository : EfRepositoryBase<Brand, CarRentalDbContext>, IBrandRepository
    {
        public BrandRepository(CarRentalDbContext context) : base(context)
        {
        }
    }
}

