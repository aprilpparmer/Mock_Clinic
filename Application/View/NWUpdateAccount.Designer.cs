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
            this.components = new System.ComponentModel.Container();
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
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._CS6232_g7DataSet = new WindowsFormsApplication._CS6232_g7DataSet();
            this.positionsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cS6232g7DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.StateComboBox = new System.Windows.Forms.ComboBox();
            this.positionsTableAdapter = new WindowsFormsApplication._CS6232_g7DataSetTableAdapters.positionsTableAdapter();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.enabledCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._CS6232_g7DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS6232g7DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.Location = new System.Drawing.Point(311, 313);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(56, 23);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddNewButton
            // 
            this.AddNewButton.AutoSize = true;
            this.AddNewButton.Location = new System.Drawing.Point(189, 313);
            this.AddNewButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(110, 23);
            this.AddNewButton.TabIndex = 18;
            this.AddNewButton.Text = "Add New Employee";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.AddNewEmployee_Click);
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(391, 91);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRadioButton.TabIndex = 7;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            this.femaleRadioButton.CheckedChanged += new System.EventHandler(this.femaleRadioButton_CheckedChanged);
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(334, 91);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.maleRadioButton.TabIndex = 6;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            this.maleRadioButton.CheckedChanged += new System.EventHandler(this.maleRadioButton_CheckedChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(254, 90);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 13);
            this.genderLabel.TabIndex = 74;
            this.genderLabel.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "(optional)";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(334, 206);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.zipTextBox.MaxLength = 5;
            this.zipTextBox.Multiline = true;
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(105, 24);
            this.zipTextBox.TabIndex = 13;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(254, 206);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(22, 13);
            this.zipLabel.TabIndex = 70;
            this.zipLabel.Text = "Zip";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(-46, 302);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(32, 13);
            this.stateLabel.TabIndex = 69;
            this.stateLabel.Text = "State";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(334, 168);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityTextBox.MaxLength = 50;
            this.cityTextBox.Multiline = true;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(105, 24);
            this.cityTextBox.TabIndex = 11;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(254, 168);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 68;
            this.cityLabel.Text = "City";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(82, 127);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.Value = new System.DateTime(2015, 3, 24, 18, 35, 27, 0);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(80, 168);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressTextBox.MaxLength = 200;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(162, 24);
            this.addressTextBox.TabIndex = 10;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(80, 90);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PhoneTextBox.MaxLength = 15;
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(162, 20);
            this.PhoneTextBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(8, 168);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 64;
            this.addressLabel.Text = "Address";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(8, 90);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(69, 13);
            this.phoneLabel.TabIndex = 63;
            this.phoneLabel.Text = "Home Phone";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(80, 55);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.MaxLength = 50;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(334, 55);
            this.ssnTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ssnTextBox.MaxLength = 9;
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.Size = new System.Drawing.Size(105, 20);
            this.ssnTextBox.TabIndex = 4;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(254, 19);
            this.middleNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(65, 13);
            this.middleNameLabel.TabIndex = 58;
            this.middleNameLabel.Text = "Middle Initial";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(8, 55);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 55;
            this.lastNameLabel.Text = "Last Name";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(254, 55);
            this.ssnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(29, 13);
            this.ssnLabel.TabIndex = 53;
            this.ssnLabel.Text = "SSN";
            // 
            // middleInitialTextBox
            // 
            this.middleInitialTextBox.Location = new System.Drawing.Point(334, 20);
            this.middleInitialTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.middleInitialTextBox.MaxLength = 1;
            this.middleInitialTextBox.Name = "middleInitialTextBox";
            this.middleInitialTextBox.Size = new System.Drawing.Size(24, 20);
            this.middleInitialTextBox.TabIndex = 2;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(80, 20);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.MaxLength = 50;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(8, 133);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(68, 13);
            this.dobLabel.TabIndex = 50;
            this.dobLabel.Text = "Date Of Birth";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(8, 20);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 48;
            this.firstNameLabel.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Position";
            // 
            // JobBox
            // 
            this.JobBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.positionsBindingSource, "positionID", true));
            this.JobBox.DataSource = this.positionsBindingSource1;
            this.JobBox.DisplayMember = "position_name";
            this.JobBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JobBox.FormattingEnabled = true;
            this.JobBox.Location = new System.Drawing.Point(334, 128);
            this.JobBox.Margin = new System.Windows.Forms.Padding(2);
            this.JobBox.Name = "JobBox";
            this.JobBox.Size = new System.Drawing.Size(105, 21);
            this.JobBox.TabIndex = 9;
            this.JobBox.ValueMember = "positionID";
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "positions";
            this.positionsBindingSource.DataSource = this._CS6232_g7DataSet;
            // 
            // _CS6232_g7DataSet
            // 
            this._CS6232_g7DataSet.DataSetName = "_CS6232_g7DataSet";
            this._CS6232_g7DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionsBindingSource1
            // 
            this.positionsBindingSource1.DataMember = "positions";
            this.positionsBindingSource1.DataSource = this.cS6232g7DataSetBindingSource;
            // 
            // cS6232g7DataSetBindingSource
            // 
            this.cS6232g7DataSetBindingSource.DataSource = this._CS6232_g7DataSet;
            this.cS6232g7DataSetBindingSource.Position = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "State";
            // 
            // UpdateButton
            // 
            this.UpdateButton.AutoSize = true;
            this.UpdateButton.Location = new System.Drawing.Point(70, 313);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(105, 23);
            this.UpdateButton.TabIndex = 17;
            this.UpdateButton.Text = "Update Employee";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // StateComboBox
            // 
            this.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StateComboBox.FormattingEnabled = true;
            this.StateComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "MD",
            "ME",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.StateComboBox.Location = new System.Drawing.Point(80, 209);
            this.StateComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(162, 21);
            this.StateComboBox.TabIndex = 12;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(334, 251);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.MaxLength = 50;
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(105, 24);
            this.passwordTextBox.TabIndex = 15;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.EnableAccount);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Password";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(80, 251);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginTextBox.MaxLength = 200;
            this.loginTextBox.Multiline = true;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(162, 24);
            this.loginTextBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 82;
            this.label5.Text = "Login";
            // 
            // enabledCheckBox
            // 
            this.enabledCheckBox.AutoSize = true;
            this.enabledCheckBox.Location = new System.Drawing.Point(12, 291);
            this.enabledCheckBox.Name = "enabledCheckBox";
            this.enabledCheckBox.Size = new System.Drawing.Size(65, 17);
            this.enabledCheckBox.TabIndex = 16;
            this.enabledCheckBox.Text = "Enabled";
            this.enabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // NWUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 375);
            this.Controls.Add(this.enabledCheckBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label5);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NWUpdateAccount";
            this.Text = "Update Account";
            this.Load += new System.EventHandler(this.NWUpdateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._CS6232_g7DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cS6232g7DataSetBindingSource)).EndInit();
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
        private _CS6232_g7DataSet _CS6232_g7DataSet;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private _CS6232_g7DataSetTableAdapters.positionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.BindingSource positionsBindingSource1;
        private System.Windows.Forms.BindingSource cS6232g7DataSetBindingSource;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox enabledCheckBox;
    }
}