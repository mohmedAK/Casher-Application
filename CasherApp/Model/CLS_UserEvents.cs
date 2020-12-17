using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasherApp.Model
{
    class CLS_UserEvents
    {
        public int EventID { get; set; }

        public DateTime EventDate { get; set; }

        public string EventName { get; set; }

        public int SaleMasterID { get; set; }

        public DateTime SaleDate { get; set; }

        public double FinalTotal { get; set; }

        public string UserName { get; set; }

    }
}
