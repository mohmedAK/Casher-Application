using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasherApp.StoredProcegers
{
    class SP_Category
    {
       Dictionary<string, string> dict = new Dictionary<string, string>()
      {
          { "SP_SelectAllCategory", "SELECT [CategoryID],[CategoryName] FROM[dbo].[Category]"},
          { "SP_GetCategoryId", "SELECT [CategoryID],[CategoryName] FROM[dbo].[Category] WHERE CategoryName = @CategoryName"},
          { "SP_InsertCategory", "INSERT INTO [dbo].[Category]([CategoryName]) VALUES(@CategoryName)"}
      };
        public string getStoredProceger(string key)
        {
            return dict[key];     
        }
    }
}
