using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project12__CodeFirstWorkFlow_.Models
{
    //Each Entity class represents a table in the database. All the properties represent a column in the table
   public class ComicBook
    {
        public ComicBook()
        {
            Artists = new List<ComicBookArtist>();
        }
        public int Id { get; set; }

        public int SeriesId { get; set; }
        public int IssueNumber { get; set; }
       
        [StringLength(100)]
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public decimal? AverageRating { get; set; }



        //A number of comic books can relate to one series class. Relational databases.
        public Series Series { get; set; }
        public ICollection<ComicBookArtist> Artists { get; set; }


        public string DisplayText
        {
            get
            {
                return $"{Series?.Title} #{IssueNumber}";
            }
        }


        public void AddArtist(Artist artist, Role role)
        {
            Artists.Add(new ComicBookArtist() 
            {
                Artist = artist,
                Role = role
            });

        }

    }
}
