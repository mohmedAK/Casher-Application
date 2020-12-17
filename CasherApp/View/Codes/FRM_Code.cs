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

namespace CasherApp.View
{
    public partial class FRM_Code : DevExpress.XtraEditors.XtraForm
    {
        public FRM_Code()
        {
            InitializeComponent();
            DisplayAllCategory();
            DisplayAllUnitCard();
        }

        //Initial Objects
        Cmd_Category categoryCMD = new Cmd_Category();
        Cmd_UnitCard unitCardCMD = new Cmd_UnitCard();
        BindingSource bSCategory = new BindingSource();
        BindingSource bSUnitCard = new BindingSource();

        #region Category Method
        //Display All Category
        void DisplayAllCategory()
        {
            List<CLS_Category> categoriesList = categoryCMD.GetAllCategory();
            bSCategory.DataSource = categoriesList;
            gridControl_Category.DataSource = bSCategory;
        }

        //Insert Category
        void InserdCategory()
        {
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                XtraMessageBox.Show("لا يمكن ادخال قيمة فارغة", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCategoryName.Focus();
                return;
            }
            gridView_Category.AddNewRow();
            int rowHandle = gridView_Category.GetRowHandle(gridView_Category.DataRowCount);
            if (gridView_Category.IsNewItemRow(rowHandle))
            {
                gridView_Category.SetRowCellValue(rowHandle, "CategoryName", txtCategoryName.Text);
            }
            categoryCMD.InsertCategory(txtCategoryName.Text);

        }

        //Delete Category

        void DeleteCategory()
        {
            if (XtraMessageBox.Show("هل تريد حذف السجل المحدد","حذف",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                categoryCMD.RemoveCategory(int.Parse(gridView_Category.GetFocusedRowCellValue("CategoryID").ToString()));
                gridView_Category.DeleteSelectedRows();

            }
            
        }
        



        private void txtCategoryName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            InserdCategory();
        }

        private void txtCategoryName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InserdCategory();
                txtCategoryName.Text = "";
            }
        }

        private void repositoryItemButtonEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DeleteCategory();
        }
        #endregion

        //Display All UnitCard
        void DisplayAllUnitCard()
        {
            List<CLS_UnitCard> categoriesList = unitCardCMD.GetAllUnitCard();
            bSUnitCard.DataSource = categoriesList;
            gridControlUnitCard.DataSource = bSUnitCard;
        }

        //Insert UnitCard
        void InsertUnitCard()
        {
            if (string.IsNullOrWhiteSpace(txtUnitName.Text))
            {
                XtraMessageBox.Show("لا يمكن ادخال قيمة فارغة", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUnitName.Focus();
                return;
            }
            gridViewUnitCard.AddNewRow();
            int rowHandle = gridViewUnitCard.GetRowHandle(gridViewUnitCard.DataRowCount);
            if (gridViewUnitCard.IsNewItemRow(rowHandle))
            {
                gridViewUnitCard.SetRowCellValue(rowHandle, "UnitName", txtUnitName.Text);
            }
            unitCardCMD.InsertUnitCard(txtUnitName.Text);

        }

        //Delete UnitCard
        void DeleteUnitCard()
        {
            if (XtraMessageBox.Show("هل تريد حذف السجل المحدد", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                unitCardCMD.RemoveUnitCard(int.Parse(gridViewUnitCard.GetFocusedRowCellValue("UnitID").ToString()));
                gridViewUnitCard.DeleteSelectedRows();
            }

        }

        private void txtUnitName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            InsertUnitCard();
        }

        private void txtUnitName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InsertUnitCard();
                txtUnitName.Text = "";
            }
        }

        private void repDeleteUnitCard_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DeleteUnitCard(); 
        }
    }
}