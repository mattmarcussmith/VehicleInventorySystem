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

        // *************** Text Property requires String inputs  **++++++++++++//
        public ModifyPartForm(int partID, Inhouse inHousePart)
        {
            InitializeComponent();

            partIDInput.Text = partID.ToString();
            nameInput.Text = inHousePart.Name;
            inventoryInput.Text = inHousePart.InStock.ToString();
            partPrice.Text = inHousePart.Price.ToString();
            minInput.Text = inHousePart.Min.ToString();
            maxInput.Text = inHousePart.Max.ToString();
            sourceInput.Text = inHousePart.MachineID.ToString();


        }
        // *************** Text Property requires String inputs  **++++++++++++//
        public ModifyPartForm(int partID, Outsourced outSourcedPart)
        {
            InitializeComponent();

            this.partIDInput.Text = partID.ToString();
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

            string name;
            int minimumQuantity, maximumQuantity, totalStock, partID;
            decimal price;
            int machineID;
            string companyName;

            // Converts inputs back to respected Data Types 
            name = nameInput.Text;
            partID = int.Parse(partIDInput.Text);
            minimumQuantity = int.Parse(minInput.Text);
            maximumQuantity = int.Parse(maxInput.Text);
            totalStock = int.Parse(inventoryInput.Text);
            price = decimal.Parse(partPrice.Text);
            


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

            // Conditonal Input options based on radio selection
            if (inHouse_radio.Checked)
            {
                try
                {
                    // Parsing Machine ID after Input is clicked is required because both machineID AND companyName use the same input field
                    machineID = int.Parse(sourceInput.Text);
                    Inhouse inHouse = new Inhouse(partID, name, totalStock, price, minimumQuantity, maximumQuantity, machineID);
                    Inventory.updatePart(partID, inHouse);
                    inHouse_radio.Checked = true;

                }
                catch (FormatException)
                {
                    MessageBox.Show("Error: Machine ID must be a numeric value.", "Please try again.");
                    return;
                }

            }
           
            else if (outSourced_radio.Checked)
            {
                 // Parsing companyName after Input is clicked is required because both companyName and MachineID use the same input field
                 companyName = sourceInput.Text;

                // Check if companyName contains numeric characters
                if (companyName.Any(char.IsDigit))
                {
                    MessageBox.Show("Error: Company Name cannot contain numeric characters.", "Please try again.");
                    return;
                }
                try
                    {
                    Outsourced outSourced = new Outsourced(partID, name, totalStock, price, minimumQuantity, maximumQuantity, companyName);
                        Inventory.updatePart(partID, outSourced);
                        outSourced_radio.Checked = true;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Error: Company Name must be character values.", "Please try again.");
                        return;
                    }
            }
            else
            { 
                MessageBox.Show("Error: Please select In-House or Outsourced");
                return;
            }

            Close();
            MainScreen.dgvParts.Update();
            MainScreen.dgvParts.Refresh();
        }
        private void CancelModifyPart(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
