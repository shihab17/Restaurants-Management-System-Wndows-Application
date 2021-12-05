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
    public class Employees
    {
        EmployeeDL employeeDL = new EmployeeDL();
        public bool IsInsert(Employee employee)
        {
            int rowsAffected = employeeDL.InsertEmployee(employee.UserId, employee.FisrtName, employee.LastName, employee.Gender, employee.PhoneNumber, employee.Email, employee.Salary, employee.TimeSchedule, employee.HireDate, employee.UserType);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsUpdate(Employee employee)
        {
            int rowsAffected = employeeDL.UpdateEmployee(employee.UserId, employee.FisrtName, employee.LastName, employee.Gender, employee.PhoneNumber, employee.Email, employee.Salary, employee.TimeSchedule, employee.HireDate);
            return rowsAffected > 0;
        }
        public List<Employee> GetEmployeesByUserType(int userType)
        {
            DataTable dt = employeeDL.GetAllEmplyeeByUserType(userType);
            List<Employee> list = new List<Employee>();
            for (int i = 0; i< dt.Rows.Count; i++)
            {
                Employee employee = new Employee();
                employee.UserId = dt.Rows[i].Field<string>("UserId");
                employee.FisrtName = dt.Rows[i].Field<string>("FirstName");
                employee.LastName = dt.Rows[i].Field<string>("LastName");
                employee.Gender = dt.Rows[i].Field<string>("Gender");
                employee.PhoneNumber = dt.Rows[i].Field<string>("PhoneNumber");
                employee.Email = dt.Rows[i].Field<string>("Email");
                employee.Salary = dt.Rows[i].Field<int>("Salary");
                employee.TimeSchedule = dt.Rows[i].Field<string>("TimeSchedule");
                employee.HireDate = dt.Rows[i].Field<string>("HireDate");
                employee.UserType = dt.Rows[i].Field<int>("UserType");
                list.Add(employee);
            }
            return list;
        }
        public bool IsDelete(string userId)
        {
            int rowsAffected = employeeDL.DeleteEmpolyee(userId);
            return rowsAffected > 0;
        }
    }
}
