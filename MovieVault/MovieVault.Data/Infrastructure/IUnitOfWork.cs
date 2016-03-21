using MovieVault.Data.Repositories;
using MovieVault.Repositories;
//using MovieVault.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieVault.Data.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
        IUserRepository UserRepository { get; }
        IMovieRepository MovieRepository { get; }
        ITheaterRepository TheaterRepository { get; }

        
      
        IEventRepository EventRepository { get; }
    }
}
