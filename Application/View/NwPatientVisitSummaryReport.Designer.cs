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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.patientVisitSummaryReport = new WindowsFormsApplication.PatientVisitSummaryReport();
            this.patientvisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_visitTableAdapter = new WindowsFormsApplication.PatientVisitSummaryReportTableAdapters.patient_visitTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientvisitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            reportDataSource2.Name = "VisitDataSet";
            reportDataSource2.Value = this.patientvisitBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication.View.NwPatientVisitSummaryReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(832, 340);
            this.reportViewer1.TabIndex = 0;
            // 
            // patientVisitSummaryReport
            // 
            this.patientVisitSummaryReport.DataSetName = "PatientVisitSummaryReport";
            this.patientVisitSummaryReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientvisitBindingSource
            // 
            this.patientvisitBindingSource.DataMember = "patient_visit";
            this.patientvisitBindingSource.DataSource = this.patientVisitSummaryReport;
            // 
            // patient_visitTableAdapter
            // 
            this.patient_visitTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a date range:";
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(156, 7);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 20);
            this.date1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "to";
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(384, 7);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 20);
            this.date2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NwPatientVisitSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "NwPatientVisitSummaryReport";
            this.Text = "Summary";
            this.Load += new System.EventHandler(this.PatientVisitSummaryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientvisitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource patientvisitBindingSource;
        private PatientVisitSummaryReport patientVisitSummaryReport;
        private PatientVisitSummaryReportTableAdapters.patient_visitTableAdapter patient_visitTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Button button1;
    }
}