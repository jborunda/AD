using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AD;

namespace AD.Models
{
    public class ADContext : DbContext
    {
        public ADContext (DbContextOptions<ADContext> options)
            : base(options)
        {
        }

        public DbSet<AD.Employee> Employee { get; set; }
    }
}
