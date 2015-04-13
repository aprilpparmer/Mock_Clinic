namespace WindowsFormsApplication.View
{
    partial class NwUpdateTest
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdateTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUpdatedName = new System.Windows.Forms.TextBox();
            this.textBoxCurrentName = new System.Windows.Forms.TextBox();
            this.NWRegisterNurse = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCurrentID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(244, 222);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(56, 19);
            this.buttonCancel.TabIndex = 35;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdateTest
            // 
            this.buttonUpdateTest.Location = new System.Drawing.Point(116, 222);
            this.buttonUpdateTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdateTest.Name = "buttonUpdateTest";
            this.buttonUpdateTest.Size = new System.Drawing.Size(56, 19);
            this.buttonUpdateTest.TabIndex = 34;
            this.buttonUpdateTest.Text = "Update";
            this.buttonUpdateTest.UseVisualStyleBackColor = true;
            this.buttonUpdateTest.Click += new System.EventHandler(this.buttonUpdateTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Updated Name";
            // 
            // textBoxUpdatedName
            // 
            this.textBoxUpdatedName.Location = new System.Drawing.Point(172, 147);
            this.textBoxUpdatedName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxUpdatedName.Name = "textBoxUpdatedName";
            this.textBoxUpdatedName.Size = new System.Drawing.Size(198, 20);
            this.textBoxUpdatedName.TabIndex = 32;
            // 
            // textBoxCurrentName
            // 
            this.textBoxCurrentName.Enabled = false;
            this.textBoxCurrentName.Location = new System.Drawing.Point(172, 82);
            this.textBoxCurrentName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCurrentName.Name = "textBoxCurrentName";
            this.textBoxCurrentName.ReadOnly = true;
            this.textBoxCurrentName.Size = new System.Drawing.Size(198, 20);
            this.textBoxCurrentName.TabIndex = 31;
            // 
            // NWRegisterNurse
            // 
            this.NWRegisterNurse.AutoSize = true;
            this.NWRegisterNurse.Location = new System.Drawing.Point(54, 85);
            this.NWRegisterNurse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NWRegisterNurse.Name = "NWRegisterNurse";
            this.NWRegisterNurse.Size = new System.Drawing.Size(99, 13);
            this.NWRegisterNurse.TabIndex = 30;
            this.NWRegisterNurse.Text = "Current Test Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Current Test ID:";
            // 
            // textBoxCurrentID
            // 
            this.textBoxCurrentID.Location = new System.Drawing.Point(172, 45);
            this.textBoxCurrentID.Name = "textBoxCurrentID";
            this.textBoxCurrentID.ReadOnly = true;
            this.textBoxCurrentID.Size = new System.Drawing.Size(128, 20);
            this.textBoxCurrentID.TabIndex = 37;
            // 
            // NwUpdateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 296);
            this.Controls.Add(this.textBoxCurrentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdateTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUpdatedName);
            this.Controls.Add(this.textBoxCurrentName);
            this.Controls.Add(this.NWRegisterNurse);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NwUpdateTest";
            this.Text = "Update Test";
            this.Load += new System.EventHandler(this.NwUpdateTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdateTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUpdatedName;
        private System.Windows.Forms.TextBox textBoxCurrentName;
        private System.Windows.Forms.Label NWRegisterNurse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCurrentID;
    }
}