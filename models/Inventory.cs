using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matthewsmith_c968.models
{
    class Inventory
    {
        // Both list Associated with Products and Parts
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();

        // All methods for Products

        // Add a Product to Inventory
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }
        // Remove a Product from Inventory
        public static bool RemoveProduct(int productID)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    Products.Remove(product);
                }
            }
            return false;

        }

        // Find a Product
        public static Product LookupProduct(int Product)
        {
            return Products.FirstOrDefault(product => product.ProductID == Product);
        }

        // Update Product with specified ID
        public static void UpdateProduct(int productID, Product newUpdatedProduct)
        {
            foreach (Product currentProduct in Products)
            {
                if (currentProduct.ProductID == productID)
                {
                    currentProduct.Name = newUpdatedProduct.Name;
                    currentProduct.InStock = newUpdatedProduct.InStock;
                    currentProduct.Price = newUpdatedProduct.Price;
                    currentProduct.Min = newUpdatedProduct.Min;
                    currentProduct.Max = newUpdatedProduct.Max;
                    currentProduct.AssociatedParts = newUpdatedProduct.AssociatedParts;
                    return;



                }
            }

        }
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }

        public static bool DeletePart(int part)
        {
            Part attemptPartDelete = LookupPart(part);
            if (attemptPartDelete != null)
            {
                Parts.Remove(attemptPartDelete);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Part LookupPart(int partID)
        {
            foreach (Part part in Parts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }

            }
            return null;

        }
        public static void updatePart(int partID, Part updatedPart)
        {
            DeletePart(partID);
            AddPart(updatedPart);
        }
    }
}
