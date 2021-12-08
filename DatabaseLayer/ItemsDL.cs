using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class ItemsDL
    {
        DataAccess dataAccess = new DataAccess();
        public int InsertItems(string CategoryName,string SubCategoryName, string ItemName, int Price)
        {
            string sql = string.Format("insert into tblItems (CategoryName, SubCategoryName, ItemName, Price)" +
              "Values('{0}', '{1}', '{2}', '{3}')", CategoryName, SubCategoryName, ItemName, Price);
            int rowsAffected = dataAccess.ExecuteComand(sql);
            return rowsAffected;
        }

        public int UpdateItems(int ItemId, string CategoryName, string SubCategoryName, string ItemName, int Price)
        {
            string query = "UPDATE tblItems SET CategoryName = '" + CategoryName + "', SubCategoryName = '" + SubCategoryName + "', ItemName = '" + ItemName + "', Price= '" + Price + "' WHERE ItemId ='" + ItemId + "' ";
            int rowsAffected = dataAccess.ExecuteComand(query);
            return rowsAffected;
        }
        public int DeleteItem(int ItemId)
        {
            string query = "DELETE FROM tblItems WHERE ItemId ='" + ItemId + "' ";
            int rowsAffected = dataAccess.ExecuteComand(query);
            return rowsAffected;
        }
        public DataTable GetAllItems()
        {
            string query = "Select * FROM tblItems ";
            SqlCommand command = dataAccess.GetCommand(query);
            DataTable dt = dataAccess.Execute(command);
            return dt;
        }
        public DataTable GetItem (int ItemId)
        {
            string query = "Select * FROM tblItems where ItemId ='" + ItemId + "' ";
            SqlCommand command = dataAccess.GetCommand(query);
            DataTable dt = dataAccess.Execute(command);
            return dt;
        }
        public DataTable GetItemByItemName(string ItemName)
        {
            string query = "Select * FROM tblItems where ItemName ='" + ItemName + "' ";
            SqlCommand command = dataAccess.GetCommand(query);
            DataTable dt = dataAccess.Execute(command);
            return dt;
        }
        public DataTable GetItemBySubCategory(string subCategory)
        {
            string query = "Select * FROM tblItems where SubCategoryName ='" + subCategory + "' ";
            SqlCommand command = dataAccess.GetCommand(query);
            DataTable dt = dataAccess.Execute(command);
            return dt;
        }

    }
}
