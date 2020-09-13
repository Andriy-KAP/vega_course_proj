using Microsoft.EntityFrameworkCore;
using vega_course_proj.Models;

namespace vega_course_proj.Persistence
{
    public class VegaDbContext: DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Feature> Feature { get; set; }
        public DbSet<ModelFeature> ModelsFeatures { get; set; }
        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Feature>().ToTable<Feature>("Feature");

            builder.Entity<ModelFeature>()
                .HasKey(mf => new { mf.FeatureId, mf.ModelId });

            builder.Entity<ModelFeature>()
                .HasOne(mf => mf.Model)
                .WithMany(m=>m.ModelFeatures)
                .HasForeignKey(mf=>mf.ModelId);

            builder.Entity<ModelFeature>()
                .HasOne(mf => mf.Feature)
                .WithMany(f=>f.ModelFeature)
                .HasForeignKey(mf=>mf.FeatureId);

            base.OnModelCreating(builder);
        }
    }
}