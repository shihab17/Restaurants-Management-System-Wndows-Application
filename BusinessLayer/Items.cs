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
    public class Items
    {
        ItemsDL itemsDL = new ItemsDL();
        public bool IsInsert(string CategoryName, string SubCategoryName, string ItemName, int Price)
        {
            int rowsAffected = itemsDL.InsertItems(CategoryName, SubCategoryName, ItemName, Price);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsUpdate(Item item)
        {
            int rowsAffected = itemsDL.UpdateItems(item.ItemId, item.CategoryName, item.SubCategoryName, item.ItemName, item.Price);
            return rowsAffected > 0;
        }
        public bool IsDelete(int itemId)
        {
            int rowsAffected = itemsDL.DeleteItem(itemId);
            return rowsAffected > 0;
        }
        public List<Item> GetAllItems()
        {
            DataTable dt = itemsDL.GetAllItems();
            List<Item> list = new List<Item>();
            foreach (DataRow dr in dt.Rows)
            {
                Item item = new Item();
                item.ItemId = dr.Field<int>("ItemId");
                item.CategoryName = dr.Field<string>("CategoryName");
                item.SubCategoryName = dr.Field<string>("SubCategoryName");
                item.ItemName = dr.Field<string>("ItemName");
                item.Price = dr.Field<int>("Price");
                list.Add(item);
            }
            return list;
        }
        public List<Item> GetItem(int itemId)
        {
            DataTable dt = itemsDL.GetItem(itemId);
            List<Item> list = new List<Item>();
            foreach (DataRow dr in dt.Rows)
            {
                Item item = new Item();
                item.ItemId = dr.Field<int>("ItemId");
                item.CategoryName = dr.Field<string>("CategoryName");
                item.SubCategoryName = dr.Field<string>("SubCategoryName");
                item.ItemName = dr.Field<string>("ItemName");
                item.Price = dr.Field<int>("Price");
                list.Add(item);
            }
            return list;
        }
        public Item GetItemByItemName(string ItemName)
        {
            DataTable dt = itemsDL.GetItemByItemName(ItemName);
            Item item = new Item();
            item.ItemId = dt.Rows[0].Field<int>("ItemId");
            item.CategoryName = dt.Rows[0].Field<string>("CategoryName");
            item.SubCategoryName = dt.Rows[0].Field<string>("SubCategoryName");
            item.ItemName = dt.Rows[0].Field<string>("ItemName");
            item.Price = dt.Rows[0].Field<int>("Price");
            return item;
        }
        public List<Item> GetItemsBySubCategory(string subCategoryName)
        {
            DataTable dt = itemsDL.GetItemBySubCategory(subCategoryName);
            List<Item> list = new List<Item>();
            foreach (DataRow dr in dt.Rows)
            {
                Item item = new Item();
                item.ItemId = dr.Field<int>("ItemId");
                item.CategoryName = dr.Field<string>("CategoryName");
                item.SubCategoryName = dr.Field<string>("SubCategoryName");
                item.ItemName = dr.Field<string>("ItemName");
                item.Price = dr.Field<int>("Price");
                list.Add(item);
            }
            return list;
        }
    }
}
