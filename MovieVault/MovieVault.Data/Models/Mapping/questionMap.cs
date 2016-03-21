using MovieVault.Domain;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace MovieVault.Data.Models.Mapping
{
    public class questionMap : EntityTypeConfiguration<question>
    {
        public questionMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.question1)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("question", "cinedb");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.question1).HasColumnName("question");
            this.Property(t => t.movquiz_idmovQuiz).HasColumnName("movquiz_idmovQuiz");

            // Relationships
         

        }
    }
}
