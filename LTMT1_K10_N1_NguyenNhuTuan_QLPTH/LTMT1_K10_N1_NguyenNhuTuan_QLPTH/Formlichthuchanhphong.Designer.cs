namespace LTMT1_K10_N1_NguyenNhuTuan_QLPTH
{
    partial class Formlichthuchanhphong
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSet = new LTMT1_K10_N1_NguyenNhuTuan_QLPTH.LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSet();
            this.thuchanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thuchanhTableAdapter = new LTMT1_K10_N1_NguyenNhuTuan_QLPTH.LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSetTableAdapters.thuchanhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuchanhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetlichthuchanhphong";
            reportDataSource1.Value = this.thuchanhBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "LTMT1_K10_N1_NguyenNhuTuan_QLPTH.Reportlichthuchanhphong.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(601, 510);
            this.reportViewer1.TabIndex = 0;
            // 
            // LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSet
            // 
            this.LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSet.DataSetName = "LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSet";
            this.LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thuchanhBindingSource
            // 
            this.thuchanhBindingSource.DataMember = "thuchanh";
            this.thuchanhBindingSource.DataSource = this.LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSet;
            // 
            // thuchanhTableAdapter
            // 
            this.thuchanhTableAdapter.ClearBeforeFill = true;
            // 
            // Formlichthuchanhphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 510);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Formlichthuchanhphong";
            this.Text = "Formlichthuchanhphong";
            this.Load += new System.EventHandler(this.Formlichthuchanhphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thuchanhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource thuchanhBindingSource;
        private LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSet LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSet;
        private LTMT1_K10_N1_NguyenNhuTuan_QLPTHDataSetTableAdapters.thuchanhTableAdapter thuchanhTableAdapter;
    }
}