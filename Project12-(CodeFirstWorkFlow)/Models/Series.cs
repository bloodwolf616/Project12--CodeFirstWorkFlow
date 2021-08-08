using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project12__CodeFirstWorkFlow_.Models
{
    public class Series
    {
        public Series()
        {
            ComicBooks = new List<ComicBook>();
        }
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Title { get; set; }
        public string Description { get; set; }
        //A series can have multiple comic books. this is a relational database
        public ICollection<ComicBook> ComicBooks { get; set; }
        
    }
}
