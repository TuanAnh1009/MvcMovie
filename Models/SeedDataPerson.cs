using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedDataPerson
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
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
        }
    }
}