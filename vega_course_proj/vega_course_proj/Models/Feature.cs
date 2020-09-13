using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace vega_course_proj.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<ModelFeature> ModelFeature { get; set; }

        public Feature()
        {
            ModelFeature= new Collection<ModelFeature>();
        }
    }
}