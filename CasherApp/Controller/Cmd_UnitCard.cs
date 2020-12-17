using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasherApp.Factory;
using CasherApp.Model;

namespace CasherApp.Controller
{
    class Cmd_UnitCard
    {
        Repository<CLS_UnitCard> cmd = new Repository<CLS_UnitCard>();

        public List<CLS_UnitCard> GetAllUnitCard()
        {
            try
            {
                return cmd.GetAll("SP_SelectAllUnitCard").ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void InsertUnitCard(string unitName)
        {
            List<CLS_UnitCard> items = new List<CLS_UnitCard>()
            {
                new CLS_UnitCard
                {
                    UnitName = unitName
                }
            };

            cmd.ExecParam("SP_InsertUnitCard @UnitName", items);
        }

        public void RemoveUnitCard(int unitID)
        {
            List<CLS_UnitCard> items = new List<CLS_UnitCard>()
            {
                new CLS_UnitCard
                {
                    UnitID = unitID
                }
            };

            cmd.ExecParam("SP_DeleteUnitCard @UnitID", items);
        }
    }
}
