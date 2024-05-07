using matthewsmith_c968.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace matthewsmith_c968
{
    public partial class AddProductForm : Form
    {
        BindingList<Part> associatedParts = new BindingList<Part>();

        private int generatedID;
        public AddProductForm(int generatedID)
        {
            InitializeComponent();
            this.Text = "Product";
            this.generatedID = generatedID; 

            // Top list contains All Parts in inventory
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
            if(partInventoryGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part was selected to add to associated parts", "Please make a selection!");
                return;
            }
            foreach (DataGridViewRow currentIteration in partInventoryGrid.SelectedRows)
            {
                Part part = currentIteration.DataBoundItem as Part;
                partInventoryGrid.ClearSelection();

                if (part != null)
                {
                    associatedParts.Add(part);
                    return;
                }
            
            }
           
           
            
        }

        private void DeleteAssociatedPart_Button(object sender, EventArgs e)
        {
            if (associatedPartsGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part was selected to delete", "Please make a selection!");
                return;
            }


            foreach (DataGridViewRow selectedRow in associatedPartsGrid.SelectedRows)
            {
                associatedPartsGrid.Rows.RemoveAt(selectedRow.Index);
            }
        }

        private void SaveAssociatedParts(object sender, EventArgs e)
        {

            // Error Handling for Inventory conditions
            if (!int.TryParse(inventoryInput.Text, out int _))
            {
                MessageBox.Show("Please enter a numeric value for minmum.");
                return;
            }
            if (!decimal.TryParse(partPriceInput.Text, out decimal _))
            {
                MessageBox.Show("Please enter a decimal value for price.");
                return;
            }
            if (!int.TryParse(maxInput.Text, out int _))
            {
                MessageBox.Show("Please enter a numeric value for maximum.");
                return;
            }
            if (!int.TryParse(minInput.Text, out int _))
            {
                MessageBox.Show("Please enter a numeric value for minimum.");
                return;
            }

            string name = nameInput.Text;
            int minimumQuantity = int.Parse(minInput.Text);
            int maximumQuantity = int.Parse(maxInput.Text);
            int price = int.Parse(partPriceInput.Text);
            int totalStock = int.Parse(inventoryInput.Text);

            // Error Handling for Inventory conditions
            if (minimumQuantity > maximumQuantity)
            {
                MessageBox.Show("Error: Min value cannot be greater than Max.");
                return;
            }

            if (totalStock < maximumQuantity || totalStock < minimumQuantity)
            {
                MessageBox.Show("Error: Inventory must be between Max and Min");
                return;

            }
            Product product = new Product(generatedID, name, price, totalStock, minimumQuantity, maximumQuantity);
            Inventory.AddProduct(product);

            if(associatedParts.Count <= 0)
            {
                MessageBox.Show("You must pick an assoicated part");
                return;
            }
            foreach(Part part in associatedParts)
            {
                product.AssociatedParts.Add(part);
            }

            Close();
          
        }

        private void CancelAddProduct(object sender, EventArgs e)
        {
            Close();
        }
    }
}
