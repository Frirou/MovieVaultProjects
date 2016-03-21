using System;
using System.Collections.Generic;

namespace MovieVault.Domain
{
    public partial class cinematheater
    {
        public int id_Theater { get; set; }
        public string address { get; set; }
        public string description { get; set; }
        public byte[] img { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public int moyRate { get; set; }
        public string name { get; set; }
        public int nb_rate { get; set; }
        public int rate { get; set; }
        public Nullable<int> id_admin { get; set; }
        public virtual personne personne { get; set; }
    }
}
