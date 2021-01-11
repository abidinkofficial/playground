using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesApplication.Models;

namespace RazorPagesApplication.Data
{
    public class RazorPagesApplicationContext : DbContext
    {
        public RazorPagesApplicationContext (DbContextOptions<RazorPagesApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesApplication.Models.Entry> Entry { get; set; }
    }
}
