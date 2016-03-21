using MovieVault.Domain;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MovieVault.Data.Models.Mapping
{
    public class personneMap : EntityTypeConfiguration<personne>
    {
        public personneMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.DTYPE)
                .IsRequired()
                .HasMaxLength(31);

            this.Property(t => t.adress)
                .HasMaxLength(255);

            this.Property(t => t.etat_civile)
                .HasMaxLength(255);

            this.Property(t => t.login)
                .HasMaxLength(255);

            this.Property(t => t.mail)
                .HasMaxLength(255);

            this.Property(t => t.nom)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.prenom)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("personne", "cinedb");
            this.Property(t => t.DTYPE).HasColumnName("DTYPE");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.adress).HasColumnName("adress");
            this.Property(t => t.etat_civile).HasColumnName("etat_civile");
            this.Property(t => t.img).HasColumnName("img");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.mail).HasColumnName("mail");
            this.Property(t => t.nom).HasColumnName("nom");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.phone).HasColumnName("phone");
            this.Property(t => t.prenom).HasColumnName("prenom");
            this.Property(t => t.valide).HasColumnName("valide");
            
        }
    }
}
