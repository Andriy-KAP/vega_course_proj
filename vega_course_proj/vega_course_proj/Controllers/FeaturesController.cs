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
    public class FeaturesController
    {
        private VegaDbContext context;
        private IMapper mapper;
        public FeaturesController(VegaDbContext  context, IMapper mapper)
        {
            this.context=context;
            this.mapper=mapper;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features = await this.context.Feature.ToListAsync();
            return this.mapper.Map<IEnumerable<Feature>, IEnumerable<FeatureResource>>(features); 
        }
    }
}