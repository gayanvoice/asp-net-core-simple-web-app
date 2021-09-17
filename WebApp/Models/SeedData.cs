using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApp.Data;
using System;
using System.Linq;

namespace WebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "E"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "E"
                    }
                );
                context.SaveChanges();
            }

            using (var context = new MovieContext(
               serviceProvider.GetRequiredService<
                   DbContextOptions<MovieContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }

                context.User.AddRange(
                    new User
                    {
                        Name = "Elizabeth",
                        IsComplete = true
                    },

                  new User
                  {
                      Name = "Elsa",
                      IsComplete = false
                  },

                    new User
                    {
                        Name = "Albert",
                        IsComplete = true
                    },

                   new User
                   {
                       Name = "Joe",
                       IsComplete = false
                   }
                );
                context.SaveChanges();
            }

            using (var context = new MovieContext(
              serviceProvider.GetRequiredService<
                  DbContextOptions<MovieContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                    new Product
                    {
                        Name = "Apple"
                    },

                  new Product
                  {
                      Name = "Banana"                 
                  }                
                );
                context.SaveChanges();
            }
        }
    }
}