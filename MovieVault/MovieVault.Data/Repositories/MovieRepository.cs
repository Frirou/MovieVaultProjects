using MovieVault.Data.Infrastructure;
using MovieVault.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieVault.Data.Repositories
{
    class MovieRepository : RepositoryBase<moviesheet>, IMovieRepository
    {
        public MovieRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface IMovieRepository : IRepository<moviesheet> { }
    
}
