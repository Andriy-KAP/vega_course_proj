using Microsoft.EntityFrameworkCore;

namespace vega_course_proj.Persistence
{
    public class VegaDbContext: DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            :base(options)
        {
            
        }
    }
}