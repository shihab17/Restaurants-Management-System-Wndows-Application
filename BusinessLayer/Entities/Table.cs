using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Entities
{
    public class Table
    {
        public enum TableStatusEnum
        {
            Booked,
            Unbooked
        }
        public string TableId { get; set; }
        public string TableType { get; set; }
        public int TableStatus { get; set; }
    }
}
