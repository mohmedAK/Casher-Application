using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasherApp.Model
{
    class CLS_ItemCard
    {
        public int ItemID { get; set; }

        public string CategoryName { get; set; }
        public string Code { get; set; }

        public string Name { get; set; }

        public string Unit { get; set; }

        public double Price { get; set; }

        public bool AddItem { get; set; }

        public int CategoryID { get; set; }
    }
}
