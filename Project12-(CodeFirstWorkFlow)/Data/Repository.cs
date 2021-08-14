using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project12__CodeFirstWorkFlow_;
using Project12__CodeFirstWorkFlow_.Models;
namespace Project12__CodeFirstWorkFlow_.Data
{
    public static class Repository
    {
        /// <summary>
        /// Private method that returns a database context.
        /// </summary>
        /// <returns>An instance of the Context class.</returns>
        static Context GetContext()
        {
            var context = new Context();
            context.Database.Log = (message) => Console.WriteLine(message);
            return context;
        }

        /// <summary>
        /// Returns a count of the comic books.
        /// </summary>
        /// <returns>An integer count of the comic books.</returns>
        public static int GetComicBookCount()
        {
            int one = 5;
            return one;
            using (Context context = GetContext())
            {
                
            }
        }

        /// <summary>
        /// Returns a list of comic books ordered by the series title 
        /// and issue number.
        /// </summary>
        /// <returns>An IList collection of ComicBook entity instances.</returns>
        public static IList<ComicBook> GetComicBooks()
        {
            return null;
            using (Context context = GetContext())
            {
                
            }
        }

        /// <summary>
        /// Returns a single comic book.
        /// </summary>
        /// <param name="comicBookId">The comic book ID to retrieve.</param>
        /// <returns>A fully populated ComicBook entity instance.</returns>
        public static ComicBook GetComicBook(int comicBookId)
        {
            return null;
            using (Context context = GetContext())
            {
              
            }
        }

        /// <summary>
        /// Returns a list of series ordered by title.
        /// </summary>
        /// <returns>An IList collection of Series entity instances.</returns>
        public static IList<Series> GetSeries()
        {
            return null;
            using (Context context = GetContext())
            {
              
            }
        }

        /// <summary>
        /// Returns a single series.
        /// </summary>
        /// <param name="seriesId">The series ID to retrieve.</param>
        /// <returns>A Series entity instance.</returns>
        public static Series GetSeries(int seriesId)
        {
            return null;
            using (Context context = GetContext())
            {
             
            }
        }

        /// <summary>
        /// Returns a list of artists ordered by name.
        /// </summary>
        /// <returns>An IList collection of Artist entity instances.</returns>
        public static IList<Artist> GetArtists()
        {
            return null;
            using (Context context = GetContext())
            {
             
            }
        }

        /// <summary>
        /// Returns a list of roles ordered by name.
        /// </summary>
        /// <returns>An IList collection of Role entity instances.</returns>
        public static IList<Role> GetRoles()
        {
            return null;
            using (Context context = GetContext())
            {
              
            }
        }

        /// <summary>
        /// Adds a comic book.
        /// </summary>
        /// <param name="comicBook">The ComicBook entity instance to add.</param>
        public static void AddComicBook(ComicBook comicBook)
        {
            using (Context context = GetContext())
            {
                var newSeries = new Series()
                {
                    Id = 1,
                    Title = "bone"
                };

              
                //adding duplicate relational Entities that im going to test to get rid of 
           
                comicBook.Series = newSeries;

                context.ComicBooks.Add(comicBook);

                //removes unwanted duplicate series Entities
                if(comicBook.Series != null || comicBook.Series.Id > 0)
                {
                    context.Entry(comicBook.Series).State = EntityState.Unchanged;
                }


            
            

                var seriesIsUnchanged = context.Entry(comicBook.Series);
               
                

                context.SaveChanges();



            }
        }

        /// <summary>
        /// Updates a comic book.
        /// </summary>
        /// <param name="comicBook">The ComicBook entity instance to update.</param>
        public static void UpdateComicBook(ComicBook comicBook)
        {
            using (Context context = GetContext())
            {
                ComicBook comicBookToUpdate = context.ComicBooks.Find(comicBook.Id);

                context.Entry(comicBookToUpdate).CurrentValues.SetValues(comicBook);
              


                context.SaveChanges();
              

            }
        }

        /// <summary>
        /// Deletes a comic book.
        /// </summary>
        /// <param name="comicBookId">The comic book ID to delete.</param>
        public static void DeleteComicBook(int comicBookId)
        {
          
        }
    }
}
