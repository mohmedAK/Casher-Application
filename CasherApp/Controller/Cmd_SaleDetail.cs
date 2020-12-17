using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasherApp.Factory;
using CasherApp.Model;

namespace CasherApp.Controller
{
    class Cmd_SaleDetail
    {
        Repository<CLS_SaleDetail> cmd = new Repository<CLS_SaleDetail>();

        public List<CLS_SaleDetail> GetSaleDetail(int saleMasterID)
        {
            try
            {
                return cmd.GetByParam("SP_SelectSaleDetailByID @SaleMasterID", new {SaleMasterID = saleMasterID}).ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void InsertSaleDetail(DateTime entryDate,string code,string name ,double qty, string unit,double price,double total, int saleMasterID)
        {
            List<CLS_SaleDetail> items = new List<CLS_SaleDetail>()
            {
                new CLS_SaleDetail
                {
                    EntryDate = entryDate,
                    Code = code,
                    Name = name,
                    Qty = qty,
                    Unit = unit,
                    Price = price,
                    Total = total,
                    SaleMasterID = saleMasterID
                }
            };

            cmd.ExecParam("SP_InsertSaleDetail @EntryDate, @Code , @Name , @Qty , @Unit, @Price, @Total, @SaleMasterID", items);
        }

        public void RemoveAllSaleDetail(int saleMasterID)
        {
            List<CLS_SaleDetail> items = new List<CLS_SaleDetail>()
            {
                new CLS_SaleDetail
                {
                  SaleMasterID = saleMasterID
                }
            };

            cmd.ExecParam("SP_DeleteAllSaleDetail @SaleMasterID ", items);

        }

        public void RemoveSingleSaleDetail(int saleDetailID)
        {
            List<CLS_SaleDetail> items = new List<CLS_SaleDetail>()
            {
                new CLS_SaleDetail
                {
                  SaleDetailID = saleDetailID
                }
            };

            cmd.ExecParam("SP_DeleteSingleSaleDetail @SaleDetailID", items);

        }
    }
    
}
