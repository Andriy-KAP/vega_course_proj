using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega_course_proj.Models;
using vega_course_proj.Persistence;

namespace vega_course_proj.Controllers
{
    public class MakesController: Controller
    {
        private VegaDbContext context;
        public MakesController(VegaDbContext context)
        {
            this.context = context;
        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await this.context.Makes.Include(m=>m.Models).ToListAsync();
        }
    }
}