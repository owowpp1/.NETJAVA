using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using P4.Models;

namespace P4.Data
{
    public class P4Context : DbContext
    {
        public P4Context (DbContextOptions<P4Context> options)
            : base(options)
        {
        }

        public DbSet<P4.Models.waluty> waluty { get; set; }
    }
}
