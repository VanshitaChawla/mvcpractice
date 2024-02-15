using Microsoft.EntityFrameworkCore;
using mvctraing.Models;

namespace mvctraing.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
