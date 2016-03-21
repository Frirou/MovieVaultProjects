using MovieVault.Domain;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MovieVault.Data.Models.Mapping
{
    public class ticketMap : EntityTypeConfiguration<ticket>
    {
        public ticketMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            // Table & Column Mappings
            this.ToTable("ticket", "cinedb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.idEvent).HasColumnName("idEvent");
            this.Property(t => t.idUser).HasColumnName("idUser");

            // Relationships
            //this.HasOptional(t => t.eventt)
            //    .WithMany(t => t.tickets)
            //    .HasForeignKey(d => d.idEvent);
            this.HasOptional(t => t.personne)
                .WithMany(t => t.tickets)
                .HasForeignKey(d => d.idUser);

        }
    }
}
