using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyEF
{
    class Context : DbContext
    {
        public DbSet<Person> People { get; set; }

        public Context(): base("DBConnection")
        {
            
        }
    }
}
