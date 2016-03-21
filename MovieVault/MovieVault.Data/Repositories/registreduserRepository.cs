using MovieVault.Data.Infrastructure;
using MovieVault.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieVault.Data.Repositories
{
    public class registreduserRepository : RepositoryBase<registreduser>, IregistreduserRepository
    {
        public registreduserRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface IregistreduserRepository : IRepository<registreduser> { }
}
