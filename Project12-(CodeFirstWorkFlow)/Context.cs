using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project12__CodeFirstWorkFlow_.Models;

namespace Project12__CodeFirstWorkFlow_
{
    public class Context : DbContext
    {
        //this represents one entity in our project.
        // all the entities would go in here.
        public DbSet<ComicBook> ComicBooks { get; set; }
    }
}
