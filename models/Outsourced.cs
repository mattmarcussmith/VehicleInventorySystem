using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matthewsmith_c968.models
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced() { }
        public Outsourced(int partID, string name, int inStock, decimal price, int min, int max)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min; 
            Max = max;
          
        }
        public Outsourced(int partID, string name, int inStock, decimal price, int min, int max, string companyName)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
            CompanyName = companyName;

        }
    }
}
