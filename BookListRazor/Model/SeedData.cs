using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BookListRazor.Data;
using System;
using System.Linq;

namespace BookListRazor.Model
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for books
                if (context.Book.Any())
                {
                    return; // Database seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "A Clash of Kings",
                        Author = "George R.R. Martin"
                    },

                    new Book
                    {
                        Title = "A Storm of Swords",
                        Author = "George R.R. Martin"
                    },

                    new Book
                    {
                        Title = "A Dance With Dragons",
                        Author = "George R.R. Martin"
                    },

                    new Book
                    {
                        Title = "The Hobbit",
                        Author = "J.R.R. Tolkein"
                    },

                    new Book
                    {
                        Title = "The Shining",
                        Author = "Stephen King"
                    },

                    new Book
                    {
                        Title = "Harry Potter and the Philosopher's Stone",
                        Author = "J.K. Rowling"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}