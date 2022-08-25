using System;
using CarRental.Application.Services.Repositories;
using CarRental.Domain.Entities;
using Core.Persistence.Paging;
using Core.CrossCuttingConcerns.Exceptions;

namespace CarRental.Application.Features.Brands.Rules
{
	public class BrandBusinessRules
	{
        private readonly IBrandRepository _brandRepository;

        public BrandBusinessRules(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task BrandNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<Brand> result = await _brandRepository.GetListAsync(b => b.Name == name);
            if (result.Items.Any()) throw new BusinessException("Brand name exists.");
        }

    }
}

