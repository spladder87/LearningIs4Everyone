using Microsoft.EntityFrameworkCore;
using BackEnd.Models;

namespace BackEnd.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<BackEnd.Models.Animals> Animals { get; set; }
    }
}