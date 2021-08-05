using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project12__CodeFirstWorkFlow_.Models
{
    public class Series
    {
        public Series()
        {
            comicBooks = new List<ComicBook>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //A series can have multiple comic books. this is a relational database
        public ICollection<ComicBook> comicBooks { get; set; }
        
    }
}
