using System;
using System.Collections.Generic;

namespace MovieVault.Domain.Entities
{
    public partial class boxoffice
    {
        public boxoffice()
        {
            this.movies = new List<movie>();
        }

        public int idBox { get; set; }
        public string date { get; set; }
        public int ordre { get; set; }
        public virtual ICollection<movie> movies { get; set; }
    }
}
