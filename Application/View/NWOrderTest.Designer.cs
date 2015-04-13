namespace WindowsFormsApplication.View
{
    partial class NwOrderTest
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxTest = new System.Windows.Forms.ComboBox();
            this.labelTest = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVisitID = new System.Windows.Forms.TextBox();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsTableAdapter = new WindowsFormsApplication.PatientVisitSummaryReportTableAdapters.testsTableAdapter();
            this.patientVisitSummaryReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientVisitSummaryReport = new WindowsFormsApplication.PatientVisitSummaryReport();
            this.patient_testsTableAdapter = new WindowsFormsApplication.PatientVisitDataSetTableAdapters.patient_testsTableAdapter();
            this.patienttestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientVisitDataSet = new WindowsFormsApplication.PatientVisitDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patienttestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.AutoSize = true;
            this.buttonSubmit.Location = new System.Drawing.Point(70, 155);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(56, 23);
            this.buttonSubmit.TabIndex = 13;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.Location = new System.Drawing.Point(160, 155);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxTest
            // 
            this.comboBoxTest.DataSource = this.testsBindingSource;
            this.comboBoxTest.DisplayMember = "test_name";
            this.comboBoxTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTest.FormattingEnabled = true;
            this.comboBoxTest.Location = new System.Drawing.Point(68, 94);
            this.comboBoxTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTest.Name = "comboBoxTest";
            this.comboBoxTest.Size = new System.Drawing.Size(148, 21);
            this.comboBoxTest.TabIndex = 15;
            this.comboBoxTest.ValueMember = "testID";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(29, 96);
            this.labelTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(31, 13);
            this.labelTest.TabIndex = 16;
            this.labelTest.Text = "Test:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Visit ID:";
            // 
            // textBoxVisitID
            // 
            this.textBoxVisitID.Location = new System.Drawing.Point(96, 31);
            this.textBoxVisitID.Name = "textBoxVisitID";
            this.textBoxVisitID.ReadOnly = true;
            this.textBoxVisitID.Size = new System.Drawing.Size(100, 20);
            this.textBoxVisitID.TabIndex = 20;
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "tests";
            this.testsBindingSource.DataSource = this.patientVisitSummaryReport;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // patientVisitSummaryReportBindingSource
            // 
            this.patientVisitSummaryReportBindingSource.DataSource = this.patientVisitSummaryReport;
            this.patientVisitSummaryReportBindingSource.Position = 0;
            // 
            // patientVisitSummaryReport
            // 
            this.patientVisitSummaryReport.DataSetName = "PatientVisitSummaryReport";
            this.patientVisitSummaryReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patient_testsTableAdapter
            // 
            this.patient_testsTableAdapter.ClearBeforeFill = true;
            // 
            // patienttestsBindingSource
            // 
            this.patienttestsBindingSource.DataMember = "patient_tests";
            this.patienttestsBindingSource.DataSource = this.patientVisitDataSet;
            // 
            // patientVisitDataSet
            // 
            this.patientVisitDataSet.DataSetName = "PatientVisitDataSet";
            this.patientVisitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NwOrderTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 201);
            this.Controls.Add(this.textBoxVisitID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.comboBoxTest);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NwOrderTest";
            this.Text = "Order Test";
            this.Load += new System.EventHandler(this.NwOrderTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patienttestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxTest;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVisitID;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private PatientVisitSummaryReportTableAdapters.testsTableAdapter testsTableAdapter;
        private PatientVisitSummaryReport patientVisitSummaryReport;
        private System.Windows.Forms.BindingSource patientVisitSummaryReportBindingSource;
        private PatientVisitDataSetTableAdapters.patient_testsTableAdapter patient_testsTableAdapter;
        private System.Windows.Forms.BindingSource patienttestsBindingSource;
        private PatientVisitDataSet patientVisitDataSet;
    }
}