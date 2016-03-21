using MovieVault.Domain;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MovieVault.Data.Models.Mapping
{
    public class moviesheetMap : EntityTypeConfiguration<moviesheet>
    {
        public moviesheetMap()
        {
            // Primary Key
            this.HasKey(t => t.id_Movie);

            // Properties
            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.title)
                .HasMaxLength(255);

            this.Property(t => t.trailer)
                .HasMaxLength(255);

            this.Property(t => t.type)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("moviesheet", "cinedb");
            this.Property(t => t.id_Movie).HasColumnName("id_Movie");
            this.Property(t => t.dateOfRelasing).HasColumnName("dateOfRelasing");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.img).HasColumnName("img");
            this.Property(t => t.moviequiz).HasColumnName("moviequiz");
            this.Property(t => t.moyRate).HasColumnName("moyRate");
            this.Property(t => t.nb_rate).HasColumnName("nb_rate");
            this.Property(t => t.rate).HasColumnName("rate");
            this.Property(t => t.title).HasColumnName("title");
            this.Property(t => t.trailer).HasColumnName("trailer");
            this.Property(t => t.type).HasColumnName("type");
            this.Property(t => t.personneId).HasColumnName("personneId");

            this.HasOptional(t => t.personne)
                .WithMany(t => t.moviesheets)
                .HasForeignKey(d => d.personneId);
        }
    }
}
