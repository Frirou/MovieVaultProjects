using MovieVault.Data.Infrastructure;

using MovieVault.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieVault.Repositories
{
    public class UserRepository : RepositoryBase<personne>, IUserRepository
    {
        public UserRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface IUserRepository : IRepository<personne> { }
}
