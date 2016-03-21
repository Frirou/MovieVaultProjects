using MovieVault.Domain;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MovieVault.Data.Models.Mapping
{
    public class cinematheaterMap : EntityTypeConfiguration<cinematheater>
    {
        public cinematheaterMap()
        {
            // Primary Key
            this.HasKey(t => t.id_Theater);

            // Properties
            this.Property(t => t.address)
                .HasMaxLength(255);

            this.Property(t => t.description)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("cinematheater", "cinedb");
            this.Property(t => t.id_Theater).HasColumnName("id_Theater");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.description).HasColumnName("description");
            this.Property(t => t.img).HasColumnName("img");
            this.Property(t => t.latitude).HasColumnName("latitude");
            this.Property(t => t.longitude).HasColumnName("longitude");
            this.Property(t => t.moyRate).HasColumnName("moyRate");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.nb_rate).HasColumnName("nb_rate");
            this.Property(t => t.rate).HasColumnName("rate");
            this.Property(t => t.id_admin).HasColumnName("id_admin");

            // Relationships
            this.HasOptional(t => t.personne)
                .WithMany(t => t.cinematheaters)
                .HasForeignKey(d => d.id_admin);

        }
    }
}
