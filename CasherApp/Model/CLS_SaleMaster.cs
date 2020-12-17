using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasherApp.Model
{
    class CLS_SaleMaster
    {
        public int SaleMasterID { get; set; }

        public DateTime EntryDate { get; set; }

        public string Currency { get; set; }

        public double QtyTotal { get; set; }

        public double FinalTotal { get; set; }

        public string UserName { get; set; }
    }

}
