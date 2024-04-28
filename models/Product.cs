using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matthewsmith_c968.models
{
    class Product
    {

        // Fields
        private int productID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        // Properties
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        // A list of Parts that are associated with Product
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        // Add Part to associated Product
        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        // Delete Part from assoicated Product
        public bool RemoveAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    AssociatedParts.Remove(part);
                    return true;
                }
            }
            return false;
        }
        // Find a Part 
        public Part LookupAssociatedPart(int partID)
        {
            return AssociatedParts.FirstOrDefault(part => part.PartID == partID);
        }

    }
}