using MovieVault.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieVault.Data.Configurations
{
    public class t_userConfiguration : ComplexTypeConfiguration<registreduser>
    {
        public t_userConfiguration()
        {
            Property(p => p.login).IsRequired();
            Property(p => p.password).IsRequired();
            //Property(p => p.firstname).HasMaxLength(50);
            //Property(p => p.lastname).HasMaxLength(50);
        }
    }
}
