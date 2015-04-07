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
            this.NWNurseMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDiagMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDiagMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allergiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.UserLabel = new System.Windows.Forms.Label();
            this.NWAdminMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NWNurseMenuStrip.SuspendLayout();
            this.NWAdminMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NWNurseMenuStrip
            // 
            this.NWNurseMenuStrip.Enabled = false;
            this.NWNurseMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NWNurseMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.patientToolStripMenuItem,
            this.toolStripMenuItem1});
            this.NWNurseMenuStrip.Location = new System.Drawing.Point(0, 28);
            this.NWNurseMenuStrip.Name = "NWNurseMenuStrip";
            this.NWNurseMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.NWNurseMenuStrip.Size = new System.Drawing.Size(1163, 28);
            this.NWNurseMenuStrip.TabIndex = 1;
            this.NWNurseMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegisterPatient,
            this.searchToolStripMenuItem,
            this.orderTestsToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // RegisterPatient
            // 
            this.RegisterPatient.Name = "RegisterPatient";
            this.RegisterPatient.Size = new System.Drawing.Size(153, 24);
            this.RegisterPatient.Text = "Register";
            this.RegisterPatient.Click += new System.EventHandler(this.RegisterPatient_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // orderTestsToolStripMenuItem
            // 
            this.orderTestsToolStripMenuItem.Name = "orderTestsToolStripMenuItem";
            this.orderTestsToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.orderTestsToolStripMenuItem.Text = "Order Tests";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagnosisToolStripMenuItem,
            this.allergiesToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 24);
            this.toolStripMenuItem1.Text = "System Settings";
            // 
            // diagnosisToolStripMenuItem
            // 
            this.diagnosisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDiagMenuItem,
            this.listDiagMenuItem});
            this.diagnosisToolStripMenuItem.Name = "diagnosisToolStripMenuItem";
            this.diagnosisToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.diagnosisToolStripMenuItem.Text = "Diagnoses";
            // 
            // addNewDiagMenuItem
            // 
            this.addNewDiagMenuItem.Name = "addNewDiagMenuItem";
            this.addNewDiagMenuItem.Size = new System.Drawing.Size(140, 24);
            this.addNewDiagMenuItem.Text = "Add New";
            this.addNewDiagMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // listDiagMenuItem
            // 
            this.listDiagMenuItem.Name = "listDiagMenuItem";
            this.listDiagMenuItem.Size = new System.Drawing.Size(140, 24);
            this.listDiagMenuItem.Text = "List";
            this.listDiagMenuItem.Click += new System.EventHandler(this.listDiagMenuItem_Click);
            // 
            // allergiesToolStripMenuItem
            // 
            this.allergiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem1,
            this.listToolStripMenuItem1});
            this.allergiesToolStripMenuItem.Name = "allergiesToolStripMenuItem";
            this.allergiesToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.allergiesToolStripMenuItem.Text = "Allergies";
            // 
            // addNewToolStripMenuItem1
            // 
            this.addNewToolStripMenuItem1.Name = "addNewToolStripMenuItem1";
            this.addNewToolStripMenuItem1.Size = new System.Drawing.Size(140, 24);
            this.addNewToolStripMenuItem1.Text = "Add New";
            // 
            // listToolStripMenuItem1
            // 
            this.listToolStripMenuItem1.Name = "listToolStripMenuItem1";
            this.listToolStripMenuItem1.Size = new System.Drawing.Size(140, 24);
            this.listToolStripMenuItem1.Text = "List";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(964, 9);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(0, 17);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Visible = false;
            // 
            // NWAdminMenuStrip
            // 
            this.NWAdminMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NWAdminMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.employeeToolStripMenuItem});
            this.NWAdminMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.NWAdminMenuStrip.Name = "NWAdminMenuStrip";
            this.NWAdminMenuStrip.Size = new System.Drawing.Size(1163, 28);
            this.NWAdminMenuStrip.TabIndex = 4;
            this.NWAdminMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.employeeToolStripMenuItem.Text = "Tasks";
            // 
            // NorthwindAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 475);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.NWNurseMenuStrip);
            this.Controls.Add(this.NWAdminMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.NWNurseMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NorthwindAdmin";
            this.Text = "Northwind Clinic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Northwind_Load);
            this.NWNurseMenuStrip.ResumeLayout(false);
            this.NWNurseMenuStrip.PerformLayout();
            this.NWAdminMenuStrip.ResumeLayout(false);
            this.NWAdminMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NWNurseMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RegisterPatient;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.ToolStripMenuItem orderTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem diagnosisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDiagMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listDiagMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allergiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip NWAdminMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
    }
}

