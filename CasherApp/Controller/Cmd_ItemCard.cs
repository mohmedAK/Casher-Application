using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasherApp.Factory;
using CasherApp.Model;

namespace CasherApp.Controller
{
    class Cmd_ItemCard
    {
        Repository<CLS_ItemCard> cmd = new Repository<CLS_ItemCard>();

        public List<CLS_ItemCard> GetAllItemCard()
        {
            try
            {
                return cmd.GetAll("SP_SelectAllItemCard").ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void InsertItemCard(string categoryName, string code,string name, string unit, double price, bool addItem, int categoryID)
        {
            List<CLS_ItemCard> items = new List<CLS_ItemCard>()
            {
                new CLS_ItemCard
                {
                    CategoryName = categoryName,
                    Code =code,
                    Name = name,
                    Unit = unit,
                    Price = price,
                    AddItem = addItem,
                    CategoryID = categoryID
                }
            };
            cmd.ExecParam("SP_InsertItemCard @CategoryName,@Code, @Name, @Unit, @Price, @AddItem, @CategoryID", items);
        }

        public void EditItemCard(int itemID, string categoryName, string code, string name, string unit, double price, bool addItem, int categoryID)
        {
            List<CLS_ItemCard> items = new List<CLS_ItemCard>()
            {
                new CLS_ItemCard
                {
                    ItemID = itemID,
                    CategoryName = categoryName,
                    Code =code,
                    Name = name,
                    Unit = unit,
                    Price = price,
                    AddItem = addItem,
                    CategoryID = categoryID
                }
            };
            cmd.ExecParam("SP_UpdateItemCard  @ItemID,@CategoryName,@Code, @Name, @Unit, @Price, @AddItem, @CategoryID", items);
        }
        public void RemoveItemCard(int itemCardID)
        {
            List<CLS_ItemCard> items = new List<CLS_ItemCard>()
            {
                new CLS_ItemCard
                {
                    ItemID =itemCardID
                }
            };
            cmd.ExecParam("SP_DeleteItemCard @ItemID", items);
        }
    }
}
