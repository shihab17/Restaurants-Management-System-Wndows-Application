using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entities
{
    public class User
    {
        public enum UserTypeEnum
        {
            Admin,
            Manager,
            Chef,
            Waiter
        };
        public string UserId { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }

    }
}
