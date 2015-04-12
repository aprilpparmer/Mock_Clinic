namespace WindowsFormsApplication.View
{
    partial class NWNewTest
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
            this.labelTestName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTestName
            // 
            this.labelTestName.AutoSize = true;
            this.labelTestName.Location = new System.Drawing.Point(27, 58);
            this.labelTestName.Name = "labelTestName";
            this.labelTestName.Size = new System.Drawing.Size(62, 13);
            this.labelTestName.TabIndex = 0;
            this.labelTestName.Text = "Test Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(92, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(299, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.Location = new System.Drawing.Point(152, 114);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(75, 23);
            this.buttonAddTest.TabIndex = 2;
            this.buttonAddTest.Text = "Add Test";
            this.buttonAddTest.UseVisualStyleBackColor = true;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(280, 114);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // NWNewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 183);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddTest);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelTestName);
            this.Name = "NWNewTest";
            this.Text = "New Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTestName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.Button buttonCancel;
    }
}