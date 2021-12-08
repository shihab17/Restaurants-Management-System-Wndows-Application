using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLayer
{
    public class TableDL
    {
        DataAccess dataAccess = new DataAccess();
        public DataTable GetlAllTables()
        {
            string query = "Select * FROM tblTables ";
            SqlCommand command = dataAccess.GetCommand(query);
            DataTable dt = dataAccess.Execute(command);
            return dt;
        }
        public DataTable GetlTableStatus(string tableId)
        {
            string query = "Select * FROM tblTables where TableId = '"+tableId+"'  ";
            SqlCommand command = dataAccess.GetCommand(query);
            DataTable dt = dataAccess.Execute(command);
            return dt;
        }
        public DataTable GetlTableByStatus(int status)
        {
            string query = "Select * FROM tblTables where TableStatus = '" + status + "'  ";
            SqlCommand command = dataAccess.GetCommand(query);
            DataTable dt = dataAccess.Execute(command);
            return dt;
        }
        public int Insert(string tableId, string TableType, int TableStatus)
        {
            string sql = string.Format("insert into tblTables(TableId, TableType, TableStatus)" +
               "Values('{0}', '{1}', '{2}')", tableId, TableType, TableStatus);
            int rowsAffected = dataAccess.ExecuteComand(sql);
            return rowsAffected;
        }
        public int Update(string tableId, string TableType, int TableStatus)
        {
            string query = "UPDATE tblTables SET  TableType= '" + TableType + "', TableStatus= '" + TableStatus + "' WHERE TableId ='" + tableId + "' ";
            int rowsAffected = dataAccess.ExecuteComand(query);
            return rowsAffected;
        }
        public int UpdateStatus(string tableId, int TableStatus)
        {
            string query = "UPDATE tblTables SET TableStatus= '" + TableStatus + "' WHERE TableId ='" + tableId + "' ";
            int rowsAffected = dataAccess.ExecuteComand(query);
            return rowsAffected;
        }
        public int Delete(string tableId)
        {
            string query = "DELETE FROM tblTables  WHERE TableId ='" + tableId + "' ";
            int rowsAffected = dataAccess.ExecuteComand(query);
            return rowsAffected;
        }
    }
}
