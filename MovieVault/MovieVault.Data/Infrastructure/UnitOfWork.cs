using MovieVault.Data.Models;
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
    public class UnitOfWork : IUnitOfWork
    {
        private cinedbContext dataContext;
        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        private IUserRepository userRepository;
        public IUserRepository UserRepository
        {
            get { return userRepository = new UserRepository(dbFactory); }
        }
        private IMovieRepository movieRepository;
        public IMovieRepository MovieRepository
        {
            get { return movieRepository = new MovieRepository(dbFactory); }
        }
        

        private ITheaterRepository theaterRepository;
        public ITheaterRepository TheaterRepository
        {
            get { return theaterRepository = new TheaterRepository(dbFactory); }
        }

        private IEventRepository eventRepository;
        public IEventRepository EventRepository
        {
            get { return eventRepository = new EventRepository(dbFactory); }
        }
        
        protected cinedbContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }
        public void Dispose()
        {
            dbFactory.Dispose();
        }
    }
}
