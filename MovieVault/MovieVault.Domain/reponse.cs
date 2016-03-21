using System;
using System.Collections.Generic;

namespace MovieVault.Domain
{
    public partial class reponse
    {
        public int id_rep { get; set; }
        public string rep_1 { get; set; }
        public string rep_2 { get; set; }
        public string rep_3 { get; set; }
        public Nullable<int> question_id { get; set; }
        public virtual question question { get; set; }
    }
}
