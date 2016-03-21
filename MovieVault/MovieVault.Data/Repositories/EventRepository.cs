using MovieVault.Data.Infrastructure;
using MovieVault.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieVault.Data.Repositories
{
    public class EventRepository : RepositoryBase<eventt>, IEventRepository
    {
        public EventRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {
        }

    }

    public interface IEventRepository : IRepository<eventt> { }
}
