using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class SubCategoriesDL
    {
        DataAccess dataAccess = new DataAccess();
        public DataTable GellAllSubCategories()
        {
            string query = "Select * FROM tblSubCategories ";
            SqlCommand command = dataAccess.GetCommand(query);
            DataTable dt = dataAccess.Execute(command);
            return dt;
        }
        public DataTable GetSubCategory(string CategoryName)
        {
            string query = "Select * FROM tblSubCategories where CategoryName ='" + CategoryName + "' ";
            SqlCommand command = dataAccess.GetCommand(query);
            DataTable dt = dataAccess.Execute(command);
            return dt;
        }

        public int Insert(string SubCategoryName, string CategoryName)
        {
            string sql = string.Format("insert into tblSubCategories (SubCategoryName, CategoryName)" +
              "Values('{0}', '{1}' )", SubCategoryName, CategoryName);
            int rowsAffected = dataAccess.ExecuteComand(sql);
            return rowsAffected;
        }
        public int Update(int SubCategoryId, string SubCategoryName, string CategoryName)
        {
            string query = "UPDATE tblSubCategories SET  SubCategoryName= '" + SubCategoryName + "', CategoryName = '" + CategoryName+ "' WHERE SubCategoryId ='" + SubCategoryId + "' ";
            int rowsAffected = dataAccess.ExecuteComand(query);
            return rowsAffected;
        }
        public int Delete(int SubCategoryId)
        {
            string query = "DELETE FROM tblSubCategories  WHERE SubCategoryId ='" + SubCategoryId + "' ";
            int rowsAffected = dataAccess.ExecuteComand(query);
            return rowsAffected;
        }
    }
}
