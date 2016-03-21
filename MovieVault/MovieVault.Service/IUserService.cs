using MovieVault.Data.Models;
using MovieVault.Domain;
using System;
using System.Collections.Generic;
namespace MovieVault.Service
{
    public interface IUserService : IDisposable
    {
        void CreateUser(personne c);
        System.Collections.Generic.List<personne> getUsers();
        //registreduser GetUser(int User_id);
        //IEnumerable<registreduser> GetUsers();
        IEnumerable<personne> GetUserLogID(int User_id);


        IEnumerable<moviesheet> GetMovies();


        personne AuthenticateUser(String login, String password);
        void UpdateUser(personne c);
        personne GetUserById(int User_id);
    }
}
