using EntTest.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<EmpContext, Configuration>());
            using (EmpContext db = new EmpContext())
            {
                //Employee emp1 = new Employee { LastName = "Ivanov", Department ="HR", Id= 1 };
                //Employee emp2 = new Employee { LastName = "Petrov", Department = "Finance", Id = 2 };
                //Customer cust1 = new Customer { Name = "Zaicev", Email = "zaicev@gamil.com", Id = 1 };
                //Customer cust2 = new Customer { Name = "Volkov", Email = "volkov@gamil.com", Id = 2};

                //db.Employee.Add(emp1);
                //db.Employee.Add(emp2);
                //db.Customer.Add(cust1);
                //db.Customer.Add(cust2);
                //db.SaveChanges();
                db.Database.Initialize(false);

                
            }
            Console.Read();
        }
    }
    
}
