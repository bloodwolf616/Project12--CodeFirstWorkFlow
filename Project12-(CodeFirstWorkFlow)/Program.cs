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

                var comicbooks = context.ComicBooks
                    .Include(cb => cb.Series)
                    .Where(cb => cb.IssueNumber >= 1)
                    .ToList();

                var comicBookQuery2 = comicbooks
                    .OrderBy(c => c.Series.Title.Contains("man"))
                    .ToList();

                foreach(var comic in comicbooks)
                {
                    Console.WriteLine(comic.DisplayText);
                }

                Console.WriteLine();
                Console.WriteLine("# of comic books: {0}", comicbooks.Count);
                Console.WriteLine();


                foreach (var comic in comicBookQuery2)
                {
                    Console.WriteLine(comic.DisplayText);
                }

                Console.WriteLine();
                Console.WriteLine("# of comic books: {0}", comicBookQuery2.Count);


               
                
                
                
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
