using GestionEmploye.Common;
using GestionEmploye.Common.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.DataAccess
{
    public class EmployeContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { 
            optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog=GestionEmploye")
                .LogTo(Console.WriteLine, new[] 
                { 
                    DbLoggerCategory.Database.Command.Name 
                }, 
                LogLevel.Information).
                EnableSensitiveDataLogging(); 
        }

        public DbSet<Employe> Employes { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
