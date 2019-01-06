using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.Entity;

namespace LibraryProject.Data
{

    public class Database : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Reader> Readers { get; set; }

    }
}
