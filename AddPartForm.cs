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
    public partial class AddPartForm : Form
    {
        private static int previousPartID = 9419;

        public AddPartForm()
        {
            InitializeComponent();
            this.Text = "Part";
            partID.Text = GeneratedID(previousPartID).ToString();
        }
         private int GeneratedID(int previousPartID)
        {
            Random random = new Random();
            return random.Next(2423, previousPartID);
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

        private void SavePartButton_Click(object sender, EventArgs e)
        {
            string name;
            int minimumQuantity, maximumQuantity, totalStock;
            decimal partPrice;
            int machineID;
            string companyName;

            try
            {
                // Parsing the Input fields from Strings to Integers
                name = nameInput.Text;
                minimumQuantity = int.Parse(minInput.Text);
                maximumQuantity = int.Parse(maxInput.Text);
                totalStock = int.Parse(inventoryInput.Text);
                partPrice = decimal.Parse(partPriceInput.Text);


                // Error Handling for Inventory conditions
                if (minimumQuantity > maximumQuantity)
                {
                    MessageBox.Show("Error: Min value cannot be greater than Max.");
                    return;
                }
               
                if ( totalStock < maximumQuantity || totalStock < minimumQuantity)
                {
                    MessageBox.Show("Error: Inventory must be between Max and Min");
                    return;
                }
             
            } catch {
                MessageBox.Show("Error: Please enter numeric values for Inventory, Price, Max, and Min fields. ");
                return;
            }


            // Conditonal Input options based on radio selection

            if (inHouse_radio.Checked)
                {
                machineID = int.Parse(sourceInput.Text);

                Inhouse inHouse = new Inhouse(GeneratedID(previousPartID), name, totalStock, partPrice, minimumQuantity, maximumQuantity, machineID);
                    Inventory.AddPart(inHouse);
                  
                } else if(outSourced_radio.Checked)
                {
                companyName = sourceInput.Text;

                Outsourced outSourced = new Outsourced(GeneratedID(previousPartID), name, totalStock, partPrice, minimumQuantity, maximumQuantity, companyName);
                    Inventory.AddPart(outSourced);
                   
                } else
                {
                    MessageBox.Show("Error: Please select In-House or Outsourced");
                }
  
            Close();


        }

        private void CancelAddPart(object sender, EventArgs e)
        {
            Close();
        }
    }
}
