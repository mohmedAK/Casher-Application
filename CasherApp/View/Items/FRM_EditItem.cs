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
namespace CasherApp.View.Items
{
    public partial class FRM_EditItem : DevExpress.XtraEditors.XtraForm
    {
     public int itemID;
        public FRM_EditItem()
        {
            InitializeComponent();
            LoadCategory();
            LoadUnit();
        }

        Cmd_Category categoryCmd = new Cmd_Category();
        Cmd_ItemCard itemCardCmd = new Cmd_ItemCard();
        Cmd_UnitCard unitCardCmd = new Cmd_UnitCard();

        //Get All Category
        void LoadCategory()
        {
            List<CLS_Category> categories = categoryCmd.GetAllCategory();
            categories.ForEach(c =>
            {
                cmbCategoryName.Properties.Items.Add(c.CategoryName);
            });
        }

        void LoadUnit()
        {
            List<CLS_UnitCard> unit = unitCardCmd.GetAllUnitCard();
            unit.ForEach(c =>
            {
                cmbUnit.Properties.Items.Add(c.UnitName);
            });
        }

        public void GetCategoryID()
        {


            if (!string.IsNullOrWhiteSpace(cmbCategoryName.Text))
            {
                CLS_Category category = categoryCmd.GetCategoryID(cmbCategoryName.Text);
                txtCategoryID.Text = category.CategoryID.ToString();
            }


        }

        void EditItem()
        {
            if (Application.OpenForms.OfType<FRM_ItemCard>().Any())
            {
                itemCardCmd.EditItemCard(itemID,cmbCategoryName.Text, txtCode.Text, txtName.Text, cmbUnit.Text, double.Parse(txtPrice.Text), chkAddItem.Checked, int.Parse(txtCategoryID.Text));
                HelperClass.ClearValue(tableLayoutPanel2);
                FRM_ItemCard frm = (FRM_ItemCard)Application.OpenForms["FRM_ItemCard"];
                frm.DisplayItemCard();
            }
        }
        private void cmbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCategoryID();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EditItem();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            e.Handled = !Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && ch != 46;
        }
    }
}