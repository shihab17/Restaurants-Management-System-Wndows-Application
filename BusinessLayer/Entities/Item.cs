using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entities
{
    public class Item
    {
        public int ItemId { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }


    }
}
