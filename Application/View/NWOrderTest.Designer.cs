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
            System.Windows.Forms.Label last_nameLabel;
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxTest = new System.Windows.Forms.ComboBox();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientVisitSummaryReport = new WindowsFormsApplication.PatientVisitSummaryReport();
            this.labelTest = new System.Windows.Forms.Label();
            this.testsTableAdapter = new WindowsFormsApplication.PatientVisitSummaryReportTableAdapters.testsTableAdapter();
            this.patientVisitSummaryReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_testsTableAdapter = new WindowsFormsApplication.PatientVisitDataSetTableAdapters.patient_testsTableAdapter();
            this.patienttestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientVisitDataSet = new WindowsFormsApplication.PatientVisitDataSet();
            this.patientsDataSet = new WindowsFormsApplication.PatientsDataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new WindowsFormsApplication.PatientsDataSetTableAdapters.patientsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication.PatientsDataSetTableAdapters.TableAdapterManager();
            this.last_nameLabel1 = new System.Windows.Forms.Label();
            this.first_nameLabel1 = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patienttestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(12, 21);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(43, 13);
            last_nameLabel.TabIndex = 20;
            last_nameLabel.Text = "Patient:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.AutoSize = true;
            this.buttonSubmit.Location = new System.Drawing.Point(40, 91);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
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
            this.buttonCancel.Location = new System.Drawing.Point(130, 91);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
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
            this.comboBoxTest.Location = new System.Drawing.Point(51, 48);
            this.comboBoxTest.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTest.Name = "comboBoxTest";
            this.comboBoxTest.Size = new System.Drawing.Size(148, 21);
            this.comboBoxTest.TabIndex = 15;
            this.comboBoxTest.ValueMember = "testID";
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "tests";
            this.testsBindingSource.DataSource = this.patientVisitSummaryReport;
            // 
            // patientVisitSummaryReport
            // 
            this.patientVisitSummaryReport.DataSetName = "PatientVisitSummaryReport";
            this.patientVisitSummaryReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(12, 50);
            this.labelTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(31, 13);
            this.labelTest.TabIndex = 16;
            this.labelTest.Text = "Test:";
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
            // patientsDataSet
            // 
            this.patientsDataSet.DataSetName = "PatientsDataSet";
            this.patientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.patientsDataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.patient_allergiesTableAdapter = null;
            this.tableAdapterManager.patientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication.PatientsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // last_nameLabel1
            // 
            this.last_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "last_name", true));
            this.last_nameLabel1.Location = new System.Drawing.Point(132, 21);
            this.last_nameLabel1.Name = "last_nameLabel1";
            this.last_nameLabel1.Size = new System.Drawing.Size(67, 23);
            this.last_nameLabel1.TabIndex = 21;
            this.last_nameLabel1.Text = "****";
            // 
            // first_nameLabel1
            // 
            this.first_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "first_name", true));
            this.first_nameLabel1.Location = new System.Drawing.Point(61, 21);
            this.first_nameLabel1.Name = "first_nameLabel1";
            this.first_nameLabel1.Size = new System.Drawing.Size(65, 23);
            this.first_nameLabel1.TabIndex = 22;
            this.first_nameLabel1.Text = "****";
            // 
            // NwOrderTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 138);
            this.Controls.Add(this.first_nameLabel1);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameLabel1);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.comboBoxTest);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NwOrderTest";
            this.Text = "Order Test";
            this.Load += new System.EventHandler(this.NwOrderTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patienttestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox comboBoxTest;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private PatientVisitSummaryReportTableAdapters.testsTableAdapter testsTableAdapter;
        private PatientVisitSummaryReport patientVisitSummaryReport;
        private System.Windows.Forms.BindingSource patientVisitSummaryReportBindingSource;
        private PatientVisitDataSetTableAdapters.patient_testsTableAdapter patient_testsTableAdapter;
        private System.Windows.Forms.BindingSource patienttestsBindingSource;
        private PatientVisitDataSet patientVisitDataSet;
        private PatientsDataSet patientsDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PatientsDataSetTableAdapters.patientsTableAdapter patientsTableAdapter;
        private PatientsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label last_nameLabel1;
        private System.Windows.Forms.Label first_nameLabel1;
    }
}