namespace WindowsFormsApplication.View
{
    partial class NwPatientVisitSummaryReport
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
            this.patientVisitSummaryReport = new WindowsFormsApplication.PatientVisitSummaryReport();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new WindowsFormsApplication.PatientVisitSummaryReportTableAdapters.patientsTableAdapter();
            this.patientVisitSummaryReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.patientsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication.View.NwPatientVisitSummary.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(776, 361);
            this.reportViewer1.TabIndex = 0;
            // 
            // patientVisitSummaryReport
            // 
            this.patientVisitSummaryReport.DataSetName = "PatientVisitSummaryReport";
            this.patientVisitSummaryReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.patientVisitSummaryReport;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // patientVisitSummaryReportBindingSource
            // 
            this.patientVisitSummaryReportBindingSource.DataSource = this.patientVisitSummaryReport;
            this.patientVisitSummaryReportBindingSource.Position = 0;
            // 
            // NwPatientVisitSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 361);
            this.Controls.Add(this.reportViewer1);
            this.Name = "NwPatientVisitSummaryReport";
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.PatientVisitSummaryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private PatientVisitSummaryReport patientVisitSummaryReport;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PatientVisitSummaryReportTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource patientVisitSummaryReportBindingSource;
    }
}