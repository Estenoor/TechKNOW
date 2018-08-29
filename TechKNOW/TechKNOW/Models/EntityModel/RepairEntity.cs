using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechKNOW.Models.Inventory;

namespace TechKNOW.Models.EntityModel
{
    public class RepairEntity
    {
        public int ID { get; set; }

        public int TechnicianID { get; set; }
        public int StudentID { get; set; }

        public ChromebookModel Chromebook { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Description { get; set; }
        public string Comments { get; set; }

        public List<PartModel> PartList { get; set; }

        public double RepairCost { get; set; }
    }
}
