using Microsoft.EntityFrameworkCore.Migrations;

namespace vega_course_proj.Migrations
{
    public partial class SeedingFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature1')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature2')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature3')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature4')");
            migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature5')");

            //Make1 models
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make1-ModelA'),(SELECT Id FROM Features WHERE Name='Feature1'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make1-ModelB'),(SELECT Id FROM Features WHERE Name='Feature1'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make1-ModelC'),(SELECT Id FROM Features WHERE Name='Feature1'))");

            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make1-ModelA'),(SELECT Id FROM Features WHERE Name='Feature2'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make1-ModelB'),(SELECT Id FROM Features WHERE Name='Feature2'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make1-ModelC'),(SELECT Id FROM Features WHERE Name='Feature2'))");

            //Make2 models
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make2-ModelA'),(SELECT Id FROM Features WHERE Name='Feature1'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make2-ModelB'),(SELECT Id FROM Features WHERE Name='Feature1'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make2-ModelC'),(SELECT Id FROM Features WHERE Name='Feature1'))");

            //Make3 models
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make3-ModelA'),(SELECT Id FROM Features WHERE Name='Feature2'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make3-ModelB'),(SELECT Id FROM Features WHERE Name='Feature2'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make3-ModelC'),(SELECT Id FROM Features WHERE Name='Feature2'))");
        
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make3-ModelA'),(SELECT Id FROM Features WHERE Name='Feature3'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make3-ModelB'),(SELECT Id FROM Features WHERE Name='Feature3'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make3-ModelC'),(SELECT Id FROM Features WHERE Name='Feature3'))");

            
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make3-ModelA'),(SELECT Id FROM Features WHERE Name='Feature4'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make3-ModelB'),(SELECT Id FROM Features WHERE Name='Feature4'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make3-ModelC'),(SELECT Id FROM Features WHERE Name='Feature4'))");

            
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make3-ModelA'),(SELECT Id FROM Features WHERE Name='Feature5'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make3-ModelB'),(SELECT Id FROM Features WHERE Name='Feature5'))");
            migrationBuilder.Sql("INSERT INTO ModelsFeatures (ModelId,FeatureId) VALUES ((SELECT Id FROM Models WHERE Name='Make3-ModelC'),(SELECT Id FROM Features WHERE Name='Feature5'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Features");
            migrationBuilder.Sql("DELETE FROM ModelsFeatures");
        }
    }
}
