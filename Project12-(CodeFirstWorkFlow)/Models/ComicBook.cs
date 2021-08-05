using System;
using System.Collections.Generic;
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
            Artists = new List<Artist>();
        }
        public int Id { get; set; }

        public int SeriesId { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public decimal? AverageRating { get; set; }



        //A number of comic books can relate to one series class. Relational databases.
        public Series Series { get; set; }
        public ICollection<Artist> Artists { get; set; }


        public string DisplayText
        {
            get
            {
                return $"{Series?.Title} #{IssueNumber}";
            }
        }

    }
}
