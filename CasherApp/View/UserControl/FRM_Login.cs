using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using CasherApp.Controller;
using CasherApp.Model;
using CasherApp.View.Main;
namespace CasherApp.View.UserControl
{
    public partial class FRM_Login : DevExpress.XtraEditors.XtraForm
    {
        int count;
        public FRM_Login()
        {
            InitializeComponent();
            count = 0;
        }

        Cmd_Users cmd_Users = new Cmd_Users();
        //User login

        void UserLogin()
        {
            CLS_Users users = cmd_Users.GetUserByUsernameAndPassword(txtUsername.Text,HelperClass.EncryptPassword(txtPassword.Text));
            if (users != null)
            {
                UserInfo.currentUser = users;
                this.Hide();
                Frm_Main frm = new Frm_Main();
                frm.Show();

            }
            else
            {
                count++;
                XtraMessageBox.Show("تاكد من صحة اسم المستخدم وكلمة المرور", "دخول", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                HelperClass.ClearValue(tableLayoutPanel2);
            }

            if (count == 3)
            {
                Application.Exit();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            UserLogin();
        }
    }
}