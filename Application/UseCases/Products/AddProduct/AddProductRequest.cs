﻿using Application.DTO;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Products.AddProduct
{
    public record AddProductRequest(
        string Name,
        string Description,
        string Category,
        DateTime CreationDate,
        DateTime? ModificationDate
        ) : IRequest<Result<AddProductResponse>>;
}
