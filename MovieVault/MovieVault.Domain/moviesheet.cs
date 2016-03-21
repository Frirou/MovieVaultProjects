using System;
using System.Collections.Generic;

namespace MovieVault.Domain
{
    public partial class moviesheet
    {
        public moviesheet()
        {
            this.boxoffices = new List<boxoffice>();
            this.events = new List<eventt>();
            this.moviecrews = new List<moviecrew>();
            this.moviecrews1 = new List<moviecrew>();
        }

        public int id_Movie { get; set; }
        public Nullable<System.DateTime> dateOfRelasing { get; set; }
        public string description { get; set; }
        public byte[] img { get; set; }
        public byte[] moviequiz { get; set; }
        public int moyRate { get; set; }
        public int nb_rate { get; set; }
        public int rate { get; set; }
        public string title { get; set; }
        public string trailer { get; set; }
        public string type { get; set; }
        public Nullable<int> personneId { get; set; }
        public virtual personne personne { get; set; }
        public virtual ICollection<boxoffice> boxoffices { get; set; }
        public virtual ICollection<eventt> events { get; set; }
        public virtual ICollection<moviecrew> moviecrews { get; set; }
        public virtual ICollection<moviecrew> moviecrews1 { get; set; }
    }
}
