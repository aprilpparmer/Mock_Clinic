﻿namespace WindowsFormsApplication.View
{
    partial class NwPatientSearch
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
            this.listViewPatients = new System.Windows.Forms.ListView();
            this.PatientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SSN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MiddleInitial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HomePhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Child = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCloseSearch = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // listViewPatients
            // 
            this.listViewPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PatientID,
            this.SSN,
            this.LastName,
            this.MiddleInitial,
            this.FirstName,
            this.DOB,
            this.Gender,
            this.Address,
            this.City,
            this.State,
            this.Zip,
            this.HomePhone,
            this.WorkPhone,
            this.Child});
            this.listViewPatients.Location = new System.Drawing.Point(15, 71);
            this.listViewPatients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewPatients.Name = "listViewPatients";
            this.listViewPatients.Size = new System.Drawing.Size(1336, 203);
            this.listViewPatients.TabIndex = 0;
            this.listViewPatients.UseCompatibleStateImageBehavior = false;
            this.listViewPatients.View = System.Windows.Forms.View.Details;
            // 
            // PatientID
            // 
            this.PatientID.Text = "PatientID";
            this.PatientID.Width = 56;
            // 
            // SSN
            // 
            this.SSN.Text = "SSN";
            this.SSN.Width = 63;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 78;
            // 
            // MiddleInitial
            // 
            this.MiddleInitial.Text = "Middle Initial";
            this.MiddleInitial.Width = 72;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 83;
            // 
            // DOB
            // 
            this.DOB.Text = "DOB";
            this.DOB.Width = 64;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 49;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 75;
            // 
            // City
            // 
            this.City.Text = "City";
            this.City.Width = 57;
            // 
            // State
            // 
            this.State.Text = "State";
            this.State.Width = 40;
            // 
            // Zip
            // 
            this.Zip.Text = "Zip";
            this.Zip.Width = 59;
            // 
            // HomePhone
            // 
            this.HomePhone.Text = "Home Phone";
            this.HomePhone.Width = 102;
            // 
            // WorkPhone
            // 
            this.WorkPhone.Text = "Work Phone";
            this.WorkPhone.Width = 106;
            // 
            // Child
            // 
            this.Child.Text = "Child";
            this.Child.Width = 70;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(16, 30);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(110, 17);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Search by DOB:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(335, 26);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(132, 22);
            this.textBoxLastName.TabIndex = 4;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(256, 28);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(80, 17);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(842, 26);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(163, 28);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search Patients";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCloseSearch
            // 
            this.buttonCloseSearch.Location = new System.Drawing.Point(1177, 292);
            this.buttonCloseSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCloseSearch.Name = "buttonCloseSearch";
            this.buttonCloseSearch.Size = new System.Drawing.Size(100, 28);
            this.buttonCloseSearch.TabIndex = 6;
            this.buttonCloseSearch.Text = "Close";
            this.buttonCloseSearch.UseVisualStyleBackColor = true;
            this.buttonCloseSearch.Click += new System.EventHandler(this.buttonCloseSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(1069, 292);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 28);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(563, 28);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(132, 22);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Name:";
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDOB.Location = new System.Drawing.Point(124, 27);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(125, 22);
            this.dateTimeDOB.TabIndex = 10;
            // 
            // NwPatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 335);
            this.Controls.Add(this.dateTimeDOB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCloseSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.listViewPatients);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NwPatientSearch";
            this.Text = "Patient Search";
            this.Load += new System.EventHandler(this.NwPatientSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPatients;
        private System.Windows.Forms.ColumnHeader PatientID;
        private System.Windows.Forms.ColumnHeader SSN;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader MiddleInitial;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader DOB;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader Zip;
        private System.Windows.Forms.ColumnHeader HomePhone;
        private System.Windows.Forms.ColumnHeader WorkPhone;
        private System.Windows.Forms.ColumnHeader Child;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCloseSearch;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeDOB;

    }
}