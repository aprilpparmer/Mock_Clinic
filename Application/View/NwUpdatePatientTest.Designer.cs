namespace WindowsFormsApplication.View
{
    partial class NwUpdatePatientTest
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
            System.Windows.Forms.Label test_nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NwUpdatePatientTest));
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.patientVisitSummaryReport = new WindowsFormsApplication.PatientVisitSummaryReport();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsTableAdapter = new WindowsFormsApplication.PatientVisitSummaryReportTableAdapters.testsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication.PatientVisitSummaryReportTableAdapters.TableAdapterManager();
            this.patientsTableAdapter = new WindowsFormsApplication.PatientVisitSummaryReportTableAdapters.patientsTableAdapter();
            this.testsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.testsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientVisitInfoDataSet = new WindowsFormsApplication.PatientVisitInfoDataSet();
            this.patient_testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_testsTableAdapter = new WindowsFormsApplication.PatientVisitInfoDataSetTableAdapters.patient_testsTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApplication.PatientVisitInfoDataSetTableAdapters.TableAdapterManager();
            this.test_nameTextBox = new System.Windows.Forms.TextBox();
            this.testCompletedBox = new System.Windows.Forms.TextBox();
            this.testResultsBox = new System.Windows.Forms.TextBox();
            this.testTakenBox = new System.Windows.Forms.TextBox();
            test_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingNavigator)).BeginInit();
            this.testsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_testsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // test_nameLabel
            // 
            test_nameLabel.AutoSize = true;
            test_nameLabel.Location = new System.Drawing.Point(12, 22);
            test_nameLabel.Name = "test_nameLabel";
            test_nameLabel.Size = new System.Drawing.Size(31, 13);
            test_nameLabel.TabIndex = 8;
            test_nameLabel.Text = "Test:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(132, 123);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Test Taken (Date):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Test Completed (Date):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Test Results:";
            // 
            // patientVisitSummaryReport
            // 
            this.patientVisitSummaryReport.DataSetName = "PatientVisitSummaryReport";
            this.patientVisitSummaryReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.diagnosesTableAdapter = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.patient_testsTableAdapter = null;
            this.tableAdapterManager.patient_visit_symptomsTableAdapter = null;
            this.tableAdapterManager.patientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.testsTableAdapter = this.testsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication.PatientVisitSummaryReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // testsBindingNavigator
            // 
            this.testsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.testsBindingNavigator.BindingSource = this.testsBindingSource;
            this.testsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.testsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.testsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.testsBindingNavigatorSaveItem});
            this.testsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.testsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.testsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.testsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.testsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.testsBindingNavigator.Name = "testsBindingNavigator";
            this.testsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.testsBindingNavigator.Size = new System.Drawing.Size(361, 25);
            this.testsBindingNavigator.TabIndex = 7;
            this.testsBindingNavigator.Text = "bindingNavigator1";
            this.testsBindingNavigator.Visible = false;
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
            // testsBindingNavigatorSaveItem
            // 
            this.testsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.testsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("testsBindingNavigatorSaveItem.Image")));
            this.testsBindingNavigatorSaveItem.Name = "testsBindingNavigatorSaveItem";
            this.testsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.testsBindingNavigatorSaveItem.Text = "Save Data";
            this.testsBindingNavigatorSaveItem.Click += new System.EventHandler(this.testsBindingNavigatorSaveItem_Click);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.patientVisitSummaryReport;
            // 
            // patientVisitInfoDataSet
            // 
            this.patientVisitInfoDataSet.DataSetName = "PatientVisitInfoDataSet";
            this.patientVisitInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patient_testsBindingSource
            // 
            this.patient_testsBindingSource.DataMember = "patient_tests";
            this.patient_testsBindingSource.DataSource = this.patientVisitInfoDataSet;
            // 
            // patient_testsTableAdapter
            // 
            this.patient_testsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.patient_visit_vitalsTableAdapter = null;
            this.tableAdapterManager1.patient_visitTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApplication.PatientVisitInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // test_nameTextBox
            // 
            this.test_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_testsBindingSource, "test_name", true));
            this.test_nameTextBox.Enabled = false;
            this.test_nameTextBox.Location = new System.Drawing.Point(132, 19);
            this.test_nameTextBox.Name = "test_nameTextBox";
            this.test_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.test_nameTextBox.TabIndex = 10;
            // 
            // testCompletedBox
            // 
            this.testCompletedBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_testsBindingSource, "test_completed", true));
            this.testCompletedBox.Location = new System.Drawing.Point(132, 71);
            this.testCompletedBox.Name = "testCompletedBox";
            this.testCompletedBox.Size = new System.Drawing.Size(100, 20);
            this.testCompletedBox.TabIndex = 12;
            // 
            // testResultsBox
            // 
            this.testResultsBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_testsBindingSource, "results", true));
            this.testResultsBox.Location = new System.Drawing.Point(132, 97);
            this.testResultsBox.Name = "testResultsBox";
            this.testResultsBox.Size = new System.Drawing.Size(100, 20);
            this.testResultsBox.TabIndex = 13;
            // 
            // testTakenBox
            // 
            this.testTakenBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_testsBindingSource, "test_taken", true));
            this.testTakenBox.Location = new System.Drawing.Point(132, 45);
            this.testTakenBox.Name = "testTakenBox";
            this.testTakenBox.Size = new System.Drawing.Size(100, 20);
            this.testTakenBox.TabIndex = 11;
            // 
            // NwUpdatePatientTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 161);
            this.Controls.Add(this.testResultsBox);
            this.Controls.Add(this.testCompletedBox);
            this.Controls.Add(this.testTakenBox);
            this.Controls.Add(this.test_nameTextBox);
            this.Controls.Add(test_nameLabel);
            this.Controls.Add(this.testsBindingNavigator);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Name = "NwUpdatePatientTest";
            this.Text = "Update Patient Test";
            this.Load += new System.EventHandler(this.NwUpdatePatientTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitSummaryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingNavigator)).EndInit();
            this.testsBindingNavigator.ResumeLayout(false);
            this.testsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_testsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private PatientVisitSummaryReport patientVisitSummaryReport;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private PatientVisitSummaryReportTableAdapters.testsTableAdapter testsTableAdapter;
        private PatientVisitSummaryReportTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator testsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton testsBindingNavigatorSaveItem;
        private PatientVisitSummaryReportTableAdapters.patientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PatientVisitInfoDataSet patientVisitInfoDataSet;
        private System.Windows.Forms.BindingSource patient_testsBindingSource;
        private PatientVisitInfoDataSetTableAdapters.patient_testsTableAdapter patient_testsTableAdapter;
        private PatientVisitInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox test_nameTextBox;
        private System.Windows.Forms.TextBox testCompletedBox;
        private System.Windows.Forms.TextBox testResultsBox;
        private System.Windows.Forms.TextBox testTakenBox;
    }
}