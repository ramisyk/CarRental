using System;
using AutoMapper;
using CarRental.Application.Features.Brands.Dtos;
using CarRental.Application.Features.Brands.Rules;
using CarRental.Application.Services.Repositories;
using CarRental.Domain.Entities;
using MediatR;

namespace CarRental.Application.Features.Brands.Commands.CreateBrand
{
	public partial class CreatedBrandCommand : IRequest<CreatedBrandDto>
	{

        public string Name { get; set; }

        public class CreateBrandCommandHandler : IRequestHandler<CreatedBrandCommand, CreatedBrandDto>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;
            private readonly BrandBusinessRules _brandBusinessRules;

            public CreateBrandCommandHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
                _brandBusinessRules = brandBusinessRules;
            }

            public async Task<CreatedBrandDto> Handle(CreatedBrandCommand request, CancellationToken cancellationToken)
            {
                await _brandBusinessRules.BrandNameCanNotBeDuplicatedWhenInserted(request.Name);

                Brand mappedBrand = _mapper.Map<Brand>(request);
                Brand createdBrand = await _brandRepository.AddAsync(mappedBrand);
                CreatedBrandDto createdBrandDto = _mapper.Map<CreatedBrandDto>(createdBrand);

                return createdBrandDto;

            }
        }
    }
}

