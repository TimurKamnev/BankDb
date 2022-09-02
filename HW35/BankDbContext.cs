using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW35
{
    public class BankDbContext : DbContext
    {
        public DbSet<Clients> Clients { get; set; } 
        public DbSet<Employees> Employees { get; set; } 
        public DbSet<Departments> Departments { get; set; } 
        public DbSet<Managers> Managers { get; set; }
        public BankDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Server =.; Database = BankDb; Trusted_Connection = True; TrustServerCertificate = true;");
        }
    }
}
