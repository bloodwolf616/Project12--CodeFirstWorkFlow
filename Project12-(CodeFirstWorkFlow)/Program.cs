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
               
              
                context.Database.Log = (message) => Debug.WriteLine(message);

                var comicBookId1 = 1;

                // var comicBookEntity1 = context.ComicBooks.Find(comicBookId1);

                var comicbookEntity = context.ComicBooks
                    .Where(c => c.Id == 1)
                    .SingleOrDefault();


                //var comicBooks = context.ComicBooks
                //    .Include(cb => cb.Series)
                //    .Include(cb => cb.Artists.Select(a => a.Artist))
                //    .Include(cb => cb.Artists.Select(a => a.Role))
                //    .ToList();
                //foreach (var comic in comicBooks)
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
