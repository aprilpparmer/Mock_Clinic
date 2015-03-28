namespace WindowsFormsApplication.View
{
    partial class NWNewVisit
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
            System.Windows.Forms.Label dob;
            System.Windows.Forms.Label patientID;
            this.vitalsTab = new System.Windows.Forms.TabControl();
            this.visitInfoTab = new System.Windows.Forms.TabPage();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.doctorsComboBox = new System.Windows.Forms.ComboBox();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDataSet1 = new WindowsFormsApplication.EmployeesDataSet();
            this.appointmentDateBox = new System.Windows.Forms.DateTimePicker();
            this.visitDateBox = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsDataSet = new WindowsFormsApplication.PatientsDataSet();
            this.dobLabel = new System.Windows.Forms.Label();
            this.middleInitialLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fillPatientInfoToolStrip = new System.Windows.Forms.ToolStrip();
            this.patientIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.patientIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillPatientInfoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.patientsTableAdapter = new WindowsFormsApplication.PatientsDataSetTableAdapters.patientsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication.PatientsDataSetTableAdapters.TableAdapterManager();
            this.doctorsTableAdapter = new WindowsFormsApplication.EmployeesDataSetTableAdapters.doctorsTableAdapter();
            this.patientIDLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            last_nameLabel = new System.Windows.Forms.Label();
            dob = new System.Windows.Forms.Label();
            patientID = new System.Windows.Forms.Label();
            this.vitalsTab.SuspendLayout();
            this.visitInfoTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).BeginInit();
            this.fillPatientInfoToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(6, 25);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(30, 13);
            last_nameLabel.TabIndex = 0;
            last_nameLabel.Text = "Last:";
            // 
            // dob
            // 
            dob.AutoSize = true;
            dob.Location = new System.Drawing.Point(6, 50);
            dob.Name = "dob";
            dob.Size = new System.Drawing.Size(33, 13);
            dob.TabIndex = 6;
            dob.Text = "DOB:";
            // 
            // vitalsTab
            // 
            this.vitalsTab.Controls.Add(this.visitInfoTab);
            this.vitalsTab.Controls.Add(this.tabPage2);
            this.vitalsTab.Controls.Add(this.tabPage1);
            this.vitalsTab.Controls.Add(this.tabPage3);
            this.vitalsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vitalsTab.Location = new System.Drawing.Point(0, 25);
            this.vitalsTab.Name = "vitalsTab";
            this.vitalsTab.SelectedIndex = 0;
            this.vitalsTab.Size = new System.Drawing.Size(444, 270);
            this.vitalsTab.TabIndex = 0;
            // 
            // visitInfoTab
            // 
            this.visitInfoTab.Controls.Add(this.cancelbutton);
            this.visitInfoTab.Controls.Add(this.saveButton);
            this.visitInfoTab.Controls.Add(this.doctorsComboBox);
            this.visitInfoTab.Controls.Add(this.appointmentDateBox);
            this.visitInfoTab.Controls.Add(this.visitDateBox);
            this.visitInfoTab.Controls.Add(this.label5);
            this.visitInfoTab.Controls.Add(this.label4);
            this.visitInfoTab.Controls.Add(this.label3);
            this.visitInfoTab.Controls.Add(this.groupBox1);
            this.visitInfoTab.Controls.Add(this.editButton);
            this.visitInfoTab.Location = new System.Drawing.Point(4, 22);
            this.visitInfoTab.Name = "visitInfoTab";
            this.visitInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.visitInfoTab.Size = new System.Drawing.Size(436, 244);
            this.visitInfoTab.TabIndex = 0;
            this.visitInfoTab.Text = "Visit Info";
            this.visitInfoTab.UseVisualStyleBackColor = true;
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(67, 205);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 17;
            this.cancelbutton.Text = "Cancel";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(303, 205);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // doctorsComboBox
            // 
            this.doctorsComboBox.DataSource = this.doctorsBindingSource;
            this.doctorsComboBox.DisplayMember = "last_name";
            this.doctorsComboBox.FormattingEnabled = true;
            this.doctorsComboBox.Location = new System.Drawing.Point(133, 178);
            this.doctorsComboBox.Name = "doctorsComboBox";
            this.doctorsComboBox.Size = new System.Drawing.Size(200, 21);
            this.doctorsComboBox.TabIndex = 14;
            this.doctorsComboBox.ValueMember = "employeeID";
            this.doctorsComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorsComboBox_SelectedIndexChanged);
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "doctors";
            this.doctorsBindingSource.DataSource = this.employeesDataSet1;
            // 
            // employeesDataSet1
            // 
            this.employeesDataSet1.DataSetName = "EmployeesDataSet";
            this.employeesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentDateBox
            // 
            this.appointmentDateBox.Location = new System.Drawing.Point(132, 152);
            this.appointmentDateBox.Name = "appointmentDateBox";
            this.appointmentDateBox.Size = new System.Drawing.Size(201, 20);
            this.appointmentDateBox.TabIndex = 13;
            this.appointmentDateBox.ValueChanged += new System.EventHandler(this.appointmentDateBox_ValueChanged);
            // 
            // visitDateBox
            // 
            this.visitDateBox.Location = new System.Drawing.Point(133, 126);
            this.visitDateBox.Name = "visitDateBox";
            this.visitDateBox.Size = new System.Drawing.Size(200, 20);
            this.visitDateBox.TabIndex = 12;
            this.visitDateBox.ValueChanged += new System.EventHandler(this.visitDateBox_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Attending Doctor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Appointment Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Visit Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(patientID);
            this.groupBox1.Controls.Add(this.patientIDLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(last_nameLabel);
            this.groupBox1.Controls.Add(dob);
            this.groupBox1.Controls.Add(this.lastNameLabel);
            this.groupBox1.Controls.Add(this.dobLabel);
            this.groupBox1.Controls.Add(this.middleInitialLabel);
            this.groupBox1.Controls.Add(this.firstNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(25, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 94);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "MI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "last_name", true));
            this.lastNameLabel.Location = new System.Drawing.Point(42, 25);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(75, 23);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "*";
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "patients";
            this.patientsBindingSource.DataSource = this.patientsDataSet;
            // 
            // patientsDataSet
            // 
            this.patientsDataSet.DataSetName = "PatientsDataSet";
            this.patientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dobLabel
            // 
            this.dobLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "dob", true));
            this.dobLabel.Location = new System.Drawing.Point(42, 50);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(100, 23);
            this.dobLabel.TabIndex = 7;
            this.dobLabel.Text = "*";
            // 
            // middleInitialLabel
            // 
            this.middleInitialLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "middle_initial", true));
            this.middleInitialLabel.Location = new System.Drawing.Point(268, 24);
            this.middleInitialLabel.Name = "middleInitialLabel";
            this.middleInitialLabel.Size = new System.Drawing.Size(14, 23);
            this.middleInitialLabel.TabIndex = 3;
            this.middleInitialLabel.Text = "*";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "first_name", true));
            this.firstNameLabel.Location = new System.Drawing.Point(159, 24);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(75, 23);
            this.firstNameLabel.TabIndex = 5;
            this.firstNameLabel.Text = "*";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(436, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vitals";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(436, 244);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Symptoms";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(436, 244);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Diagnoses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fillPatientInfoToolStrip
            // 
            this.fillPatientInfoToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientIDToolStripLabel,
            this.patientIDToolStripTextBox,
            this.fillPatientInfoToolStripButton});
            this.fillPatientInfoToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillPatientInfoToolStrip.Name = "fillPatientInfoToolStrip";
            this.fillPatientInfoToolStrip.Size = new System.Drawing.Size(444, 25);
            this.fillPatientInfoToolStrip.TabIndex = 2;
            this.fillPatientInfoToolStrip.Text = "fillPatientInfoToolStrip";
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
            // fillPatientInfoToolStripButton
            // 
            this.fillPatientInfoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillPatientInfoToolStripButton.Name = "fillPatientInfoToolStripButton";
            this.fillPatientInfoToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.fillPatientInfoToolStripButton.Text = "FillPatientInfo";
            this.fillPatientInfoToolStripButton.Click += new System.EventHandler(this.fillPatientInfoToolStripButton_Click);
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.patientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication.PatientsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // patientID
            // 
            patientID.AutoSize = true;
            patientID.Location = new System.Drawing.Point(159, 50);
            patientID.Name = "patientID";
            patientID.Size = new System.Drawing.Size(57, 13);
            patientID.TabIndex = 9;
            patientID.Text = "Patient ID:";
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientsBindingSource, "patientID", true));
            this.patientIDLabel.Location = new System.Drawing.Point(221, 50);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(100, 23);
            this.patientIDLabel.TabIndex = 10;
            this.patientIDLabel.Text = "*";
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(296, 205);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(87, 23);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Save Changes";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // NWNewVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 295);
            this.Controls.Add(this.vitalsTab);
            this.Controls.Add(this.fillPatientInfoToolStrip);
            this.Name = "NWNewVisit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient Visit";
            this.Load += new System.EventHandler(this.NWNewVisit_Load);
            this.vitalsTab.ResumeLayout(false);
            this.visitInfoTab.ResumeLayout(false);
            this.visitInfoTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataSet)).EndInit();
            this.fillPatientInfoToolStrip.ResumeLayout(false);
            this.fillPatientInfoToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl vitalsTab;
        private System.Windows.Forms.TabPage visitInfoTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private PatientsDataSet patientsDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private PatientsDataSetTableAdapters.patientsTableAdapter patientsTableAdapter;
        private PatientsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label middleInitialLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.ToolStrip fillPatientInfoToolStrip;
        private System.Windows.Forms.ToolStripLabel patientIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox patientIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillPatientInfoToolStripButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox doctorsComboBox;
        private System.Windows.Forms.DateTimePicker appointmentDateBox;
        private System.Windows.Forms.DateTimePicker visitDateBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button saveButton;
        private EmployeesDataSet employeesDataSet1;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private EmployeesDataSetTableAdapters.doctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.Label patientIDLabel;
        private System.Windows.Forms.Button editButton;
        }
}