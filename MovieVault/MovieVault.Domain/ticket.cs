using System;
using System.Collections.Generic;

namespace MovieVault.Domain
{
    public partial class ticket
    {
        public int id { get; set; }
        public Nullable<int> idEvent { get; set; }
        public Nullable<int> idUser { get; set; }
        public virtual eventt eventt { get; set; }
        public virtual personne personne { get; set; }
    }
}
