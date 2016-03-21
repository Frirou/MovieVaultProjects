using System;
using System.Collections.Generic;

namespace MovieVault.Domain
{
    public partial class personne
    {
        public personne()
        {
            this.boxoffices = new List<boxoffice>();
            this.cinematheaters = new List<cinematheater>();
            this.events = new List<eventt>();
            this.tickets = new List<ticket>();
        }

        public string DTYPE { get; set; }
        public int id { get; set; }
        public string adress { get; set; }
        public string etat_civile { get; set; }
        public byte[] img { get; set; }
        public string login { get; set; }
        public string mail { get; set; }
        public string nom { get; set; }
        public string password { get; set; }
        public int phone { get; set; }
        public string prenom { get; set; }
        public Nullable<bool> valide { get; set; }
        public virtual ICollection<moviesheet> moviesheets { get; set; }
        public virtual ICollection<boxoffice> boxoffices { get; set; }
        public virtual ICollection<cinematheater> cinematheaters { get; set; }
        public virtual ICollection<eventt> events { get; set; }
        public virtual ICollection<ticket> tickets { get; set; }
    }
}
