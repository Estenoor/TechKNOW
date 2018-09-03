using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechKNOW.Data;
using TechKNOW.Models.EntityModel;

namespace TechKNOW.Repositories
{
    public class RepairRepository
    {
        private readonly ApplicationDbContext _context;

        public RepairRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<RepairEntity> GetAllRepairs()
        {
            return _context.Repairs.ToList();
        }

        public void AddRepair(RepairEntity Repair)
        {
            _context.Repairs.Add(Repair);
            _context.SaveChanges();
        }

        public RepairEntity GetRepairByID(int id)
        {
            return _context.Repairs.SingleOrDefault(r => r.ID == id);
        }
    }
}
