using Microsoft.EntityFrameworkCore;

namespace MVCDemoEFC.Models
{
    public class SchoolContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BCQFL9J\\SQLEXPRESS; Database=MVCDemoEFCDB; Integrated Security=True");
        }
    }
}
