using Microsoft.EntityFrameworkCore;
using StudentPortal.Models.Entities;

namespace StudentPortal.Data
{
    public class AppLicationDbContext : DbContext
    {
        public AppLicationDbContext(DbContextOptions<AppLicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
