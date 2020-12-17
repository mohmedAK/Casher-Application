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
namespace CasherApp.View.UserControl
{
    public partial class FRM_User : DevExpress.XtraEditors.XtraForm
    {
        public FRM_User()
        {
            InitializeComponent();
        }

        Cmd_Users userCMD = new Cmd_Users();

        void AddUser()
        {
            //check if user doublicated
            List<CLS_Users> users = userCMD.GetAllUsers();
            if (users.Exists(a=>a.UserName == txtUserName.Text))
            {
                XtraMessageBox.Show("الاسم معرف في ادارة المستخدمين", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                return;
            }

            //check password and confirm password
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                XtraMessageBox.Show("تاكيد كلمة المرور غير متطابقة", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                txtPassword.ResetText();
                txtConfirmPassword.ResetText();
                return;
            }

            //check null value
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text)|| string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                XtraMessageBox.Show("يرجى ملى جميع الحقول", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Focus();
                
                txtPassword.ResetText();
                txtConfirmPassword.ResetText();
                return;
            }

            string password = HelperClass.EncryptPassword(txtPassword.Text);
            userCMD.InsertUser(txtUserName.Text, password);
            XtraMessageBox.Show("تمت اضافة مستخدم جديد", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtUserName.Focus();
            txtUserName.ResetText();
            txtPassword.ResetText();
            txtConfirmPassword.ResetText();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}