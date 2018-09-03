using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechKNOW.Data;
using TechKNOW.Models.EntityModel;
using TechKNOW.Models.Inventory;
using TechKNOW.Models.Repair;
using TechKNOW.Repositories;

namespace TechKNOW.Services
{
    public class RepairService
    {
        private readonly RepairRepository _repairRepository;
        private readonly ChromebookService _chromebookService;

        private List<CreateViewModel> TempRepair = new List<CreateViewModel>
        {
            new CreateViewModel(5, "1002020", "567898765", "SF5392")
        };

        public RepairService(ApplicationDbContext context)
        {
            _repairRepository = new RepairRepository(context);
            _chromebookService = new ChromebookService(context);
        }

        public List<RepairEntity> GetAllRepairs()
        {
            return _repairRepository.GetAllRepairs();
        }

        public void AddRepair(CreateViewModel Repair)
        {
            RepairEntity NewRepair = new RepairEntity();
            NewRepair.TechnicianID = Repair.TechnicianID;
            NewRepair.StudentID = Repair.StudentID;
            NewRepair.Chromebook = _chromebookService.GetChromebookByAssetTag(Repair.AssetTag);
            NewRepair.StartDate = Repair.StartDate;

            _repairRepository.AddRepair(NewRepair);
        }

        public RepairEntity GetRepairByID(int Id)
        {
            return _repairRepository.GetRepairByID(Id);
        }
    }
}
