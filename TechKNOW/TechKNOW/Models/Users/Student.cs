using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechKNOW.Models.EntityModel;

namespace TechKNOW.Models.Users
{
    public class Student
    {
        public int ID { get; set; }

        public string StudentID { get; set; }

        public List<RepairEntity> Repairs { get; set; }
    }
}
