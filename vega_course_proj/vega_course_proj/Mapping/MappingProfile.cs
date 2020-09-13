using AutoMapper;
using vega_course_proj.Models;
using vega_course_proj.Resources;

namespace vega_course_proj.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
            CreateMap<ModelFeature, ModelFeatureResource>();
        }
    }
}