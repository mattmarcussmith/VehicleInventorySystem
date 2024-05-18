using matthewsmith_c968.models;
using System;
using System.Windows.Forms;

namespace matthewsmith_c968
{
    public partial class ModifyPartForm : Form
    {
        MainForm MainScreen = (MainForm)Application.OpenForms["MainForm"];

        // **************************** Constructor for Inhouse Parts  ***************************//
        public ModifyPartForm(Inhouse inHousePart)
        {
            InitializeComponent();
            this.Text = "Modify Part";
            partIDInput.Text = inHousePart.PartID.ToString();
            nameInput.Text = inHousePart.Name;
            inventoryInput.Text = inHousePart.InStock.ToString();
            partPrice.Text = inHousePart.Price.ToString();
            minInput.Text = inHousePart.Min.ToString();
            maxInput.Text = inHousePart.Max.ToString();
            sourceInput.Text = inHousePart.MachineID.ToString();

            inHouse_radio.Checked = true;
        }
        // **************************** Constructor for Outsourced Parts  ***************************//
        public ModifyPartForm(Outsourced outSourcedPart)
        {
            InitializeComponent();
            this.Text = "Modify Part";
            partIDInput.Text = outSourcedPart.PartID.ToString();
            nameInput.Text = outSourcedPart.Name;
            inventoryInput.Text = outSourcedPart.InStock.ToString();
            partPrice.Text = outSourcedPart.Price.ToString();
            minInput.Text = outSourcedPart.Min.ToString();
            maxInput.Text = outSourcedPart.Max.ToString();
            sourceInput.Text = outSourcedPart.CompanyName;

            outSourced_radio.Checked = true;
        }

        // **************************** Save Modified Part ****************************//
        private void SavePartButton_Click(object sender, EventArgs e)
        {
            string partName = nameInput.Text;
            int partID = int.Parse(partIDInput.Text);
            int minimumQuantity;
            int maximumQuantity;
            int totalStock;
            decimal price;

            // *************** Validating user input ***************//

            if (!int.TryParse(minInput.Text, out minimumQuantity))
            {
                MessageBox.Show("Error: minimum quantity must be a valid integer.");
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

            // *************** Updates Part in Inventory based on condition of radio state ***************//
            if (inHouse_radio.Checked)
            {
                if (!int.TryParse(sourceInput.Text, out _))
                {
                    MessageBox.Show("Error: You must enter a valid integer for Machine ID");
                    return;
                }
                Inhouse inHousePart = new Inhouse(partID, partName, totalStock, price, minimumQuantity, maximumQuantity, int.Parse(sourceInput.Text));
                Inventory.UpdatePart(partID, inHousePart);
            }
            else
            {
                if (int.TryParse(sourceInput.Text, out _))
                {
                    MessageBox.Show("Error: You must enter character values for Company name.");
                    return;
                }
                Outsourced outSourcedPart = new Outsourced(partID, partName, totalStock, price, minimumQuantity, maximumQuantity, sourceInput.Text);
                Inventory.UpdatePart(partID, outSourcedPart);
            }
            MainScreen.partGrid.Update();
            MainScreen.partGrid.Refresh();
            Close();
        }
        private void InHouse_Change(object sender, EventArgs e)
        {
            sourceLabel.Text = "Machine ID";
        }
        private void OutSourced_Change(object sender, EventArgs e)
        {
            sourceLabel.Text = "Company Name";
        }
        private void CancelModifyPart(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
