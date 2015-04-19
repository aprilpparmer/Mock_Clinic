namespace WindowsFormsApplication.View
{
    partial class NWViewAllergies
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
            this.listViewAllergies = new System.Windows.Forms.ListView();
            this.allergyID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allergy_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enabled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddAllergy = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDeleteAllergy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAllergies
            // 
            this.listViewAllergies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.allergyID,
            this.allergy_Name,
            this.enabled});
            this.listViewAllergies.Location = new System.Drawing.Point(76, 41);
            this.listViewAllergies.Name = "listViewAllergies";
            this.listViewAllergies.Size = new System.Drawing.Size(294, 235);
            this.listViewAllergies.TabIndex = 0;
            this.listViewAllergies.UseCompatibleStateImageBehavior = false;
            this.listViewAllergies.View = System.Windows.Forms.View.Details;
            // 
            // allergyID
            // 
            this.allergyID.Text = "Allergy ID";
            // 
            // allergy_Name
            // 
            this.allergy_Name.Text = "Allergy Name";
            this.allergy_Name.Width = 147;
            // 
            // enabled
            // 
            this.enabled.Text = "Enabled";
            // 
            // buttonAddAllergy
            // 
            this.buttonAddAllergy.Location = new System.Drawing.Point(76, 299);
            this.buttonAddAllergy.Name = "buttonAddAllergy";
            this.buttonAddAllergy.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAllergy.TabIndex = 1;
            this.buttonAddAllergy.Text = "Add Allergy";
            this.buttonAddAllergy.UseVisualStyleBackColor = true;
            this.buttonAddAllergy.Click += new System.EventHandler(this.buttonAddAllergy_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(295, 299);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonDeleteAllergy
            // 
            this.buttonDeleteAllergy.Location = new System.Drawing.Point(177, 299);
            this.buttonDeleteAllergy.Name = "buttonDeleteAllergy";
            this.buttonDeleteAllergy.Size = new System.Drawing.Size(92, 23);
            this.buttonDeleteAllergy.TabIndex = 3;
            this.buttonDeleteAllergy.Text = "Delete Allergy";
            this.buttonDeleteAllergy.UseVisualStyleBackColor = true;
            this.buttonDeleteAllergy.Click += new System.EventHandler(this.buttonDeleteAllergy_Click);
            // 
            // NWViewAllergies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 354);
            this.Controls.Add(this.buttonDeleteAllergy);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddAllergy);
            this.Controls.Add(this.listViewAllergies);
            this.Name = "NWViewAllergies";
            this.Text = "View Allergies";
            this.Activated += new System.EventHandler(this.loadAllergies);
            this.Load += new System.EventHandler(this.loadAllergies);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAllergies;
        private System.Windows.Forms.ColumnHeader allergyID;
        private System.Windows.Forms.ColumnHeader allergy_Name;
        private System.Windows.Forms.ColumnHeader enabled;
        private System.Windows.Forms.Button buttonAddAllergy;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDeleteAllergy;
    }
}