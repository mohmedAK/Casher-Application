using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasherApp.Factory;
using CasherApp.Model;
namespace CasherApp.Controller
{
    class Cmd_UserEvents
    {
        Repository<CLS_UserEvents> cmd = new Repository<CLS_UserEvents>();

        public List<CLS_UserEvents> GetAllUserEvent()
        {
            try
            {
                return cmd.GetAll("SP_SelectAllUserEvents").ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

    
    }
}
