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
            this.NWmenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserLabel = new System.Windows.Forms.Label();
            this.NWmenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NWmenuStrip
            // 
            this.NWmenuStrip.Enabled = false;
            this.NWmenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NWmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.patientToolStripMenuItem});
            this.NWmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.NWmenuStrip.Name = "NWmenuStrip";
            this.NWmenuStrip.Size = new System.Drawing.Size(1163, 28);
            this.NWmenuStrip.TabIndex = 1;
            this.NWmenuStrip.Text = "menuStrip1";
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
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editInformationToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.orderTestsToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // editInformationToolStripMenuItem
            // 
            this.editInformationToolStripMenuItem.Name = "editInformationToolStripMenuItem";
            this.editInformationToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.editInformationToolStripMenuItem.Text = "Register";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // orderTestsToolStripMenuItem
            // 
            this.orderTestsToolStripMenuItem.Name = "orderTestsToolStripMenuItem";
            this.orderTestsToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.orderTestsToolStripMenuItem.Text = "Order Tests";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.searchToolStripMenuItem.Text = "Search";
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
            // NorthwindAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 475);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.NWmenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.NWmenuStrip;
            this.Name = "NorthwindAdmin";
            this.Text = "Northwind Clinic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Northwind_Load);
            this.NWmenuStrip.ResumeLayout(false);
            this.NWmenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip NWmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.ToolStripMenuItem orderTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    }
}

