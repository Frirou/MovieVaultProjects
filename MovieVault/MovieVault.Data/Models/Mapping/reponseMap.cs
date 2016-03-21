using MovieVault.Domain;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MovieVault.Data.Models.Mapping
{
    public class reponseMap : EntityTypeConfiguration<reponse>
    {
        public reponseMap()
        {
            // Primary Key
            this.HasKey(t => t.id_rep);

            // Properties
            this.Property(t => t.rep_1)
                .HasMaxLength(255);

            this.Property(t => t.rep_2)
                .HasMaxLength(255);

            this.Property(t => t.rep_3)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("reponse", "cinedb");
            this.Property(t => t.id_rep).HasColumnName("id_rep");
            this.Property(t => t.rep_1).HasColumnName("rep_1");
            this.Property(t => t.rep_2).HasColumnName("rep_2");
            this.Property(t => t.rep_3).HasColumnName("rep_3");
            this.Property(t => t.question_id).HasColumnName("question_id");

            // Relationships
            this.HasOptional(t => t.question)
                .WithMany(t => t.reponses)
                .HasForeignKey(d => d.question_id);

        }
    }
}
