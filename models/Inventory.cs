using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matthewsmith_c968.models
{
    class Inventory
    {
        // Both list Associated with Products and Parts
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();



        // Prepopulated data
        public static void mockData()
        {

            // Prepopulated data for the main form Parts table
            Part vehiclePart1 = new Inhouse(1, "Crankshaft", 15, 143.25m, 304, 10, 8565);
            Part vehiclePart2 = new Inhouse(2, "Drive Shaft", 10, 55.56m, 25, 10, 8565);
            Part vehiclePart3 = new Inhouse(3, "Piston Rod", 12, 35.56m, 25, 10, 1236);
            Part vehiclePart4 = new Inhouse(4, "Axle Shaft", 15, 75.54m, 25, 10, 1236);

            Part vehiclePart5 = new Outsourced(5, "Timing Belt", 66, 25.75m, 30, 10, "Toyota");
            Part vehiclePart6 = new Outsourced(6, "Differential Gear", 340, 366.00m, 25, 10, "Honda");
            Part vehiclePart7 = new Outsourced(7, "Camshaft", 12, 126.25m, 120, 10, "Ford");
            Part vehiclePart8 = new Outsourced(8, "Universal Joint", 15, 46.00m, 25, 10, "Chevrolet");

            // Inhouse Parts added to binding list
            Parts.Add(vehiclePart1);
            Parts.Add(vehiclePart2);
            Parts.Add(vehiclePart3);
            Parts.Add(vehiclePart4);

            // Outsourced Parts added to binding list
            Parts.Add(vehiclePart5);
            Parts.Add(vehiclePart6);
            Parts.Add(vehiclePart7);
            Parts.Add(vehiclePart8);

            // Prepopulated data for the main form Product table
            Product toyotaCamry = new Product(1, "2019 Toyota Camry", 24540m, 10, 5, 10);
            Product hondaCivic = new Product(2, "2020 Honda Civic", 22000m, 8, 4, 8);
            Product fordMustang = new Product(3, "2018 Ford Mustang", 35000m, 5, 3, 6);
            Product chevroletTahoe = new Product(4, "2021 Chevrolet Tahoe", 55000m, 7, 3, 7);
            Product subaruOutback = new Product(5, "2019 Subaru Outback", 30000m, 6, 2, 5);
            Product bmwX5 = new Product(6, "2022 BMW X5", 65000m, 4, 1, 4);
            Product mercedesCClass = new Product(7, "2021 Mercedes C-Class", 50000m, 3, 2, 3);

            // Products added to binding list
            Products.Add(toyotaCamry);
            Products.Add(hondaCivic);
            Products.Add(fordMustang);
            Products.Add(chevroletTahoe);
            Products.Add(subaruOutback);
            Products.Add(bmwX5);
            Products.Add(mercedesCClass);


        }


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
