using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using WebApplication1.Models.Entities;

namespace WebApplication1.Data
{
    public class AppLicationDbContext : DbContext
    {
        public DbSet<Account> Account { get; set; }

        public DbSet<Resident> Residents { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=accounts.db");
    }
}

