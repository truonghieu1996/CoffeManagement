using System;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraSplashScreen;

using BUS;

namespace GUI
{
    public partial class fSendMail : DevExpress.XtraEditors.XtraForm
    {
        public fSendMail()
        {
            InitializeComponent();
            hyperlinkLabelControl.Text = "Truy cập <href=https://www.google.com/settings/u/1/security/lesssecureapps >đường dẫn</href>";
            hyperlinkLabelControl.HyperlinkClick += hyperlinkLabelControl_HyperlinkClick;
        }

        void hyperlinkLabelControl_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            hyperlinkLabelControl.LinkVisited = true;
            System.Diagnostics.Process.Start(e.Link);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            if (txtEmailSend.Text == "" || txtPassword.Text == "" || txtReceiveEmail.Text == "")
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi");
                return;
            }
            if (!txtEmailSend.Text.Contains("gmail.com"))
            {
                XtraMessageBox.Show("Email gửi không hợp lệ", "Lỗi");
                return;
            }
            if (!txtReceiveEmail.Text.Contains("gmail.com"))
            {
                XtraMessageBox.Show("Email nhận không hợp lệ", "Lỗi");
                return;
            }

            Mail mail = new Mail(txtEmailSend.Text, txtPassword.Text, txtReceiveEmail.Text);
            mail.SendMail(cmbLisfFile.SelectedText);

            SplashScreenManager.CloseForm();
            XtraMessageBox.Show("Gửi thành công", "Thông báo");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fSendMail_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles("*.log");

            foreach (FileInfo item in files)
                cmbLisfFile.Properties.Items.Add(item);
        }
    }
}