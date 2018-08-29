using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechKNOW.Models.Inventory;

namespace TechKNOW.Models.Reporting
{
    public class ReceiptModel
    {
        public int ID { get; set; }

        public int TechnicianID { get; set; }
        public int StudentID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ChromebookModel ChromeBook { get; set; }
        public List<PartModel> PartList { get; set; }
        public double TotalCost { get; set; }
    }
}
