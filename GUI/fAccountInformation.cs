using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

using DTO;
using BUS;

namespace GUI
{
    public partial class fAccountInformation : DevExpress.XtraEditors.XtraForm
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public fAccountInformation(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txtUserName.Text = acc.UserName;
            txtDisplayName.Text = acc.DisplayName;
        }

        private void UpdateAccount()
        {
            string displayName = txtDisplayName.Text;
            string password = txtPassword.Text;
            string newPass = txtNewPassword.Text;
            string retypePass = txtReTypePass.Text;
            string userName = txtUserName.Text;

            if (!newPass.Equals(retypePass))
                MessageBox.Show("Mật khẩu nhập lại không đúng");
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                if (AccountBUS.Instance.UpdateInformation(userName, displayName, password, newPass))
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Cập nhật thành công");
                    Log.WriteLog("change account's information");
                }
                else
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}