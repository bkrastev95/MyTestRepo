using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestApplication.Models
{
    public class MyContext : DbContext
    {
        public MyContext()
            : base("MyContext")
        {
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
