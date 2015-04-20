namespace WindowsFormsApplication.View
{
    partial class nwListDiag
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
            this.diagnosesDataSet = new WindowsFormsApplication.DiagnosesDataSet();
            this.diagnosesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosesTableAdapter = new WindowsFormsApplication.DiagnosesDataSetTableAdapters.diagnosesTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication.DiagnosesDataSetTableAdapters.TableAdapterManager();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.diagListView = new System.Windows.Forms.ListView();
            this.diagId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diagName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Treatment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Active = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diagnosesDataSet
            // 
            this.diagnosesDataSet.DataSetName = "DiagnosesDataSet";
            this.diagnosesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // diagnosesTableAdapter
            // 
            this.diagnosesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.diagnosesTableAdapter = this.diagnosesTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication.DiagnosesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // diagListView
            // 
            this.diagListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.diagId,
            this.diagName,
            this.Description,
            this.Treatment,
            this.Active});
            this.diagListView.Location = new System.Drawing.Point(12, 12);
            this.diagListView.Name = "diagListView";
            this.diagListView.Size = new System.Drawing.Size(905, 293);
            this.diagListView.TabIndex = 0;
            this.diagListView.UseCompatibleStateImageBehavior = false;
            this.diagListView.View = System.Windows.Forms.View.Details;
            this.diagListView.SelectedIndexChanged += new System.EventHandler(this.enableButton);
            // 
            // diagId
            // 
            this.diagId.Text = "Id";
            this.diagId.Width = 30;
            // 
            // diagName
            // 
            this.diagName.Text = "Diagnoses Name";
            this.diagName.Width = 191;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 252;
            // 
            // Treatment
            // 
            this.Treatment.Text = "Treatment";
            this.Treatment.Width = 347;
            // 
            // Active
            // 
            this.Active.Text = "Active";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(923, 44);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(92, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Diagnoses";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(923, 98);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 40);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete Diagnoses";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // nwListDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 288);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.diagListView);
            this.Name = "nwListDiag";
            this.Text = "List Diagnoses";
            this.Activated += new System.EventHandler(this.loadDiags);
            this.Load += new System.EventHandler(this.nwListDiag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DiagnosesDataSet diagnosesDataSet;
        private System.Windows.Forms.BindingSource diagnosesBindingSource;
        private DiagnosesDataSetTableAdapters.diagnosesTableAdapter diagnosesTableAdapter;
        private DiagnosesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ListView diagListView;
        private System.Windows.Forms.ColumnHeader diagName;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Treatment;
        private System.Windows.Forms.ColumnHeader diagId;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ColumnHeader Active;



    }
}