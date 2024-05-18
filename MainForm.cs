using matthewsmith_c968.models;
using System;
using System.Windows.Forms;

namespace matthewsmith_c968
{
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            InitializeComponent();
            
            this.Text = "Main Screen";
            // **************************** Instantiates Dummy Data ***************************//
            Inventory.MockData();
         
            // Set the data to the Parts Grid View
            var totalPartsInventory = new BindingSource();
            totalPartsInventory.DataSource = Inventory.Parts;
            partGrid.DataSource = totalPartsInventory;
            // Entire row selected
            partGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Read only Grid
            partGrid.ReadOnly = true;
            // Cannot select more than one row
            partGrid.MultiSelect = false;
            // Cannot create rows
            partGrid.AllowUserToAddRows = false;

            // Set the data to the Products Grid View
            var totalProductsInventory = new BindingSource();
            totalProductsInventory.DataSource = Inventory.Products;
            productGrid.DataSource = totalProductsInventory;

            // Entire row selected
            productGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Read only Grid
            productGrid.ReadOnly = true;
            // Cannot select more than one row
            productGrid.MultiSelect = false;
            // Cannot create rows
            productGrid.AllowUserToAddRows = false;

        }
        // **************************** Creates random ID for new Part ***************************//
        public static Random random = new Random();
        public int generateID;
        private int GeneratedID()
        {
            int generatedID = random.Next(10000, 99999);

            return generatedID;
        }
        // Clears selected row on application start
        private void ClearBindingParts(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partGrid.ClearSelection();
        }

        private void ClearBindingProducts(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productGrid.ClearSelection();
        }

        // *************** Search Part Event ***************//
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
                MessageBox.Show("This Part ID does not exist");
                return;
            }
            foreach (DataGridViewRow currentIteration in partGrid.Rows)
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
        // *************** Part Click Events ***************//
        private void PartAdd_Button(object sender, EventArgs e)
        {
            int generatedID = GeneratedID();
            new AddPartForm(generatedID).ShowDialog();
        }

        private void PartModify_Button(object sender, EventArgs e)
        {
            if (partGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part was selected to modify", "Please make a selection!");
                return;
            }

            Part selectedPart = (Part)partGrid.CurrentRow.DataBoundItem;
            if (selectedPart is Inhouse inhouse)
            {
                // Open ModifyPartForm for Inhouse parts
                new ModifyPartForm(inhouse).ShowDialog();
            }
            else if (selectedPart is Outsourced outsourced)
            {
                // Open ModifyPartForm for Outsourced parts
                new ModifyPartForm(outsourced).ShowDialog();
            }
        }
        private void PartDelete_Button(object sender, EventArgs e)
        {

            if (partGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("No part was selected to delete", "Please make a selection!");
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "This cannot be undone.");

            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in partGrid.SelectedRows)
                {
                    partGrid.Rows.RemoveAt(row.Index);
                }
            }
        }
        // *************** Search Part Event ***************//
        private void SearchProduct_Button(object sender, EventArgs e)
        {
            string searchValue = searchProductInput.Text;

            if (!int.TryParse(searchValue, out _))
            {
                MessageBox.Show("Please enter a numeric value");
                return;
            }

            int searchID = int.Parse(searchProductInput.Text);
            Product matchingPartFound = Inventory.LookupProduct(searchID);
            if (searchID < 0)
            {
                MessageBox.Show("Please enter a numeric value greater than 0");
                return;
            }
            if (matchingPartFound == null)
            {
                MessageBox.Show("This Part ID does not exist");
                return;
            }
            foreach (DataGridViewRow currentIteration in productGrid.Rows)
            {
                Product part = (Product)currentIteration.DataBoundItem;
                if (part.ProductID == matchingPartFound.ProductID)
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

        // *************** Product Click Events ***************//
        private void ProductSave_Button(object sender, EventArgs e)
        {
            AddProductForm addNewProduct = new AddProductForm(generateID);
            addNewProduct.ShowDialog();
        }
        // Modify Product
        private void ProductModify_Button(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)productGrid.CurrentRow.DataBoundItem;

            if (productGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Product to modify. ");
                return;
            }
            new ModifyProductForm( selectedProduct).ShowDialog();
        }

        private void ProductDelete_Button(object sender, EventArgs e)
        {
            if (productGrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("No product was selected", "Please make a selection");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "This cannot be undone.");
            if (result == DialogResult.OK)
            {
                foreach (DataGridViewRow row in productGrid.SelectedRows)
                {
                    productGrid.Rows.RemoveAt(row.Index);
                }
            }
            if (productGrid.CurrentRow != null)
            {
                // Checks if the Product thats clicked is null or does NOT have Associated parts
                Product product = productGrid.CurrentRow.DataBoundItem as Product;
                if (product != null && product.AssociatedParts.Count > 0)
                {
                    MessageBox.Show("Please remove assigned Parts before deleting a Product");
                    return;
                }
            }
        }
        private void ExitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
