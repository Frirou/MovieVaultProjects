
using MovieVault.Domain;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MovieVault.Data.Models.Mapping
{
    public class boxofficeMap : EntityTypeConfiguration<boxoffice>
    {
        public boxofficeMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("boxoffice", "cinedb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.id_Movie).HasColumnName("id_Movie");
            this.Property(t => t.id_user).HasColumnName("id_user");

            // Relationships
            this.HasOptional(t => t.personne)
                .WithMany(t => t.boxoffices)
                .HasForeignKey(d => d.id_user);
            this.HasOptional(t => t.moviesheet)
                .WithMany(t => t.boxoffices)
                .HasForeignKey(d => d.id_Movie);

        }
    }
}
