using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.Entity;

namespace LibrarySolution
{

    public class Database : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Event> eventHistory { get; set; }
        public DbSet<Reader> Readers { get; set; }

    }
}
