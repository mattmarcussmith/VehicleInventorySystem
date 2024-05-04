using matthewsmith_c968.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matthewsmith_c968
{
    public partial class MainForm : Form
    {
        private static int updatedPartID = 9455;
        private int GeneratedID()
        {
            Random random = new Random();
            return random.Next(2423, updatedPartID);
        }

        public MainForm()
        {
            InitializeComponent();
            MainScreen();
         
            this.Text = "Main Screen";
            
          
        }
        public void MainScreen()
        {
            // Prepopulate the mock data for Parts and Products
            Inventory.mockData();

            // Set the data to the Parts Grid View
            var totalPartsInventory = new BindingSource();
            totalPartsInventory.DataSource = Inventory.Parts;
            dgvParts.DataSource = totalPartsInventory;

        
            // Entire row selected when clicked for Parts
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Read only Grid
            dgvParts.ReadOnly = true;
            // Cannot select more than one row
            dgvParts.MultiSelect = false;
            // Cannot create rows
            dgvParts.AllowUserToAddRows = false;

            // Set the data to the Products Grid View
            var totalProductsInventory = new BindingSource();
            totalProductsInventory.DataSource = Inventory.Products;
            dgvProducts.DataSource = totalProductsInventory;

           

            // Entire row selected when clicked for Parts
            dgvParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Read only Grid
            dgvParts.ReadOnly = true;
            // Cannot select more than one row
            dgvParts.MultiSelect = false;
            // Cannot create rows
            dgvParts.AllowUserToAddRows = false;

            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Read only Grid
            dgvProducts.ReadOnly = true;
            // Cannot select more than one row
            dgvProducts.MultiSelect = false;
            // Cannot create rows
            dgvProducts.AllowUserToAddRows = false;

        }

        // Clears selected row on application start
        private void clearBindingParts(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvParts.ClearSelection();
        }

        private void clearBindingProducts(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProducts.ClearSelection();
        }





        // Search Event
        private void search_Part(object sender, EventArgs e)
        {

            string searchQuery = searchPartInput.Text;
            int searchQueryID;
            

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Error: Please enter a Part ID number.");
                return;
            }
          

            searchQueryID = int.Parse(searchQuery);
        
            Part matchingPartID = Inventory.LookupPart(searchQueryID);
         
            foreach (DataGridViewRow row in dgvParts.Rows)
            {
               
                Part currentRow = row.DataBoundItem as Part;

                if (matchingPartID != null && matchingPartID.PartID == currentRow.PartID)
                {
                    row.Selected = true;
                    break;
                }
               
                else if(matchingPartID == null)
                {
                    MessageBox.Show("Error: Part ID does not exists.");
                    return;
                }
                else if (searchQueryID < 1)
                {
                    MessageBox.Show("Error: Please enter a Part ID number that is greater than zero.");
                    return;
                }
                else
                {
                    row.Selected = false;
                 
                  

                }
            }
        }

        // *** Part click events **//

        // Part Delete Event
        private void part_Delete(object sender, EventArgs e)
        {

            if (dgvParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part was selected to delete", "Please make a selection!");
                return;
            }
            foreach (DataGridViewRow row in dgvParts.SelectedRows)
                {
                    dgvParts.Rows.RemoveAt(row.Index);

            }

            
        }

        private void part_Add(object sender, EventArgs e)
        {
           new AddPartForm().ShowDialog();
        }

        
        private void part_Modify(object sender, EventArgs e)
        {
            Part part = dgvParts.CurrentRow.DataBoundItem as Part;
            int generatedID = GeneratedID();

            if (dgvParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part was selected to modify", "Please make a selection!");
                return;
            }
            if (part is Inhouse)
            {
                ModifyPartForm form = new ModifyPartForm(generatedID, (Inhouse) part);
                form.ShowDialog();
            }
            if(part is Outsourced)
            {
                ModifyPartForm form = new ModifyPartForm(generatedID, (Outsourced) part);
                form.ShowDialog();

            }

        }


        // *** Product click events **//
        private void product_Delete(object sender, EventArgs e)
        {
            if(dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("No product was selected", "Please make a selection");
                return;
            }

            foreach(DataGridViewRow row in dgvProducts.SelectedRows)
            {
                dgvProducts.Rows.RemoveAt(row.Index);
            }

            if (dgvProducts.CurrentRow != null)
            {
                Product product = dgvProducts.CurrentRow.DataBoundItem as Product;
                if (product != null && product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Please remove assigned Parts before deleting a Product");
                    return;
                }

            }
        }

        private void product_Modify(object sender, EventArgs e)
        {

        }

        private void product_Add(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
