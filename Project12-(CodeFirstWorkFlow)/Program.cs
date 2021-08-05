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
          
            using(var context = new Context())
            {
                var series1 = new Series()
                {
                    Title = "The Amazing Spider-Man"
                };
                
                var series2 = new Series()
                {
                    Title = "The Invincible Iron Man"
                };
                var artist1 = new Artist()
                {
                    Name = "Stan lee"
                };
                var artist2 = new Artist()
                {
                    Name = "Jack Kirby"
                };
                var artist3 = new Artist()
                {
                    Name = "Steve Diko"
                };


                var comicBook1 = new ComicBook()
                {
                    Series = series1,
                    IssueNumber = 1,
                    PublishedOn = DateTime.Today

                };
                comicBook1.Artists.Add(artist1);
                comicBook1.Artists.Add(artist2);

                var comicBook2 = new ComicBook()
                {
                    Series = series2,
                    IssueNumber = 2,
                    PublishedOn = DateTime.Today
                };
                comicBook2.Artists.Add(artist1);
                comicBook2.Artists.Add(artist2);

                var comicBook3 = new ComicBook()
                {
                    Series = series2,
                    IssueNumber = 1,
                    PublishedOn = DateTime.Today
                };
                comicBook3.Artists.Add(artist1);
                comicBook3.Artists.Add(artist3);

                context.ComicBooks.Add(comicBook1);
                context.ComicBooks.Add(comicBook2);
                context.ComicBooks.Add(comicBook3);

                context.SaveChanges();

                var comicBooks = context.ComicBooks
                    .Include(cb => cb.Series)
                    .Include(cb => cb.Artists)
                    .ToList();
                foreach(var comic in comicBooks)
                {
                    var artistsNames = comic.Artists.Select(a => a.Name).ToList();
                    var displayArtists = string.Join(", ", artistsNames);
                    Console.WriteLine(comic.DisplayText);
                    Console.WriteLine(displayArtists);
                }

              
            }

            Console.ReadLine();
        }
    }
}
