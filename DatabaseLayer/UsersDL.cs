using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class UsersDL
    {
        DataAccess dataAccess;
        public UsersDL()
        {
            dataAccess = new DataAccess();
        }
       
        public DataTable LoginAccessDL(string userId, string password)
        {
            string sql = "select * " +
               " from [dbo].[tblUsers] where UserId='" + userId
               + "' and Password='" + password + "'";
            SqlCommand command = dataAccess.GetCommand(sql);

            DataTable dt = dataAccess.Execute(command);
            return dt;
        }
        public int Insert(string userId, string password, int userType)
        {
            string sql = string.Format("insert into tblUsers(UserId,Password,UserType)" +
               "Values('{0}', '{1}', '{2}')", userId, password, userType);
            int rowsAffected = dataAccess.ExecuteComand(sql);
            return rowsAffected;
        }
        public int Update(string userId, string password, int userType)
        {
            string query = "UPDATE tblUsers SET  Password= '" + password + "', UserType= '" + userType + "' WHERE userId ='" + userId + "' ";
            int rowsAffected = dataAccess.ExecuteComand(query);
            return rowsAffected;
        }
        public int Delete(string userId)
        {
            string query = "DELETE FROM tblUsers  WHERE userId ='" + userId + "' ";
            int rowsAffected = dataAccess.ExecuteComand(query);
            return rowsAffected;
        }

    }
}
