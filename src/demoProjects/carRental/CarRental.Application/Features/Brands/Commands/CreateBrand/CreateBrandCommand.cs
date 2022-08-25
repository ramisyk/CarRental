using System;
using CarRental.Application.Features.Brands.Dtos;
using MediatR;

namespace CarRental.Application.Features.Brands.Commands.CreateBrand
{
	public class CreateBrandCommand : IRequest<CreatedBrandDto>
	{
		
	}
}

