namespace WindowsFormsApplication.View
{
    partial class NwNewVisit
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxBloodPressure = new System.Windows.Forms.TextBox();
            this.txtBoxPatientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxTemperature = new System.Windows.Forms.TextBox();
            this.txtBoxSymptoms = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPulse = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOrderTests = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.txtBoxHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxNotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxDoctorName = new System.Windows.Forms.ComboBox();
            this.comboBoxNurseName = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxPatientID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxVisitDate = new System.Windows.Forms.TextBox();
            this._CS6232_g7DataSet = new WindowsFormsApplication._CS6232_g7DataSet();
            this.nursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nursesTableAdapter = new WindowsFormsApplication._CS6232_g7DataSetTableAdapters.nursesTableAdapter();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new WindowsFormsApplication._CS6232_g7DataSetTableAdapters.doctorsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._CS6232_g7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Blood Pressure:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient Name:";
            // 
            // txtBoxBloodPressure
            // 
            this.txtBoxBloodPressure.Location = new System.Drawing.Point(87, 17);
            this.txtBoxBloodPressure.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxBloodPressure.Name = "txtBoxBloodPressure";
            this.txtBoxBloodPressure.Size = new System.Drawing.Size(99, 20);
            this.txtBoxBloodPressure.TabIndex = 4;
            // 
            // txtBoxPatientName
            // 
            this.txtBoxPatientName.Location = new System.Drawing.Point(131, 54);
            this.txtBoxPatientName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPatientName.Name = "txtBoxPatientName";
            this.txtBoxPatientName.Size = new System.Drawing.Size(274, 20);
            this.txtBoxPatientName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Symptoms:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Temperature:";
            // 
            // txtBoxTemperature
            // 
            this.txtBoxTemperature.Location = new System.Drawing.Point(79, 48);
            this.txtBoxTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxTemperature.Name = "txtBoxTemperature";
            this.txtBoxTemperature.Size = new System.Drawing.Size(52, 20);
            this.txtBoxTemperature.TabIndex = 8;
            // 
            // txtBoxSymptoms
            // 
            this.txtBoxSymptoms.Location = new System.Drawing.Point(48, 251);
            this.txtBoxSymptoms.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxSymptoms.Multiline = true;
            this.txtBoxSymptoms.Name = "txtBoxSymptoms";
            this.txtBoxSymptoms.Size = new System.Drawing.Size(357, 69);
            this.txtBoxSymptoms.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pulse:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBoxPulse
            // 
            this.txtBoxPulse.Location = new System.Drawing.Point(249, 17);
            this.txtBoxPulse.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPulse.Name = "txtBoxPulse";
            this.txtBoxPulse.Size = new System.Drawing.Size(87, 20);
            this.txtBoxPulse.TabIndex = 11;
            this.txtBoxPulse.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(196, 428);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(349, 428);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOrderTests
            // 
            this.btnOrderTests.AutoSize = true;
            this.btnOrderTests.Location = new System.Drawing.Point(48, 428);
            this.btnOrderTests.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderTests.Name = "btnOrderTests";
            this.btnOrderTests.Size = new System.Drawing.Size(72, 23);
            this.btnOrderTests.TabIndex = 14;
            this.btnOrderTests.Text = "Order Tests";
            this.btnOrderTests.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxWeight);
            this.groupBox1.Controls.Add(this.txtBoxHeight);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxBloodPressure);
            this.groupBox1.Controls.Add(this.txtBoxPulse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxTemperature);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(48, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 100);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vitals";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.Location = new System.Drawing.Point(296, 48);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(40, 20);
            this.txtBoxWeight.TabIndex = 15;
            // 
            // txtBoxHeight
            // 
            this.txtBoxHeight.Location = new System.Drawing.Point(190, 48);
            this.txtBoxHeight.Name = "txtBoxHeight";
            this.txtBoxHeight.Size = new System.Drawing.Size(40, 20);
            this.txtBoxHeight.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(246, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Height:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Notes:";
            // 
            // txtBoxNotes
            // 
            this.txtBoxNotes.Location = new System.Drawing.Point(48, 346);
            this.txtBoxNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxNotes.Multiline = true;
            this.txtBoxNotes.Name = "txtBoxNotes";
            this.txtBoxNotes.Size = new System.Drawing.Size(357, 69);
            this.txtBoxNotes.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Doctor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Nurse:";
            // 
            // comboBoxDoctorName
            // 
            this.comboBoxDoctorName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doctorsBindingSource, "last_name", true));
            this.comboBoxDoctorName.DataSource = this.doctorsBindingSource;
            this.comboBoxDoctorName.DisplayMember = "last_name";
            this.comboBoxDoctorName.FormattingEnabled = true;
            this.comboBoxDoctorName.Location = new System.Drawing.Point(101, 87);
            this.comboBoxDoctorName.Name = "comboBoxDoctorName";
            this.comboBoxDoctorName.Size = new System.Drawing.Size(117, 21);
            this.comboBoxDoctorName.TabIndex = 21;
            this.comboBoxDoctorName.ValueMember = "employeeID";
            // 
            // comboBoxNurseName
            // 
            this.comboBoxNurseName.DataSource = this.nursesBindingSource;
            this.comboBoxNurseName.DisplayMember = "last_name";
            this.comboBoxNurseName.FormattingEnabled = true;
            this.comboBoxNurseName.Location = new System.Drawing.Point(284, 87);
            this.comboBoxNurseName.Name = "comboBoxNurseName";
            this.comboBoxNurseName.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNurseName.TabIndex = 22;
            this.comboBoxNurseName.ValueMember = "employeeID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Patient ID:";
            // 
            // txtBoxPatientID
            // 
            this.txtBoxPatientID.Location = new System.Drawing.Point(112, 19);
            this.txtBoxPatientID.Name = "txtBoxPatientID";
            this.txtBoxPatientID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPatientID.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(240, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Visit Date:";
            // 
            // txtBoxVisitDate
            // 
            this.txtBoxVisitDate.Location = new System.Drawing.Point(297, 19);
            this.txtBoxVisitDate.Name = "txtBoxVisitDate";
            this.txtBoxVisitDate.Size = new System.Drawing.Size(108, 20);
            this.txtBoxVisitDate.TabIndex = 26;
            // 
            // _CS6232_g7DataSet
            // 
            this._CS6232_g7DataSet.DataSetName = "_CS6232_g7DataSet";
            this._CS6232_g7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nursesBindingSource
            // 
            this.nursesBindingSource.DataMember = "nurses";
            this.nursesBindingSource.DataSource = this._CS6232_g7DataSet;
            // 
            // nursesTableAdapter
            // 
            this.nursesTableAdapter.ClearBeforeFill = true;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "doctors";
            this.doctorsBindingSource.DataSource = this._CS6232_g7DataSet;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // NwNewVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 462);
            this.Controls.Add(this.txtBoxVisitDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBoxPatientID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBoxNurseName);
            this.Controls.Add(this.comboBoxDoctorName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxNotes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOrderTests);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxSymptoms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPatientName);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NwNewVisit";
            this.Text = "New Visit";
            this.Load += new System.EventHandler(this.NwNewVisit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._CS6232_g7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxBloodPressure;
        private System.Windows.Forms.TextBox txtBoxPatientName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxTemperature;
        private System.Windows.Forms.TextBox txtBoxSymptoms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPulse;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOrderTests;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.TextBox txtBoxHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxDoctorName;
        private System.Windows.Forms.ComboBox comboBoxNurseName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxPatientID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxVisitDate;
        private _CS6232_g7DataSet _CS6232_g7DataSet;
        private System.Windows.Forms.BindingSource nursesBindingSource;
        private _CS6232_g7DataSetTableAdapters.nursesTableAdapter nursesTableAdapter;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private _CS6232_g7DataSetTableAdapters.doctorsTableAdapter doctorsTableAdapter;

    }
}