namespace WindowsFormsApplication.View
{
    partial class NWViewPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NWViewPatient));
            this.genderLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.homePhoneTextBox = new System.Windows.Forms.TextBox();
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
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.workPhoneLabel = new System.Windows.Forms.Label();
            this.workPhoneTextBox = new System.Windows.Forms.TextBox();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.newVisitButton = new System.Windows.Forms.Button();
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
            this.patient_visitDataGridView = new System.Windows.Forms.DataGridView();
            this.patient_visitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientVisitDataSet = new WindowsFormsApplication.PatientVisitDataSet();
            this.patient_visitTableAdapter = new WindowsFormsApplication.PatientVisitDataSetTableAdapters.patient_visitTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication.PatientVisitDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitInfoButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingNavigator)).BeginInit();
            this.patient_visitBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(471, 70);
            this.genderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(42, 13);
            this.genderLabel.TabIndex = 56;
            this.genderLabel.Text = "Gender";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(780, 108);
            this.zipTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.zipTextBox.MaxLength = 5;
            this.zipTextBox.Multiline = true;
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.ReadOnly = true;
            this.zipTextBox.Size = new System.Drawing.Size(105, 24);
            this.zipTextBox.TabIndex = 47;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(700, 111);
            this.zipLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(22, 13);
            this.zipLabel.TabIndex = 52;
            this.zipLabel.Text = "Zip";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(547, 108);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.stateTextBox.MaxLength = 50;
            this.stateTextBox.Multiline = true;
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.ReadOnly = true;
            this.stateTextBox.Size = new System.Drawing.Size(128, 24);
            this.stateTextBox.TabIndex = 46;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(471, 111);
            this.stateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(32, 13);
            this.stateLabel.TabIndex = 51;
            this.stateLabel.Text = "State";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(354, 108);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityTextBox.MaxLength = 50;
            this.cityTextBox.Multiline = true;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.ReadOnly = true;
            this.cityTextBox.Size = new System.Drawing.Size(105, 24);
            this.cityTextBox.TabIndex = 44;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(274, 111);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 50;
            this.cityLabel.Text = "City";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(285, 438);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(56, 19);
            this.CancelButton.TabIndex = 49;
            this.CancelButton.Text = "Close";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(100, 108);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressTextBox.MaxLength = 200;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(162, 24);
            this.addressTextBox.TabIndex = 42;
            // 
            // homePhoneTextBox
            // 
            this.homePhoneTextBox.Location = new System.Drawing.Point(100, 71);
            this.homePhoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.homePhoneTextBox.MaxLength = 15;
            this.homePhoneTextBox.Name = "homePhoneTextBox";
            this.homePhoneTextBox.ReadOnly = true;
            this.homePhoneTextBox.Size = new System.Drawing.Size(162, 20);
            this.homePhoneTextBox.TabIndex = 36;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(28, 111);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 45;
            this.addressLabel.Text = "Address";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(28, 71);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(69, 13);
            this.phoneLabel.TabIndex = 43;
            this.phoneLabel.Text = "Home Phone";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(547, 38);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.lastNameTextBox.MaxLength = 50;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(128, 20);
            this.lastNameTextBox.TabIndex = 32;
            // 
            // ssnTextBox
            // 
            this.ssnTextBox.Location = new System.Drawing.Point(780, 38);
            this.ssnTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ssnTextBox.MaxLength = 9;
            this.ssnTextBox.Name = "ssnTextBox";
            this.ssnTextBox.ReadOnly = true;
            this.ssnTextBox.Size = new System.Drawing.Size(105, 20);
            this.ssnTextBox.TabIndex = 34;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(274, 38);
            this.middleNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(65, 13);
            this.middleNameLabel.TabIndex = 38;
            this.middleNameLabel.Text = "Middle Initial";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(471, 38);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 35;
            this.lastNameLabel.Text = "Last Name";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(700, 38);
            this.ssnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(29, 13);
            this.ssnLabel.TabIndex = 33;
            this.ssnLabel.Text = "SSN";
            // 
            // middleInitialTextBox
            // 
            this.middleInitialTextBox.Location = new System.Drawing.Point(354, 38);
            this.middleInitialTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.middleInitialTextBox.MaxLength = 1;
            this.middleInitialTextBox.Name = "middleInitialTextBox";
            this.middleInitialTextBox.ReadOnly = true;
            this.middleInitialTextBox.Size = new System.Drawing.Size(24, 20);
            this.middleInitialTextBox.TabIndex = 31;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(100, 38);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.firstNameTextBox.MaxLength = 50;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.firstNameTextBox.TabIndex = 29;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Location = new System.Drawing.Point(700, 71);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(68, 13);
            this.dobLabel.TabIndex = 30;
            this.dobLabel.Text = "Date Of Birth";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(28, 38);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 28;
            this.firstNameLabel.Text = "First Name";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(780, 67);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.dateTextBox.MaxLength = 9;
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(105, 20);
            this.dateTextBox.TabIndex = 57;
            // 
            // workPhoneLabel
            // 
            this.workPhoneLabel.AutoSize = true;
            this.workPhoneLabel.Location = new System.Drawing.Point(274, 74);
            this.workPhoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.workPhoneLabel.Name = "workPhoneLabel";
            this.workPhoneLabel.Size = new System.Drawing.Size(67, 13);
            this.workPhoneLabel.TabIndex = 54;
            this.workPhoneLabel.Text = "Work Phone";
            // 
            // workPhoneTextBox
            // 
            this.workPhoneTextBox.Location = new System.Drawing.Point(354, 74);
            this.workPhoneTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.workPhoneTextBox.MaxLength = 15;
            this.workPhoneTextBox.Name = "workPhoneTextBox";
            this.workPhoneTextBox.ReadOnly = true;
            this.workPhoneTextBox.Size = new System.Drawing.Size(105, 20);
            this.workPhoneTextBox.TabIndex = 37;
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(547, 68);
            this.genderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.genderTextBox.MaxLength = 9;
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.ReadOnly = true;
            this.genderTextBox.Size = new System.Drawing.Size(128, 20);
            this.genderTextBox.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 18);
            this.label2.TabIndex = 60;
            this.label2.Text = "Patient Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 61;
            this.label3.Text = "Visit Information";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(810, 8);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 62;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // newVisitButton
            // 
            this.newVisitButton.Location = new System.Drawing.Point(532, 438);
            this.newVisitButton.Name = "newVisitButton";
            this.newVisitButton.Size = new System.Drawing.Size(75, 23);
            this.newVisitButton.TabIndex = 63;
            this.newVisitButton.Text = "New Visit";
            this.newVisitButton.UseVisualStyleBackColor = true;
            this.newVisitButton.Click += new System.EventHandler(this.newVisitButton_Click);
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
            this.patient_visitBindingNavigator.Size = new System.Drawing.Size(907, 25);
            this.patient_visitBindingNavigator.TabIndex = 64;
            this.patient_visitBindingNavigator.Text = "bindingNavigator1";
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
            this.patient_visitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patient_visitBindingNavigatorSaveItem.Enabled = false;
            this.patient_visitBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patient_visitBindingNavigatorSaveItem.Image")));
            this.patient_visitBindingNavigatorSaveItem.Name = "patient_visitBindingNavigatorSaveItem";
            this.patient_visitBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patient_visitBindingNavigatorSaveItem.Text = "Save Data";
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
            this.visitInfoButton});
            this.patient_visitDataGridView.DataSource = this.patient_visitBindingSource;
            this.patient_visitDataGridView.Location = new System.Drawing.Point(36, 186);
            this.patient_visitDataGridView.Name = "patient_visitDataGridView";
            this.patient_visitDataGridView.ReadOnly = true;
            this.patient_visitDataGridView.Size = new System.Drawing.Size(546, 220);
            this.patient_visitDataGridView.TabIndex = 65;
            this.patient_visitDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patient_visitDataGridView_CellContentClick);
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
            this.tableAdapterManager.patient_testsTableAdapter = null;
            this.tableAdapterManager.patient_visit_notesTableAdapter = null;
            this.tableAdapterManager.patient_visit_symptomsTableAdapter = null;
            this.tableAdapterManager.patient_visit_vitalsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication.PatientVisitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "visitID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Visit ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "visit_date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Visit Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "doctorName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Doctor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nurseName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nurse";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // visitInfoButton
            // 
            this.visitInfoButton.HeaderText = "Visit Info";
            this.visitInfoButton.Name = "visitInfoButton";
            this.visitInfoButton.ReadOnly = true;
            this.visitInfoButton.Text = "";
            this.visitInfoButton.UseColumnTextForButtonValue = true;
            // 
            // NWViewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 481);
            this.Controls.Add(this.patient_visitDataGridView);
            this.Controls.Add(this.patient_visitBindingNavigator);
            this.Controls.Add(this.newVisitButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.workPhoneTextBox);
            this.Controls.Add(this.workPhoneLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.homePhoneTextBox);
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
            this.Name = "NWViewPatient";
            this.Text = "View Patient";
            this.Activated += new System.EventHandler(this.activatedFom);
            this.Load += new System.EventHandler(this.NWViewPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingNavigator)).EndInit();
            this.patient_visitBindingNavigator.ResumeLayout(false);
            this.patient_visitBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient_visitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox homePhoneTextBox;
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
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.Label workPhoneLabel;
        private System.Windows.Forms.TextBox workPhoneTextBox;
        private System.Windows.Forms.TextBox genderTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button newVisitButton;
        private PatientVisitDataSet patientVisitDataSet;
        private System.Windows.Forms.BindingSource patient_visitBindingSource;
        private PatientVisitDataSetTableAdapters.patient_visitTableAdapter patient_visitTableAdapter;
        private PatientVisitDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.DataGridView patient_visitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewButtonColumn visitInfoButton;

    }
}