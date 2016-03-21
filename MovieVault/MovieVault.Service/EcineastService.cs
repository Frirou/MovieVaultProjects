using MovieVault.Data.Infrastructure;
using MovieVault.Domain;
using MovieVault.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MovieVault.Service
{
    public class EcineastService : IEcineasteServices
    {

        DatabaseFactory dbFactory = null;
        IUnitOfWork utOfWork = null;

        public EcineastService()
        {
            dbFactory = new DatabaseFactory();
            utOfWork = new UnitOfWork(dbFactory);
        }
        public void CreateMovie(moviesheet p)
        {
            personne r = new personne();
            utOfWork.MovieRepository.Add(p);
            utOfWork.Commit();
        }

        public void UpdateMovie(moviesheet p)
        {
            utOfWork.MovieRepository.Update(p);
            utOfWork.Commit();
        }


        public IEnumerable<moviesheet> GetMovie()
        {
            var movies = utOfWork.MovieRepository.GetAll();
            return movies;
        }
        public IEnumerable<moviesheet> GetMovieByUser(int user_id)
        {
            //registreduser r = new registreduser();
            //movie m = new movie();
            //if (r.User_id == m.cineast_User_id)
            //{
                
                return utOfWork.MovieRepository.GetMany(x => x.personne.id == user_id);
                //return movies;
            //}
        }

        public moviesheet Getmovie(int movie_id)
        {

            var movie = utOfWork.MovieRepository.GetById(movie_id) as moviesheet;

            return movie;

        }


        //-------------------------------------------------------------------------// 


        //public IEnumerable<member> GetMembers()
        //{
        //    var members = utOfWork.MemberRepository.GetAll();
        //    return members;
        //}

        //public member GetMember(int member_id)
        //{
        //    var member = utOfWork.MemberRepository.GetById(member_id);
        //    return member;
        //}


        //public void CreateMember(member mb)
        //{
        //    utOfWork.MemberRepository.Add(mb);
        //    utOfWork.Commit();
        //}
        //public IEnumerable<member> GetMemberByname(string name)
        //{
        //    return utOfWork.MemberRepository.GetMany(x => x.name == name);
        //}

        //-------------------------------------------------------------------------// 


        public IEnumerable<cinematheater> GetTheaters()
        {
            var theaters = utOfWork.TheaterRepository.GetAll();
            return theaters;
        }

        public cinematheater GetTheater(int Cinema_theater_id)
        {
            var theater = utOfWork.TheaterRepository.GetById(Cinema_theater_id);
            return theater;
        }

        public IEnumerable<cinematheater> GetTheaterByaddress(string address)
        {
            return utOfWork.TheaterRepository.GetMany(x => x.address == address);
        }



       

        //------------------------------------------------------------------------//

        public void Dispose()
        {
            utOfWork.Dispose();
        }

        public void deleteMovie(moviesheet m)
        {
            utOfWork.MovieRepository.Delete(m);
            utOfWork.Commit();


        }

        //-------------------------------------------------------------------------// 

        //public void CreateForumCrew(forumcrew f)
        //{
        //    utOfWork.ForumCrewRepository.Add(f);
        //    utOfWork.Commit();
        //}

        //public forumcrew GetForumCrew(int id)
        //{
        //    var forumscrew = utOfWork.ForumCrewRepository.GetById(id);
        //    return forumscrew;
        //}

        //public IEnumerable<forumcrew> GetForumsCrew()
        //{
        //    var forumscrew = utOfWork.ForumCrewRepository.GetAll();
        //    return forumscrew;
        //}

        //public void Updateforumcrew(forumcrew f)
        //{
        //    utOfWork.ForumCrewRepository.Update(f);
        //    utOfWork.Commit();
        //}

        //public void Deleteforumcrew(forumcrew f)
        //{
        //    utOfWork.ForumCrewRepository.Delete(f);
        //    utOfWork.Commit();
        //}

        //-------------------------------------------------------------------------//


        public void CreateEvent(eventt f)
        {
            utOfWork.EventRepository.Add(f);
            utOfWork.Commit();
        }

        public IEnumerable<eventt> GetEvent()
        {
            var Event = utOfWork.EventRepository.GetAll();
            return Event;
        }
        public eventt GetEventByID(int eventid)
        {
            var Events = utOfWork.EventRepository.GetById(eventid);
            return Events;
        }

        //-------------------------------------------------------------------------//


        //public List<Statisitcs> getBeastEvalution()
        //{
        //    IEnumerable<evaluation> AllEvalution = utOfWork.EvaluationRepository.GetAll();
        //    var query = from don in AllEvalution
        //                group don by don.movie_movie_id into groupEval
        //                select new { id = groupEval.Key, avgD = groupEval.Average(d => d.note) };
        //    List<Statisitcs> ls = new List<Statisitcs>();

        //    foreach (var item in query)
        //    {
        //        Statisitcs stc = new Statisitcs();
        //        stc.avg = Math.Round(item.avgD);
        //        stc.eval = utOfWork.EvaluationRepository.GetById((int)item.id);
        //        ls.Add(stc);

        //    }
        //    return ls;
        //}



  
    }
}
