namespace WindowsFormsApplication.View
{
    partial class NwDocSearch
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
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.updateEmployeeButton = new System.Windows.Forms.Button();
            this.viewEmployeeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCloseSearch = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.listViewEmployee = new System.Windows.Forms.ListView();
            this.employeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PositionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Active = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.AutoSize = true;
            this.addEmployeeButton.Location = new System.Drawing.Point(524, 142);
            this.addEmployeeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(94, 23);
            this.addEmployeeButton.TabIndex = 21;
            this.addEmployeeButton.Text = "Add Employee";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // updateEmployeeButton
            // 
            this.updateEmployeeButton.AutoSize = true;
            this.updateEmployeeButton.Location = new System.Drawing.Point(524, 117);
            this.updateEmployeeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateEmployeeButton.Name = "updateEmployeeButton";
            this.updateEmployeeButton.Size = new System.Drawing.Size(94, 23);
            this.updateEmployeeButton.TabIndex = 19;
            this.updateEmployeeButton.Text = "Edit Employee";
            this.updateEmployeeButton.UseVisualStyleBackColor = true;
            this.updateEmployeeButton.Click += new System.EventHandler(this.updateEmployeeButton_Click);
            // 
            // viewEmployeeButton
            // 
            this.viewEmployeeButton.AutoSize = true;
            this.viewEmployeeButton.Location = new System.Drawing.Point(524, 92);
            this.viewEmployeeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewEmployeeButton.Name = "viewEmployeeButton";
            this.viewEmployeeButton.Size = new System.Drawing.Size(96, 23);
            this.viewEmployeeButton.TabIndex = 18;
            this.viewEmployeeButton.Text = "View Employee";
            this.viewEmployeeButton.UseVisualStyleBackColor = true;
            this.viewEmployeeButton.Click += new System.EventHandler(this.viewEmployeeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(245, 16);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 15;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(353, 275);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCloseSearch
            // 
            this.buttonCloseSearch.Location = new System.Drawing.Point(445, 275);
            this.buttonCloseSearch.Name = "buttonCloseSearch";
            this.buttonCloseSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonCloseSearch.TabIndex = 24;
            this.buttonCloseSearch.Text = "Close";
            this.buttonCloseSearch.UseVisualStyleBackColor = true;
            this.buttonCloseSearch.Click += new System.EventHandler(this.buttonCloseSearch_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(363, 11);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(122, 23);
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.Text = "Search Employees";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(74, 15);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 14;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(15, 16);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 16;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(-187, 80);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(84, 13);
            this.labelFirstName.TabIndex = 13;
            this.labelFirstName.Text = "Search by DOB:";
            // 
            // listViewEmployee
            // 
            this.listViewEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeID,
            this.FirstName,
            this.LastName,
            this.PositionID,
            this.Active});
            this.listViewEmployee.Location = new System.Drawing.Point(10, 50);
            this.listViewEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewEmployee.Name = "listViewEmployee";
            this.listViewEmployee.Size = new System.Drawing.Size(510, 221);
            this.listViewEmployee.TabIndex = 25;
            this.listViewEmployee.UseCompatibleStateImageBehavior = false;
            this.listViewEmployee.View = System.Windows.Forms.View.Details;
            // 
            // employeeID
            // 
            this.employeeID.Text = "Employee ID";
            this.employeeID.Width = 104;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 156;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 195;
            // 
            // PositionID
            // 
            this.PositionID.Text = "Position";
            this.PositionID.Width = 111;
            // 
            // Active
            // 
            this.Active.Text = "Status";
            this.Active.Width = 96;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.Location = new System.Drawing.Point(524, 167);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(97, 23);
            this.DeleteButton.TabIndex = 26;
            this.DeleteButton.Text = "Delete Employee";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NwDocSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 318);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.listViewEmployee);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.updateEmployeeButton);
            this.Controls.Add(this.viewEmployeeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCloseSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NwDocSearch";
            this.Text = "Employee Search";
            this.Activated += new System.EventHandler(this.NwDocSearch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button updateEmployeeButton;
        private System.Windows.Forms.Button viewEmployeeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCloseSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.ListView listViewEmployee;
        private System.Windows.Forms.ColumnHeader employeeID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader PositionID;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ColumnHeader Active;

    }
}