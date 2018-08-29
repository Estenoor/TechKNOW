using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechKNOW.Models.Repair
{
    public class CreateViewModel
    {
        public int ID { get; set; }

        public string AssetTag { get; set; }
        public string SerialNumber { get; set; }

        public int TechnicianID { get; set; }
        public int StudentID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
