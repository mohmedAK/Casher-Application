using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasherApp.Model
{
    class CLS_SaleDetail
    {
        public int SaleDetailID { get; set; }

        public DateTime EntryDate { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public double Qty { get; set; }

        public string Unit { get; set; }

        public double Price { get; set; }

        public double Total { get; set; }

        public int SaleMasterID { get; set; }
    }
}
