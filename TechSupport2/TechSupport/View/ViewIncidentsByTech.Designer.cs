namespace TechSupport2.TechSupport.View
{
    partial class ViewIncidentsByTech
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            this.technicanData = new TechSupport2.TechnicanData();
            this.techniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techniciansTableAdapter = new TechSupport2.TechnicanDataTableAdapters.TechniciansTableAdapter();
            this.tableAdapterManager = new TechSupport2.TechnicanDataTableAdapters.TableAdapterManager();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.incidentsData = new TechSupport2.IncidentsData();
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentsTableAdapter = new TechSupport2.IncidentsDataTableAdapters.IncidentsTableAdapter();
            this.tableAdapterManager1 = new TechSupport2.IncidentsDataTableAdapters.TableAdapterManager();
            this.incidentsDataGridView = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOpened = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.technicanData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(11, 12);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(14, 42);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(7, 70);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 17);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Phone:";
            // 
            // technicanData
            // 
            this.technicanData.DataSetName = "TechnicanData";
            this.technicanData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techniciansBindingSource
            // 
            this.techniciansBindingSource.DataMember = "Technicians";
            this.techniciansBindingSource.DataSource = this.technicanData;
            // 
            // techniciansTableAdapter
            // 
            this.techniciansTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TechniciansTableAdapter = this.techniciansTableAdapter;
            this.tableAdapterManager.UpdateOrder = TechSupport2.TechnicanDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciansBindingSource, "Name", true));
            this.nameComboBox.DataSource = this.techniciansBindingSource;
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(66, 12);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(202, 24);
            this.nameComboBox.TabIndex = 2;
            this.nameComboBox.ValueMember = "TechID";
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciansBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(66, 39);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(202, 22);
            this.emailTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciansBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(66, 67);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(202, 22);
            this.phoneTextBox.TabIndex = 5;
            // 
            // incidentsData
            // 
            this.incidentsData.DataSetName = "IncidentsData";
            this.incidentsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataMember = "Incidents";
            this.incidentsBindingSource.DataSource = this.incidentsData;
            // 
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.IncidentsTableAdapter = this.incidentsTableAdapter;
            this.tableAdapterManager1.UpdateOrder = TechSupport2.IncidentsDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // incidentsDataGridView
            // 
            this.incidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Customer,
            this.DateOpened,
            this.Title});
            this.incidentsDataGridView.Location = new System.Drawing.Point(17, 122);
            this.incidentsDataGridView.Name = "incidentsDataGridView";
            this.incidentsDataGridView.RowTemplate.Height = 24;
            this.incidentsDataGridView.Size = new System.Drawing.Size(743, 246);
            this.incidentsDataGridView.TabIndex = 6;
            // 
            // Product
            // 
            this.Product.FillWeight = 150F;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.Width = 150;
            // 
            // Customer
            // 
            this.Customer.FillWeight = 150F;
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.Width = 150;
            // 
            // DateOpened
            // 
            this.DateOpened.FillWeight = 150F;
            this.DateOpened.HeaderText = "DateOpened";
            this.DateOpened.Name = "DateOpened";
            this.DateOpened.Width = 150;
            // 
            // Title
            // 
            this.Title.FillWeight = 250F;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.Width = 250;
            // 
            // ViewIncidentsByTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 380);
            this.Controls.Add(this.incidentsDataGridView);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameComboBox);
            this.Name = "ViewIncidentsByTech";
            this.Text = "View Incidents By Tech";
            this.Load += new System.EventHandler(this.ViewIncidentsByTech_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technicanData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TechnicanData technicanData;
        private System.Windows.Forms.BindingSource techniciansBindingSource;
        private TechnicanDataTableAdapters.TechniciansTableAdapter techniciansTableAdapter;
        private TechnicanDataTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private IncidentsData incidentsData;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
        private IncidentsDataTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
        private IncidentsDataTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView incidentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOpened;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
    }
}