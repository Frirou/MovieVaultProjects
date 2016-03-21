using System;
using System.Collections.Generic;

namespace MovieVault.Domain
{
    public partial class boxoffice
    {
        public int id { get; set; }
        public Nullable<int> id_Movie { get; set; }
        public Nullable<int> id_user { get; set; }
        public virtual personne personne { get; set; }
        public virtual moviesheet moviesheet { get; set; }
    }
}
