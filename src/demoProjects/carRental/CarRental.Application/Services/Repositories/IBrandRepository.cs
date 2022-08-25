using System;
using CarRental.Domain.Entities;
using Core.Persistence.Repositories;

namespace CarRental.Application.Services.Repositories
{
	public interface IBrandRepository : IAsyncRepository<Brand>, IRepository<Brand>
	{

	}
}

