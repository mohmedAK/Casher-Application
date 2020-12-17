using CasherApp.Controller;
using CasherApp.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CasherApp.View.Sales
{
    public partial class FRM_Sales : DevExpress.XtraEditors.XtraForm
    {
        public string state;

        public FRM_Sales()
        {
            InitializeComponent();

            CreateTabPages();
            AddButtonPages();
            txtCode.Focus();
        }

        private void FRM_Sales_Load(object sender, EventArgs e)
        {
            state = "New";
            newData();
            txtCode.Focus();
        }
        Cmd_SaleMaster cmdSaleMaster = new Cmd_SaleMaster();
        Cmd_Category cmdCategoey = new Cmd_Category();
        Cmd_SaleDetail cmdSaleDetail = new Cmd_SaleDetail();
        Cmd_ItemCard cmdItemCard = new Cmd_ItemCard();

        //New Data
        void newData()
        {
            HelperClass.ClearValue(tableLayoutPanel1);
            List<CLS_SaleMaster> saleMasters = cmdSaleMaster.GetAllSaleMaster();
            int maxID = saleMasters.DefaultIfEmpty().Max(c => c == null ? 1 : c.SaleMasterID + 1);
            lblSaleMasterID.Text = maxID.ToString();
            lblCurrency.Text = "دينار عراقي";
            lblFinalTotal.Text = string.Format("{0:N}", double.Parse("0"));
            lblItemQty.Text = "0";
            dtEntryDate.DateTime = DateTime.Today;
            //lblUsrname.Text = UserInfo.currentUser.UserName;
            lblUsrname.Text = "المدير";

            while (gvSaleDetail.RowCount > 0)
            {
                gvSaleDetail.SelectAll();
                gvSaleDetail.DeleteSelectedRows();

            }
        }

        //Save Sale Master Data
        void saveSaleMaster()
        {
            cmdSaleMaster.InsertSaleMaster(int.Parse(lblSaleMasterID.Text), dtEntryDate.DateTime, lblCurrency.Text,
                                           int.Parse(lblItemQty.Text), double.Parse(lblFinalTotal.Text), lblUsrname.Text);

        }

        //Edit or Update Sale Existing Sale Master Date

        public void EditSaleMaster()
        {
            cmdSaleMaster.EditSaleMaster(int.Parse(lblSaleMasterID.Text), dtEntryDate.DateTime, lblCurrency.Text,
                                         int.Parse(lblItemQty.Text), double.Parse(lblFinalTotal.Text), lblUsrname.Text);

        }

        //Add Sale Detail Records
        void addSaileDetail()
        {
            for (int i = 0; i < gvSaleDetail.DataRowCount; i++)
            {
                DateTime entryDate = dtEntryDate.DateTime;
                string code = gvSaleDetail.GetRowCellValue(i, "Code").ToString();
                string name = gvSaleDetail.GetRowCellValue(i, "Name").ToString();
                double qty = double.Parse(gvSaleDetail.GetRowCellValue(i, "Qty").ToString());
                string unit = gvSaleDetail.GetRowCellValue(i, "Unit").ToString();
                double price = double.Parse(gvSaleDetail.GetRowCellValue(i, "Code").ToString());
                double total = qty * price;
                int saleMasterID = int.Parse(gvSaleDetail.GetRowCellValue(i, "SaleMasterID").ToString());

                cmdSaleDetail.InsertSaleDetail(entryDate, code, name, qty, unit, price, total, saleMasterID);
            }
        }

        //Delete All Sale Detail
        void deleteAllSaleDetail()
        {
            cmdSaleDetail.RemoveAllSaleDetail(int.Parse(lblSaleMasterID.Text));
        }

        //GetItemData
        void GetItem()
        {
            List<CLS_ItemCard> item = cmdItemCard.GetAllItemCard().Where(c => c.Code == txtCode.Text).ToList();
            if (!item.Exists(c => c.Code == txtCode.Text))
            {
                XtraMessageBox.Show("الصنف غير معرف", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            item.ForEach(c =>
            {
                AddRowToGridView(c);

                //gvSaleDetail.AddNewRow();
                //int rowHandel = gvSaleDetail.GetRowHandle(gvSaleDetail.DataRowCount);
                //if (gvSaleDetail.IsNewItemRow(rowHandel))
                //{
                //    gvSaleDetail.SetRowCellValue(rowHandel, "Code",c.Code);
                //    gvSaleDetail.SetRowCellValue(rowHandel, "Name", c.Name);
                //    gvSaleDetail.SetRowCellValue(rowHandel, "Unit", c.Unit);
                //    if (string.IsNullOrWhiteSpace(txtQty.Text))
                //    {
                //        txtQty.Text = "1";
                //        gvSaleDetail.SetRowCellValue(rowHandel, "Qty", txtQty.Text);
                //    }
                //    else
                //    {
                //        gvSaleDetail.SetRowCellValue(rowHandel, "Qty", txtQty.Text);
                //    }

                //    gvSaleDetail.SetRowCellValue(rowHandel, "Price", c.Price);
                //    gvSaleDetail.SetRowCellValue(rowHandel, "Total", double.Parse(txtQty.Text) * c.Price);
                //    gvSaleDetail.SetRowCellValue(rowHandel, "SaleMasterID", lblSaleMasterID.Text);
                //}
            });

            gvSaleDetail.FocusedRowHandle = 0;
            double sum = 0;
            for (int i = 0; i < gvSaleDetail.DataRowCount; i++)
            {
                sum += double.Parse(gvSaleDetail.GetRowCellValue(i, "Total").ToString());
                lblFinalTotal.Text = sum.ToString();
            }

            lblItemQty.Text = gvSaleDetail.RowCount.ToString();
            txtCode.ResetText();
            txtQty.ResetText();
            txtCode.Focus();

        }

        //Create TabPages

        void CreateTabPages()
        {
            List<CLS_Category> categories = cmdCategoey.GetAllCategory();
            categories.ForEach(c =>
            {
                tapItems.TabPages.Add(c.CategoryName);
            });
        }

        void AddButtonPages()
        {
            int i = 1;
            foreach (XtraTabPage tb in tapItems.TabPages)
            {
                tb.Appearance.Header.Font = new Font("Segoe UI", 13, FontStyle.Bold);
                List<CLS_ItemCard> item = cmdItemCard.GetAllItemCard().Where(c => c.CategoryID == i && c.AddItem == true).ToList();
                FlowLayoutPanel flp = new FlowLayoutPanel();
                flp.Dock = DockStyle.Fill;

                item.ForEach(c =>
                {
                    SimpleButton b = new SimpleButton();
                    b.Size = new Size(120, 120);
                    b.Font = new Font("Segoe UI", 15, FontStyle.Bold);
                    b.ForeColor = Color.White;
                    b.ImageOptions.Image = imageCollection1.Images[0];
                    b.ImageOptions.ImageToTextAlignment = ImageAlignToText.BottomCenter;
                    b.Appearance.BackColor = Color.SteelBlue;
                    b.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
                    b.Appearance.BorderColor = Color.Firebrick;
                    b.Text = c.Name;
                    b.Tag = item;
                    b.Click += B_Click;
                    flp.Controls.Add(b);
                });
                tb.Controls.Add(flp);
                i++;
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            SimpleButton b = (SimpleButton)sender;
            List<CLS_ItemCard> item = (List<CLS_ItemCard>)b.Tag;
            item.ForEach(c =>
            {
                if (c.Name == b.Text)
                {
                    AddRowToGridView(c);
                }
            });
        }

        void AddRowToGridView(CLS_ItemCard c)
        {
            gvSaleDetail.AddNewRow();
            int rowHandel = gvSaleDetail.GetRowHandle(gvSaleDetail.DataRowCount);
            if (gvSaleDetail.IsNewItemRow(rowHandel))
            {
                gvSaleDetail.SetRowCellValue(rowHandel, "Code", c.Code);
                gvSaleDetail.SetRowCellValue(rowHandel, "Name", c.Name);
                gvSaleDetail.SetRowCellValue(rowHandel, "Unit", c.Unit);
                if (string.IsNullOrWhiteSpace(txtQty.Text))
                {
                    txtQty.Text = "1";
                    gvSaleDetail.SetRowCellValue(rowHandel, "Qty", txtQty.Text);
                }
                else
                {
                    gvSaleDetail.SetRowCellValue(rowHandel, "Qty", txtQty.Text);
                }

                gvSaleDetail.SetRowCellValue(rowHandel, "Price", c.Price);
                gvSaleDetail.SetRowCellValue(rowHandel, "Total", double.Parse(txtQty.Text) * c.Price);
                gvSaleDetail.SetRowCellValue(rowHandel, "SaleMasterID", lblSaleMasterID.Text);
            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            txtQty.Text += btn1.Text;
            txtCode.Focus();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtQty.Text += btn2.Text;
            txtCode.Focus();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtQty.Text += btn3.Text;
            txtCode.Focus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtQty.Text += btn4.Text;
            txtCode.Focus();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtQty.Text += btn5.Text;
            txtCode.Focus();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtQty.Text += btn6.Text;
            txtCode.Focus();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtQty.Text += btn7.Text;
            txtCode.Focus();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtQty.Text += btn8.Text;
            txtCode.Focus();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtQty.Text += btn9.Text;
            txtCode.Focus();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtQty.Text += btn0.Text;
            txtCode.Focus();
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            txtQty.Text += btnComma.Text;
            txtCode.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQty.ResetText();
            txtCode.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtQty.Text))
            {
                txtQty.Text = txtQty.Text.Remove(txtQty.Text.Length - 1, 1);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            GetItem();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetItem();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            state = "New";
            newData();
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
            txtCode.Focus();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            state = "Old";
            newData();
            btnEdit.Enabled = false;
            btnAdd.Enabled = true;
            txtCode.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (gvSaleDetail.RowCount == 0)
            {
                XtraMessageBox.Show("لايمكن حفظ فاتورة فارغة", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (state == "New")
            {
                saveSaleMaster();
                addSaileDetail();
            }

            if (state == "Old")
            {
                EditSaleMaster();
                deleteAllSaleDetail();
                addSaileDetail();
            }

            newData();

            txtCode.Focus();
        }
    }
}