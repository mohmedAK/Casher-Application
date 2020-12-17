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
    public partial class FRM_ItemCard : DevExpress.XtraEditors.XtraForm
    {
     
        public FRM_ItemCard()
        {
            InitializeComponent();
            DisplayItemCard();
        }

        Cmd_ItemCard itemCardCMD = new Cmd_ItemCard();
        BindingSource bSItemCard = new BindingSource();

        //Get All Item Data
   public void DisplayItemCard()
        {
            List<CLS_ItemCard> itemCardsList = itemCardCMD.GetAllItemCard();
            bSItemCard.Clear();
            bSItemCard.DataSource = itemCardsList;
           
            gcItemCard.DataSource = bSItemCard;
        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "جديد")
            {
                Frm_AddItems frm = new Frm_AddItems();
                frm.ShowDialog();
            }

            if (e.Button.Properties.Caption == "تعديل")
            {
                FRM_EditItem frm = new FRM_EditItem();

                frm.txtCategoryID.Text = gvItemCard.GetFocusedRowCellValue("CategoryID").ToString();
                frm.cmbCategoryName.Text = gvItemCard.GetFocusedRowCellValue("CategoryName").ToString();
                frm.txtCode.Text = gvItemCard.GetFocusedRowCellValue("Code").ToString();
                frm.txtName.Text = gvItemCard.GetFocusedRowCellValue("Name").ToString();
                frm.cmbUnit.Text = gvItemCard.GetFocusedRowCellValue("Unit").ToString();
                frm.txtPrice.Text = gvItemCard.GetFocusedRowCellValue("Price").ToString();
                frm.chkAddItem.Checked =(bool) gvItemCard.GetFocusedRowCellValue("AddItem");
                frm.itemID = int.Parse(gvItemCard.GetFocusedRowCellValue("ItemID").ToString());
                frm.ShowDialog();
            }
        }
    }
}