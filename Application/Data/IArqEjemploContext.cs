using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Data
{
    public interface IArqEjemploContext
    {
        DbSet<Room> Rooms { get; }
        DbSet<RoomType> RoomsType { get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
