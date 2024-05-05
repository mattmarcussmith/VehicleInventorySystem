using matthewsmith_c968.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matthewsmith_c968
{
    public partial class AddProductForm : Form
    {
        BindingList<Part> associatedParts = new BindingList<Part>();

        public AddProductForm()
        {
            InitializeComponent();
            this.Text = "Product";

            // Top list contains all parts in inventory
            var inventory = new BindingSource();
            inventory.DataSource = Inventory.Parts;
            partInventoryGrid.DataSource = inventory;

            // Bottom list contains Associated Parts 
            var associatedInventory = new BindingSource();
            associatedInventory.DataSource = associatedParts;
            associatedPartsGrid.DataSource = associatedInventory;

            // *************** Add Product grid settings ***************//
            // Entire row selected
            partInventoryGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Read only Grid
            partInventoryGrid.ReadOnly = true;
            // Cannot select more than one row
            partInventoryGrid.MultiSelect = false;
            // Cannot create rows
            partInventoryGrid.AllowUserToAddRows = false;

            // *************** Associated Parts grid settings ***************//
            // Entire row selected
            associatedPartsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Read only Grid
            associatedPartsGrid.ReadOnly = true;
            // Cannot select more than one row
            associatedPartsGrid.MultiSelect = false;
            // Cannot create rows
            associatedPartsGrid.AllowUserToAddRows = false;


        }
        // Clears selected row on application start
        private void ClearBindingParts(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partInventoryGrid.ClearSelection();
        }

        private void ClearBindingProducts(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            associatedPartsGrid.ClearSelection();
        }

        private void SearchPart_Button(object sender, EventArgs e)
        {
            string searchValue = searchPartInput.Text;
            if (!int.TryParse(searchValue, out _))
            {
                MessageBox.Show("Please enter a numeric value");
                return;
            }

            int searchID = int.Parse(searchPartInput.Text);
            Part matchingPartFound = Inventory.LookupPart(searchID);
            if (searchID < 0)
            {
                MessageBox.Show("Please enter a numeric value greater than 0");
                return;
            }
            if (matchingPartFound == null)
            {
                MessageBox.Show("This Part ID does not excist");
                return;
            }
 
            foreach (DataGridViewRow currentIteration in partInventoryGrid.Rows)
            {
                Part part = (Part)currentIteration.DataBoundItem;
                if (part.PartID == matchingPartFound.PartID)
                {
                    currentIteration.Selected = true;
                    break;
                }
                else
                {
                    currentIteration.Selected = false;
                }
            }

        }
        // *************** Associated Part added ***************//
        private void AddAssociatedPart_Button(object sender, EventArgs e)
        {
            Part part = (Part)partInventoryGrid.CurrentRow.DataBoundItem;
            associatedParts.Add(part);
        }

        private void DeleteAssociatedPart_Button(object sender, EventArgs e)
        {
            foreach(DataGridViewRow selectedRow in associatedPartsGrid.SelectedRows)
            {
                associatedPartsGrid.Rows.RemoveAt(selectedRow.Index);
            }
        }

    }
}
