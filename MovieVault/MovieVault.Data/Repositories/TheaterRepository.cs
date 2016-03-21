using MovieVault.Data.Infrastructure;
using MovieVault.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieVault.Data.Infrastructure
{
    public class TheaterRepository : RepositoryBase<cinematheater>, ITheaterRepository
    {
        public TheaterRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }

    }
    public interface ITheaterRepository : IRepository<cinematheater> { }

}
