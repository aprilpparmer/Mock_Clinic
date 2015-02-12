namespace TechSupport2.TechSupport.View
{
    partial class UpdateIncident
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionText = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.decriptionText = new System.Windows.Forms.TextBox();
            this.dateOpenedText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.productText = new System.Windows.Forms.TextBox();
            this.customerText = new System.Windows.Forms.TextBox();
            this.IncidentIDText = new System.Windows.Forms.TextBox();
            this.technicianBox = new System.Windows.Forms.ComboBox();
            this.techniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupportDataSet = new TechSupport2.TechSupportDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.techSupportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techniciansTableAdapter = new TechSupport2.TechSupportDataSetTableAdapters.TechniciansTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incident ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Technician:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date opened:";
            // 
            // descriptionText
            // 
            this.descriptionText.AutoSize = true;
            this.descriptionText.Location = new System.Drawing.Point(12, 286);
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(83, 17);
            this.descriptionText.TabIndex = 6;
            this.descriptionText.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Text to add:";
            // 
            // decriptionText
            // 
            this.decriptionText.BackColor = System.Drawing.SystemColors.Menu;
            this.decriptionText.Location = new System.Drawing.Point(113, 269);
            this.decriptionText.Multiline = true;
            this.decriptionText.Name = "decriptionText";
            this.decriptionText.Size = new System.Drawing.Size(390, 129);
            this.decriptionText.TabIndex = 8;
            // 
            // dateOpenedText
            // 
            this.dateOpenedText.BackColor = System.Drawing.SystemColors.Menu;
            this.dateOpenedText.Location = new System.Drawing.Point(113, 241);
            this.dateOpenedText.Name = "dateOpenedText";
            this.dateOpenedText.Size = new System.Drawing.Size(200, 22);
            this.dateOpenedText.TabIndex = 9;
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.SystemColors.Menu;
            this.titleText.Location = new System.Drawing.Point(113, 191);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(200, 22);
            this.titleText.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(113, 423);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(390, 157);
            this.textBox4.TabIndex = 11;
            // 
            // productText
            // 
            this.productText.BackColor = System.Drawing.SystemColors.Menu;
            this.productText.Location = new System.Drawing.Point(113, 110);
            this.productText.Name = "productText";
            this.productText.Size = new System.Drawing.Size(200, 22);
            this.productText.TabIndex = 12;
            // 
            // customerText
            // 
            this.customerText.BackColor = System.Drawing.SystemColors.Menu;
            this.customerText.Location = new System.Drawing.Point(113, 70);
            this.customerText.Name = "customerText";
            this.customerText.Size = new System.Drawing.Size(200, 22);
            this.customerText.TabIndex = 13;
            // 
            // IncidentIDText
            // 
            this.IncidentIDText.Location = new System.Drawing.Point(113, 29);
            this.IncidentIDText.Name = "IncidentIDText";
            this.IncidentIDText.Size = new System.Drawing.Size(100, 22);
            this.IncidentIDText.TabIndex = 14;
            // 
            // technicianBox
            // 
            this.technicianBox.BackColor = System.Drawing.SystemColors.Menu;
            this.technicianBox.DataSource = this.techniciansBindingSource;
            this.technicianBox.DisplayMember = "Name";
            this.technicianBox.FormattingEnabled = true;
            this.technicianBox.Location = new System.Drawing.Point(113, 150);
            this.technicianBox.MaxDropDownItems = 20;
            this.technicianBox.Name = "technicianBox";
            this.technicianBox.Size = new System.Drawing.Size(200, 24);
            this.technicianBox.TabIndex = 15;
            this.technicianBox.ValueMember = "TechID";
            // 
            // techniciansBindingSource
            // 
            this.techniciansBindingSource.DataMember = "Technicians";
            this.techniciansBindingSource.DataSource = this.techSupportDataSet;
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(219, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "Get Incident";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // techSupportDataSetBindingSource
            // 
            this.techSupportDataSetBindingSource.DataSource = this.techSupportDataSet;
            this.techSupportDataSetBindingSource.Position = 0;
            // 
            // techniciansTableAdapter
            // 
            this.techniciansTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(113, 593);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(261, 593);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 27);
            this.button3.TabIndex = 18;
            this.button3.Text = "Close Incident";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(428, 593);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 27);
            this.button4.TabIndex = 19;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // UpdateIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 632);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.technicianBox);
            this.Controls.Add(this.IncidentIDText);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.productText);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.dateOpenedText);
            this.Controls.Add(this.decriptionText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateIncident";
            this.Text = "Update Incident";
            this.Load += new System.EventHandler(this.UpdateIncident_Load);
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label descriptionText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox decriptionText;
        private System.Windows.Forms.TextBox dateOpenedText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox productText;
        private System.Windows.Forms.TextBox customerText;
        private System.Windows.Forms.TextBox IncidentIDText;
        private System.Windows.Forms.ComboBox technicianBox;
        private System.Windows.Forms.Button button1;
        private TechSupportDataSet techSupportDataSet;
        private System.Windows.Forms.BindingSource techSupportDataSetBindingSource;
        private System.Windows.Forms.BindingSource techniciansBindingSource;
        private TechSupportDataSetTableAdapters.TechniciansTableAdapter techniciansTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}