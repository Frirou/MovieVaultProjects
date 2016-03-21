using MovieVault.Data.Models.Mapping;
using MovieVault.Domain;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace MovieVault.Data.Models
{
    public partial class cinedbContext : DbContext
    {
        static cinedbContext()
        {
            Database.SetInitializer<cinedbContext>(null);
        }

        public cinedbContext()
            : base("Name=cinedbContext")
        {
        }

        public DbSet<boxoffice> boxoffices { get; set; }
        public DbSet<cinematheater> cinematheaters { get; set; }
        public DbSet<eventt> events { get; set; }
        public DbSet<moviecrew> moviecrews { get; set; }
        public DbSet<moviesheet> moviesheets { get; set; }
        public DbSet<personne> personnes { get; set; }
        public DbSet<question> questions { get; set; }
      
        public DbSet<reponse> reponses { get; set; }
        public DbSet<ticket> tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new boxofficeMap());
            modelBuilder.Configurations.Add(new cinematheaterMap());
            modelBuilder.Configurations.Add(new eventMap());
            modelBuilder.Configurations.Add(new moviecrewMap());
            modelBuilder.Configurations.Add(new moviesheetMap());
            modelBuilder.Configurations.Add(new personneMap());
            modelBuilder.Configurations.Add(new questionMap());
            modelBuilder.Configurations.Add(new reponseMap());
            modelBuilder.Configurations.Add(new ticketMap());
        }
    }
}
