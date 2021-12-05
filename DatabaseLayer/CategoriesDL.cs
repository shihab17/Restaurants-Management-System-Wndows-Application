using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class CategoriesDL
    {
        DataAccess dataAccess = new DataAccess();

        public DataTable GellAllCategories()
        {
            string query = "Select * FROM tblCategories ";
            SqlCommand command = dataAccess.GetCommand(query);
            DataTable dt = dataAccess.Execute(command);
            return dt;
        }
        public DataTable GetCategory(int categoryId)
        {
            string query = "Select * FROM tblCategories where CategoryId ='" + categoryId + "' ";
            SqlCommand command = dataAccess.GetCommand(query);
            DataTable dt = dataAccess.Execute(command);
            return dt;
        }
        public int Insert(string categotyName)
        {
            string sql = string.Format("insert into tblCategories (CategoryName)" +
              "Values('{0}')", categotyName);
            int rowsAffected = dataAccess.ExecuteComand(sql);
            return rowsAffected;
        }
        public int Update(int categoriesId, string categoryName)
        {
            string query = "UPDATE tblCategories SET  CategoryName= '" + categoryName + "' WHERE CategoryId ='" + categoriesId + "' ";
            int rowsAffected = dataAccess.ExecuteComand(query);
            return rowsAffected;
        }
        public int Delete(int categoriesId)
        {
            string query = "DELETE FROM tblCategories  WHERE CategoryId ='" + categoriesId + "' ";
            int rowsAffected = dataAccess.ExecuteComand(query);
            return rowsAffected;
        }

    }
}
