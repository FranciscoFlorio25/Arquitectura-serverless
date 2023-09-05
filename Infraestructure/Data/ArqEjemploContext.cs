using Application.Data;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class ArqEjemploContext : DbContext , IArqEjemploContext
    {
        public ArqEjemploContext(DbContextOptions options) : base(options){}

        public DbSet<Product> Products => Set<Product>();
    }
}
