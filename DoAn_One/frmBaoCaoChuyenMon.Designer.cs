namespace DoAn_One
{
    partial class frmBaoCaoChuyenMon
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
            this.View_ChuyenMonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLNSuDataSet1 = new DoAn_One.QLNSuDataSet1();
            this.rpvChuyenMon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.View_ChuyenMonTableAdapter = new DoAn_One.QLNSuDataSet1TableAdapters.View_ChuyenMonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_ChuyenMonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNSuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // View_ChuyenMonBindingSource
            // 
            this.View_ChuyenMonBindingSource.DataMember = "View_ChuyenMon";
            this.View_ChuyenMonBindingSource.DataSource = this.QLNSuDataSet1;
            // 
            // QLNSuDataSet1
            // 
            this.QLNSuDataSet1.DataSetName = "QLNSuDataSet1";
            this.QLNSuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvChuyenMon
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_ChuyenMonBindingSource;
            this.rpvChuyenMon.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvChuyenMon.LocalReport.ReportEmbeddedResource = "DoAn_One.ReportChuyenMon.rdlc";
            this.rpvChuyenMon.Location = new System.Drawing.Point(0, 94);
            this.rpvChuyenMon.Name = "rpvChuyenMon";
            this.rpvChuyenMon.ServerReport.BearerToken = null;
            this.rpvChuyenMon.Size = new System.Drawing.Size(1262, 494);
            this.rpvChuyenMon.TabIndex = 0;
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Location = new System.Drawing.Point(468, 12);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(141, 40);
            this.btnTaoBaoCao.TabIndex = 3;
            this.btnTaoBaoCao.Text = "Tạo Báo Cáo";
            this.btnTaoBaoCao.UseVisualStyleBackColor = true;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.btnTaoBaoCao_Click);
            // 
            // View_ChuyenMonTableAdapter
            // 
            this.View_ChuyenMonTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 600);
            this.Controls.Add(this.btnTaoBaoCao);
            this.Controls.Add(this.rpvChuyenMon);
            this.Name = "frmBaoCaoChuyenMon";
            this.Text = "frmBaoCaoChuyenMon";
            this.Load += new System.EventHandler(this.frmBaoCaoChuyenMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_ChuyenMonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNSuDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvChuyenMon;
        private System.Windows.Forms.Button btnTaoBaoCao;
        private System.Windows.Forms.BindingSource View_ChuyenMonBindingSource;
        private QLNSuDataSet1 QLNSuDataSet1;
        private QLNSuDataSet1TableAdapters.View_ChuyenMonTableAdapter View_ChuyenMonTableAdapter;
    }
}