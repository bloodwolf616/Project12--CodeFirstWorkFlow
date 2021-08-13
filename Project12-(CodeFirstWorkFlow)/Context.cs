using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project12__CodeFirstWorkFlow_.Models;
using Project12__CodeFirstWorkFlow_.Data;
namespace Project12__CodeFirstWorkFlow_
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }


        //dbset represents a collection of all Entities of that class type in our project. think of a list of Employee Entity classes that represent different employees. 
        // all the entities would go in the context class.
        public DbSet<ComicBook> ComicBooks { get; set; }
    }
}

//DropCreateDatabaseAlways<Context>()


