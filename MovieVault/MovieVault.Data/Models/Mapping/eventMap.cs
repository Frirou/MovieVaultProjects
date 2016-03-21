using MovieVault.Domain;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MovieVault.Data.Models.Mapping
{
    public class eventMap : EntityTypeConfiguration<eventt>
    {
        public eventMap()
        {
            // Primary Key
            this.HasKey(t => t.idEvent);

            // Properties
            this.Property(t => t.address)
                .HasMaxLength(255);

            this.Property(t => t.name)
                .HasMaxLength(255);

            this.Property(t => t.typeevt)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("event", "cinedb");
            this.Property(t => t.idEvent).HasColumnName("idEvent");
            this.Property(t => t.address).HasColumnName("address");
            this.Property(t => t.begin_date).HasColumnName("begin_date");
            this.Property(t => t.blocked).HasColumnName("blocked");
            this.Property(t => t.end_date).HasColumnName("end_date");
            this.Property(t => t.img).HasColumnName("img");
            this.Property(t => t.latitude).HasColumnName("latitude");
            this.Property(t => t.longitude).HasColumnName("longitude");
            this.Property(t => t.moyRate).HasColumnName("moyRate");
            this.Property(t => t.name).HasColumnName("name");
            this.Property(t => t.nbCheckIn).HasColumnName("nbCheckIn");
            this.Property(t => t.nb_rate).HasColumnName("nb_rate");
            this.Property(t => t.nbrTicket).HasColumnName("nbrTicket");
            this.Property(t => t.rate).HasColumnName("rate");
            this.Property(t => t.typeevt).HasColumnName("typeevt");
            this.Property(t => t.id_Movie).HasColumnName("id_Movie");
            this.Property(t => t.personne_id).HasColumnName("personne_id");

            // Relationships
            this.HasOptional(t => t.personne)
                .WithMany(t => t.events)
                .HasForeignKey(d => d.personne_id);
            this.HasOptional(t => t.moviesheet)
                .WithMany(t => t.events)
                .HasForeignKey(d => d.id_Movie);

        }
    }
}
