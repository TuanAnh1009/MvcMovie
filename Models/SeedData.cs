using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
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
                        Rating = "R",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "HAHAAHA",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
            
            using (var context1 = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context1.Person.Any())
                {
                    return;   // DB has been seeded
                }

                context1.Person.AddRange(
                    new Person
                    {
                        PersonName = "Nguyễn Tuấn Anh"
                    },

                    new Person
                    {
                        PersonName = "Vũ Thị Loan"
                    },

                    new Person
                    {
                        PersonName = "Nguyễn Tuấn Anh"
                    },
                    new Person
                    {
                        PersonName = "Vũ Thị Loan"
                    },

                    new Person
                    {
                        PersonName = "Nguyễn Tuấn Anh"
                    }
                );
                context1.SaveChanges();
            }
             using (var context1 = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context1.Employee.Any())
                {
                    return;   // DB has been seeded
                }

                context1.Employee.AddRange(
                    new Employee
                    {
                        EmployeeName = "Nguyễn Tuấn Anh",
                        PhoneNumber = 111111111

                    },

                    new Employee
                    {
                        EmployeeName = "Vũ Thị Loan",
                        PhoneNumber = 111111111
                    },

                    new Employee
                    {
                        EmployeeName = "Nguyễn Tuấn Anh",
                        PhoneNumber = 111111111
                    },
                    new Employee
                    {
                        EmployeeName = "Vũ Thị Loan",
                        PhoneNumber = 111111111
                    },

                    new Employee
                    {
                        EmployeeName = "Nguyễn Tuấn Anh",
                        PhoneNumber = 111111111
                    }
                );
                context1.SaveChanges();
            }
        }
    }
}