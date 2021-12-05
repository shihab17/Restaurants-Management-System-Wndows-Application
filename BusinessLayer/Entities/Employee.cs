using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entities
{
    public class Employee
    {
        public string UserId { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
        public string TimeSchedule { get; set; }
        public string HireDate { get; set; } 
        public int UserType { get; set; }
        
    }
}
