namespace WindowsFormsApplication.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NwViewVisit));
            System.Windows.Forms.Label visit_dateLabel;
            System.Windows.Forms.Label appt_dateLabel;
            System.Windows.Forms.Label doctorNameLabel;
            System.Windows.Forms.Label nurseNameLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.patient_visitBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.patient_visitBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patient_visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientVisitInfoDataSet = new WindowsFormsApplication.PatientVisitInfoDataSet();
            this.patient_visitTableAdapter = new WindowsFormsApplication.PatientVisitInfoDataSetTableAdapters.patient_visitTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication.PatientVisitInfoDataSetTableAdapters.TableAdapterManager();
            this.visit_dateLabel1 = new System.Windows.Forms.Label();
            this.appt_dateLabel1 = new System.Windows.Forms.Label();
            this.doctorNameLabel1 = new System.Windows.Forms.Label();
            this.nurseNameLabel1 = new System.Windows.Forms.Label();
            visit_dateLabel = new System.Windows.Forms.Label();
            appt_dateLabel = new System.Windows.Forms.Label();
            doctorNameLabel = new System.Windows.Forms.Label();
            nurseNameLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingNavigator)).BeginInit();
            this.patient_visitBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitInfoDataSet)).BeginInit();
            this.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(41, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vitals";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(41, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 50);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Symptoms/Diagnoses";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(41, 259);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(440, 85);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tests";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(41, 350);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(440, 98);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Notes";
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
            this.patient_visitBindingNavigator.Size = new System.Drawing.Size(522, 25);
            this.patient_visitBindingNavigator.TabIndex = 2;
            this.patient_visitBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // patient_visitBindingNavigatorSaveItem
            // 
            this.patient_visitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patient_visitBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patient_visitBindingNavigatorSaveItem.Image")));
            this.patient_visitBindingNavigatorSaveItem.Name = "patient_visitBindingNavigatorSaveItem";
            this.patient_visitBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patient_visitBindingNavigatorSaveItem.Text = "Save Data";
            this.patient_visitBindingNavigatorSaveItem.Click += new System.EventHandler(this.patient_visitBindingNavigatorSaveItem_Click);
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
            // patient_visitTableAdapter
            // 
            this.patient_visitTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.patient_testsTableAdapter = null;
            this.tableAdapterManager.patient_visit_notesTableAdapter = null;
            this.tableAdapterManager.patient_visit_symptomsTableAdapter = null;
            this.tableAdapterManager.patient_visit_vitalsTableAdapter = null;
            this.tableAdapterManager.patient_visitTableAdapter = this.patient_visitTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication.PatientVisitInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // visit_dateLabel1
            // 
            this.visit_dateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visitBindingSource, "visit_date", true));
            this.visit_dateLabel1.Location = new System.Drawing.Point(79, 25);
            this.visit_dateLabel1.Name = "visit_dateLabel1";
            this.visit_dateLabel1.Size = new System.Drawing.Size(100, 23);
            this.visit_dateLabel1.TabIndex = 1;
            this.visit_dateLabel1.Text = "***";
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
            // appt_dateLabel1
            // 
            this.appt_dateLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visitBindingSource, "appt_date", true));
            this.appt_dateLabel1.Location = new System.Drawing.Point(122, 48);
            this.appt_dateLabel1.Name = "appt_dateLabel1";
            this.appt_dateLabel1.Size = new System.Drawing.Size(100, 23);
            this.appt_dateLabel1.TabIndex = 3;
            this.appt_dateLabel1.Text = "***";
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
            // doctorNameLabel1
            // 
            this.doctorNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visitBindingSource, "doctorName", true));
            this.doctorNameLabel1.Location = new System.Drawing.Point(297, 25);
            this.doctorNameLabel1.Name = "doctorNameLabel1";
            this.doctorNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.doctorNameLabel1.TabIndex = 5;
            this.doctorNameLabel1.Text = "***";
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
            // nurseNameLabel1
            // 
            this.nurseNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patient_visitBindingSource, "nurseName", true));
            this.nurseNameLabel1.Location = new System.Drawing.Point(297, 48);
            this.nurseNameLabel1.Name = "nurseNameLabel1";
            this.nurseNameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nurseNameLabel1.TabIndex = 7;
            this.nurseNameLabel1.Text = "***";
            // 
            // NwViewVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 452);
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
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingNavigator)).EndInit();
            this.patient_visitBindingNavigator.ResumeLayout(false);
            this.patient_visitBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitInfoDataSet)).EndInit();
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

    }
}