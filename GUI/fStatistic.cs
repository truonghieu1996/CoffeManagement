using System;

namespace GUI
{
    public partial class fStatistic : DevExpress.XtraEditors.XtraForm
    {
        public fStatistic()
        {
            InitializeComponent();
        }

        private void fStatistic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeManagementDataSet.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter.Fill(this.coffeeManagementDataSet.Bill);
        }
    }
}