using matthewsmith_c968.models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace matthewsmith_c968
{
    public partial class AddPartForm : Form
    {
        private int generatedID;
        public AddPartForm(int generatedID)
        {
            InitializeComponent();
            this.Text = "Part";
            this.generatedID = generatedID;
        }
        // *************** Changes Label name on radio button click ***************//
        private void InHouse_Change(object sender, EventArgs e)
        {
            sourceLabel.Text = "Machine ID";
        }
        private void OutSourced_Change(object sender, EventArgs e)
        {
            sourceLabel.Text = "Company Name";
        }
        // *************** Save Part to Main Screen ***************//
        private void SavePartButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            int minimumQuantity, maximumQuantity, totalStock;
            decimal partPrice;

            // *************** Validating user input ***************//
            if (!int.TryParse(minInput.Text, out minimumQuantity))
            {
                MessageBox.Show("Error: Minimum quantity must be a valid integer.");
                return;
            }
            if (!int.TryParse(maxInput.Text, out maximumQuantity))
            {
                MessageBox.Show("Error: Maximum quantity must be a valid integer.");
                return;
            }
            if (!int.TryParse(inventoryInput.Text, out totalStock))
            {
                MessageBox.Show("Error: Total stock must be a valid integer.");
                return;
            }
            if (!decimal.TryParse(partPriceInput.Text, out partPrice))
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

            // Conditonal Input options based on radio selection

            if (inHouse_radio.Checked)
            {

                if (!int.TryParse(sourceInput.Text, out int machineID))
                {
                    MessageBox.Show("Error: Machine ID must be numeric values");
                    return;
                }

                Inhouse inHouse = new Inhouse(generatedID, name, totalStock, partPrice, minimumQuantity, maximumQuantity, machineID);
                Inventory.AddPart(inHouse);

            }
            else if (outSourced_radio.Checked)
            {
                string companyName = sourceInput.Text;
                if (companyName.Any(char.IsDigit))
                {
                    MessageBox.Show("Error: Company Name must be character values.");
                    return;
                }
                companyName = sourceInput.Text;

                Outsourced outSourced = new Outsourced(generatedID, name, totalStock, partPrice, minimumQuantity, maximumQuantity, companyName);
                Inventory.AddPart(outSourced);

            }

            Close();
        }
        private void CancelAddPart(object sender, EventArgs e)
        {
            Close();
        }
    }
}
