using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MovieVault.Domain;
namespace MovieVault.Service
{
    public interface IEcineasteServices : IDisposable
    {


        //Movie
        void CreateMovie(moviesheet m);
        IEnumerable<moviesheet> GetMovie();
        moviesheet Getmovie(int id);
        void UpdateMovie(moviesheet m);
        void deleteMovie(moviesheet m);
        IEnumerable<moviesheet> GetMovieByUser(int user_id);


        //Member
        //void CreateMember(member mb);
        //member GetMember(int member_id);
        //IEnumerable<member> GetMembers();
        //IEnumerable<member> GetMemberByname(string name);

        //cinema theater


        cinematheater GetTheater(int Cinema_theater_id);
        IEnumerable<cinematheater> GetTheaters();
        IEnumerable<cinematheater> GetTheaterByaddress(string address);


        //------------------------------------------------------------------

        //void CreateForumCrew(forumcrew f);
        //forumcrew GetForumCrew(int id);
        //IEnumerable<forumcrew> GetForumsCrew();

        //void Updateforumcrew(forumcrew f);

        //void Deleteforumcrew(forumcrew f);

        //------------------------------------------------------------------

        void CreateEvent(eventt f);
        IEnumerable<eventt> GetEvent();
        eventt GetEventByID(int eventid);

        //List<Statisitcs> getBeastEvalution(); 
    }
}
