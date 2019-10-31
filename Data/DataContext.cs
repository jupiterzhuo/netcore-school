using Microsoft.EntityFrameworkCore;
using SchoolApp.API.Models;

namespace SchoolApp.API.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}

        public DbSet<Student> Students { get; set; }
    
    }
}