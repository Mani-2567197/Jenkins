using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiIntro.Models;

namespace WebApiIntro.Data
{
    public class Emp04DbContext : DbContext
    {
        public Emp04DbContext (DbContextOptions<Emp04DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiIntro.Models.Employee> Employee { get; set; } = default!;
    }
}
