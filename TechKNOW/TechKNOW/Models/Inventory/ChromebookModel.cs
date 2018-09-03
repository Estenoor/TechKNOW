using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechKNOW.Models.EntityModel;

namespace TechKNOW.Models.Inventory
{
    public class ChromebookModel
    {
        public int ID { get; set; }

        public string AssetTag { get; set; }
        public string SerialNumber { get; set; }

        public bool IsLoaner { get; set; }
        public int? StudentID { get; set; }

        public bool Active { get; set; }
        public string Location { get; set; }

        public List<RepairEntity> Repairs { get; set; }
    }
}
