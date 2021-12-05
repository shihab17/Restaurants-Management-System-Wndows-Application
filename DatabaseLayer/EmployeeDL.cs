using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class EmployeeDL
    {
        DataAccess dataAccess = new DataAccess();
        public int InsertEmployee(string userId, string fName, string lName, string gender, string phoneNumber, string email, int salary, string timeSchedule, string hireDate, int userTpye)
        {
            string sql = string.Format("insert into tblEmployee (UserId, FirstName, LastName, Gender, PhoneNumber, Email, Salary, TimeSchedule, HireDate, UserType )" +
              "Values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", userId, fName, lName, gender, phoneNumber, email, salary, timeSchedule, hireDate, userTpye);
            int rowsAffected = dataAccess.ExecuteComand(sql);
            return rowsAffected;
        }
        public int UpdateEmployee(string userId, string fName, string lName, string gender, string phoneNumber, string email, int salary, string timeSchedule, string hireDate)
        {
            string query = "UPDATE tblEmployee SET FirstName = '" + fName + "', LastName = '" + lName + "', Gender= '" + gender + "', PhoneNumber= '" + phoneNumber + "', Email= '" + email + "', Salary = '"+ salary + "', TimeSchedule = '"+ timeSchedule + "', HireDate = '"+ hireDate +"' WHERE userId ='" + userId + "' ";
            int rowsAffected = dataAccess.ExecuteComand(query);
            return rowsAffected;
        }
        public DataTable GetAllEmplyeeByUserType(int userType)
        {
            string query = "Select * FROM tblEmployee where UserType ='" + userType + "' ";
            SqlCommand command =dataAccess.GetCommand(query);
            DataTable dt = dataAccess.Execute(command);
            return dt;
        }
        public int DeleteEmpolyee(string userId)
        {
            string query = "DELETE FROM tblEmployee WHERE userId ='" + userId + "' ";
            int rowsAffected = dataAccess.ExecuteComand(query);
            return rowsAffected;
        }
    }
}
