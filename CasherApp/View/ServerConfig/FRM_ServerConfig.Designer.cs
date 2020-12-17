namespace CasherApp.View.ServerConfig
{
    partial class FRM_ServerConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ServerConfig));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textEditServerName = new DevExpress.XtraEditors.TextEdit();
            this.textEditDatabseName = new DevExpress.XtraEditors.TextEdit();
            this.textEditUsername = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroupConnectionMode = new DevExpress.XtraEditors.RadioGroup();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonSaveSettings = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDatabseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupConnectionMode.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(541, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.tableLayoutPanel2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.LookAndFeel.SkinName = "The Bezier";
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(535, 405);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Server Configuration";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.39421F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.60579F));
            this.tableLayoutPanel2.Controls.Add(this.textEditServerName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textEditDatabseName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textEditUsername, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textEditPassword, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelControl4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelControl5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.radioGroupConnectionMode, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(531, 370);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // textEditServerName
            // 
            this.textEditServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditServerName.Location = new System.Drawing.Point(148, 3);
            this.textEditServerName.Name = "textEditServerName";
            this.textEditServerName.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditServerName.Properties.Appearance.Options.UseFont = true;
            this.textEditServerName.Properties.AutoHeight = false;
            this.textEditServerName.Size = new System.Drawing.Size(380, 38);
            this.textEditServerName.TabIndex = 0;
            // 
            // textEditDatabseName
            // 
            this.textEditDatabseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditDatabseName.Location = new System.Drawing.Point(148, 47);
            this.textEditDatabseName.Name = "textEditDatabseName";
            this.textEditDatabseName.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditDatabseName.Properties.Appearance.Options.UseFont = true;
            this.textEditDatabseName.Properties.AutoHeight = false;
            this.textEditDatabseName.Size = new System.Drawing.Size(380, 38);
            this.textEditDatabseName.TabIndex = 1;
            // 
            // textEditUsername
            // 
            this.textEditUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditUsername.Enabled = false;
            this.textEditUsername.Location = new System.Drawing.Point(148, 202);
            this.textEditUsername.Name = "textEditUsername";
            this.textEditUsername.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditUsername.Properties.Appearance.Options.UseFont = true;
            this.textEditUsername.Properties.AutoHeight = false;
            this.textEditUsername.Size = new System.Drawing.Size(380, 38);
            this.textEditUsername.TabIndex = 2;
            // 
            // textEditPassword
            // 
            this.textEditPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditPassword.Enabled = false;
            this.textEditPassword.Location = new System.Drawing.Point(148, 246);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditPassword.Properties.Appearance.Options.UseFont = true;
            this.textEditPassword.Properties.AutoHeight = false;
            this.textEditPassword.Size = new System.Drawing.Size(380, 38);
            this.textEditPassword.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(46, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 19);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Server Name :";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(115, 19);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Database Name :";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(20, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(122, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Connection Mode";
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(66, 211);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 19);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Username :";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(69, 255);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(73, 19);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Password :";
            // 
            // radioGroupConnectionMode
            // 
            this.radioGroupConnectionMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioGroupConnectionMode.Location = new System.Drawing.Point(148, 91);
            this.radioGroupConnectionMode.Name = "radioGroupConnectionMode";
            this.radioGroupConnectionMode.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroupConnectionMode.Properties.Appearance.Options.UseFont = true;
            this.radioGroupConnectionMode.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Windows Authentication"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "SQL Authentication")});
            this.radioGroupConnectionMode.Size = new System.Drawing.Size(380, 105);
            this.radioGroupConnectionMode.TabIndex = 9;
            this.radioGroupConnectionMode.SelectedIndexChanged += new System.EventHandler(this.radioGroupConnectionMode_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.simpleButtonCancel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.simpleButtonSaveSettings, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(240, 290);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.78378F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.21622F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(288, 77);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonCancel.Appearance.Options.UseFont = true;
            this.simpleButtonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonCancel.ImageOptions.Image")));
            this.simpleButtonCancel.Location = new System.Drawing.Point(147, 29);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(138, 45);
            this.simpleButtonCancel.TabIndex = 0;
            this.simpleButtonCancel.Text = "Cancel";
            // 
            // simpleButtonSaveSettings
            // 
            this.simpleButtonSaveSettings.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButtonSaveSettings.Appearance.Options.UseFont = true;
            this.simpleButtonSaveSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButtonSaveSettings.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSaveSettings.ImageOptions.Image")));
            this.simpleButtonSaveSettings.Location = new System.Drawing.Point(3, 29);
            this.simpleButtonSaveSettings.Name = "simpleButtonSaveSettings";
            this.simpleButtonSaveSettings.Size = new System.Drawing.Size(138, 45);
            this.simpleButtonSaveSettings.TabIndex = 1;
            this.simpleButtonSaveSettings.TabStop = false;
            this.simpleButtonSaveSettings.Text = "Save Settings";
            this.simpleButtonSaveSettings.Click += new System.EventHandler(this.simpleButtonSaveSettings_Click);
            // 
            // FRM_ServerConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.LookAndFeel.SkinName = "The Bezier";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ServerConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDatabseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupConnectionMode.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.TextEdit textEditServerName;
        private DevExpress.XtraEditors.TextEdit textEditDatabseName;
        private DevExpress.XtraEditors.TextEdit textEditUsername;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.RadioGroup radioGroupConnectionMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSaveSettings;
    }
}