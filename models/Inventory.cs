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

        //************************* Bindling List for Products and Parts  *************************//

        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> Parts = new BindingList<Part>();

        //************************* Dummy data *************************//
        public static void MockData()
        {
            // Inhouse Parts
            Parts.Add(new Inhouse(1, "Crankshaft", 15, 143.25m, 304, 10, 8565));
            Parts.Add(new Inhouse(2, "Drive Shaft", 10, 55.56m, 25, 10, 8565));
            Parts.Add(new Inhouse(3, "Piston Rod", 12, 35.56m, 25, 10, 1236));
            Parts.Add(new Inhouse(4, "Axle Shaft", 15, 75.54m, 25, 10, 1236));

            // Outsourced Parts
            Parts.Add(new Outsourced(780, "Fuel Pump", 35, 85.00m, 30, 10, "Bosch"));
            Parts.Add(new Outsourced(965, "Wheel Hub Assembly", 40, 120.00m, 50, 20, "Timken"));
            Parts.Add(new Outsourced(276, "Control Arm", 28, 60.50m, 35, 15, "Mevotech"));
            Parts.Add(new Outsourced(567, "Thermostat", 15, 25.25m, 20, 10, "Stant"));
            Parts.Add(new Outsourced(189, "Alternator", 22, 150.00m, 30, 10, "Denso"));
            Parts.Add(new Outsourced(492, "Starter Motor", 20, 120.00m, 30, 10, "Bosch"));
            Parts.Add(new Outsourced(704, "Fuel Filter", 18, 15.75m, 20, 10, "ACDelco"));

            // Products
            Products.Add(new Product(58, "2019 Toyota Camry", 24540m, 10, 5, 10));
            Products.Add(new Product(59, "2020 Honda Civic", 22000m, 8, 4, 8));
            Products.Add(new Product(60, "2018 Ford Mustang", 35000m, 5, 3, 6));
            Products.Add(new Product(61, "2021 Chevrolet Tahoe", 55000m, 7, 3, 7));
            Products.Add(new Product(62, "2019 Subaru Outback", 30000m, 6, 2, 5));
            Products.Add(new Product(63, "2022 BMW X5", 65000m, 4, 1, 4));
        }


        //************************* All methods for Products  *************************//
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

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
        public static Product LookupProduct(int Product)
        {
            return Products.FirstOrDefault(product => product.ProductID == Product);
        }

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

        //************************* All methods for Parts  *************************//
        public static void AddPart(Part part)
        {
            Parts.Add(part);
        }
        public static Part LookupPart(int partID)
        {
            return Parts.FirstOrDefault(part => part.PartID == partID);
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
        public static void UpdatePart(int partID, Part updatedPart)
        {
            DeletePart(partID);
            AddPart(updatedPart);



        }
    }
}


