namespace WindowsFormsApplication.View
{
    partial class NwViewVisits
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.patient_visitDataGridView = new System.Windows.Forms.DataGridView();
            this.patient_visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientVisitDataSet = new WindowsFormsApplication.PatientVisitDataSet();
            this.patient_visitTableAdapter = new WindowsFormsApplication.PatientVisitDataSetTableAdapters.patient_visitTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication.PatientVisitDataSetTableAdapters.TableAdapterManager();
            this.patientVisitDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsDataSet = new WindowsFormsApplication.PatientsDataSet();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new WindowsFormsApplication.PatientsDataSetTableAdapters.patientsTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApplication.PatientsDataSetTableAdapters.TableAdapterManager();
            this.first_nameLabel1 = new System.Windows.Forms.Label();
            this.last_nameLabel1 = new System.Windows.Forms.Label();
            this.dobLabel1 = new System.Windows.Forms.Label();
            this.fillByPatientInfoToolStrip = new System.Windows.Forms.ToolStrip();
            this.patientIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.patientIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByPatientInfoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.fillByPatientInfoToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visits For:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DOB:";
            // 
            // patient_visitDataGridView
            // 
            this.patient_visitDataGridView.AllowUserToAddRows = false;
            this.patient_visitDataGridView.AllowUserToDeleteRows = false;
            this.patient_visitDataGridView.AutoGenerateColumns = false;
            this.patient_visitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patient_visitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.patient_visitDataGridView.DataSource = this.patient_visitBindingSource;
            this.patient_visitDataGridView.Location = new System.Drawing.Point(6, 62);
            this.patient_visitDataGridView.Name = "patient_visitDataGridView";
            this.patient_visitDataGridView.ReadOnly = true;
            this.patient_visitDataGridView.Size = new System.Drawing.Size(712, 220);
            this.patient_visitDataGridView.TabIndex = 5;
            // 
            // patient_visitBindingSource
            // 
            this.patient_visitBindingSource.DataMember = "patient_visit";
            this.patient_visitBindingSource.DataSource = this.patientVisitDataSet;
            // 
            // patientVisitDataSet
            // 
            this.patientVisitDataSet.DataSetName = "PatientVisitDataSet";
            this.patientVisitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patient_visitTableAdapter
            // 
            this.patient_visitTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.patient_visit_notesTableAdapter = null;
            this.tableAdapterManager.patient_visit_symptomsTableAdapter = null;
            this.tableAdapterManager.patient_visit_vitalsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication.PatientVisitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientVisitDataSetBindingSource
            // 
            this.patientVisitDataSetBindingSource.DataSource = this.patientVisitDataSet;
            this.patientVisitDataSetBindingSource.Position = 0;
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.patientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApplication.PatientsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // first_nameLabel1
            // 
            this.first_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "first_name", true));
            this.first_nameLabel1.Location = new System.Drawing.Point(192, 33);
            this.first_nameLabel1.Name = "first_nameLabel1";
            this.first_nameLabel1.Size = new System.Drawing.Size(54, 23);
            this.first_nameLabel1.TabIndex = 6;
            this.first_nameLabel1.Text = "****";
            // 
            // last_nameLabel1
            // 
            this.last_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "last_name", true));
            this.last_nameLabel1.Location = new System.Drawing.Point(246, 33);
            this.last_nameLabel1.Name = "last_nameLabel1";
            this.last_nameLabel1.Size = new System.Drawing.Size(43, 23);
            this.last_nameLabel1.TabIndex = 7;
            this.last_nameLabel1.Text = "****";
            // 
            // dobLabel1
            // 
            this.dobLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "dob", true));
            this.dobLabel1.Location = new System.Drawing.Point(420, 33);
            this.dobLabel1.Name = "dobLabel1";
            this.dobLabel1.Size = new System.Drawing.Size(100, 23);
            this.dobLabel1.TabIndex = 8;
            this.dobLabel1.Text = "****";
            // 
            // fillByPatientInfoToolStrip
            // 
            this.fillByPatientInfoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientIDToolStripLabel,
            this.patientIDToolStripTextBox,
            this.fillByPatientInfoToolStripButton});
            this.fillByPatientInfoToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByPatientInfoToolStrip.Name = "fillByPatientInfoToolStrip";
            this.fillByPatientInfoToolStrip.Size = new System.Drawing.Size(868, 25);
            this.fillByPatientInfoToolStrip.TabIndex = 9;
            this.fillByPatientInfoToolStrip.Text = "fillByPatientInfoToolStrip";
            this.fillByPatientInfoToolStrip.Visible = false;
            // 
            // patientIDToolStripLabel
            // 
            this.patientIDToolStripLabel.Name = "patientIDToolStripLabel";
            this.patientIDToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.patientIDToolStripLabel.Text = "patientID:";
            // 
            // patientIDToolStripTextBox
            // 
            this.patientIDToolStripTextBox.Name = "patientIDToolStripTextBox";
            this.patientIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByPatientInfoToolStripButton
            // 
            this.fillByPatientInfoToolStripButton.Name = "fillByPatientInfoToolStripButton";
            this.fillByPatientInfoToolStripButton.Size = new System.Drawing.Size(23, 22);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "visitID";
            this.dataGridViewTextBoxColumn1.HeaderText = "visitID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "patientID";
            this.dataGridViewTextBoxColumn2.HeaderText = "patientID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "visit_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Visit Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 74;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "appt_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "appt_date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "doctorID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Doctor ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nurseID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nurse ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 74;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "symptom_name";
            this.dataGridViewTextBoxColumn7.HeaderText = "Symptoms";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 74;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "pulse";
            this.dataGridViewTextBoxColumn8.HeaderText = "Pulse";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 75;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "blood_pressure";
            this.dataGridViewTextBoxColumn9.HeaderText = "Blood Pressure";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 74;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "temp";
            this.dataGridViewTextBoxColumn10.HeaderText = "Temperature";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 74;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "height";
            this.dataGridViewTextBoxColumn11.HeaderText = "Height";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 75;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "weight";
            this.dataGridViewTextBoxColumn12.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 74;
            // 
            // NwViewVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 366);
            this.Controls.Add(this.fillByPatientInfoToolStrip);
            this.Controls.Add(this.dobLabel1);
            this.Controls.Add(this.last_nameLabel1);
            this.Controls.Add(this.first_nameLabel1);
            this.Controls.Add(this.patient_visitDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "NwViewVisits";
            this.Text = "Patient Visits";
            this.Load += new System.EventHandler(this.NwViewVisits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.fillByPatientInfoToolStrip.ResumeLayout(false);
            this.fillByPatientInfoToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private PatientVisitDataSet patientVisitDataSet;
        private System.Windows.Forms.BindingSource patient_visitBindingSource;
        private PatientVisitDataSetTableAdapters.patient_visitTableAdapter patient_visitTableAdapter;
        private PatientVisitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource patientVisitDataSetBindingSource;
        private System.Windows.Forms.DataGridView patient_visitDataGridView;
        private PatientsDataSet patientsDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PatientsDataSetTableAdapters.patientsTableAdapter patientsTableAdapter;
        private PatientsDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label first_nameLabel1;
        private System.Windows.Forms.Label last_nameLabel1;
        private System.Windows.Forms.Label dobLabel1;
        private System.Windows.Forms.ToolStrip fillByPatientInfoToolStrip;
        private System.Windows.Forms.ToolStripLabel patientIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox patientIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByPatientInfoToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;


    }
}