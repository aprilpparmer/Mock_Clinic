namespace WindowsFormsApplication.View
{
    partial class NWViewTests
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
            this.listViewTests = new System.Windows.Forms.ListView();
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.buttonDeleteTest = new System.Windows.Forms.Button();
            this.buttonUpdateTest = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewTests
            // 
            this.listViewTests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewTests.Location = new System.Drawing.Point(36, 35);
            this.listViewTests.Name = "listViewTests";
            this.listViewTests.Size = new System.Drawing.Size(286, 252);
            this.listViewTests.TabIndex = 0;
            this.listViewTests.UseCompatibleStateImageBehavior = false;
            this.listViewTests.View = System.Windows.Forms.View.Details;
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.Location = new System.Drawing.Point(12, 321);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTest.TabIndex = 1;
            this.buttonAddTest.Text = "Add Test";
            this.buttonAddTest.UseVisualStyleBackColor = true;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // buttonDeleteTest
            // 
            this.buttonDeleteTest.Location = new System.Drawing.Point(93, 321);
            this.buttonDeleteTest.Name = "buttonDeleteTest";
            this.buttonDeleteTest.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTest.TabIndex = 2;
            this.buttonDeleteTest.Text = "Delete Test";
            this.buttonDeleteTest.UseVisualStyleBackColor = true;
            this.buttonDeleteTest.Click += new System.EventHandler(this.buttonDeleteTest_Click);
            // 
            // buttonUpdateTest
            // 
            this.buttonUpdateTest.Location = new System.Drawing.Point(174, 321);
            this.buttonUpdateTest.Name = "buttonUpdateTest";
            this.buttonUpdateTest.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateTest.TabIndex = 3;
            this.buttonUpdateTest.Text = "Update Test";
            this.buttonUpdateTest.UseVisualStyleBackColor = true;
            this.buttonUpdateTest.Click += new System.EventHandler(this.buttonUpdateTest_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(255, 321);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Test ID";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Test Name";
            this.columnHeader2.Width = 209;
            // 
            // NWViewTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 403);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdateTest);
            this.Controls.Add(this.buttonDeleteTest);
            this.Controls.Add(this.buttonAddTest);
            this.Controls.Add(this.listViewTests);
            this.Name = "NWViewTests";
            this.Text = "View Tests";
            this.Activated += new System.EventHandler(this.loadTests);
            this.Load += new System.EventHandler(this.loadTests);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTests;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.Button buttonDeleteTest;
        private System.Windows.Forms.Button buttonUpdateTest;
        private System.Windows.Forms.Button buttonCancel;
    }
}