using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GettingStartedWebApp.Models;

namespace GettingStartedWebApp.Data
{
    public class GettingStartedWebAppContext : DbContext
    {
        public GettingStartedWebAppContext (DbContextOptions<GettingStartedWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<GettingStartedWebApp.Models.Movie> Movie { get; set; } = default!;
    }
}