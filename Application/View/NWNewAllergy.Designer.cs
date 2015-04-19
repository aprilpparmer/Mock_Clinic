namespace WindowsFormsApplication.View
{
    partial class NWNewAllergy
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
            this.labelAllergyName = new System.Windows.Forms.Label();
            this.textBoxAllergyName = new System.Windows.Forms.TextBox();
            this.buttonAddAllergy = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAllergyName
            // 
            this.labelAllergyName.AutoSize = true;
            this.labelAllergyName.Location = new System.Drawing.Point(31, 54);
            this.labelAllergyName.Name = "labelAllergyName";
            this.labelAllergyName.Size = new System.Drawing.Size(75, 13);
            this.labelAllergyName.TabIndex = 0;
            this.labelAllergyName.Text = "Allergy Name: ";
            // 
            // textBoxAllergyName
            // 
            this.textBoxAllergyName.Location = new System.Drawing.Point(112, 51);
            this.textBoxAllergyName.Name = "textBoxAllergyName";
            this.textBoxAllergyName.Size = new System.Drawing.Size(206, 20);
            this.textBoxAllergyName.TabIndex = 1;
            // 
            // buttonAddAllergy
            // 
            this.buttonAddAllergy.Location = new System.Drawing.Point(77, 124);
            this.buttonAddAllergy.Name = "buttonAddAllergy";
            this.buttonAddAllergy.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAllergy.TabIndex = 2;
            this.buttonAddAllergy.Text = "Add Allergy";
            this.buttonAddAllergy.UseVisualStyleBackColor = true;
            this.buttonAddAllergy.Click += new System.EventHandler(this.buttonAddAllergy_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(217, 124);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // NWNewAllergy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 221);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddAllergy);
            this.Controls.Add(this.textBoxAllergyName);
            this.Controls.Add(this.labelAllergyName);
            this.Name = "NWNewAllergy";
            this.Text = "New allergy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAllergyName;
        private System.Windows.Forms.TextBox textBoxAllergyName;
        private System.Windows.Forms.Button buttonAddAllergy;
        private System.Windows.Forms.Button buttonCancel;
    }
}