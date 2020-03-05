using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntTest
{
    class EmpContext : DbContext
    {
        
        
            public EmpContext()
                : base("DBConnection")
            { }

            public DbSet<Employee> Employee { get; set; }
        public DbSet<Customer> Customer { get; set; }
    }
}
