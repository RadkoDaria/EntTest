using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntTest
{
   public class Employee
    {
        [Required]
        public string LastName { get; set; }
        public string Department { get; set; }
        [MaxLength (10)]
        public string PhoneNumber { get; set; }
        public int Id { get; set; }
    }
}
