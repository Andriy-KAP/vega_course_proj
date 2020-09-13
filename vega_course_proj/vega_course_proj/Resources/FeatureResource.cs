using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vega_course_proj.Resources
{
    public class FeatureResource
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ModelFeatureResource> ModelFeature { get; set; }

        public FeatureResource()
        {
            ModelFeature= new Collection<ModelFeatureResource>();
        }
    }
}