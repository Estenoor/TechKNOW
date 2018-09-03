using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechKNOW.Data;
using TechKNOW.Models.Inventory;

namespace TechKNOW.Repositories
{
    public class ChromebookRepository
    {
        private readonly ApplicationDbContext _context;

        public ChromebookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ChromebookModel> GetAllChromebooks()
        {
            return _context.Chromebooks.ToList();
        }

        public ChromebookModel GetChromebookByAssetTag(String AssetTag)
        {
            return _context.Chromebooks.SingleOrDefault(c => c.AssetTag == AssetTag);
        }

        public ChromebookModel GetChromebookBySerialNumber(String SerialNumber)
        {
            return _context.Chromebooks.SingleOrDefault(c => c.SerialNumber == SerialNumber);
        }
    }
}
