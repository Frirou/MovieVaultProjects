using System;
using System.Collections.Generic;

namespace MovieVault.Domain
{
    public partial class question
    {
        public question()
        {
            this.reponses = new List<reponse>();
        }

        public int id { get; set; }
        public string question1 { get; set; }
        public Nullable<int> movquiz_idmovQuiz { get; set; }
        public virtual ICollection<reponse> reponses { get; set; }
    }
}
