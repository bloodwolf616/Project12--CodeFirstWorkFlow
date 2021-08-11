using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project12__CodeFirstWorkFlow_.Models;
using System.Data.Entity;
using System.Diagnostics;

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

                var role1 = new Role()
                {
                    Name = "Script"
                };

                var role2 = new Role()
                {
                    Name = "pencils"
                };


                var comicBook1 = new ComicBook()
                {
                    Series = series1,
                    IssueNumber = 1,
                    PublishedOn = DateTime.Today

                };
                comicBook1.AddArtist(artist1, role1);
                comicBook1.AddArtist(artist2, role2);

                var comicBook2 = new ComicBook()
                {
                    Series = series2,
                    IssueNumber = 2,
                    PublishedOn = DateTime.Today
                };
                comicBook2.AddArtist(artist1, role1);
                comicBook2.AddArtist(artist2, role2);

                var comicBook3 = new ComicBook()
                {
                    Series = series2,
                    IssueNumber = 1,
                    PublishedOn = DateTime.Today
                };
                comicBook3.AddArtist(artist1, role1);
                comicBook3.AddArtist(artist3, role2);

                context.ComicBooks.Add(comicBook1);
                context.ComicBooks.Add(comicBook2);
                context.ComicBooks.Add(comicBook3);

                context.SaveChanges();

                context.Database.Log = (message) => Debug.WriteLine(message);

                var comicbooks = context.ComicBooks
                    .Include(cb => cb.Series)
                    .Where(cb => cb.IssueNumber == 1)
                    .ToList();

                foreach(var comic in comicbooks)
                {
                    Console.WriteLine(comic.DisplayText);
                }

                Console.WriteLine();
                Console.WriteLine("# of comic books: {0}", comicbooks.Count);

                //var comicBooks = context.ComicBooks
                //    .Include(cb => cb.Series)
                //    .Include(cb => cb.Artists.Select(a => a.Artist))
                //    .Include(cb => cb.Artists.Select(a => a.Role))
                //    .ToList();
                //foreach(var comic in comicBooks)
                //{
                //    var artistRolesNames = comic.Artists.Select(a => $"{a.Artist.Name} - {a.Role.Name}").ToList();
                //    var displayArtistRoles = string.Join(", ", artistRolesNames);
                //    Console.WriteLine(comic.DisplayText);
                //    Console.WriteLine(displayArtistRoles);
                //}

              
            }

            Console.ReadLine();
        }
    }
}
