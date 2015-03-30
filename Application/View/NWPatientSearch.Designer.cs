namespace WindowsFormsApplication.View
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
            this.viewPatientButton = new System.Windows.Forms.Button();
            this.editPatientButton = new System.Windows.Forms.Button();
            this.viewVisitsButton = new System.Windows.Forms.Button();
            this.addVisitButton = new System.Windows.Forms.Button();
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
            this.listViewPatients.Location = new System.Drawing.Point(11, 58);
            this.listViewPatients.Margin = new System.Windows.Forms.Padding(2);
            this.listViewPatients.Name = "listViewPatients";
            this.listViewPatients.Size = new System.Drawing.Size(1003, 166);
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
            this.labelFirstName.Location = new System.Drawing.Point(12, 24);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(84, 13);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Search by DOB:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(251, 21);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(192, 23);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(632, 21);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(122, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search Patients";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCloseSearch
            // 
            this.buttonCloseSearch.Location = new System.Drawing.Point(883, 237);
            this.buttonCloseSearch.Name = "buttonCloseSearch";
            this.buttonCloseSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseSearch.TabIndex = 10;
            this.buttonCloseSearch.Text = "Close";
            this.buttonCloseSearch.UseVisualStyleBackColor = true;
            this.buttonCloseSearch.Click += new System.EventHandler(this.buttonCloseSearch_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(802, 237);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // viewPatientButton
            // 
            this.viewPatientButton.Location = new System.Drawing.Point(1018, 58);
            this.viewPatientButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewPatientButton.Name = "viewPatientButton";
            this.viewPatientButton.Size = new System.Drawing.Size(88, 19);
            this.viewPatientButton.TabIndex = 5;
            this.viewPatientButton.Text = "View Patient";
            this.viewPatientButton.UseVisualStyleBackColor = true;
            this.viewPatientButton.Click += new System.EventHandler(this.viewPatientButton_Click);
            // 
            // editPatientButton
            // 
            this.editPatientButton.Location = new System.Drawing.Point(1018, 82);
            this.editPatientButton.Margin = new System.Windows.Forms.Padding(2);
            this.editPatientButton.Name = "editPatientButton";
            this.editPatientButton.Size = new System.Drawing.Size(88, 19);
            this.editPatientButton.TabIndex = 6;
            this.editPatientButton.Text = "Edit Patient";
            this.editPatientButton.UseVisualStyleBackColor = true;
            this.editPatientButton.Click += new System.EventHandler(this.editPatientButton_Click);
            // 
            // viewVisitsButton
            // 
            this.viewVisitsButton.Location = new System.Drawing.Point(1018, 105);
            this.viewVisitsButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewVisitsButton.Name = "viewVisitsButton";
            this.viewVisitsButton.Size = new System.Drawing.Size(88, 19);
            this.viewVisitsButton.TabIndex = 7;
            this.viewVisitsButton.Text = "View Visits";
            this.viewVisitsButton.UseVisualStyleBackColor = true;
            // 
            // addVisitButton
            // 
            this.addVisitButton.Location = new System.Drawing.Point(1018, 129);
            this.addVisitButton.Margin = new System.Windows.Forms.Padding(2);
            this.addVisitButton.Name = "addVisitButton";
            this.addVisitButton.Size = new System.Drawing.Size(88, 19);
            this.addVisitButton.TabIndex = 8;
            this.addVisitButton.Text = "Add Visist";
            this.addVisitButton.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(422, 23);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Name:";
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDOB.Location = new System.Drawing.Point(93, 22);
            this.dateTimeDOB.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(95, 20);
            this.dateTimeDOB.TabIndex = 1;
            // 
            // NwPatientSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 285);
            this.Controls.Add(this.addVisitButton);
            this.Controls.Add(this.viewVisitsButton);
            this.Controls.Add(this.editPatientButton);
            this.Controls.Add(this.viewPatientButton);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NwPatientSearch";
            this.Text = "Patient Search";
            this.Activated += new System.EventHandler(this.activatedForum);
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

        private System.Windows.Forms.Button viewPatientButton;
        private System.Windows.Forms.Button editPatientButton;
        private System.Windows.Forms.Button viewVisitsButton;
        private System.Windows.Forms.Button addVisitButton;

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeDOB;


    }
}