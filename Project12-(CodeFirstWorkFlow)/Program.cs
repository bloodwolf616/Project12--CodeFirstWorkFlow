using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project12__CodeFirstWorkFlow_.Models;
using System.Data.Entity;
namespace Project12__CodeFirstWorkFlow_
{
    class Program
    {
        static void Main(string[] args)
        {
            var series = new Series()
            {
                Title = "The Amazing Spider-Man"
            };
            using(var context = new Context())
            {
                context.ComicBooks.Add(new ComicBook()
                {
                    Series = series,
                    IssueNumber = 1,
                    PublishedOn = DateTime.Today
                });
                context.ComicBooks.Add(new ComicBook()
                {
                    Series = series,
                    IssueNumber = 2,
                    PublishedOn = DateTime.Today
                });
                context.SaveChanges();

                var comicBooks = context.ComicBooks
                    .Include(cb => cb.Series)
                    .ToList();
                foreach(var comic in comicBooks)
                {
                    Console.WriteLine(comic.DisplayText);
                }

              
            }

            Console.ReadLine();
        }
    }
}
