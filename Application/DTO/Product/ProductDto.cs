using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Product
{
    public record ProductDto (
        Guid Id,
        string Name,
        string Description,
        string Category,
        DateTime CreationDate,
        DateTime? ModificationDate);
}
