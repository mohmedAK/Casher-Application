using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CasherApp.Factory;
using CasherApp.Model;

namespace CasherApp.Controller
{
    class Cmd_Users
    {
        Repository<CLS_Users> cmd = new Repository<CLS_Users>();

        public List<CLS_Users> GetAllUsers()
        {
            try
            {
                return cmd.GetAll("SP_SelectAllUsers").ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public CLS_Users GetUserByUsernameAndPassword(string userName, string userPassword)
        {
            try
            {
               return cmd.GetSingle("SELECT [UserID] ,[UserName] ,[UserPassword] FROM[dbo].[Users]" +
                                     " where UserName = @UserName And UserPassword = @UserPassword",
                    new {
                        UserName = userName,
                        UserPassword =userPassword
                });
            }
            catch (Exception)
            {
                
                return null;
            }
        }

        public CLS_Users GetUserID(string userName )
        {
            try
            {
                return cmd.GetSingle("SP_GetUserID @UserName ",
                     new CLS_Users
                     {
                         UserName = userName,
                         
                     });
            }
            catch (Exception)
            {

                return null;
            }
        }

        public void InsertUser(string userName , string userPassword)
        {
            List<CLS_Users> items = new List<CLS_Users>()
            {
                new CLS_Users
                {
                    UserName = userName,
                    UserPassword =userPassword
                }
            };
            cmd.ExecParam("SP_InsertUser @UserName ,@UserPassword ", items);
        }

        public void EditUser(int userID, string userName, string userPassword)
        {
            List<CLS_Users> items = new List<CLS_Users>()
            {
                new CLS_Users
                {
                    UserID =userID,
                    UserName = userName,
                    UserPassword =userPassword
                }
            };
            cmd.ExecParam("SP_UpdateUser @UserID @UserName @UserPassword ", items);
        }

        public void RemoveUser(int userID)
        {
            List<CLS_Users> items = new List<CLS_Users>()
            {
                new CLS_Users
                {
                    UserID =userID
                   
                }
            };
            cmd.ExecParam("SP_DeleteUser @UserID ", items);
        }
    }
}
