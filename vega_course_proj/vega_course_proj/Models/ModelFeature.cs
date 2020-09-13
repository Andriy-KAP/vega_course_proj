namespace vega_course_proj.Models
{
    [Table("ModelsFeatures")]
    public class ModelFeature
    {
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
    }
}