using Microsoft.EntityFrameworkCore;
using vega_course_proj.Models;

namespace vega_course_proj.Persistence
{
    public class VegaDbContext: DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            :base(options)
        {
            
        }
    }
}