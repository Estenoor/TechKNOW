using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechKNOW.Data;
using TechKNOW.Models.EntityModel;
using TechKNOW.Models.Repair;
using TechKNOW.Services;

namespace TechKNOW.Controllers
{
    public class RepairController : Controller
    {
        private readonly RepairService _repairService;

        public RepairController(ApplicationDbContext context)
        {
            _repairService = new RepairService(context);
        }

        public IActionResult Index()
        {
            List<RepairEntity> Model = _repairService.GetAllRepairs();
            return View(Model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateViewModel Repair)
        {
            Repair.ID = 2;
            Repair.StartDate = DateTime.Now;

            _repairService.AddRepair(Repair);

            return RedirectToAction("Index");
        }
    }
}