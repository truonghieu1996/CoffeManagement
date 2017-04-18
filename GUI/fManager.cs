using System;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;
using System.IO;
using DevExpress.LookAndFeel;

using DTO;
using BUS;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace GUI
{
    public partial class fManager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; DisplayAccount(loginAccount.TypeID); }
        }

        public fManager(Account loginAccount)
        {
            InitializeComponent();
            this.LoginAccount = loginAccount;
            LoadSkin();
        }

        DefaultLookAndFeel defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();

        private void LoadSkin()
        {
            //defaultLookAndFeel.LookAndFeel.SkinName = "Blue";
            BonusSkins.Register();
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGallery(ribbonGalleryBarItem1, true);

            string fileName = "Skins.txt";
            if (File.Exists(fileName) == false)
                defaultLookAndFeel.LookAndFeel.SetSkinStyle("Default");
            else
            {
                StreamReader sr = new StreamReader(fileName, false);
                defaultLookAndFeel.LookAndFeel.SetSkinStyle(sr.ReadLine());
                sr.Close();
            }
        }

        private void fManager_Load(object sender, EventArgs e)
        {
            ribbonPageGroupSystem.Text = loginAccount.DisplayName;
            bsTextDate.Caption = "Chào " + loginAccount.DisplayName;
        }

        private void DisplayAccount(int type)
        {
            ribbonPageManager.Visible = type == 1; // admin
        }

        private Form CheckFormExist(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }

        private void btnShowForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fMain));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fMain f = new fMain();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSendMail_ItemClick(object sender, ItemClickEventArgs e)
        {
            fSendMail f = new fSendMail();
            f.ShowDialog();
        }

        private void btnAccountInfo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fAccountInformation));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fAccountInformation f = new fAccountInformation(loginAccount);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnViewFood_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fFood));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fFood f = new fFood();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnViewCategoryFood_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fCategory));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fCategory f = new fCategory();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnViewTable_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fTable));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fTable f = new fTable();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnViewAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fAccount));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fAccount f = new fAccount();
                f.LoginUserName = loginAccount.UserName;
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnViewBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fBill));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fBill f = new fBill();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnStatistic_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            Form frm = this.CheckFormExist(typeof(fStatistic));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fStatistic f = new fStatistic();
                f.MdiParent = this;
                f.Show();
            }
            SplashScreenManager.CloseForm();
        }

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "BAK Files (.bak)|*.bak|All Files (*.*)|*.*";
            save.InitialDirectory = Directory.GetCurrentDirectory();

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    SecurityBUS.Instance.BackupData(save.FileName);
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Sao lưu thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Sao lưu thất bại!\nError: " + ex, "Lỗi");
                }
            }
        }

        private void btnRestore_ItemClick(object sender, ItemClickEventArgs e)
        {
            openFileDialogRestore.Filter = "bak File |*.bak";
            openFileDialogRestore.InitialDirectory = Directory.GetCurrentDirectory();

            if (openFileDialogRestore.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    SecurityBUS.Instance.RestoreData(openFileDialogRestore.FileName);
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Phục hồi thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Phục hồi thất bại!\nError: " + ex, "Lỗi");
                }
            }
        }

        private void btnLog_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(fLog));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                fLog f = new fLog();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void fManager_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                fManager_Load(sender, e);
        }

        private void fManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Log.WriteLog("----------" + loginAccount.UserName + " log out ----------");

            string skinsName = defaultLookAndFeel.LookAndFeel.SkinName;
            string fileName = "Skins.txt";
            StreamWriter sw = new StreamWriter(fileName, false);
            sw.WriteLine(skinsName);
            sw.Close();
        }
	}
}