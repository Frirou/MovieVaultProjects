using MovieVault.Data.Infrastructure;
using MovieVault.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieVault.Data.Repositories
{
    public class moviesheetRepository : RepositoryBase<movie>, ImoviesheetRepository
    {
        public moviesheetRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }
    }
    public interface ImoviesheetRepository : IRepository<movie> { }
}
