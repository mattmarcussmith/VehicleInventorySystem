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
            
            // Inhouse Partds
            Part part1 = new Inhouse(1, "Crankshaft", 15, 143.25m, 304, 10, 8565);
            Part part2 = new Inhouse(2, "Drive Shaft", 10, 55.56m, 25, 10, 8565);
            Part part3 = new Inhouse(3, "Piston Rod", 12, 35.56m, 25, 10, 1236);
            Part part4 = new Inhouse(4, "Axle Shaft", 15, 75.54m, 25, 10, 1236);
            Part part5 = new Inhouse(101, "Crankshaft", 15, 143.25m, 304, 10, 8565);
            Part part6 = new Inhouse(102, "Drive Shaft", 10, 55.56m, 25, 10, 8565);
            Part part7 = new Inhouse(103, "Piston Rod", 12, 35.56m, 25, 10, 1236);
            Part part8 = new Inhouse(104, "Axle Shaft", 15, 75.54m, 25, 10, 1236);
            Part part9 = new Inhouse(150, "Exhaust Manifold", 20, 85.75m, 25, 10, 8565);
            Part part10 = new Inhouse(457, "Camshaft", 18, 110.75m, 25, 10, 8565);
            Part part11 = new Inhouse(760, "Timing Belt", 13, 65.35m, 25, 10, 8565);
            Part part12 = new Inhouse(963, "Oil Pump", 9, 40.25m, 25, 10, 1236);
            Part part13 = new Inhouse(166, "Valve Cover", 11, 25.90m, 25, 10, 1236);
            Part part14 = new Inhouse(469, "Engine Block", 17, 380.00m, 25, 10, 8565);
            Part part15 = new Inhouse(772, "Turbocharger", 6, 250.50m, 25, 10, 8565);
            Part part16 = new Inhouse(975, "Fuel Injector", 8, 75.45m, 25, 10, 1236);
            Part part17 = new Inhouse(278, "Intake Manifold", 12, 85.20m, 25, 10, 1236);
            Part part18 = new Inhouse(581, "Throttle Body", 10, 55.75m, 25, 10, 8565);
            Part part19 = new Inhouse(784, "Water Pump", 9, 35.00m, 25, 10, 8565);
            Part part20 = new Inhouse(187, "Fuel Filter", 6, 20.75m, 25, 10, 1236);
            Part part21 = new Inhouse(490, "Radiator", 8, 90.25m, 25, 10, 8565);
            Part part22 = new Inhouse(793, "Alternator", 10, 150.00m, 25, 10, 8565);
            Part part23 = new Inhouse(196, "Starter Motor", 9, 120.00m, 25, 10, 1236);
            Part part24 = new Inhouse(499, "Brake Caliper", 7, 85.75m, 25, 10, 1236);
            Part part25 = new Inhouse(802, "Wheel Hub Assembly", 14, 110.50m, 25, 10, 8565);
            Part part26 = new Inhouse(213, "Control Arm", 11, 60.00m, 25, 10, 8565);
            Part part27 = new Inhouse(516, "Tie Rod End", 9, 25.25m, 25, 10, 1236);
            Part part28 = new Inhouse(819, "Ball Joint", 8, 35.50m, 25, 10, 1236);
            Part part29 = new Inhouse(224, "Shock Absorber", 13, 75.75m, 25, 10, 8565);
            Part part30 = new Inhouse(527, "Strut Assembly", 12, 85.50m, 25, 10, 8565);
            Part part31 = new Inhouse(830, "Sway Bar Link", 7, 30.25m, 25, 10, 1236);
            Part part32 = new Inhouse(235, "Wheel Bearing", 10, 40.75m, 25, 10, 8565);
            Part part33 = new Inhouse(538, "CV Axle Shaft", 6, 75.00m, 25, 10, 8565);
            Part part34 = new Inhouse(941, "Drive Belt", 7, 20.25m, 25, 10, 1236);
            Part part35 = new Inhouse(244, "Spark Plug", 6, 5.75m, 25, 10, 1236);
            Part part36 = new Inhouse(547, "Ignition Coil", 8, 35.50m, 25, 10, 8565);
            Part part37 = new Inhouse(948, "Fuel Pump", 9, 85.00m, 25, 10, 8565);
            Part part38 = new Inhouse(455, "Oxygen Sensor", 5, 65.25m, 25, 10, 1236);
            Part part39 = new Inhouse(758, "Thermostat", 7, 25.50m, 25, 10, 1236);
            Part part40 = new Inhouse(961, "Water Pump", 10, 55.00m, 25, 10, 8565);
            Part part41 = new Inhouse(462, "Air Filter", 6, 15.75m, 25, 10, 8565);
            Part part42 = new Inhouse(865, "Oil Filter", 6, 10.25m, 25, 10, 1236);
            Part part43 = new Inhouse(168, "Transmission Filter", 5, 25.50m, 25, 10, 8565);
            Part part44 = new Inhouse(471, "Brake Pad Set", 7, 35.75m, 25, 10, 8565);
            Part part45 = new Inhouse(774, "Clutch Kit", 6, 125.00m, 25, 10, 1236);
            Part part46 = new Inhouse(977, "Exhaust System", 9, 350.00m, 25, 10, 1236);
            Part part47 = new Inhouse(280, "Battery", 8, 100.50m, 25, 10, 8565);

            Parts.Add(part1);
            Parts.Add(part2);
            Parts.Add(part3);
            Parts.Add(part4);
            Parts.Add(part5);
            Parts.Add(part6);
            Parts.Add(part7);
            Parts.Add(part8);
            Parts.Add(part9);
            Parts.Add(part10);
            Parts.Add(part11);
            Parts.Add(part12);
            Parts.Add(part13);
            Parts.Add(part14);
            Parts.Add(part15);
            Parts.Add(part16);
            Parts.Add(part17);
            Parts.Add(part18);
            Parts.Add(part19);
            Parts.Add(part20);
            Parts.Add(part21);
            Parts.Add(part22);
            Parts.Add(part23);
            Parts.Add(part24);
            Parts.Add(part25);
            Parts.Add(part26);
            Parts.Add(part27);
            Parts.Add(part28);
            Parts.Add(part29);
            Parts.Add(part30);
            Parts.Add(part31);
            Parts.Add(part32);
            Parts.Add(part33);
            Parts.Add(part34);
            Parts.Add(part35);
            Parts.Add(part36);
            Parts.Add(part37);
            Parts.Add(part38);
            Parts.Add(part39);
            Parts.Add(part40);
            Parts.Add(part41);
            Parts.Add(part42);
            Parts.Add(part43);
            Parts.Add(part44);
            Parts.Add(part45);
            Parts.Add(part46);
            Parts.Add(part47);

            // Outsourced Parts
            Part part48 = new Outsourced(780, "Fuel Pump", 35, 85.00m, 30, 10, "Bosch");
            Part part49 = new Outsourced(965, "Wheel Hub Assembly", 40, 120.00m, 50, 20, "Timken");
            Part part50 = new Outsourced(276, "Control Arm", 28, 60.50m, 35, 15, "Mevotech");
            Part part51 = new Outsourced(567, "Thermostat", 15, 25.25m, 20, 10, "Stant");
            Part part52 = new Outsourced(189, "Alternator", 22, 150.00m, 30, 10, "Denso");
            Part part53 = new Outsourced(492, "Starter Motor", 20, 120.00m, 30, 10, "Bosch");
            Part part54 = new Outsourced(704, "Fuel Filter", 18, 15.75m, 20, 10, "ACDelco");
            Part part55 = new Outsourced(917, "Radiator", 38, 95.00m, 35, 15, "Spectra");
            Part part56 = new Outsourced(221, "Ignition Coil", 16, 45.50m, 25, 10, "Delphi");
            Part part57 = new Outsourced(424, "Fuel Injector", 24, 80.25m, 30, 10, "Bosch");
            Part part58 = new Outsourced(637, "Oxygen Sensor", 20, 55.75m, 25, 10, "Denso");
            Part part59 = new Outsourced(850, "Catalytic Converter", 55, 225.00m, 50, 20, "Magnaflow");
            Part part60 = new Outsourced(538, "Mass Air Flow Sensor", 18, 65.00m, 25, 10, "Bosch");
            Part part61 = new Outsourced(935, "Power Steering Pump", 32, 110.50m, 40, 15, "Cardone");
            Part part62 = new Outsourced(680, "Exhaust Pipe", 30, 85.75m, 35, 15, "Walker");
            Part part63 = new Outsourced(376, "Ignition Switch", 14, 40.25m, 20, 10, "Standard Motor Products");
            Part part64 = new Outsourced(514, "Spark Plug", 12, 25.00m, 20, 10, "NGK");
            Part part65 = new Outsourced(829, "Radiator Hose", 18, 30.50m, 25, 10, "Gates");
            Part part66 = new Outsourced(742, "Air Filter", 20, 15.75m, 15, 5, "K&N Engineering");
            Part part67 = new Outsourced(245, "Brake Disc", 40, 80.00m, 35, 15, "ACDelco");
            Part part68 = new Outsourced(576, "Transmission Filter", 16, 20.25m, 25, 10, "WIX Filters");
            Part part69 = new Outsourced(398, "CV Axle", 28, 95.00m, 30, 10, "SurTrack");
            Part part70 = new Outsourced(167, "Strut Assembly", 35, 120.75m, 40, 15, "Monroe");
            Part part71 = new Outsourced(920, "Wheel Bearing", 22, 55.00m, 30, 10, "Timken");
            Part part72 = new Outsourced(431, "Brake Booster", 18, 85.50m, 35, 15, "Cardone");
            Part part73 = new Outsourced(587, "Window Regulator", 24, 75.25m, 30, 10, "Dorman");
            Part part74 = new Outsourced(781, "Fuel Pump", 35, 85.00m, 30, 10, "Bosch");
            Part part75 = new Outsourced(966, "Wheel Hub Assembly", 40, 120.00m, 50, 20, "Timken");
            Part part76 = new Outsourced(277, "Control Arm", 28, 60.50m, 35, 15, "Mevotech");
            Part part77 = new Outsourced(568, "Thermostat", 15, 25.25m, 20, 10, "Stant");
            Part part78 = new Outsourced(190, "Alternator", 22, 150.00m, 30, 10, "Denso");
            Part part79 = new Outsourced(493, "Starter Motor", 20, 120.00m, 30, 10, "Bosch");
            Part part80 = new Outsourced(705, "Fuel Filter", 18, 15.75m, 20, 10, "ACDelco");
            Part part81 = new Outsourced(918, "Radiator", 38, 95.00m, 35, 15, "Spectra");
            Part part82 = new Outsourced(222, "Ignition Coil", 16, 45.50m, 25, 10, "Delphi");
            Part part83 = new Outsourced(425, "Fuel Injector", 24, 80.25m, 30, 10, "Bosch");
            Part part84 = new Outsourced(638, "Oxygen Sensor", 20, 55.75m, 25, 10, "Denso");
            Part part85 = new Outsourced(851, "Catalytic Converter", 55, 225.00m, 50, 20, "Magnaflow");
            Part part86 = new Outsourced(539, "Mass Air Flow Sensor", 18, 65.00m, 25, 10, "Bosch");
            Part part87 = new Outsourced(936, "Power Steering Pump", 32, 110.50m, 40, 15, "Cardone");
            Part part88 = new Outsourced(681, "Exhaust Pipe", 30, 85.75m, 35, 15, "Walker");
            Part part89 = new Outsourced(377, "Ignition Switch", 14, 40.25m, 20, 10, "Standard Motor Products");
            Part part90 = new Outsourced(515, "Spark Plug", 12, 25.00m, 20, 10, "NGK");
            Part part91 = new Outsourced(830, "Radiator Hose", 18, 30.50m, 25, 10, "Gates");
            Part part92 = new Outsourced(743, "Air Filter", 20, 15.75m, 15, 5, "K&N Engineering");
            Part part93 = new Outsourced(246, "Brake Disc", 40, 80.00m, 35, 15, "ACDelco");
            Part part94 = new Outsourced(577, "Transmission Filter", 16, 20.25m, 25, 10, "WIX Filters");
            Part part95 = new Outsourced(399, "CV Axle", 28, 95.00m, 30, 10, "SurTrack");
            Part part96 = new Outsourced(168, "Strut Assembly", 35, 120.75m, 40, 15, "Monroe");
            Part part97 = new Outsourced(921, "Wheel Bearing", 22, 55.00m, 30, 10, "Timken");
            Part part98 = new Outsourced(432, "Brake Booster", 18, 85.50m, 35, 15, "Cardone");
            Part part99 = new Outsourced(588, "Window Regulator", 24, 75.25m, 30, 10, "Dorman");

            Parts.Add(part48);
            Parts.Add(part49);
            Parts.Add(part50);
            Parts.Add(part51);
            Parts.Add(part52);
            Parts.Add(part53);
            Parts.Add(part54);
            Parts.Add(part55);
            Parts.Add(part56);
            Parts.Add(part57);
            Parts.Add(part58);
            Parts.Add(part59);
            Parts.Add(part60);
            Parts.Add(part61);
            Parts.Add(part62);
            Parts.Add(part63);
            Parts.Add(part64);
            Parts.Add(part65);
            Parts.Add(part66);
            Parts.Add(part67);
            Parts.Add(part68);
            Parts.Add(part69);
            Parts.Add(part70);
            Parts.Add(part71);
            Parts.Add(part72);
            Parts.Add(part73);
            Parts.Add(part74);
            Parts.Add(part75);
            Parts.Add(part76);
            Parts.Add(part77);
            Parts.Add(part78);
            Parts.Add(part79);
            Parts.Add(part80);
            Parts.Add(part81);
            Parts.Add(part82);
            Parts.Add(part83);
            Parts.Add(part84);
            Parts.Add(part85);
            Parts.Add(part86);
            Parts.Add(part87);
            Parts.Add(part88);
            Parts.Add(part89);
            Parts.Add(part90);
            Parts.Add(part91);
            Parts.Add(part92);
            Parts.Add(part93);
            Parts.Add(part94);
            Parts.Add(part95);
            Parts.Add(part96);
            Parts.Add(part97);
            Parts.Add(part98);
            Parts.Add(part99);

            Product product10 = new Product(58, "2019 Toyota Camry", 24540m, 10, 5, 10);
            Product product11 = new Product(59, "2020 Honda Civic", 22000m, 8, 4, 8);
            Product product12 = new Product(60, "2018 Ford Mustang", 35000m, 5, 3, 6);
            Product product13 = new Product(61, "2021 Chevrolet Tahoe", 55000m, 7, 3, 7);
            Product product14 = new Product(62, "2019 Subaru Outback", 30000m, 6, 2, 5);
            Product product15 = new Product(63, "2022 BMW X5", 65000m, 4, 1, 4);
            Product product16 = new Product(64, "2021 Mercedes C-Class", 50000m, 3, 2, 3);
            Product product17 = new Product(729, "2023 Audi Q5", 53000m, 6, 2, 5);
            Product product18 = new Product(856, "2019 Toyota Camry", 24540m, 10, 5, 10);
            Product product19 = new Product(281, "2020 Honda Civic", 22000m, 8, 4, 8);
            Product product20 = new Product(404, "2018 Ford Mustang", 35000m, 5, 3, 6);
            Product product21 = new Product(512, "2021 Chevrolet Tahoe", 55000m, 7, 3, 7);
            Product product22 = new Product(633, "2019 Subaru Outback", 30000m, 6, 2, 5);
            Product product23 = new Product(755, "2022 BMW X5", 65000m, 4, 1, 4);
            Product product24 = new Product(824, "2021 Mercedes C-Class", 50000m, 3, 2, 3);
            Product product25 = new Product(943, "2024 Tesla Model S", 80000m, 6, 2, 5);
            Product product26 = new Product(126, "2021 Toyota Corolla", 20000m, 9, 4, 8);
            Product product27 = new Product(227, "2020 Ford Fusion", 24000m, 8, 3, 7);
            Product product28 = new Product(328, "2019 Honda Accord", 26000m, 7, 2, 6);
            Product product29 = new Product(429, "2022 Chevrolet Silverado", 45000m, 6, 3, 7);
            Product product30 = new Product(530, "2023 Subaru Forester", 28000m, 8, 2, 5);
            Product product31 = new Product(631, "2020 BMW 3 Series", 40000m, 5, 1, 4);
            Product product32 = new Product(732, "2022 Mercedes-Benz E-Class", 55000m, 4, 2, 3);
            Product product33 = new Product(833, "2021 Tesla Model 3", 45000m, 5, 2, 5);
            Product product34 = new Product(934, "2023 Audi A4", 48000m, 6, 2, 5);
            Product product35 = new Product(1035, "2024 Toyota RAV4", 32000m, 7, 3, 6);
            Product product36 = new Product(1136, "2021 Ford Explorer", 42000m, 6, 2, 5);
            Product product37 = new Product(1237, "2020 Honda CR-V", 30000m, 8, 3, 7);
            Product product38 = new Product(1338, "2022 Chevrolet Equinox", 35000m, 7, 2, 6);
            Product product39 = new Product(1439, "2023 Subaru Outback", 34000m, 8, 2, 5);
            Product product40 = new Product(1540, "2021 BMW X3", 47000m, 5, 1, 4);
            Product product41 = new Product(1641, "2024 Mercedes-Benz GLC", 52000m, 4, 2, 3);
            Product product42 = new Product(1742, "2022 Tesla Model Y", 55000m, 5, 2, 5);
            Product product43 = new Product(1843, "2023 Audi Q3", 38000m, 6, 2, 5);
            Product product44 = new Product(1944, "2024 Toyota Highlander", 45000m, 7, 3, 6);
            Product product45 = new Product(2045, "2021 Ford Escape", 32000m, 8, 3, 7);
            Product product46 = new Product(2146, "2020 Honda Pilot", 40000m, 7, 2, 6);
            Product product47 = new Product(2247, "2022 Chevrolet Traverse", 38000m, 7, 2, 6);
            Product product48 = new Product(2348, "2023 Subaru Crosstrek", 29000m, 9, 2, 5);
            Product product49 = new Product(2449, "2024 BMW X1", 42000m, 6, 1, 4);
            Product product50 = new Product(2550, "2021 Mercedes-Benz GLB", 48000m, 5, 2, 3);

            Products.Add(product10);
            Products.Add(product11);
            Products.Add(product12);
            Products.Add(product13);
            Products.Add(product14);
            Products.Add(product15);
            Products.Add(product16);
            Products.Add(product17);
            Products.Add(product18);
            Products.Add(product19);
            Products.Add(product20);
            Products.Add(product21);
            Products.Add(product22);
            Products.Add(product23);
            Products.Add(product24);
            Products.Add(product25);
            Products.Add(product10);
            Products.Add(product11);
            Products.Add(product12);
            Products.Add(product13);
            Products.Add(product14);
            Products.Add(product15);
            Products.Add(product16);
            Products.Add(product17);
            Products.Add(product18);
            Products.Add(product19);
            Products.Add(product20);
            Products.Add(product21);
            Products.Add(product22);
            Products.Add(product23);
            Products.Add(product24);
            Products.Add(product25);
            Products.Add(product26);
            Products.Add(product27);
            Products.Add(product28);
            Products.Add(product29);
            Products.Add(product30);
            Products.Add(product31);
            Products.Add(product32);
            Products.Add(product33);
            Products.Add(product34);
            Products.Add(product35);
            Products.Add(product36);
            Products.Add(product37);
            Products.Add(product38);
            Products.Add(product39);
            Products.Add(product40);
            Products.Add(product41);
            Products.Add(product42);
            Products.Add(product43);
            Products.Add(product44);
            Products.Add(product45);
            Products.Add(product46);
            Products.Add(product47);
            Products.Add(product48);
            Products.Add(product49);
            Products.Add(product50);

        }
        // All methods for Products
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
                if (currentProduct.ProductID != productID)
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
        public static void UpdatePart(int partID, Part updatedPart)
        {
            foreach(Part currentIteration in Parts)
            {
                if(currentIteration.PartID == partID)
                {
                   
                    currentIteration.Name = updatedPart.Name;
                    currentIteration.InStock = updatedPart.InStock;
                    currentIteration.Price = updatedPart.Price;
                    currentIteration.Min = updatedPart.Min;
                    currentIteration.Max = updatedPart.Max;
                    
                    if(currentIteration is Inhouse inHouseParts && updatedPart is Inhouse updateInhouseParts)
                    {
                        inHouseParts.MachineID = updateInhouseParts.MachineID;
                        
                    }
                     else if (currentIteration is Outsourced outSourcedParts && updatedPart is Outsourced updatedOutSourcedParts)
                    {
                        outSourcedParts.CompanyName = updatedOutSourcedParts.CompanyName;
                       
                    }
         
                    return;
                }
            }
     
        }
    }

}
