using CasherApp.Factory;
using CasherApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using CasherApp.StoredProcegers;
namespace CasherApp.Controller
{
    class Cmd_Category
    {
        Repository<CLS_Category> cmd = new Repository<CLS_Category>();
        SP_Category SP_Category = new SP_Category();
        public List<CLS_Category> GetAllCategory()
        {
            try
            {
                return cmd.GetAll(SP_Category.getStoredProceger("SP_SelectAllCategory")).ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public CLS_Category GetCategoryID(string categoryName)
        {
            try
            {
                return cmd.GetSingle(SP_Category.getStoredProceger("SP_GetCategoryId"),
                    new CLS_Category
                    {
                        CategoryName = categoryName

                    });
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void InsertCategory(string categoryName)
        {
            List<CLS_Category> categories = new List<CLS_Category>()
            {
                new CLS_Category
                {
                    CategoryName =categoryName
                }
            };
            cmd.ExecParam(SP_Category.getStoredProceger("SP_InsertCategory"), categories);
        }

        public void RemoveCategory(int categoryID)
        {
            List<CLS_Category> categories = new List<CLS_Category>()
            {
                new CLS_Category
                {
                    CategoryID =categoryID
                }
            };
            cmd.ExecParam("SP_DeleteCategory @CategoryID", categories);
        }
    }
}
