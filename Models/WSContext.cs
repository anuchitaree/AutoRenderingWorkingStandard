using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRenderingWorkingStandard.Models
{
    public class WSContext :DbContext 
    {


        public WSContext() :base(nameOrConnectionString: "Default")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<WorkingStandard> WorkingStandards { get; set; }

    }
}
