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
    public class SubCategories
    {
        SubCategoriesDL subCategoriesDL = new SubCategoriesDL();
        public List<SubCategory> GetAllSubCategories()
        {
            DataTable dt = subCategoriesDL.GellAllSubCategories();
            List<SubCategory> list = new List<SubCategory>();
            foreach (DataRow dr in dt.Rows)
            {
                SubCategory subCategory = new SubCategory();
                subCategory.SubCategoryId = dr.Field<int>("SubCategoryId");
                subCategory.SubCategoryName = dr.Field<string>("SubCategoryName");
                subCategory.CategoryName = dr.Field<string>("CategoryName");
                list.Add(subCategory);
            }
            return list;
        }
        public List<SubCategory> GetSubCategoryByCategoryName(string categoryName)
        {
            DataTable dt = subCategoriesDL.GetSubCategory(categoryName);
            List<SubCategory> list = new List<SubCategory>();
            foreach (DataRow dr in dt.Rows)
            {
                SubCategory subCategory = new SubCategory();
                subCategory.SubCategoryId = dr.Field<int>("SubCategoryId");
                subCategory.SubCategoryName = dr.Field<string>("SubCategoryName");
                subCategory.CategoryName = dr.Field<string>("CategoryName");
                list.Add(subCategory);
            }
            return list;
        }
        public bool IsInsert(string SubCategoryName, string CategoryName)
        {
            int rowsAffected = subCategoriesDL.Insert(SubCategoryName, CategoryName);
            return rowsAffected > 0;
        }
        public bool IsUpdate(SubCategory subCategory)
        {
            int rowsAffected = subCategoriesDL.Update(subCategory.SubCategoryId, subCategory.SubCategoryName, subCategory.CategoryName);
            return (rowsAffected > 0);
        }
        public bool IsDelete(int SubCategoryId)
        {
            int rowsAffected = subCategoriesDL.Delete(SubCategoryId);
            return rowsAffected > 0;
        }
    }
}
