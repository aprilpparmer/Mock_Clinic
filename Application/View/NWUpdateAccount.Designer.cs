namespace WindowsFormsApplication.View
{
    partial class NWUpdateAccount
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.genderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.ssnTextBox = new System.Windows.Forms.TextBox();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.middleInitialTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JobBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.Location = new System.Drawing.Point(418, 326);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 27);
            this.CancelButton.TabIndex = 41;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.AutoSize = true;
            this.AddNewButton.Location = new System.Drawing.Point(256, 326);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(140, 27);
            this.AddNewButton.TabIndex = 40;
            this.AddNewButton.Text = "Add New Employee";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(521, 112);
            this.femaleRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(75, 21);
            this.femaleRadioButton.TabIndex = 61;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.femaleRadioButton_CheckedChanged);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(445, 112);
            this.maleRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(59, 21);
            this.maleRadioButton.TabIndex = 60;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.maleRadioButton_CheckedChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(368, 111);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(56, 17);
            this.genderLabel.TabIndex = 74;
            this.genderLabel.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 71;
            this.label1.Text = "(optional)";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(445, 254);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zipTextBox.MaxLength = 5;
            this.zipTextBox.Multiline = true;
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(139, 29);
            this.zipTextBox.TabIndex = 67;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(382, 254);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(28, 17);
            this.zipLabel.TabIndex = 70;
            this.zipLabel.Text = "Zip";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(-62, 372);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(41, 17);
            this.stateLabel.TabIndex = 69;
            this.stateLabel.Text = "State";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(445, 207);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cityTextBox.MaxLength = 50;
            this.cityTextBox.Multiline = true;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(139, 29);
            this.cityTextBox.TabIndex = 65;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(382, 210);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(31, 17);
            this.cityLabel.TabIndex = 68;
            this.cityLabel.Text = "City";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(109, 156);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(128, 22);
            this.dateTimePicker.TabIndex = 59;
            this.dateTimePicker.Value = new System.DateTime(2015, 3, 24, 18, 35, 27, 0);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(107, 207);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressTextBox.MaxLength = 200;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(215, 29);
            this.addressTextBox.TabIndex = 62;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(107, 111);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneTextBox.MaxLength = 15;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(215, 22);
            this.PhoneTextBox.TabIndex = 56;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(27, 211);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 17);
            this.addressLabel.TabIndex = 64;
            this.addressLabel.Text = "Address";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(11, 111);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(90, 17);
            this.phoneLabel.TabIndex = 63;
            this.phoneLabel.Text = "Home Phone";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(107, 68);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTextBox.MaxLength = 50;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(215, 22);
            this.lastNameTextBox.TabIndex = 52;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(445, 68);
            this.ssnTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ssnTextBox.MaxLength = 9;
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(139, 22);
            this.ssnTextBox.TabIndex = 54;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(339, 23);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(85, 17);
            this.middleNameLabel.TabIndex = 58;
            this.middleNameLabel.Text = "Middle Initial";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(11, 68);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(76, 17);
            this.lastNameLabel.TabIndex = 55;
            this.lastNameLabel.Text = "Last Name";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(382, 68);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(36, 17);
            this.ssnLabel.TabIndex = 53;
            this.ssnLabel.Text = "SSN";
            // 
            // middleInitialTextBox
            // 
            this.middleInitialTextBox.Location = new System.Drawing.Point(445, 24);
            this.middleInitialTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.middleInitialTextBox.MaxLength = 1;
            this.middleInitialTextBox.Name = "middleInitialTextBox";
            this.middleInitialTextBox.Size = new System.Drawing.Size(31, 22);
            this.middleInitialTextBox.TabIndex = 51;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(107, 24);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTextBox.MaxLength = 50;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(215, 22);
            this.firstNameTextBox.TabIndex = 49;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(11, 164);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(90, 17);
            this.dobLabel.TabIndex = 50;
            this.dobLabel.Text = "Date Of Birth";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(11, 24);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(76, 17);
            this.firstNameLabel.TabIndex = 48;
            this.firstNameLabel.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Employee Type";
            // 
            // JobBox
            // 
            this.JobBox.FormattingEnabled = true;
            this.JobBox.Items.AddRange(new object[] {
            "Doctor",
            "Nurse",
            "Administrator"});
            this.JobBox.Location = new System.Drawing.Point(445, 158);
            this.JobBox.Name = "JobBox";
            this.JobBox.Size = new System.Drawing.Size(121, 24);
            this.JobBox.TabIndex = 77;
            this.JobBox.SelectedIndexChanged += new System.EventHandler(this.JobBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 78;
            this.label3.Text = "State";
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.Location = new System.Drawing.Point(97, 326);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(140, 27);
            this.UpdateButton.TabIndex = 79;
            this.UpdateButton.Text = "Update Employee";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // StateComboBox
            // 
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "District Of Columbia",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.StateComboBox.Location = new System.Drawing.Point(107, 257);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(215, 24);
            this.StateComboBox.TabIndex = 80;
            // 
            // NWUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 382);
            this.Controls.Add(this.StateComboBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JobBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.ssnTextBox);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.middleInitialTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddNewButton);
            this.Name = "NWUpdateAccount";
            this.Text = "Update Account";
            this.Load += new System.EventHandler(this.NWUpdateAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox ssnTextBox;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.TextBox middleInitialTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox JobBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.ComboBox StateComboBox;
    }
}