using System;
using System.Collections.Generic;

namespace MovieVault.Domain
{
    public partial class eventt
    {
        public eventt()
        {
            this.tickets = new List<ticket>();
        }

        public int idEvent { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> begin_date { get; set; }
        public bool blocked { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public byte[] img { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public int moyRate { get; set; }
        public string name { get; set; }
        public int nbCheckIn { get; set; }
        public int nb_rate { get; set; }
        public int nbrTicket { get; set; }
        public int rate { get; set; }
        public string typeevt { get; set; }
        public Nullable<int> id_Movie { get; set; }
        public Nullable<int> personne_id { get; set; }
        public virtual personne personne { get; set; }
        public virtual moviesheet moviesheet { get; set; }
        public virtual ICollection<ticket> tickets { get; set; }
    }
}
