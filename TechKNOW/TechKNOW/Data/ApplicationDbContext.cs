using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TechKNOW.Models.EntityModel;
using TechKNOW.Models.Inventory;

namespace TechKNOW.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<RepairEntity> Repairs { get; set; }
        public DbSet<ChromebookModel> Chromebooks { get; set; }
    }
}
