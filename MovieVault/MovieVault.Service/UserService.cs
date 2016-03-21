using MovieVault.Data.Infrastructure;
using MovieVault.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieVault.Service
{
    public class UserService : IUserService
    {
        DatabaseFactory dbFactory = null;
        IUnitOfWork utOfWork = null;
        public UserService()
        {
            dbFactory = new DatabaseFactory();
            utOfWork = new UnitOfWork(dbFactory);
        }
        public List<personne> getUsers()
        {
            return utOfWork.UserRepository.GetAll().ToList();
        }
        public void CreateUser(personne c)
        {
            utOfWork.UserRepository.Add(c);
            utOfWork.Commit();
        }
        //public registreduser GetUser(int User_id)
        //{
        //    var user = utOfWork.UserRepository.GetById(User_id);
        //    return user;
        //}
        public IEnumerable<personne> GetUserLogID(int User_id)
        {
            var ok = utOfWork.UserRepository.GetMany(p => p.id == User_id);
            return ok;
        }
        public void UpdateUser(personne c)
        {
            utOfWork.UserRepository.Update(c);
            utOfWork.Commit();

        }
        public personne GetUserById(int User_id)
        {
            return utOfWork.UserRepository.GetById(User_id);
        }



        public IEnumerable<moviesheet> GetMovies()
        {
            var movies = utOfWork.MovieRepository.GetAll();
            return movies;
        }
        public personne AuthenticateUser(String login, String password)
        {
            return utOfWork.UserRepository.Get(u => u.login == login && u.password == password);

        }

        
        public void Dispose()
        {
            utOfWork.Dispose();
        }
    }
    
}
