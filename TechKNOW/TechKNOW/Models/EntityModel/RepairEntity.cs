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

        public String TechnicianID { get; set; }

        public int StudentID { get; set; }

        public ChromebookModel Chromebook { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public String Description { get; set; }
        public String Comments { get; set; }

        public List<PartModel> PartList { get; set; }

        public double? RepairCost { get; set; }
    }
}
