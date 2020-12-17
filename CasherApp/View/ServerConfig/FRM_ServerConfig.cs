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
using CasherApp.Properties;
namespace CasherApp.View.ServerConfig
{
    public partial class FRM_ServerConfig : DevExpress.XtraEditors.XtraForm
    {
        public FRM_ServerConfig()
        {
            InitializeComponent();
        }

        private void simpleButtonSaveSettings_Click(object sender, EventArgs e)
        {
            if (isEmpity())
            {
                if (radioGroupConnectionMode.SelectedIndex == 0)
                {
                    Settings.Default.ServerMode = "Windows";
                    Settings.Default.ServerName = textEditServerName.Text;
                    Settings.Default.DBName = textEditDatabseName.Text;

                }

                if (radioGroupConnectionMode.SelectedIndex == 1)
                {
                    Settings.Default.ServerMode = "SQL";
                    Settings.Default.ServerName = textEditServerName.Text;
                    Settings.Default.DBName = textEditDatabseName.Text;
                    Settings.Default.UserName = textEditUsername.Text;
                    Settings.Default.UserPassword = textEditPassword.Text;

                }
                Settings.Default.ServerCheck = true;
                Settings.Default.Save();
                Settings.Default.Reload();
                XtraMessageBox.Show("Server Configuration Succeeded", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void radioGroupConnectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroupConnectionMode.SelectedIndex == 0)
            {
                textEditUsername.Enabled = false;
                textEditPassword.Enabled = false;
            }
            else
            {
                textEditUsername.Enabled = true;
                textEditPassword.Enabled = true;
            }
        }

        private bool isEmpity()
        {
            if (radioGroupConnectionMode.SelectedIndex == 0)
            {
                if (textEditServerName.Text == string.Empty || textEditDatabseName.Text == string.Empty)
                {
                    XtraMessageBox.Show("Please Fill All Data ", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    return true;
                }
                
            }
            else if (radioGroupConnectionMode.SelectedIndex == 1)
            {
                if (textEditServerName.Text == string.Empty ||
                    textEditDatabseName.Text == string.Empty ||
                    textEditUsername.Text == string.Empty ||
                    textEditPassword.Text == string.Empty)
                {
                    XtraMessageBox.Show("Please Fill All Data ", "Configuration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    return true;
                }

            }
            
                return false;
            
           
        }
    }
}