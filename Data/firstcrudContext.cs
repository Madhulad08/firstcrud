using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using firstcrud.model;

namespace firstcrud.Data
{
    public class firstcrudContext : DbContext
    {
        public firstcrudContext (DbContextOptions<firstcrudContext> options)
            : base(options)
        {
        }

        public DbSet<firstcrud.model.student> student { get; set; } = default!;
    }
}
