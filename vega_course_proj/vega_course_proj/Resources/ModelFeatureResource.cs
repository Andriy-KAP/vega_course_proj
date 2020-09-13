namespace vega_course_proj.Resources
{
    public class ModelFeatureResource
    {
        public int ModelId { get; set; }
        public ModelResource Model { get; set; }
        public int FeatureId { get; set; }
        public FeatureResource Feature { get; set; }
    }
}