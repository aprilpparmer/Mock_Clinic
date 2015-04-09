﻿namespace WindowsFormsApplication.View
{
    partial class NwViewVisit
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
            System.Windows.Forms.Label visit_dateLabel;
            System.Windows.Forms.Label appt_dateLabel;
            System.Windows.Forms.Label doctorNameLabel;
            System.Windows.Forms.Label nurseNameLabel;
            System.Windows.Forms.Label blood_pressureLabel;
            System.Windows.Forms.Label pulseLabel;
            System.Windows.Forms.Label tempLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label symptom_nameLabel;
            System.Windows.Forms.Label diagnoses_nameLabel;
            System.Windows.Forms.Label diagnoses_treatmentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NwViewVisit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nurseNameLabel1 = new System.Windows.Forms.Label();
            this.patient_visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientVisitInfoDataSet = new WindowsFormsApplication.PatientVisitInfoDataSet();
            this.doctorNameLabel1 = new System.Windows.Forms.Label();
            this.appt_dateLabel1 = new System.Windows.Forms.Label();
            this.visit_dateLabel1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.weightLabel1 = new System.Windows.Forms.Label();
            this.patient_visit_vitalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.heightLabel1 = new System.Windows.Forms.Label();
            this.tempLabel1 = new System.Windows.Forms.Label();
            this.pulseLabel1 = new System.Windows.Forms.Label();
            this.blood_pressureLabel1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.diagnoses_treatmentLabel1 = new System.Windows.Forms.Label();
            this.patient_visit_symptomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnoses_nameLabel1 = new System.Windows.Forms.Label();
            this.symptom_nameLabel1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.patient_testsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.patient_visit_notesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patient_visit_notesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_visitBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.patient_visitBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patient_visitTableAdapter = new WindowsFormsApplication.PatientVisitInfoDataSetTableAdapters.patient_visitTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication.PatientVisitInfoDataSetTableAdapters.TableAdapterManager();
            this.patient_visit_vitalsTableAdapter = new WindowsFormsApplication.PatientVisitInfoDataSetTableAdapters.patient_visit_vitalsTableAdapter();
            this.patient_visit_symptomsTableAdapter = new WindowsFormsApplication.PatientVisitInfoDataSetTableAdapters.patient_visit_symptomsTableAdapter();
            this.patient_testsTableAdapter = new WindowsFormsApplication.PatientVisitInfoDataSetTableAdapters.patient_testsTableAdapter();
            this.patient_visit_notesTableAdapter = new WindowsFormsApplication.PatientVisitInfoDataSetTableAdapters.patient_visit_notesTableAdapter();
            visit_dateLabel = new System.Windows.Forms.Label();
            appt_dateLabel = new System.Windows.Forms.Label();
            doctorNameLabel = new System.Windows.Forms.Label();
            nurseNameLabel = new System.Windows.Forms.Label();
            blood_pressureLabel = new System.Windows.Forms.Label();
            pulseLabel = new System.Windows.Forms.Label();
            tempLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            symptom_nameLabel = new System.Windows.Forms.Label();
            diagnoses_nameLabel = new System.Windows.Forms.Label();
            diagnoses_treatmentLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitInfoDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visit_vitalsBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visit_symptomsBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_testsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_testsBindingSource)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visit_notesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visit_notesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingNavigator)).BeginInit();
            this.patient_visitBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // visit_dateLabel
            // 
            visit_dateLabel.AutoSize = true;
            visit_dateLabel.Location = new System.Drawing.Point(21, 25);
            visit_dateLabel.Name = "visit_dateLabel";
            visit_dateLabel.Size = new System.Drawing.Size(55, 13);
            visit_dateLabel.TabIndex = 0;
            visit_dateLabel.Text = "Visit Date:";
            // 
            // appt_dateLabel
            // 
            appt_dateLabel.AutoSize = true;
            appt_dateLabel.Location = new System.Drawing.Point(21, 48);
            appt_dateLabel.Name = "appt_dateLabel";
            appt_dateLabel.Size = new System.Drawing.Size(95, 13);
            appt_dateLabel.TabIndex = 2;
            appt_dateLabel.Text = "Appointment Date:";
            // 
            // doctorNameLabel
            // 
            doctorNameLabel.AutoSize = true;
            doctorNameLabel.Location = new System.Drawing.Point(249, 25);
            doctorNameLabel.Name = "doctorNameLabel";
            doctorNameLabel.Size = new System.Drawing.Size(42, 13);
            doctorNameLabel.TabIndex = 4;
            doctorNameLabel.Text = "Doctor:";
            // 
            // nurseNameLabel
            // 
            nurseNameLabel.AutoSize = true;
            nurseNameLabel.Location = new System.Drawing.Point(249, 48);
            nurseNameLabel.Name = "nurseNameLabel";
            nurseNameLabel.Size = new System.Drawing.Size(38, 13);
            nurseNameLabel.TabIndex = 6;
            nurseNameLabel.Text = "Nurse:";
            // 
            // blood_pressureLabel
            // 
            blood_pressureLabel.AutoSize = true;
            blood_pressureLabel.Location = new System.Drawing.Point(17, 21);
            blood_pressureLabel.Name = "blood_pressureLabel";
            blood_pressureLabel.Size = new System.Drawing.Size(81, 13);
            blood_pressureLabel.TabIndex = 0;
            blood_pressureLabel.Text = "Blood Pressure:";
            // 
            // pulseLabel
            // 
            pulseLabel.AutoSize = true;
            pulseLabel.Location = new System.Drawing.Point(249, 21);
            pulseLabel.Name = "pulseLabel";
            pulseLabel.Size = new System.Drawing.Size(36, 13);
            pulseLabel.TabIndex = 2;
            pulseLabel.Text = "Pulse:";
            // 
            // tempLabel
            // 
            tempLabel.AutoSize = true;
            tempLabel.Location = new System.Drawing.Point(17, 44);
            tempLabel.Name = "tempLabel";
            tempLabel.Size = new System.Drawing.Size(70, 13);
            tempLabel.TabIndex = 4;
            tempLabel.Text = "Temperature:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(174, 44);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(41, 13);
            heightLabel.TabIndex = 6;
            heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(297, 44);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(44, 13);
            weightLabel.TabIndex = 8;
            weightLabel.Text = "Weight:";
            // 
            // symptom_nameLabel
            // 
            symptom_nameLabel.AutoSize = true;
            symptom_nameLabel.Location = new System.Drawing.Point(21, 25);
            symptom_nameLabel.Name = "symptom_nameLabel";
            symptom_nameLabel.Size = new System.Drawing.Size(58, 13);
            symptom_nameLabel.TabIndex = 0;
            symptom_nameLabel.Text = "Symptoms:";
            // 
            // diagnoses_nameLabel
            // 
            diagnoses_nameLabel.AutoSize = true;
            diagnoses_nameLabel.Location = new System.Drawing.Point(21, 48);
            diagnoses_nameLabel.Name = "diagnoses_nameLabel";
            diagnoses_nameLabel.Size = new System.Drawing.Size(60, 13);
            diagnoses_nameLabel.TabIndex = 2;
            diagnoses_nameLabel.Text = "Diagnoses:";
            // 
            // diagnoses_treatmentLabel
            // 
            diagnoses_treatmentLabel.AutoSize = true;
            diagnoses_treatmentLabel.Location = new System.Drawing.Point(21, 72);
            diagnoses_treatmentLabel.Name = "diagnoses_treatmentLabel";
            diagnoses_treatmentLabel.Size = new System.Drawing.Size(58, 13);
            diagnoses_treatmentLabel.TabIndex = 6;
            diagnoses_treatmentLabel.Text = "Treatment:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nurseNameLabel);
            this.groupBox1.Controls.Add(this.nurseNameLabel1);
            this.groupBox1.Controls.Add(doctorNameLabel);
            this.groupBox1.Controls.Add(this.doctorNameLabel1);
            this.groupBox1.Controls.Add(appt_dateLabel);
            this.groupBox1.Controls.Add(this.appt_dateLabel1);
            this.groupBox1.Controls.Add(visit_dateLabel);
            this.groupBox1.Controls.Add(this.visit_dateLabel1);
            this.groupBox1.Location = new System.Drawing.Point(41, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visit Information";
            // 
            // nurseNameLabel1
            // 
            this.nurseNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visitBindingSource, "nurseName", true));
            this.nurseNameLabel1.Location = new System.Drawing.Point(297, 48);
            this.nurseNameLabel1.Name = "nurseNameLabel1";
            this.nurseNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nurseNameLabel1.TabIndex = 7;
            this.nurseNameLabel1.Text = "***";
            // 
            // patient_visitBindingSource
            // 
            this.patient_visitBindingSource.DataMember = "patient_visit";
            this.patient_visitBindingSource.DataSource = this.patientVisitInfoDataSet;
            // 
            // patientVisitInfoDataSet
            // 
            this.patientVisitInfoDataSet.DataSetName = "PatientVisitInfoDataSet";
            this.patientVisitInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorNameLabel1
            // 
            this.doctorNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visitBindingSource, "doctorName", true));
            this.doctorNameLabel1.Location = new System.Drawing.Point(297, 25);
            this.doctorNameLabel1.Name = "doctorNameLabel1";
            this.doctorNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.doctorNameLabel1.TabIndex = 5;
            this.doctorNameLabel1.Text = "***";
            // 
            // appt_dateLabel1
            // 
            this.appt_dateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visitBindingSource, "appt_date", true));
            this.appt_dateLabel1.Location = new System.Drawing.Point(122, 48);
            this.appt_dateLabel1.Name = "appt_dateLabel1";
            this.appt_dateLabel1.Size = new System.Drawing.Size(100, 23);
            this.appt_dateLabel1.TabIndex = 3;
            this.appt_dateLabel1.Text = "***";
            // 
            // visit_dateLabel1
            // 
            this.visit_dateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visitBindingSource, "visit_date", true));
            this.visit_dateLabel1.Location = new System.Drawing.Point(79, 25);
            this.visit_dateLabel1.Name = "visit_dateLabel1";
            this.visit_dateLabel1.Size = new System.Drawing.Size(100, 23);
            this.visit_dateLabel1.TabIndex = 1;
            this.visit_dateLabel1.Text = "***";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(weightLabel);
            this.groupBox2.Controls.Add(this.weightLabel1);
            this.groupBox2.Controls.Add(heightLabel);
            this.groupBox2.Controls.Add(this.heightLabel1);
            this.groupBox2.Controls.Add(tempLabel);
            this.groupBox2.Controls.Add(this.tempLabel1);
            this.groupBox2.Controls.Add(pulseLabel);
            this.groupBox2.Controls.Add(this.pulseLabel1);
            this.groupBox2.Controls.Add(blood_pressureLabel);
            this.groupBox2.Controls.Add(this.blood_pressureLabel1);
            this.groupBox2.Location = new System.Drawing.Point(41, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 70);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vitals";
            // 
            // weightLabel1
            // 
            this.weightLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visit_vitalsBindingSource, "weight", true));
            this.weightLabel1.Location = new System.Drawing.Point(347, 44);
            this.weightLabel1.Name = "weightLabel1";
            this.weightLabel1.Size = new System.Drawing.Size(50, 23);
            this.weightLabel1.TabIndex = 9;
            this.weightLabel1.Text = "****";
            // 
            // patient_visit_vitalsBindingSource
            // 
            this.patient_visit_vitalsBindingSource.DataMember = "patient_visit_vitals";
            this.patient_visit_vitalsBindingSource.DataSource = this.patientVisitInfoDataSet;
            // 
            // heightLabel1
            // 
            this.heightLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visit_vitalsBindingSource, "height", true));
            this.heightLabel1.Location = new System.Drawing.Point(221, 44);
            this.heightLabel1.Name = "heightLabel1";
            this.heightLabel1.Size = new System.Drawing.Size(41, 23);
            this.heightLabel1.TabIndex = 7;
            this.heightLabel1.Text = "****";
            // 
            // tempLabel1
            // 
            this.tempLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visit_vitalsBindingSource, "temp", true));
            this.tempLabel1.Location = new System.Drawing.Point(93, 44);
            this.tempLabel1.Name = "tempLabel1";
            this.tempLabel1.Size = new System.Drawing.Size(41, 23);
            this.tempLabel1.TabIndex = 5;
            this.tempLabel1.Text = "****";
            // 
            // pulseLabel1
            // 
            this.pulseLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visit_vitalsBindingSource, "pulse", true));
            this.pulseLabel1.Location = new System.Drawing.Point(291, 21);
            this.pulseLabel1.Name = "pulseLabel1";
            this.pulseLabel1.Size = new System.Drawing.Size(100, 23);
            this.pulseLabel1.TabIndex = 3;
            this.pulseLabel1.Text = "****";
            // 
            // blood_pressureLabel1
            // 
            this.blood_pressureLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visit_vitalsBindingSource, "blood_pressure", true));
            this.blood_pressureLabel1.Location = new System.Drawing.Point(104, 21);
            this.blood_pressureLabel1.Name = "blood_pressureLabel1";
            this.blood_pressureLabel1.Size = new System.Drawing.Size(100, 23);
            this.blood_pressureLabel1.TabIndex = 1;
            this.blood_pressureLabel1.Text = "****";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(diagnoses_treatmentLabel);
            this.groupBox3.Controls.Add(this.diagnoses_treatmentLabel1);
            this.groupBox3.Controls.Add(diagnoses_nameLabel);
            this.groupBox3.Controls.Add(this.diagnoses_nameLabel1);
            this.groupBox3.Controls.Add(symptom_nameLabel);
            this.groupBox3.Controls.Add(this.symptom_nameLabel1);
            this.groupBox3.Location = new System.Drawing.Point(41, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 101);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symptoms/Diagnoses";
            // 
            // diagnoses_treatmentLabel1
            // 
            this.diagnoses_treatmentLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visit_symptomsBindingSource, "diagnoses_treatment", true));
            this.diagnoses_treatmentLabel1.Location = new System.Drawing.Point(85, 72);
            this.diagnoses_treatmentLabel1.Name = "diagnoses_treatmentLabel1";
            this.diagnoses_treatmentLabel1.Size = new System.Drawing.Size(371, 23);
            this.diagnoses_treatmentLabel1.TabIndex = 7;
            this.diagnoses_treatmentLabel1.Text = "****";
            // 
            // patient_visit_symptomsBindingSource
            // 
            this.patient_visit_symptomsBindingSource.DataMember = "patient_visit_symptoms";
            this.patient_visit_symptomsBindingSource.DataSource = this.patientVisitInfoDataSet;
            // 
            // diagnoses_nameLabel1
            // 
            this.diagnoses_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visit_symptomsBindingSource, "diagnoses_name", true));
            this.diagnoses_nameLabel1.Location = new System.Drawing.Point(85, 48);
            this.diagnoses_nameLabel1.Name = "diagnoses_nameLabel1";
            this.diagnoses_nameLabel1.Size = new System.Drawing.Size(371, 23);
            this.diagnoses_nameLabel1.TabIndex = 3;
            this.diagnoses_nameLabel1.Text = "****";
            // 
            // symptom_nameLabel1
            // 
            this.symptom_nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visit_symptomsBindingSource, "symptom_name", true));
            this.symptom_nameLabel1.Location = new System.Drawing.Point(85, 25);
            this.symptom_nameLabel1.Name = "symptom_nameLabel1";
            this.symptom_nameLabel1.Size = new System.Drawing.Size(371, 23);
            this.symptom_nameLabel1.TabIndex = 1;
            this.symptom_nameLabel1.Text = "****";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.patient_testsDataGridView);
            this.groupBox4.Location = new System.Drawing.Point(41, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 119);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tests";
            // 
            // patient_testsDataGridView
            // 
            this.patient_testsDataGridView.AllowUserToAddRows = false;
            this.patient_testsDataGridView.AllowUserToDeleteRows = false;
            this.patient_testsDataGridView.AutoGenerateColumns = false;
            this.patient_testsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patient_testsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.patient_testsDataGridView.DataSource = this.patient_testsBindingSource;
            this.patient_testsDataGridView.Location = new System.Drawing.Point(6, 19);
            this.patient_testsDataGridView.Name = "patient_testsDataGridView";
            this.patient_testsDataGridView.ReadOnly = true;
            this.patient_testsDataGridView.Size = new System.Drawing.Size(450, 94);
            this.patient_testsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "patient_testID";
            this.dataGridViewTextBoxColumn1.HeaderText = "patient_testID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "visitID";
            this.dataGridViewTextBoxColumn2.HeaderText = "visitID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "testID";
            this.dataGridViewTextBoxColumn3.HeaderText = "testID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "test_name";
            this.dataGridViewTextBoxColumn8.HeaderText = "Test";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "test_ordered";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ordered";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "test_taken";
            this.dataGridViewTextBoxColumn5.HeaderText = "Taken";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "test_completed";
            this.dataGridViewTextBoxColumn6.HeaderText = "Completed";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "results";
            this.dataGridViewTextBoxColumn7.HeaderText = "Results";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // patient_testsBindingSource
            // 
            this.patient_testsBindingSource.DataMember = "patient_tests";
            this.patient_testsBindingSource.DataSource = this.patientVisitInfoDataSet;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.patient_visit_notesDataGridView);
            this.groupBox5.Location = new System.Drawing.Point(41, 415);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(462, 130);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Notes";
            // 
            // patient_visit_notesDataGridView
            // 
            this.patient_visit_notesDataGridView.AllowUserToAddRows = false;
            this.patient_visit_notesDataGridView.AllowUserToDeleteRows = false;
            this.patient_visit_notesDataGridView.AutoGenerateColumns = false;
            this.patient_visit_notesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patient_visit_notesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.patient_visit_notesDataGridView.DataSource = this.patient_visit_notesBindingSource;
            this.patient_visit_notesDataGridView.Location = new System.Drawing.Point(13, 20);
            this.patient_visit_notesDataGridView.Name = "patient_visit_notesDataGridView";
            this.patient_visit_notesDataGridView.ReadOnly = true;
            this.patient_visit_notesDataGridView.Size = new System.Drawing.Size(443, 104);
            this.patient_visit_notesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "notesID";
            this.dataGridViewTextBoxColumn9.HeaderText = "notesID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "visitID";
            this.dataGridViewTextBoxColumn10.HeaderText = "visitID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "note";
            this.dataGridViewTextBoxColumn11.HeaderText = "Note";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 300;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn12.HeaderText = "Date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn13.HeaderText = "Employee";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // patient_visit_notesBindingSource
            // 
            this.patient_visit_notesBindingSource.DataMember = "patient_visit_notes";
            this.patient_visit_notesBindingSource.DataSource = this.patientVisitInfoDataSet;
            // 
            // patient_visitBindingNavigator
            // 
            this.patient_visitBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patient_visitBindingNavigator.BindingSource = this.patient_visitBindingSource;
            this.patient_visitBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patient_visitBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patient_visitBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.patient_visitBindingNavigatorSaveItem});
            this.patient_visitBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patient_visitBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patient_visitBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patient_visitBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patient_visitBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patient_visitBindingNavigator.Name = "patient_visitBindingNavigator";
            this.patient_visitBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patient_visitBindingNavigator.Size = new System.Drawing.Size(536, 25);
            this.patient_visitBindingNavigator.TabIndex = 2;
            this.patient_visitBindingNavigator.Text = "bindingNavigator1";
            this.patient_visitBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // patient_visitBindingNavigatorSaveItem
            // 
            this.patient_visitBindingNavigatorSaveItem.Name = "patient_visitBindingNavigatorSaveItem";
            this.patient_visitBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            // 
            // patient_visitTableAdapter
            // 
            this.patient_visitTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.patient_visit_vitalsTableAdapter = null;
            this.tableAdapterManager.patient_visitTableAdapter = this.patient_visitTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication.PatientVisitInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patient_visit_vitalsTableAdapter
            // 
            this.patient_visit_vitalsTableAdapter.ClearBeforeFill = true;
            // 
            // patient_visit_symptomsTableAdapter
            // 
            this.patient_visit_symptomsTableAdapter.ClearBeforeFill = true;
            // 
            // patient_testsTableAdapter
            // 
            this.patient_testsTableAdapter.ClearBeforeFill = true;
            // 
            // patient_visit_notesTableAdapter
            // 
            this.patient_visit_notesTableAdapter.ClearBeforeFill = true;
            // 
            // NwViewVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 557);
            this.Controls.Add(this.patient_visitBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "NwViewVisit";
            this.Text = "Visit Information";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitInfoDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visit_vitalsBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visit_symptomsBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patient_testsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_testsBindingSource)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patient_visit_notesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visit_notesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingNavigator)).EndInit();
            this.patient_visitBindingNavigator.ResumeLayout(false);
            this.patient_visitBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private PatientVisitInfoDataSet patientVisitInfoDataSet;
        private System.Windows.Forms.BindingSource patient_visitBindingSource;
        private PatientVisitInfoDataSetTableAdapters.patient_visitTableAdapter patient_visitTableAdapter;
        private PatientVisitInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patient_visitBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton patient_visitBindingNavigatorSaveItem;
        private System.Windows.Forms.Label nurseNameLabel1;
        private System.Windows.Forms.Label doctorNameLabel1;
        private System.Windows.Forms.Label appt_dateLabel1;
        private System.Windows.Forms.Label visit_dateLabel1;
        private System.Windows.Forms.BindingSource patient_visit_vitalsBindingSource;
        private PatientVisitInfoDataSetTableAdapters.patient_visit_vitalsTableAdapter patient_visit_vitalsTableAdapter;
        private System.Windows.Forms.Label weightLabel1;
        private System.Windows.Forms.Label heightLabel1;
        private System.Windows.Forms.Label tempLabel1;
        private System.Windows.Forms.Label pulseLabel1;
        private System.Windows.Forms.Label blood_pressureLabel1;
        private System.Windows.Forms.BindingSource patient_visit_symptomsBindingSource;
        private PatientVisitInfoDataSetTableAdapters.patient_visit_symptomsTableAdapter patient_visit_symptomsTableAdapter;
        private System.Windows.Forms.Label diagnoses_treatmentLabel1;
        private System.Windows.Forms.Label diagnoses_nameLabel1;
        private System.Windows.Forms.Label symptom_nameLabel1;
        private System.Windows.Forms.BindingSource patient_testsBindingSource;
        private PatientVisitInfoDataSetTableAdapters.patient_testsTableAdapter patient_testsTableAdapter;
        private System.Windows.Forms.DataGridView patient_testsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource patient_visit_notesBindingSource;
        private PatientVisitInfoDataSetTableAdapters.patient_visit_notesTableAdapter patient_visit_notesTableAdapter;
        private System.Windows.Forms.DataGridView patient_visit_notesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

    }
}