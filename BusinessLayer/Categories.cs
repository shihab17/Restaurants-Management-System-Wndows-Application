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
    public class Categories
    {
        CategoriesDL categoriesDL = new CategoriesDL();
        public List<Category> GetAllCategories()
        {
            DataTable dt = categoriesDL.GellAllCategories();
            List<Category> list = new List<Category>();
            foreach (DataRow dr in dt.Rows)
            {
                Category category = new Category();
                category.CategoryId = dr.Field<int>("CategoryId");
                category.CategoryName = dr.Field<string>("CategoryName");
                list.Add(category);
            }
            return list;
        }
        public bool IsInsert(string categoryName)
        {
            int rowsAffected = categoriesDL.Insert(categoryName);
            return rowsAffected > 0;
        }
        public bool IsUpdate(Category category)
        {
            int rowsAffected = categoriesDL.Update(category.CategoryId, category.CategoryName);
            return (rowsAffected > 0);
        }
        public bool IsDelete(int categoryId)
        {
            int rowsAffected = categoriesDL.Delete(categoryId);
            return rowsAffected > 0;
        }
    }
}
