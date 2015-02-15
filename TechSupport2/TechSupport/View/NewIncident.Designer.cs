namespace TechSupport2.View
{
    partial class OpenIncidents
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
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.titleText = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.customerBox = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupportDataSet = new TechSupport2.TechSupportDataSet();
            this.productBox = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new TechSupport2.TechSupportDataSetTableAdapters.CustomersTableAdapter();
            this.productsTableAdapter = new TechSupport2.TechSupportDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(110, 143);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(260, 167);
            this.descriptionText.TabIndex = 4;
            this.descriptionText.Tag = "Description";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(110, 97);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(260, 22);
            this.titleText.TabIndex = 5;
            this.titleText.Tag = "Title";
            // 
            // createButton
            // 
            this.createButton.AutoSize = true;
            this.createButton.Location = new System.Drawing.Point(110, 316);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(113, 27);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create Incident";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(295, 316);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // customerBox
            // 
            this.customerBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.customerBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerBox.DataSource = this.customersBindingSource;
            this.customerBox.DisplayMember = "Name";
            this.customerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerBox.FormattingEnabled = true;
            this.customerBox.Location = new System.Drawing.Point(110, 21);
            this.customerBox.MaxDropDownItems = 100;
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(260, 24);
            this.customerBox.TabIndex = 8;
            this.customerBox.ValueMember = "Name";
            this.customerBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.techSupportDataSet;
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBox
            // 
            this.productBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productBox.DataSource = this.productsBindingSource;
            this.productBox.DisplayMember = "Name";
            this.productBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productBox.FormattingEnabled = true;
            this.productBox.Location = new System.Drawing.Point(110, 60);
            this.productBox.MaxDropDownItems = 50;
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(260, 24);
            this.productBox.TabIndex = 9;
            this.productBox.ValueMember = "Name";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.techSupportDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // OpenIncidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 370);
            this.Controls.Add(this.productBox);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OpenIncidents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Create Incident";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox productBox;
        private TechSupportDataSet techSupportDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private TechSupportDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TechSupportDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ComboBox customerBox;
    }
}