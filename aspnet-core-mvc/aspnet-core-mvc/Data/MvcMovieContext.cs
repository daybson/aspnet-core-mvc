using aspnet_core_mvc.Models;

using Microsoft.EntityFrameworkCore;

using Npgsql.EntityFrameworkCore.PostgreSQL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_mvc.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext()
        {

        }

        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=moviesDatabase;Username=postgres;Password=123456;");
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
