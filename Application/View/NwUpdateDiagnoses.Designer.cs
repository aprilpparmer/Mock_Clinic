namespace WindowsFormsApplication.View
{
    partial class NwUpdateDiagnoses
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
            this.labelCurrrentDiagnoses = new System.Windows.Forms.Label();
            this.labelUPdatedDiadnoses = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.diagnosesDataSet = new WindowsFormsApplication.DiagnosesDataSet();
            this.diagnosesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosesTableAdapter = new WindowsFormsApplication.DiagnosesDataSetTableAdapters.diagnosesTableAdapter();
            this.buttonUpdateDiagnoses = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxCurrentDiagnoses = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrrentDiagnoses
            // 
            this.labelCurrrentDiagnoses.AutoSize = true;
            this.labelCurrrentDiagnoses.Location = new System.Drawing.Point(47, 53);
            this.labelCurrrentDiagnoses.Name = "labelCurrrentDiagnoses";
            this.labelCurrrentDiagnoses.Size = new System.Drawing.Size(100, 13);
            this.labelCurrrentDiagnoses.TabIndex = 0;
            this.labelCurrrentDiagnoses.Text = "Current Diagnoses :";
            // 
            // labelUPdatedDiadnoses
            // 
            this.labelUPdatedDiadnoses.AutoSize = true;
            this.labelUPdatedDiadnoses.Location = new System.Drawing.Point(47, 111);
            this.labelUPdatedDiadnoses.Name = "labelUPdatedDiadnoses";
            this.labelUPdatedDiadnoses.Size = new System.Drawing.Size(101, 13);
            this.labelUPdatedDiadnoses.TabIndex = 2;
            this.labelUPdatedDiadnoses.Text = "Updated Diagnoses";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.diagnosesBindingSource;
            this.comboBox1.DisplayMember = "diagnoses_name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(154, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "diagnosesID";
            // 
            // diagnosesDataSet
            // 
            this.diagnosesDataSet.DataSetName = "DiagnosesDataSet";
            this.diagnosesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnosesBindingSource
            // 
            this.diagnosesBindingSource.DataMember = "diagnoses";
            this.diagnosesBindingSource.DataSource = this.diagnosesDataSet;
            // 
            // diagnosesTableAdapter
            // 
            this.diagnosesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdateDiagnoses
            // 
            this.buttonUpdateDiagnoses.Location = new System.Drawing.Point(72, 181);
            this.buttonUpdateDiagnoses.Name = "buttonUpdateDiagnoses";
            this.buttonUpdateDiagnoses.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateDiagnoses.TabIndex = 4;
            this.buttonUpdateDiagnoses.Text = "Update";
            this.buttonUpdateDiagnoses.UseVisualStyleBackColor = true;
            this.buttonUpdateDiagnoses.Click += new System.EventHandler(this.buttonUpdateDiagnoses_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(188, 181);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxCurrentDiagnoses
            // 
            this.textBoxCurrentDiagnoses.Location = new System.Drawing.Point(153, 50);
            this.textBoxCurrentDiagnoses.Name = "textBoxCurrentDiagnoses";
            this.textBoxCurrentDiagnoses.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentDiagnoses.TabIndex = 6;
            // 
            // NwUpdateDiagnoses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 255);
            this.Controls.Add(this.textBoxCurrentDiagnoses);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonUpdateDiagnoses);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelUPdatedDiadnoses);
            this.Controls.Add(this.labelCurrrentDiagnoses);
            this.Name = "NwUpdateDiagnoses";
            this.Text = "Update Diagnoses";
            this.Load += new System.EventHandler(this.NwUpdateDiagnoses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrrentDiagnoses;
        private System.Windows.Forms.Label labelUPdatedDiadnoses;
        private System.Windows.Forms.ComboBox comboBox1;
        private DiagnosesDataSet diagnosesDataSet;
        private System.Windows.Forms.BindingSource diagnosesBindingSource;
        private DiagnosesDataSetTableAdapters.diagnosesTableAdapter diagnosesTableAdapter;
        private System.Windows.Forms.Button buttonUpdateDiagnoses;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxCurrentDiagnoses;
    }
}