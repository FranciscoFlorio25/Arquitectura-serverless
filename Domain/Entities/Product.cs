using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product
    {
        public Product(string name, string description, string category, DateTime creationDate, DateTime? modificationDate)
        {
            Name = name;
            Description = description;
            Category = category;
            CreationDate = creationDate;
            ModificationDate = modificationDate;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set;}

    }
}
