using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechKNOW.Models.Inventory
{
    public class PartModel
    {
        public int ID { get; set; }
        public int PartNumber { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
