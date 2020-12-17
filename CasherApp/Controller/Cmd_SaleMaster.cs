using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasherApp.Factory;
using CasherApp.Model;

namespace CasherApp.Controller
{
    class Cmd_SaleMaster
    {
        Repository<CLS_SaleMaster> cmd = new Repository<CLS_SaleMaster>();

        public List<CLS_SaleMaster> GetAllSaleMaster()
        {
            try
            {
                return cmd.GetAll("SP_SelectAllSaleMaster").ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void InsertSaleMaster(int saleMasterID,DateTime entryDate,string currency,double qtyTotal,double finalTotal,string userName)
        {
            List<CLS_SaleMaster> items = new List<CLS_SaleMaster>()
            {
                new CLS_SaleMaster
                {
                    SaleMasterID =saleMasterID,
                    EntryDate =entryDate,
                    Currency = currency,
                    QtyTotal =qtyTotal,
                    FinalTotal =finalTotal,
                    UserName =userName
                }
            };

            cmd.ExecParam("SP_InsertSaleMaster @SaleMasterID, @EntryDate , @Currency , @QtyTotal, @FinalTotal, @UserName", items);
        }

        public void EditSaleMaster(int saleMasterID, DateTime entryDate, string currency, double qtyTotal, double finalTotal, string userName)
        {
            List<CLS_SaleMaster> items = new List<CLS_SaleMaster>()
            {
                new CLS_SaleMaster
                {
                    SaleMasterID =saleMasterID,
                    EntryDate =entryDate,
                    Currency = currency,
                    QtyTotal =qtyTotal,
                    FinalTotal =finalTotal,
                    UserName =userName
                }
            };

            cmd.ExecParam("SP_UpdateSaleMaster @SaleMasterID, @EntryDate , @Currency , @QtyTotal, @FinalTotal, @UserName", items);
        }

        public void RemoveSaleMaster(int saleMasterID)
        {
            List<CLS_SaleMaster> items = new List<CLS_SaleMaster>()
            {
                new CLS_SaleMaster
                {
                    SaleMasterID =saleMasterID,
                   
                }
            };

            cmd.ExecParam("SP_DeleteSaleMaster @SaleMasterID", items);
        }
    }
}
