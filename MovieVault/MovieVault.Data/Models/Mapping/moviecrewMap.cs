using MovieVault.Domain;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MovieVault.Data.Models.Mapping
{
    public class moviecrewMap : EntityTypeConfiguration<moviecrew>
    {
        public moviecrewMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.actors)
                .HasMaxLength(255);

            this.Property(t => t.directors)
                .HasMaxLength(255);

            this.Property(t => t.movieMaker)
                .HasMaxLength(255);

            this.Property(t => t.stars)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("moviecrew", "cinedb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.actors).HasColumnName("actors");
            this.Property(t => t.directors).HasColumnName("directors");
            this.Property(t => t.img).HasColumnName("img");
            this.Property(t => t.movieMaker).HasColumnName("movieMaker");
            this.Property(t => t.personne).HasColumnName("personne");
            this.Property(t => t.stars).HasColumnName("stars");
            this.Property(t => t.id_Movie).HasColumnName("id_Movie");

            // Relationships
            this.HasMany(t => t.moviesheets)
                .WithMany(t => t.moviecrews1)
                .Map(m =>
                    {
                        m.ToTable("moviesheet_moviecrew", "cinedb");
                        m.MapLeftKey("crew_id");
                        m.MapRightKey("MovieSheet_id_Movie");
                    });

            this.HasOptional(t => t.moviesheet)
                .WithMany(t => t.moviecrews)
                .HasForeignKey(d => d.id_Movie);

        }
    }
}
