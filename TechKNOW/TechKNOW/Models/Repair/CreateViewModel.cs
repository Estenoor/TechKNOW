using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechKNOW.Models.Repair
{
    public class CreateViewModel
    {
        public CreateViewModel() { }

        public CreateViewModel(int ID, String AssetTag, String SerialNumber, String TechnicianID)
        {
            this.ID = ID;
            this.AssetTag = AssetTag;
            this.SerialNumber = SerialNumber;
            this.TechnicianID = TechnicianID;
        }


        public int ID { get; set; }

        public string AssetTag { get; set; }
        public string SerialNumber { get; set; }

        public string TechnicianID { get; set; }
        public int StudentID { get; set; }

        public DateTime? StartDate { get; set; }
    }
}
