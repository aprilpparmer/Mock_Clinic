namespace WindowsFormsApplication.View
{
    partial class NorthwindAdmin
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
            this.NWMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDiagMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDiagMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allergiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientVisitSummaryByDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserLabel = new System.Windows.Forms.Label();
            this.NWMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NWMenuStrip
            // 
            this.NWMenuStrip.Enabled = false;
            this.NWMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NWMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.adminMenuItems});
            this.NWMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.NWMenuStrip.Name = "NWMenuStrip";
            this.NWMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.NWMenuStrip.Size = new System.Drawing.Size(872, 24);
            this.NWMenuStrip.TabIndex = 1;
            this.NWMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegisterPatient,
            this.searchToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // RegisterPatient
            // 
            this.RegisterPatient.Name = "RegisterPatient";
            this.RegisterPatient.Size = new System.Drawing.Size(116, 22);
            this.RegisterPatient.Text = "Register";
            this.RegisterPatient.Click += new System.EventHandler(this.RegisterPatient_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // adminMenuItems
            // 
            this.adminMenuItems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagnosisToolStripMenuItem,
            this.allergiesToolStripMenuItem,
            this.accountsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.testsToolStripMenuItem});
            this.adminMenuItems.Name = "adminMenuItems";
            this.adminMenuItems.Size = new System.Drawing.Size(100, 20);
            this.adminMenuItems.Text = "Admin Settings";
            // 
            // diagnosisToolStripMenuItem
            // 
            this.diagnosisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDiagMenuItem,
            this.listDiagMenuItem});
            this.diagnosisToolStripMenuItem.Name = "diagnosisToolStripMenuItem";
            this.diagnosisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.diagnosisToolStripMenuItem.Text = "Diagnoses";
            // 
            // addNewDiagMenuItem
            // 
            this.addNewDiagMenuItem.Name = "addNewDiagMenuItem";
            this.addNewDiagMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addNewDiagMenuItem.Text = "Add New";
            this.addNewDiagMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // listDiagMenuItem
            // 
            this.listDiagMenuItem.Name = "listDiagMenuItem";
            this.listDiagMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listDiagMenuItem.Text = "List";
            this.listDiagMenuItem.Click += new System.EventHandler(this.listDiagMenuItem_Click);
            // 
            // allergiesToolStripMenuItem
            // 
            this.allergiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.listToolStripMenuItem1});
            this.allergiesToolStripMenuItem.Name = "allergiesToolStripMenuItem";
            this.allergiesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allergiesToolStripMenuItem.Text = "Allergies";
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.addNewToolStripMenuItem1.Text = "Add New";
            // 
            // listToolStripMenuItem1
            // 
            this.listToolStripMenuItem1.Name = "listToolStripMenuItem1";
            this.listToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.listToolStripMenuItem1.Text = "List";
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.listEmployeesToolStripMenuItem});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.accountsToolStripMenuItem.Text = "Employees";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // listEmployeesToolStripMenuItem
            // 
            this.listEmployeesToolStripMenuItem.Name = "listEmployeesToolStripMenuItem";
            this.listEmployeesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listEmployeesToolStripMenuItem.Text = "Search Employees";
            this.listEmployeesToolStripMenuItem.Click += new System.EventHandler(this.listEmployeesToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientVisitSummaryByDateToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // patientVisitSummaryByDateToolStripMenuItem
            // 
            this.patientVisitSummaryByDateToolStripMenuItem.Name = "patientVisitSummaryByDateToolStripMenuItem";
            this.patientVisitSummaryByDateToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.patientVisitSummaryByDateToolStripMenuItem.Text = "Patient Visit Summary By Date";
            this.patientVisitSummaryByDateToolStripMenuItem.Click += new System.EventHandler(this.patientVisitSummaryByDateToolStripMenuItem_Click);
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTestToolStripMenuItem,
            this.listTestsToolStripMenuItem});
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.testsToolStripMenuItem.Text = "Tests";
            // 
            // addTestToolStripMenuItem
            // 
            this.addTestToolStripMenuItem.Name = "addTestToolStripMenuItem";
            this.addTestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addTestToolStripMenuItem.Text = "Add Test";
            this.addTestToolStripMenuItem.Click += new System.EventHandler(this.addTestToolStripMenuItem_Click);
            // 
            // listTestsToolStripMenuItem
            // 
            this.listTestsToolStripMenuItem.Name = "listTestsToolStripMenuItem";
            this.listTestsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listTestsToolStripMenuItem.Text = "List Tests";
            this.listTestsToolStripMenuItem.Click += new System.EventHandler(this.listTestsToolStripMenuItem_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(723, 7);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(0, 13);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Visible = false;
            // 
            // NorthwindAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 386);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.NWMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.NWMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NorthwindAdmin";
            this.Text = "Northwind Clinic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Northwind_Load);
            this.NWMenuStrip.ResumeLayout(false);
            this.NWMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NWMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegisterPatient;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenuItems;
        private System.Windows.Forms.ToolStripMenuItem diagnosisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDiagMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDiagMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allergiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientVisitSummaryByDateToolStripMenuItem;
    }
}

