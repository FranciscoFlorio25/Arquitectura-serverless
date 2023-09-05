using Application.Data;
using Application.DTO;
using Application.DTO.Product;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Products.GetProduct
{
    public class GetProductHandler : IRequestHandler<GetProductRequest, Result<GetProductResponse>>
    {
        private readonly IArqEjemploContext _context;

        public GetProductHandler (IArqEjemploContext context)
        {
            _context = context;
        }

        public async Task<Result<GetProductResponse>> Handle(GetProductRequest request, CancellationToken cancellationToken)
        {
            var products = await _context.Products.AsNoTracking().ToListAsync(cancellationToken);

            if(products == null || !products.Any())
            {
                return "No hay productos";
            }

            var response = products.Select(x => new ProductDto(
                x.Id,
                x.Name,
                x.Description,
                x.Category,
                x.CreationDate,
                x.ModificationDate
                ));

            return new GetProductResponse(response); 
        }
    }
}
