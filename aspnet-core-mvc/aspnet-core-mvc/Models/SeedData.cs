using aspnet_core_mvc.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnet_core_mvc.Models
{
    public static class SeedData
    {
        public static void Initalize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange
                (
                    new Movie
                    {
                        Title = "Terminator 2",
                        ReleaseDate = DateTime.Parse("1990-1-12"),
                        Genre = "Fiction/Action",
                        Price = 7.9M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Matrix",
                        ReleaseDate = DateTime.Parse("2002-06-05"),
                        Genre = "Fiction/Action",
                        Price = 8.9M,
                        Rating = "S"
                    },

                    new Movie
                    {
                        Title = "Rocky",
                        ReleaseDate = DateTime.Parse("1984-11-12"),
                        Genre = "Drama",
                        Price = 4.5M,
                        Rating = "L"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
