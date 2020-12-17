using CasherApp.Controller;
using CasherApp.Model;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CasherApp.View.Items
{
    public partial class Frm_AddItems : DevExpress.XtraEditors.XtraForm
    {
        public Frm_AddItems()
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

        void AddItem()
        {
            if (string.IsNullOrWhiteSpace(cmbCategoryName.Text) || string.IsNullOrWhiteSpace(txtCode.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                XtraMessageBox.Show("يرجى ملئ جميع الحقول", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            List<CLS_ItemCard> item = itemCardCmd.GetAllItemCard();
            if (item.Exists(c => c.Name == txtName.Text || c.Code == txtCode.Text))
            {
                XtraMessageBox.Show("الصنف معرف مسبقا في بطاقة الاصناف", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
                return;
            }

            if (Application.OpenForms.OfType<FRM_ItemCard>().Any())
            {
                itemCardCmd.InsertItemCard(cmbCategoryName.Text, txtCode.Text, txtName.Text, cmbUnit.Text, double.Parse(txtPrice.Text), chkAddItem.Checked, int.Parse(txtCategoryID.Text));
                HelperClass.ClearValue(tableLayoutPanel2);
                FRM_ItemCard frm = (FRM_ItemCard)Application.OpenForms["FRM_ItemCard"];
                frm.DisplayItemCard();
                //frm.gvItemCard.AddNewRow();
                //int rowHandler = frm.gvItemCard.GetRowHandle(frm.gvItemCard.DataRowCount); ;
                //if (frm.gvItemCard.IsNewItemRow(rowHandler))
                //{
                //    frm.gvItemCard.SetRowCellValue(rowHandler, "CategoryID", txtCategoryID.Text);
                //    frm.gvItemCard.SetRowCellValue(rowHandler, "CategoryName", txtCategoryID.Text);
                //    frm.gvItemCard.SetRowCellValue(rowHandler, "Code", txtCategoryID.Text);
                //    frm.gvItemCard.SetRowCellValue(rowHandler, "Name", txtCategoryID.Text);
                //    frm.gvItemCard.SetRowCellValue(rowHandler, "Unit", txtCategoryID.Text);
                //    frm.gvItemCard.SetRowCellValue(rowHandler, "Price", txtCategoryID.Text);
                //    frm.gvItemCard.SetRowCellValue(rowHandler, "AddItem", txtCategoryID.Text);
                //}
            }

        }

        private void cmbCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCategoryID();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem();
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