using Application.DTO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Products.GetProduct
{
    public record GetProductResponse(IEnumerable<ProductDto> Products);
}
