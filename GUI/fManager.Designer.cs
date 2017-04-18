namespace GUI
{
    partial class fManager
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::GUI.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManager));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.btnShowForm = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnViewFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewCategoryFood = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewTable = new DevExpress.XtraBars.BarButtonItem();
            this.btnAccountInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnViewBill = new DevExpress.XtraBars.BarButtonItem();
            this.btnStatistic = new DevExpress.XtraBars.BarButtonItem();
            this.bsTextDate = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonGalleryBarItem1 = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnLog = new DevExpress.XtraBars.BarButtonItem();
            this.btnSendMail = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageManager = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCateogry = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupStatictis = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.openFileDialogRestore = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // ribbon
            // 
            this.ribbon.ApplicationButtonDropDownControl = this.applicationMenu1;
            this.ribbon.ApplicationIcon = global::GUI.Properties.Resources.Uiconstock_Dynamic_Flat_Android_Coffee;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnShowForm,
            this.barSubItem1,
            this.btnViewFood,
            this.btnViewCategoryFood,
            this.btnViewTable,
            this.btnAccountInfo,
            this.btnLogOut,
            this.btnViewAccount,
            this.btnViewBill,
            this.btnStatistic,
            this.bsTextDate,
            this.ribbonGalleryBarItem1,
            this.btnBackup,
            this.btnRestore,
            this.btnLog,
            this.btnSendMail});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage,
            this.ribbonPageManager});
            this.ribbon.Size = new System.Drawing.Size(975, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // btnShowForm
            // 
            this.btnShowForm.Caption = "Tác vụ";
            this.btnShowForm.Id = 2;
            this.btnShowForm.LargeGlyph = global::GUI.Properties.Resources.icon_developer_icon;
            this.btnShowForm.LargeWidth = 75;
            this.btnShowForm.Name = "btnShowForm";
            this.btnShowForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnShowForm_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 3;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnViewFood
            // 
            this.btnViewFood.Caption = "Thực đơn";
            this.btnViewFood.Id = 4;
            this.btnViewFood.LargeGlyph = global::GUI.Properties.Resources.Food_Coffee_icon;
            this.btnViewFood.LargeWidth = 75;
            this.btnViewFood.Name = "btnViewFood";
            this.btnViewFood.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewFood_ItemClick);
            // 
            // btnViewCategoryFood
            // 
            this.btnViewCategoryFood.Caption = "Danh mục";
            this.btnViewCategoryFood.Id = 5;
            this.btnViewCategoryFood.LargeGlyph = global::GUI.Properties.Resources.Ecommerce_Bill_icon;
            this.btnViewCategoryFood.LargeWidth = 75;
            this.btnViewCategoryFood.Name = "btnViewCategoryFood";
            this.btnViewCategoryFood.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewCategoryFood_ItemClick);
            // 
            // btnViewTable
            // 
            this.btnViewTable.Caption = "Bàn";
            this.btnViewTable.Id = 6;
            this.btnViewTable.LargeGlyph = global::GUI.Properties.Resources.Household_Table_icon;
            this.btnViewTable.LargeWidth = 75;
            this.btnViewTable.Name = "btnViewTable";
            this.btnViewTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewTable_ItemClick);
            // 
            // btnAccountInfo
            // 
            this.btnAccountInfo.Caption = "Thông tin tài khoản";
            this.btnAccountInfo.Id = 7;
            this.btnAccountInfo.LargeGlyph = global::GUI.Properties.Resources.user_info_icon;
            this.btnAccountInfo.LargeWidth = 75;
            this.btnAccountInfo.Name = "btnAccountInfo";
            this.btnAccountInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccountInfo_ItemClick);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng xuất";
            this.btnLogOut.Id = 8;
            this.btnLogOut.LargeGlyph = global::GUI.Properties.Resources.logout_icon;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // btnViewAccount
            // 
            this.btnViewAccount.Caption = "Tài khoản";
            this.btnViewAccount.Id = 9;
            this.btnViewAccount.LargeGlyph = global::GUI.Properties.Resources.User_Group_icon;
            this.btnViewAccount.LargeWidth = 75;
            this.btnViewAccount.Name = "btnViewAccount";
            this.btnViewAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewAccount_ItemClick);
            // 
            // btnViewBill
            // 
            this.btnViewBill.Caption = "Doanh thu";
            this.btnViewBill.Id = 10;
            this.btnViewBill.LargeGlyph = global::GUI.Properties.Resources.Cash_icon;
            this.btnViewBill.LargeWidth = 75;
            this.btnViewBill.Name = "btnViewBill";
            this.btnViewBill.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnViewBill_ItemClick);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Caption = "Thống kê";
            this.btnStatistic.Id = 11;
            this.btnStatistic.LargeGlyph = global::GUI.Properties.Resources.Presentation_icon;
            this.btnStatistic.LargeWidth = 75;
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStatistic_ItemClick);
            // 
            // bsTextDate
            // 
            this.bsTextDate.Caption = "barStaticItem1";
            this.bsTextDate.Id = 12;
            this.bsTextDate.Name = "bsTextDate";
            this.bsTextDate.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonGalleryBarItem1
            // 
            this.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1";
            this.ribbonGalleryBarItem1.Id = 13;
            this.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1";
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao Lưu";
            this.btnBackup.Id = 14;
            this.btnBackup.LargeGlyph = global::GUI.Properties.Resources.Backup_restore_icon;
            this.btnBackup.LargeWidth = 75;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục hồi";
            this.btnRestore.Id = 15;
            this.btnRestore.LargeGlyph = global::GUI.Properties.Resources.Folder_URL_History_icon;
            this.btnRestore.LargeWidth = 75;
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // btnLog
            // 
            this.btnLog.Caption = "Nhật ký hệ thống";
            this.btnLog.Id = 16;
            this.btnLog.LargeGlyph = global::GUI.Properties.Resources.Apps_preferences_system_time_icon;
            this.btnLog.LargeWidth = 75;
            this.btnLog.Name = "btnLog";
            this.btnLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLog_ItemClick);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Caption = "Gửi báo cáo";
            this.btnSendMail.Id = 17;
            this.btnSendMail.LargeGlyph = global::GUI.Properties.Resources.email_send_icon;
            this.btnSendMail.LargeWidth = 75;
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSendMail_ItemClick);
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroupSystem,
            this.ribbonPageGroup2});
            this.ribbonPage.Name = "ribbonPage";
            this.ribbonPage.Text = "Chức năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnShowForm);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Chức năng";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSendMail);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Báo cáo";
            // 
            // ribbonPageGroupSystem
            // 
            this.ribbonPageGroupSystem.ItemLinks.Add(this.btnAccountInfo);
            this.ribbonPageGroupSystem.ItemLinks.Add(this.btnLogOut);
            this.ribbonPageGroupSystem.Name = "ribbonPageGroupSystem";
            this.ribbonPageGroupSystem.Text = "Hệ thống";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.ribbonGalleryBarItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Giao diện";
            // 
            // ribbonPageManager
            // 
            this.ribbonPageManager.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCateogry,
            this.ribbonPageGroupStatictis,
            this.ribbonPageGroup3});
            this.ribbonPageManager.Name = "ribbonPageManager";
            this.ribbonPageManager.Text = "Quản lý";
            // 
            // ribbonPageGroupCateogry
            // 
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.btnViewFood);
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.btnViewCategoryFood);
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.btnViewTable);
            this.ribbonPageGroupCateogry.ItemLinks.Add(this.btnViewAccount);
            this.ribbonPageGroupCateogry.Name = "ribbonPageGroupCateogry";
            this.ribbonPageGroupCateogry.Text = "Danh mục";
            // 
            // ribbonPageGroupStatictis
            // 
            this.ribbonPageGroupStatictis.ItemLinks.Add(this.btnViewBill);
            this.ribbonPageGroupStatictis.ItemLinks.Add(this.btnStatistic);
            this.ribbonPageGroupStatictis.Name = "ribbonPageGroupStatictis";
            this.ribbonPageGroupStatictis.Text = "Thống kê";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBackup);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnRestore);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnLog);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Bảo mật";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsTextDate);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 502);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(975, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // fManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 533);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "fManager";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "QUẢN LÝ QUÁN CAFE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fManager_FormClosing);
            this.Load += new System.EventHandler(this.fManager_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fManager_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageManager;
        private DevExpress.XtraBars.BarButtonItem btnShowForm;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnViewFood;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCateogry;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupStatictis;
        private DevExpress.XtraBars.BarButtonItem btnViewCategoryFood;
        private DevExpress.XtraBars.BarButtonItem btnViewTable;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarButtonItem btnAccountInfo;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnViewAccount;
        private DevExpress.XtraBars.BarButtonItem btnViewBill;
        private DevExpress.XtraBars.BarButtonItem btnStatistic;
        private DevExpress.XtraBars.BarStaticItem bsTextDate;
        private DevExpress.XtraBars.RibbonGalleryBarItem ribbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
		private DevExpress.XtraBars.BarButtonItem btnBackup;
		private DevExpress.XtraBars.BarButtonItem btnRestore;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
		private System.Windows.Forms.OpenFileDialog openFileDialogRestore;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DevExpress.XtraBars.BarButtonItem btnLog;
        private DevExpress.XtraBars.BarButtonItem btnSendMail;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
	}
}