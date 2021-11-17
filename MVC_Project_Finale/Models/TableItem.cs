using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Project_Finale.Models
{
    public class TableItem
    {
        public int Index { get; set; }
        public string Value { get; set; }

        public TableItem(int index, string value)
        {
            Index = index;
            Value = value;
        }
    }
}
