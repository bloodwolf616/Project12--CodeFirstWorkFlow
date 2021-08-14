using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project12__CodeFirstWorkFlow_.Models;
using System.Data.Entity;
using Project12__CodeFirstWorkFlow_.Data;
using System.Diagnostics;

namespace Project12__CodeFirstWorkFlow_
{
    class Program
    {
        static void Main(string[] args)
        {


            var seriesSpiderMan = new Series()
            {
                Title = "The Amazing Spider-Man",
                Description = "The Amazing Spider-Man (abbreviated as ASM) is an American comic book series published by Marvel Comics, featuring the adventures of the fictional superhero Spider-Man. Being the mainstream continuity of the franchise, it began publication in 1963 as a monthly periodical and was published continuously, with a brief interruption in 1995, until its relaunch with a new numbering order in 1999. In 2003 the series reverted to the numbering order of the first volume. The title has occasionally been published biweekly, and was published three times a month from 2008 to 2010. A film named after the comic was released July 3, 2012."
            };
          

            var artistStanLee = new Artist()
            {
                Name = "Stan Lee"
            };
            var artistSteveDitko = new Artist()
            {
                Name = "Steve Ditko"
            };
          

            var roleScript = new Role()
            {
                Name = "Script"
            };
            var rolePencils = new Role()
            {
                Name = "Pencils"
            };

            var comicBook10 = new ComicBook()
            {
                Series = seriesSpiderMan,
                IssueNumber = 1,
                Description = "As Peter Parker and Aunt May struggle to pay the bills after Uncle Bens death, Spider-Man must try to save a doomed John Jameson from his out of control spacecraft. / Spideys still trying to make ends meet so he decides to try and join the Fantastic Four. When that becomes public knowledge the Chameleon decides to frame Spider-Man and steals missile defense plans disguised as Spidey.",
                PublishedOn = new DateTime(1963, 3, 1),
                AverageRating = 7.1m
            };
            comicBook10.AddArtist(artistStanLee, roleScript);
            comicBook10.AddArtist(artistSteveDitko, rolePencils);
            Repository.AddComicBook(comicBook10);


            //using (var context = new Context())
            //{


            //    context.Database.Log = (message) => Debug.WriteLine(message);




            //    var comicBooks = context.ComicBooks
            //        .Include(cb => cb.Series)
            //        .Include(cb => cb.Artists.Select(a => a.Artist))
            //        .Include(cb => cb.Artists.Select(a => a.Role))
            //        .ToList();
            //    foreach (var comic in comicBooks)
            //    {
            //        var artistRolesNames = comic.Artists.Select(a => $"{a.Artist.Name} - {a.Role.Name}").ToList();
            //        var displayArtistRoles = string.Join(", ", artistRolesNames);
            //        Console.WriteLine(comic.DisplayText);
            //        Console.WriteLine(displayArtistRoles);
            //    }


            //}

            Console.ReadLine();
        }
    }
}
