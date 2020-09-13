using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega_course_proj.Models;
using vega_course_proj.Persistence;
using vega_course_proj.Resources;

namespace vega_course_proj.Controllers
{
    public class MakesController : Controller
    {
        private VegaDbContext context;
        public IMapper Mapper { get; set; }
        public MakesController(VegaDbContext context, IMapper mapper)
        {
            this.Mapper = mapper;
            this.context = context;
        }
        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await this.context.Makes.Include(m => m.Models).ToListAsync();
            return this.Mapper.Map<IEnumerable<Make>, IEnumerable<MakeResource>>(makes);
        }
    }
}