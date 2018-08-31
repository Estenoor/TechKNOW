using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechKNOW.Data;
using TechKNOW.Models.EntityModel;
using TechKNOW.Models.Repair;
using TechKNOW.Repositories;

namespace TechKNOW.Services
{
    public class RepairService
    {
        private readonly RepairRepository _repairRepository;

        private List<CreateViewModel> TempRepair = new List<CreateViewModel>
        {
            new CreateViewModel(5, "1002020", "567898765", "SF5392")
        };

        public RepairService(ApplicationDbContext context)
        {
            _repairRepository = new RepairRepository(context);
        }

        public List<CreateViewModel> GetAllRepairs()
        {
            return TempRepair;
        }

        public void AddRepair(CreateViewModel Repair)
        {
            TempRepair.Add(Repair);
        }

           
    }
}
