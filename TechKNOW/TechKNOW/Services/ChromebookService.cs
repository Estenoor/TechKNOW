using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechKNOW.Data;
using TechKNOW.Models.Inventory;
using TechKNOW.Repositories;

namespace TechKNOW.Services
{
    public class ChromebookService
    {
        private readonly ChromebookRepository _chromebookRepository;

        public ChromebookService(ApplicationDbContext context)
        {
            _chromebookRepository = new ChromebookRepository(context);
        }

        public List<ChromebookModel> GetAllChromebooks()
        {
            return _chromebookRepository.GetAllChromebooks();
        }

        public ChromebookModel GetChromebookByAssetTag(string AssetTag)
        {
            return _chromebookRepository.GetChromebookByAssetTag(AssetTag);
        }

        public ChromebookModel GetChromebookBySerialNumber(string SerialNumber)
        {
            return _chromebookRepository.GetChromebookBySerialNumber(SerialNumber);
        }
    }
}
