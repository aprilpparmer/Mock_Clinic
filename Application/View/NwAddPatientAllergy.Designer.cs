namespace WindowsFormsApplication.View
{
    partial class NwAddPatientAllergy
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
            this.allergyComboBox = new System.Windows.Forms.ComboBox();
            this._CS6232_g7DataSet2 = new WindowsFormsApplication._CS6232_g7DataSet2();
            this.allergiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allergiesTableAdapter = new WindowsFormsApplication._CS6232_g7DataSet2TableAdapters.allergiesTableAdapter();
            this.addAllergyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._CS6232_g7DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allergiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // allergyComboBox
            // 
            this.allergyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.allergiesBindingSource, "allergy_name", true));
            this.allergyComboBox.DataSource = this.allergiesBindingSource;
            this.allergyComboBox.DisplayMember = "allergy_name";
            this.allergyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.allergyComboBox.FormattingEnabled = true;
            this.allergyComboBox.Location = new System.Drawing.Point(12, 27);
            this.allergyComboBox.Name = "allergyComboBox";
            this.allergyComboBox.Size = new System.Drawing.Size(262, 21);
            this.allergyComboBox.TabIndex = 0;
            this.allergyComboBox.ValueMember = "allergyID";
            // 
            // _CS6232_g7DataSet2
            // 
            this._CS6232_g7DataSet2.DataSetName = "_CS6232_g7DataSet2";
            this._CS6232_g7DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allergiesBindingSource
            // 
            this.allergiesBindingSource.DataMember = "allergies";
            this.allergiesBindingSource.DataSource = this._CS6232_g7DataSet2;
            // 
            // allergiesTableAdapter
            // 
            this.allergiesTableAdapter.ClearBeforeFill = true;
            // 
            // addAllergyButton
            // 
            this.addAllergyButton.Location = new System.Drawing.Point(103, 65);
            this.addAllergyButton.Name = "addAllergyButton";
            this.addAllergyButton.Size = new System.Drawing.Size(75, 23);
            this.addAllergyButton.TabIndex = 1;
            this.addAllergyButton.Text = "Add Allergy";
            this.addAllergyButton.UseVisualStyleBackColor = true;
            this.addAllergyButton.Click += new System.EventHandler(this.addAllergyButton_Click);
            // 
            // NwAddPatientAllergy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 112);
            this.Controls.Add(this.addAllergyButton);
            this.Controls.Add(this.allergyComboBox);
            this.Name = "NwAddPatientAllergy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Patient Allergy";
            this.Load += new System.EventHandler(this.NwAddPatientAllergy_Load);
            ((System.ComponentModel.ISupportInitialize)(this._CS6232_g7DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allergiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox allergyComboBox;
        private _CS6232_g7DataSet2 _CS6232_g7DataSet2;
        private System.Windows.Forms.BindingSource allergiesBindingSource;
        private _CS6232_g7DataSet2TableAdapters.allergiesTableAdapter allergiesTableAdapter;
        private System.Windows.Forms.Button addAllergyButton;
    }
}