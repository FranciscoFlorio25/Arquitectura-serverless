using Application.Data;
using Application.DTO;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Products.AddProduct
{

    public class AddProductHandler : IRequestHandler<AddProductRequest, Result<AddProductResponse>>
    {
        private readonly IArqEjemploContext _context;

        public AddProductHandler(IArqEjemploContext context)
        {
            _context = context;
        }
        public async Task<Result<AddProductResponse>> Handle(AddProductRequest request, CancellationToken cancellationToken)
        {
           Product product = new(request.Name,request.Description,request.Category, DateTime.Now, null);
            try
            {
                await _context.Products.AddAsync(product, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);

                return new AddProductResponse(
                    product.Name,
                    product.Description,
                    product.Category,
                    product.CreationDate,
                    product.ModificationDate);
            }
            catch (Exception ex)
            {
                return "Ocurrio un error al crear el producto" + " " + ex.Message;
            }

        }
    }
}
