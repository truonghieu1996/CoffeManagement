namespace GUI
{
    partial class fStatistic
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartBill = new DevExpress.XtraCharts.ChartControl();
            this.coffeeManagementDataSet = new GUI.CoffeeManagementDataSet();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billTableAdapter = new GUI.CoffeeManagementDataSetTableAdapters.BillTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chartBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartBill
            // 
            this.chartBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartBill.DataAdapter = this.billTableAdapter;
            this.chartBill.DataSource = this.billBindingSource;
            xyDiagram1.AxisX.Title.Alignment = System.Drawing.StringAlignment.Far;
            xyDiagram1.AxisX.Title.Text = "Thời gian";
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Alignment = System.Drawing.StringAlignment.Far;
            xyDiagram1.AxisY.Title.Text = "Doanh thu (VND)";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartBill.Diagram = xyDiagram1;
            this.chartBill.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartBill.Location = new System.Drawing.Point(2, 1);
            this.chartBill.Name = "chartBill";
            series1.ArgumentDataMember = "CheckIn";
            series1.Name = "Doanh thu";
            series1.ValueDataMembersSerializable = "TotalPrice";
            this.chartBill.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartBill.Size = new System.Drawing.Size(692, 421);
            this.chartBill.TabIndex = 0;
            chartTitle1.Text = "Thống kê doanh thu";
            this.chartBill.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // coffeeManagementDataSet
            // 
            this.coffeeManagementDataSet.DataSetName = "CoffeeManagementDataSet";
            this.coffeeManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "Bill";
            this.billBindingSource.DataSource = this.coffeeManagementDataSet;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // fStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 422);
            this.Controls.Add(this.chartBill);
            this.Name = "fStatistic";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.fStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartBill;
        private CoffeeManagementDataSetTableAdapters.BillTableAdapter billTableAdapter;
        private CoffeeManagementDataSet coffeeManagementDataSet;
        private System.Windows.Forms.BindingSource billBindingSource;
    }
}