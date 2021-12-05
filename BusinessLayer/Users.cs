using BusinessLayer.Entities;
using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Users
    {
        UsersDL userDl;
        public Users()
        {
            userDl = new UsersDL();
        }
        public User LoginAccess(string userId, string password)
        {
            DataTable dt = userDl.LoginAccessDL(userId, password);
            User user = new User();
            if (dt.Rows.Count > 0)
            {
                user.UserId = dt.Rows[0].Field<string>("UserId");
                user.Password = dt.Rows[0].Field<string>("Password");
                user.UserType = dt.Rows[0].Field<int>("UserType");
                return user;
            }
            else
            {
                return null;
            }
            
        }
        public bool InsertUser(User user)
        {
            int rowsAffected = userDl.Insert(user.UserId, user.Password, user.UserType);
            return rowsAffected > 0;
        }
        public bool UpdateUser(User user)
        {
            int rowsAffected = userDl.Update(user.UserId, user.Password, user.UserType);
            return rowsAffected > 0;
        }
        public bool DeleteUser(string userId)
        {
            int rowsAffected = userDl.Delete(userId);
            return rowsAffected > 0;
        }
    }
}
