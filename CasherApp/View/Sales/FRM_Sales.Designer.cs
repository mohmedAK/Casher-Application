namespace CasherApp.View.Sales
{
    partial class FRM_Sales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Sales));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearche = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.tapItems = new DevExpress.XtraTab.XtraTabControl();
            this.gcSaleDetale = new DevExpress.XtraGrid.GridControl();
            this.cLSSaleDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvSaleDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSaleDetailID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEntryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaleMasterID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.btn3 = new DevExpress.XtraEditors.SimpleButton();
            this.txtQty = new DevExpress.XtraEditors.TextEdit();
            this.btn2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn6 = new DevExpress.XtraEditors.SimpleButton();
            this.btn5 = new DevExpress.XtraEditors.SimpleButton();
            this.btn4 = new DevExpress.XtraEditors.SimpleButton();
            this.btn9 = new DevExpress.XtraEditors.SimpleButton();
            this.btn8 = new DevExpress.XtraEditors.SimpleButton();
            this.btn7 = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnComma = new DevExpress.XtraEditors.SimpleButton();
            this.btn0 = new DevExpress.XtraEditors.SimpleButton();
            this.btnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.btnBack = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dtEntryDate = new DevExpress.XtraEditors.DateEdit();
            this.lblCurrency = new DevExpress.XtraEditors.LabelControl();
            this.lblFinalTotal = new DevExpress.XtraEditors.LabelControl();
            this.lblSaleMasterID = new DevExpress.XtraEditors.LabelControl();
            this.lblItemQty = new DevExpress.XtraEditors.LabelControl();
            this.lblUsrname = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tapItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSaleDetale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLSSaleDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.5F));
            this.tableLayoutPanel1.Controls.Add(this.btnExit, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnPrint, 4, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnSearche, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnEdit, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tapItems, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gcSaleDetale, 9, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtCode, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtQty, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnComma, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnEnter, 6, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 8, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFinalTotal, 9, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblSaleMasterID, 8, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblItemQty, 7, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblUsrname, 6, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelControl6, 6, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelControl7, 7, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelControl8, 8, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnNew, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1231, 749);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Appearance.Options.UseForeColor = true;
            this.btnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(646, 625);
            this.btnExit.Name = "btnExit";
            this.tableLayoutPanel1.SetRowSpan(this.btnExit, 2);
            this.btnExit.Size = new System.Drawing.Size(92, 121);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "خروج";
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Appearance.Options.UseBackColor = true;
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Appearance.Options.UseForeColor = true;
            this.btnPrint.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(744, 625);
            this.btnPrint.Name = "btnPrint";
            this.tableLayoutPanel1.SetRowSpan(this.btnPrint, 2);
            this.btnPrint.Size = new System.Drawing.Size(92, 121);
            this.btnPrint.TabIndex = 31;
            this.btnPrint.Text = "طباعة";
            // 
            // btnSearche
            // 
            this.btnSearche.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearche.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearche.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnSearche.Appearance.Options.UseBackColor = true;
            this.btnSearche.Appearance.Options.UseFont = true;
            this.btnSearche.Appearance.Options.UseForeColor = true;
            this.btnSearche.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnSearche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearche.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearche.ImageOptions.Image")));
            this.btnSearche.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSearche.Location = new System.Drawing.Point(842, 625);
            this.btnSearche.Name = "btnSearche";
            this.tableLayoutPanel1.SetRowSpan(this.btnSearche, 2);
            this.btnSearche.Size = new System.Drawing.Size(92, 121);
            this.btnSearche.TabIndex = 30;
            this.btnSearche.Text = "بحث";
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(940, 625);
            this.btnAdd.Name = "btnAdd";
            this.tableLayoutPanel1.SetRowSpan(this.btnAdd, 2);
            this.btnAdd.Size = new System.Drawing.Size(92, 121);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Appearance.Options.UseBackColor = true;
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Appearance.Options.UseForeColor = true;
            this.btnEdit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.Enabled = false;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnEdit.Location = new System.Drawing.Point(1038, 625);
            this.btnEdit.Name = "btnEdit";
            this.tableLayoutPanel1.SetRowSpan(this.btnEdit, 2);
            this.btnEdit.Size = new System.Drawing.Size(92, 121);
            this.btnEdit.TabIndex = 28;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tapItems
            // 
            this.tapItems.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tapItems.Appearance.ForeColor = System.Drawing.Color.White;
            this.tapItems.Appearance.Options.UseBackColor = true;
            this.tapItems.Appearance.Options.UseForeColor = true;
            this.tableLayoutPanel1.SetColumnSpan(this.tapItems, 6);
            this.tapItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tapItems.Location = new System.Drawing.Point(646, 3);
            this.tapItems.Name = "tapItems";
            this.tableLayoutPanel1.SetRowSpan(this.tapItems, 8);
            this.tapItems.Size = new System.Drawing.Size(582, 616);
            this.tapItems.TabIndex = 0;
            // 
            // gcSaleDetale
            // 
            this.gcSaleDetale.DataSource = this.cLSSaleDetailBindingSource;
            this.gcSaleDetale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSaleDetale.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gcSaleDetale.Location = new System.Drawing.Point(3, 91);
            this.gcSaleDetale.MainView = this.gvSaleDetail;
            this.gcSaleDetale.Name = "gcSaleDetale";
            this.tableLayoutPanel1.SetRowSpan(this.gcSaleDetale, 6);
            this.gcSaleDetale.Size = new System.Drawing.Size(361, 528);
            this.gcSaleDetale.TabIndex = 1;
            this.gcSaleDetale.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSaleDetail});
            // 
            // cLSSaleDetailBindingSource
            // 
            this.cLSSaleDetailBindingSource.DataSource = typeof(CasherApp.Model.CLS_SaleDetail);
            // 
            // gvSaleDetail
            // 
            this.gvSaleDetail.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSaleDetail.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvSaleDetail.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gvSaleDetail.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSaleDetail.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvSaleDetail.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSaleDetail.Appearance.Row.Options.UseFont = true;
            this.gvSaleDetail.Appearance.Row.Options.UseTextOptions = true;
            this.gvSaleDetail.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gvSaleDetail.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gvSaleDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSaleDetailID,
            this.colEntryDate,
            this.colCode,
            this.colName,
            this.colQty,
            this.colUnit,
            this.colPrice,
            this.colTotal,
            this.colSaleMasterID});
            this.gvSaleDetail.GridControl = this.gcSaleDetale;
            this.gvSaleDetail.Name = "gvSaleDetail";
            this.gvSaleDetail.OptionsCustomization.AllowColumnMoving = false;
            this.gvSaleDetail.OptionsCustomization.AllowColumnResizing = false;
            this.gvSaleDetail.OptionsFind.AllowFindPanel = false;
            this.gvSaleDetail.OptionsMenu.EnableColumnMenu = false;
            this.gvSaleDetail.OptionsMenu.EnableFooterMenu = false;
            this.gvSaleDetail.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.gvSaleDetail.OptionsView.ShowGroupPanel = false;
            this.gvSaleDetail.RowHeight = 25;
            // 
            // colSaleDetailID
            // 
            this.colSaleDetailID.FieldName = "SaleDetailID";
            this.colSaleDetailID.Name = "colSaleDetailID";
            // 
            // colEntryDate
            // 
            this.colEntryDate.FieldName = "EntryDate";
            this.colEntryDate.Name = "colEntryDate";
            // 
            // colCode
            // 
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            // 
            // colName
            // 
            this.colName.Caption = "الصنف";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 134;
            // 
            // colQty
            // 
            this.colQty.Caption = "الكمية";
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.OptionsColumn.AllowEdit = false;
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 1;
            this.colQty.Width = 69;
            // 
            // colUnit
            // 
            this.colUnit.FieldName = "Unit";
            this.colUnit.Name = "colUnit";
            // 
            // colPrice
            // 
            this.colPrice.Caption = "السعر";
            this.colPrice.DisplayFormat.FormatString = "N";
            this.colPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            this.colPrice.Width = 130;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // colSaleMasterID
            // 
            this.colSaleMasterID.FieldName = "SaleMasterID";
            this.colSaleMasterID.Name = "colSaleMasterID";
            // 
            // txtCode
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtCode, 3);
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(370, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtCode.Properties.Appearance.Options.UseFont = true;
            this.txtCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCode.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtCode.Properties.AutoHeight = false;
            this.tableLayoutPanel1.SetRowSpan(this.txtCode, 2);
            this.txtCode.Size = new System.Drawing.Size(270, 82);
            this.txtCode.TabIndex = 2;
            this.txtCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyDown);
            // 
            // btn3
            // 
            this.btn3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn3.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn3.Appearance.Options.UseBackColor = true;
            this.btn3.Appearance.Options.UseFont = true;
            this.btn3.Appearance.Options.UseForeColor = true;
            this.btn3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(554, 180);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(86, 83);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // txtQty
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtQty, 3);
            this.txtQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(370, 91);
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.Appearance.BackColor = System.Drawing.Color.DarkGray;
            this.txtQty.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.txtQty.Properties.Appearance.Options.UseBackColor = true;
            this.txtQty.Properties.Appearance.Options.UseFont = true;
            this.txtQty.Properties.Appearance.Options.UseForeColor = true;
            this.txtQty.Properties.Appearance.Options.UseTextOptions = true;
            this.txtQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtQty.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.txtQty.Properties.AutoHeight = false;
            this.txtQty.Size = new System.Drawing.Size(270, 83);
            this.txtQty.TabIndex = 3;
            // 
            // btn2
            // 
            this.btn2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn2.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn2.Appearance.Options.UseBackColor = true;
            this.btn2.Appearance.Options.UseFont = true;
            this.btn2.Appearance.Options.UseForeColor = true;
            this.btn2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(462, 180);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(86, 83);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn1.Appearance.Options.UseBackColor = true;
            this.btn1.Appearance.Options.UseFont = true;
            this.btn1.Appearance.Options.UseForeColor = true;
            this.btn1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(370, 180);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(86, 83);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn6
            // 
            this.btn6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn6.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn6.Appearance.Options.UseBackColor = true;
            this.btn6.Appearance.Options.UseFont = true;
            this.btn6.Appearance.Options.UseForeColor = true;
            this.btn6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(554, 269);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(86, 83);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn5.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn5.Appearance.Options.UseBackColor = true;
            this.btn5.Appearance.Options.UseFont = true;
            this.btn5.Appearance.Options.UseForeColor = true;
            this.btn5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(462, 269);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(86, 83);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn4.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn4.Appearance.Options.UseBackColor = true;
            this.btn4.Appearance.Options.UseFont = true;
            this.btn4.Appearance.Options.UseForeColor = true;
            this.btn4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(370, 269);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(86, 83);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn9.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn9.Appearance.Options.UseBackColor = true;
            this.btn9.Appearance.Options.UseFont = true;
            this.btn9.Appearance.Options.UseForeColor = true;
            this.btn9.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Location = new System.Drawing.Point(554, 358);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(86, 83);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn8.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn8.Appearance.Options.UseBackColor = true;
            this.btn8.Appearance.Options.UseFont = true;
            this.btn8.Appearance.Options.UseForeColor = true;
            this.btn8.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Location = new System.Drawing.Point(462, 358);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(86, 83);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn7.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn7.Appearance.Options.UseBackColor = true;
            this.btn7.Appearance.Options.UseFont = true;
            this.btn7.Appearance.Options.UseForeColor = true;
            this.btn7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Location = new System.Drawing.Point(370, 358);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(86, 83);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnClear
            // 
            this.btnClear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnClear.Appearance.Options.UseBackColor = true;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.Appearance.Options.UseForeColor = true;
            this.btnClear.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(554, 447);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 83);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnComma
            // 
            this.btnComma.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnComma.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComma.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnComma.Appearance.Options.UseBackColor = true;
            this.btnComma.Appearance.Options.UseFont = true;
            this.btnComma.Appearance.Options.UseForeColor = true;
            this.btnComma.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnComma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComma.Location = new System.Drawing.Point(462, 447);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(86, 83);
            this.btnComma.TabIndex = 14;
            this.btnComma.Text = ",";
            this.btnComma.Click += new System.EventHandler(this.btnComma_Click);
            // 
            // btn0
            // 
            this.btn0.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn0.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn0.Appearance.Options.UseBackColor = true;
            this.btn0.Appearance.Options.UseFont = true;
            this.btn0.Appearance.Options.UseForeColor = true;
            this.btn0.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Location = new System.Drawing.Point(370, 447);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(86, 83);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEnter.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnEnter.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Appearance.Options.UseBackColor = true;
            this.btnEnter.Appearance.Options.UseFont = true;
            this.btnEnter.Appearance.Options.UseForeColor = true;
            this.btnEnter.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.tableLayoutPanel1.SetColumnSpan(this.btnEnter, 2);
            this.btnEnter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEnter.Location = new System.Drawing.Point(462, 536);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(178, 83);
            this.btnEnter.TabIndex = 16;
            this.btnEnter.Text = "Enter";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnBack
            // 
            this.btnBack.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnBack.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBack.Appearance.Options.UseBackColor = true;
            this.btnBack.Appearance.Options.UseFont = true;
            this.btnBack.Appearance.Options.UseForeColor = true;
            this.btnBack.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(370, 536);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 83);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "->>";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.dtEntryDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCurrency, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(361, 82);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // dtEntryDate
            // 
            this.dtEntryDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtEntryDate.EditValue = null;
            this.dtEntryDate.Enabled = false;
            this.dtEntryDate.Location = new System.Drawing.Point(184, 3);
            this.dtEntryDate.Name = "dtEntryDate";
            this.dtEntryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtEntryDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEntryDate.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.dtEntryDate.Properties.Appearance.Options.UseBackColor = true;
            this.dtEntryDate.Properties.Appearance.Options.UseFont = true;
            this.dtEntryDate.Properties.Appearance.Options.UseForeColor = true;
            this.dtEntryDate.Properties.AutoHeight = false;
            this.dtEntryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEntryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtEntryDate.Size = new System.Drawing.Size(174, 76);
            this.dtEntryDate.TabIndex = 0;
            // 
            // lblCurrency
            // 
            this.lblCurrency.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCurrency.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblCurrency.Appearance.Options.UseBackColor = true;
            this.lblCurrency.Appearance.Options.UseFont = true;
            this.lblCurrency.Appearance.Options.UseForeColor = true;
            this.lblCurrency.Appearance.Options.UseTextOptions = true;
            this.lblCurrency.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCurrency.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblCurrency.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrency.Enabled = false;
            this.lblCurrency.Location = new System.Drawing.Point(3, 3);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(175, 76);
            this.lblCurrency.TabIndex = 1;
            this.lblCurrency.Text = "دينار عراقي";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFinalTotal.Appearance.Font = new System.Drawing.Font("Segoe UI Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTotal.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblFinalTotal.Appearance.Options.UseBackColor = true;
            this.lblFinalTotal.Appearance.Options.UseFont = true;
            this.lblFinalTotal.Appearance.Options.UseForeColor = true;
            this.lblFinalTotal.Appearance.Options.UseTextOptions = true;
            this.lblFinalTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblFinalTotal.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblFinalTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFinalTotal.Location = new System.Drawing.Point(3, 625);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.tableLayoutPanel1.SetRowSpan(this.lblFinalTotal, 2);
            this.lblFinalTotal.Size = new System.Drawing.Size(361, 121);
            this.lblFinalTotal.TabIndex = 20;
            this.lblFinalTotal.Text = "0";
            // 
            // lblSaleMasterID
            // 
            this.lblSaleMasterID.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSaleMasterID.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleMasterID.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblSaleMasterID.Appearance.Options.UseBackColor = true;
            this.lblSaleMasterID.Appearance.Options.UseFont = true;
            this.lblSaleMasterID.Appearance.Options.UseForeColor = true;
            this.lblSaleMasterID.Appearance.Options.UseTextOptions = true;
            this.lblSaleMasterID.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSaleMasterID.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblSaleMasterID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSaleMasterID.Location = new System.Drawing.Point(370, 684);
            this.lblSaleMasterID.Name = "lblSaleMasterID";
            this.lblSaleMasterID.Size = new System.Drawing.Size(86, 62);
            this.lblSaleMasterID.TabIndex = 21;
            this.lblSaleMasterID.Text = "0";
            // 
            // lblItemQty
            // 
            this.lblItemQty.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblItemQty.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemQty.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblItemQty.Appearance.Options.UseBackColor = true;
            this.lblItemQty.Appearance.Options.UseFont = true;
            this.lblItemQty.Appearance.Options.UseForeColor = true;
            this.lblItemQty.Appearance.Options.UseTextOptions = true;
            this.lblItemQty.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblItemQty.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblItemQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemQty.Location = new System.Drawing.Point(462, 684);
            this.lblItemQty.Name = "lblItemQty";
            this.lblItemQty.Size = new System.Drawing.Size(86, 62);
            this.lblItemQty.TabIndex = 22;
            this.lblItemQty.Text = "0";
            // 
            // lblUsrname
            // 
            this.lblUsrname.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblUsrname.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsrname.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblUsrname.Appearance.Options.UseBackColor = true;
            this.lblUsrname.Appearance.Options.UseFont = true;
            this.lblUsrname.Appearance.Options.UseForeColor = true;
            this.lblUsrname.Appearance.Options.UseTextOptions = true;
            this.lblUsrname.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblUsrname.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblUsrname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsrname.Location = new System.Drawing.Point(554, 684);
            this.lblUsrname.Name = "lblUsrname";
            this.lblUsrname.Size = new System.Drawing.Size(86, 62);
            this.lblUsrname.TabIndex = 23;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseBackColor = true;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl6.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl6.Location = new System.Drawing.Point(554, 625);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(86, 53);
            this.labelControl6.TabIndex = 24;
            this.labelControl6.Text = "اسم البائع";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseBackColor = true;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl7.Location = new System.Drawing.Point(462, 625);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 53);
            this.labelControl7.TabIndex = 25;
            this.labelControl7.Text = "عدد الاصناف";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.Options.UseBackColor = true;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl8.Location = new System.Drawing.Point(370, 625);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(86, 53);
            this.labelControl8.TabIndex = 26;
            this.labelControl8.Text = "رقم الفاتورة";
            // 
            // btnNew
            // 
            this.btnNew.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNew.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnNew.Appearance.Options.UseBackColor = true;
            this.btnNew.Appearance.Options.UseFont = true;
            this.btnNew.Appearance.Options.UseForeColor = true;
            this.btnNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.ImageOptions.Image")));
            this.btnNew.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnNew.Location = new System.Drawing.Point(1136, 625);
            this.btnNew.Name = "btnNew";
            this.tableLayoutPanel1.SetRowSpan(this.btnNew, 2);
            this.btnNew.Size = new System.Drawing.Size(92, 121);
            this.btnNew.TabIndex = 27;
            this.btnNew.Text = "جديد";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "buy_16x16.png");
            // 
            // FRM_Sales
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 749);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FRM_Sales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة المبيعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_Sales_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tapItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSaleDetale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLSSaleDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraTab.XtraTabControl tapItems;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnSearche;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraGrid.GridControl gcSaleDetale;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSaleDetail;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraEditors.SimpleButton btn3;
        private DevExpress.XtraEditors.TextEdit txtQty;
        private DevExpress.XtraEditors.SimpleButton btn2;
        private DevExpress.XtraEditors.SimpleButton btn1;
        private DevExpress.XtraEditors.SimpleButton btn6;
        private DevExpress.XtraEditors.SimpleButton btn5;
        private DevExpress.XtraEditors.SimpleButton btn4;
        private DevExpress.XtraEditors.SimpleButton btn9;
        private DevExpress.XtraEditors.SimpleButton btn8;
        private DevExpress.XtraEditors.SimpleButton btn7;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnComma;
        private DevExpress.XtraEditors.SimpleButton btn0;
        private DevExpress.XtraEditors.SimpleButton btnEnter;
        private DevExpress.XtraEditors.SimpleButton btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.DateEdit dtEntryDate;
        private DevExpress.XtraEditors.LabelControl lblCurrency;
        private DevExpress.XtraEditors.LabelControl lblFinalTotal;
        private DevExpress.XtraEditors.LabelControl lblSaleMasterID;
        private DevExpress.XtraEditors.LabelControl lblItemQty;
        private DevExpress.XtraEditors.LabelControl lblUsrname;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private System.Windows.Forms.BindingSource cLSSaleDetailBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleDetailID;
        private DevExpress.XtraGrid.Columns.GridColumn colEntryDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colUnit;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colSaleMasterID;
        private DevExpress.Utils.ImageCollection imageCollection1;
    }
}