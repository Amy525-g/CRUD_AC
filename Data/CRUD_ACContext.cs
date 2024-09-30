using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_AC.Models;

namespace CRUD_AC.Data
{
    public class CRUD_ACContext : DbContext
    {
        public CRUD_ACContext (DbContextOptions<CRUD_ACContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_AC.Models.Producto> Producto { get; set; } = default!;
    }
}
