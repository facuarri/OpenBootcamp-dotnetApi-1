using Microsoft.EntityFrameworkCore;
using openBootcamp_aspNetApi_ejercicio1.Models.DataModels;

namespace openBootcamp_aspNetApi_ejercicio1.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) { }
        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
    }
}
