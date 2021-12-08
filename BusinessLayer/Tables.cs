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
    public class Tables
    {
        TableDL tableDL = new TableDL();
        public List<Table> GetAllTables()
        {
            DataTable dt = tableDL.GetlAllTables();
            List<Table> list = new List<Table>();
            foreach (DataRow dr in dt.Rows)
            {
                Table table = new Table();
                table.TableId = dr.Field<string>("TableId");
                table.TableType = dr.Field<string>("TableType");
                table.TableStatus = dr.Field<int>("TableStatus");
                list.Add(table);
            }
            return list;
        }
        public int GetTableStatus(string tableId)
        {
            DataTable dt = tableDL.GetlTableStatus(tableId);
            if(dt.Rows.Count > 0)
            {
                return dt.Rows[0].Field<int>("TableStatus");
            }
            else
            {
                return -1;
            }
            
        }
        public List<Table> GetTableByStatus(int status)
        {
            DataTable dt = tableDL.GetlTableByStatus(status);
            List<Table> list = new List<Table>();
            foreach (DataRow dr in dt.Rows)
            {
                Table table = new Table();
                table.TableId = dr.Field<string>("TableId");
                table.TableType = dr.Field<string>("TableType");
                table.TableStatus = dr.Field<int>("TableStatus");
                list.Add(table);
            }
            return list;
        }
        public bool isInsert(Table table)
        {
            int rowsAffected = tableDL.Insert(table.TableId, table.TableType, table.TableStatus);
            return rowsAffected > 0;
        }
        public bool isUpdate(Table table)
        {
            int rowsAffected = tableDL.Update(table.TableId, table.TableType, table.TableStatus);
            return (rowsAffected > 0);
        }
        public bool isUpdateStatus(string tableId, int status)
        {
            int rowsAffected = tableDL.UpdateStatus(tableId, status);
            return (rowsAffected > 0);
        }
        public bool isDelete(string tableId)
        {
            int rowsAffected = tableDL.Delete(tableId);
            return rowsAffected > 0;
        }
    }
}
