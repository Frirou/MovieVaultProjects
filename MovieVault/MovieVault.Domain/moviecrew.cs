using System;
using System.Collections.Generic;

namespace MovieVault.Domain
{
    public partial class moviecrew
    {
        public moviecrew()
        {
            this.moviesheets = new List<moviesheet>();
        }

        public int id { get; set; }
        public string actors { get; set; }
        public string directors { get; set; }
        public byte[] img { get; set; }
        public string movieMaker { get; set; }
        public byte[] personne { get; set; }
        public string stars { get; set; }
        public Nullable<int> id_Movie { get; set; }
        public virtual moviesheet moviesheet { get; set; }
        public virtual ICollection<moviesheet> moviesheets { get; set; }
    }
}
