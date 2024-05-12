using matthewsmith_c968.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matthewsmith_c968
{
    public partial class ModifyPartForm : Form
    {
        MainForm MainScreen = (MainForm)Application.OpenForms["MainForm"];

        public ModifyPartForm()
        {
            InitializeComponent();
            this.Text = "Modify Part";


        }
        // Changes the Label to In-House when the radio button is clicked
        private void InHouse_Change(object sender, EventArgs e)
        {
            sourceLabel.Text = "Machine ID";
        }
        // Changes the Label to Outsourced when the radio button is clicked
        private void OutSourced_Change(object sender, EventArgs e)
        {
            sourceLabel.Text = "Company Name";


        }

        
        public ModifyPartForm(int generatedID, Inhouse inHousePart)
        {
            InitializeComponent();

            partIDInput.Text = generatedID.ToString();
            nameInput.Text = inHousePart.Name;
            inventoryInput.Text = inHousePart.InStock.ToString();
            partPrice.Text = inHousePart.Price.ToString();
            minInput.Text = inHousePart.Min.ToString();
            maxInput.Text = inHousePart.Max.ToString();
            sourceInput.Text = inHousePart.MachineID.ToString();


        }
      
        public ModifyPartForm(int generatedID, Outsourced outSourcedPart)
        {
            InitializeComponent();

            partIDInput.Text = generatedID.ToString();
            nameInput.Text = outSourcedPart.Name;
            inventoryInput.Text = outSourcedPart.InStock.ToString();
            partPrice.Text = outSourcedPart.Price.ToString();
            minInput.Text = outSourcedPart.Min.ToString();
            maxInput.Text = outSourcedPart.Max.ToString();
            sourceInput.Text = outSourcedPart.CompanyName;


        }

        // *************** Save Modified Part  **++++++++++++//
        private void SavePartButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            int minimumQuantity, maximumQuantity, totalStock, partID;
            decimal price;


            // *************** Error Handling  **++++++++++++//

            // Parse minimumQuantity
            if (!int.TryParse(minInput.Text, out minimumQuantity))
            {
                MessageBox.Show("Error: Minimum quantity must be a valid integer.");
                return;
            }

            // Parse maximumQuantity
            if (!int.TryParse(maxInput.Text, out maximumQuantity))
            {
                MessageBox.Show("Error: Maximum quantity must be a valid integer.");
                return;
            }

            // Parse totalStock
            if (!int.TryParse(inventoryInput.Text, out totalStock))
            {
                MessageBox.Show("Error: Total stock must be a valid integer.");
                return;
            }

            // Parse Part ID
            if (!int.TryParse(partIDInput.Text, out partID))
            {
                MessageBox.Show("Unknown Part ID Error.");
                return;
            }
            // Parse Part Price
            if (!decimal.TryParse(partPrice.Text, out price))
            {
                MessageBox.Show("Error: Part price must be a valid decimal value.");
                return;
            }

            if (minimumQuantity > maximumQuantity)
            {
                MessageBox.Show("Error: Your minimum exceeds your maximum.");
                return;
            }
            if (totalStock < minimumQuantity || totalStock > maximumQuantity)
            {
                MessageBox.Show("Error: Inventory must be between minimum and maximum");
                return;
            }


            // *************** Values passed based on radio button clicked  **++++++++++++//
            if (inHouse_radio.Checked)
            {
                if (!int.TryParse(sourceInput.Text, out int machineID))
                {
                    MessageBox.Show("Error: Machine ID must be numeric values");
                    return;
                }
                // Passing inHouse object with MachineID
                Inhouse inHouse = new Inhouse(partID, name, totalStock, price, minimumQuantity, maximumQuantity, machineID);
                Inventory.UpdatePart(partID, inHouse);


            }
            else if (outSourced_radio.Checked)
            {
                string companyName = sourceInput.Text;
                if (companyName.Any(char.IsDigit))
                {
                    MessageBox.Show("Error: Company Name must be character values.");
                    return;
                }

                Outsourced outsourced = new Outsourced(partID, name, totalStock, price, minimumQuantity, maximumQuantity, companyName);
                Inventory.UpdatePart(partID, outsourced);

            }


            Close();
            // Refresh the data source of the grid
            MainScreen.MainScreen();
            MainScreen.partGrid.Update();
            MainScreen.partGrid.Refresh();
        }
        private void CancelModifyPart(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
