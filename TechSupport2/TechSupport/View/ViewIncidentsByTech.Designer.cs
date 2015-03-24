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
            this.technician = new TechSupport2.Technician();
            this.techniciansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techniciansTableAdapter = new TechSupport2.TechnicianTableAdapters.TechniciansTableAdapter();
            this.tableAdapterManager = new TechSupport2.TechnicianTableAdapters.TableAdapterManager();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.techSupportDataSet = new TechSupport2.TechSupportDataSet();
            this.incidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incidentsTableAdapter = new TechSupport2.TechSupportDataSetTableAdapters.IncidentsTableAdapter();
            this.tableAdapterManager1 = new TechSupport2.TechSupportDataSetTableAdapters.TableAdapterManager();
            this.incidentsDataGrid = new System.Windows.Forms.DataGridView();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOpened = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.technician)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(15, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(81, 17);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Technician:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(50, 45);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(43, 73);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 17);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Phone:";
            // 
            // technician
            // 
            this.technician.DataSetName = "Technician";
            this.technician.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // techniciansBindingSource
            // 
            this.techniciansBindingSource.DataMember = "Technicians";
            this.techniciansBindingSource.DataSource = this.technician;
            // 
            // techniciansTableAdapter
            // 
            this.techniciansTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TechniciansTableAdapter = this.techniciansTableAdapter;
            this.tableAdapterManager.UpdateOrder = TechSupport2.TechnicianTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciansBindingSource, "Name", true));
            this.nameComboBox.DataSource = this.techniciansBindingSource;
            this.nameComboBox.DisplayMember = "Name";
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(102, 12);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(195, 24);
            this.nameComboBox.TabIndex = 1;
            this.nameComboBox.ValueMember = "TechID";
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciansBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(102, 42);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(195, 22);
            this.emailTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.techniciansBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(102, 70);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ReadOnly = true;
            this.phoneTextBox.Size = new System.Drawing.Size(195, 22);
            this.phoneTextBox.TabIndex = 5;
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidentsBindingSource
            // 
            this.incidentsBindingSource.DataMember = "Incidents";
            this.incidentsBindingSource.DataSource = this.techSupportDataSet;
            // 
            // incidentsTableAdapter
            // 
            this.incidentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CustomersTableAdapter = null;
            this.tableAdapterManager1.IncidentsTableAdapter = this.incidentsTableAdapter;
            this.tableAdapterManager1.ProductsTableAdapter = null;
            this.tableAdapterManager1.RegistrationsTableAdapter = null;
            this.tableAdapterManager1.StatesTableAdapter = null;
            this.tableAdapterManager1.TechniciansTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TechSupport2.TechSupportDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // incidentsDataGrid
            // 
            this.incidentsDataGrid.AllowUserToAddRows = false;
            this.incidentsDataGrid.AllowUserToDeleteRows = false;
            this.incidentsDataGrid.AutoGenerateColumns = false;
            this.incidentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incidentsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductCode,
            this.DateOpened,
            this.Column1,
            this.Title});
            this.incidentsDataGrid.DataSource = this.incidentsBindingSource;
            this.incidentsDataGrid.Location = new System.Drawing.Point(12, 140);
            this.incidentsDataGrid.Name = "incidentsDataGrid";
            this.incidentsDataGrid.ReadOnly = true;
            this.incidentsDataGrid.RowTemplate.Height = 24;
            this.incidentsDataGrid.Size = new System.Drawing.Size(694, 181);
            this.incidentsDataGrid.TabIndex = 6;
            // 
            // ProductCode
            // 
            this.ProductCode.DataPropertyName = "Product";
            this.ProductCode.FillWeight = 150F;
            this.ProductCode.HeaderText = "Product";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 150;
            // 
            // DateOpened
            // 
            this.DateOpened.DataPropertyName = "openDate";
            this.DateOpened.FillWeight = 150F;
            this.DateOpened.HeaderText = "Date Opened";
            this.DateOpened.Name = "DateOpened";
            this.DateOpened.ReadOnly = true;
            this.DateOpened.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Customer";
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "Customer";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.FillWeight = 200F;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 200;
            // 
            // ViewIncidentsByTech
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 360);
            this.Controls.Add(this.incidentsDataGrid);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameComboBox);
            this.Name = "ViewIncidentsByTech";
            this.Text = "ViewIncidentsByTech";
            this.Load += new System.EventHandler(this.ViewIncidentsByTech_Load);
            ((System.ComponentModel.ISupportInitialize)(this.technician)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Technician technician;
        private System.Windows.Forms.BindingSource techniciansBindingSource;
        private TechnicianTableAdapters.TechniciansTableAdapter techniciansTableAdapter;
        private TechnicianTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private TechSupportDataSet techSupportDataSet;
        private System.Windows.Forms.BindingSource incidentsBindingSource;
        private TechSupportDataSetTableAdapters.IncidentsTableAdapter incidentsTableAdapter;
        private TechSupportDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView incidentsDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOpened;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
    }
}