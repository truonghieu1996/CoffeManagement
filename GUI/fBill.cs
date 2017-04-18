using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

using BUS;

namespace GUI
{
    public partial class fBill : DevExpress.XtraEditors.XtraForm
    {
        public fBill()
        {
            InitializeComponent();
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            deFromDate.EditValue = new DateTime(today.Year, today.Month, 1);
            deToDate.EditValue = deFromDate.DateTime.AddMonths(1).AddDays(-1);
            btnRemove.Enabled = false;
        }

        private void btnShowBill_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            LoadListBillByDate((DateTime)deFromDate.EditValue, (DateTime)deToDate.EditValue);
            SplashScreenManager.CloseForm();
        }

        void LoadListBillByDate(DateTime fromDate, DateTime toDate)
        {
            try
            {
                gcBill.DataSource = BillBUS.Instance.GetListBillByDate(fromDate, toDate);
                gvBill.Columns[0].Caption = "Mã hóa đơn";
                gvBill.Columns[1].Caption = "Tên bàn";
                gvBill.Columns[2].Caption = "Ngày vào";
                gvBill.Columns[3].Caption = "Giảm giá";
                gvBill.Columns[4].Caption = "Tổng tiền";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }

        private void gvBill_DoubleClick(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            int id = (int)gvBill.GetRowCellValue(gvBill.FocusedRowHandle, gvBill.Columns[0]);

            if (XtraMessageBox.Show("Xóa hóa đơn " + id + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    BillInfoBUS.Instance.DeleteBillInfoByBillID(id);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Error: " + ex);
                }

                if (BillBUS.Instance.DeleteBill(id))
                {
                    btnShowBill_Click(sender, e);
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
                    Log.WriteLog("delete Bill, ID = " + id);
                }
                else
                    XtraMessageBox.Show("Không thể xóa hóa đơn", "Lỗi");
            }
            btnRemove.Enabled = false;
        }
    }
}