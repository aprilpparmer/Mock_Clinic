using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication.Controller;
using WindowsFormsApplication.Model;

namespace WindowsFormsApplication.View
{
    public partial class nwListDiag : Form
    {
        NorthwindController _controller;

        public nwListDiag()
        {
            InitializeComponent();
            _controller = new NorthwindController();

        }
        private static nwListDiag _NWListDiagform;

        /// <summary>
        /// Checks to see if Instance is created, and returns Instance
        /// </summary>
        /// <returns>List Diag Instance</returns>
        public static nwListDiag GetChildInstance()
        {
            if (_NWListDiagform == null) //if not created yet, Create an instance
                _NWListDiagform = new nwListDiag();
            else
            {
                _NWListDiagform.Dispose();
                _NWListDiagform = new nwListDiag();

            }
            return _NWListDiagform;  //just created or created earlier.Return it
        }

        private void loadDiags(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
                        deleteButton.Enabled = false;
            List<Diagnoses> diagnosesList; 
            diagListView.Items.Clear();
            try
            {
                diagnosesList = _controller.GetAllDiagnoses();
                if (diagnosesList.Count > 0)
                {
                    Diagnoses diag;
                    for (int i = 0; i < diagnosesList.Count; i++)
                    {
                        diag = diagnosesList[i];
                        diagListView.Items.Add(diag.DiagnosesId.ToString());
                        diagListView.Items[i].SubItems.Add(diag.Name);
                        diagListView.Items[i].SubItems.Add(diag.Description.Trim());
                        diagListView.Items[i].SubItems.Add(diag.Treatment.Trim());
                    }
                }
            }
            catch
            {
                MessageBox.Show(@"There are no diagnoses at this time.");
            }

        }
        private void addButton_Click(object sender, EventArgs e)
        {
            NWNewDiag NWNewDiagForm = NWNewDiag.GetChildInstance();
            NWNewDiagForm.MdiParent = MdiParent;
            NWNewDiagForm.Show();
            NWNewDiagForm.BringToFront();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = diagListView.SelectedItems[0];
                int diagId = int.Parse(item.SubItems[0].Text);
                string diagName = item.SubItems[1].Text;
                DialogResult result1 = MessageBox.Show(@"Are you sure you want to Delete: " + diagName + @". Anything referencing this will error. Only Delete Unreferenced Items", @"Confirm Delete", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    int result2 = _controller.DeleteDiag(diagId);
                    if (result2 == 1)
                    {
                        MessageBox.Show(@"Result = 1.");
                    }
                    else
                    {
                        MessageBox.Show(@"Result = 0.");
                    }
                    loadData();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(@"There was a problem erasing the diag.");
            }
        }

        private void enableButton(object sender, EventArgs e)
        {
            deleteButton.Enabled = true;
        }



    }
}
