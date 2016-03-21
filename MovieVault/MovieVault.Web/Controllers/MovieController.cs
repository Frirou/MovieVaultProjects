using MovieVault.Domain;
using MovieVault.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MovieVault.Web.Controllers
{
    public class MovieController : Controller
    {


        IEcineasteServices service = null;
        IUserService serviceu = null;
        personne reg = null;
        public MovieController()
        {

            service = new EcineastService();
            serviceu = new UserService();
            reg = new personne();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                service.Dispose();
            }
            base.Dispose(disposing);
        }




        //
        // GET: /Movie/
        public ActionResult Index()
        {
            var movies = serviceu.GetMovies();
            return View(movies);


        }

        //
        // GET: /Movie/Details/5
        public ActionResult Details(int id)
        {
            //int idmovie = Convert.ToInt32(Session["movie_id"]);
            //movie m = Session["Movie"] as movie;   
            moviesheet movie = service.Getmovie(id);
            
            return View(movie);
        }

        //
        // GET: /Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Movie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }



        public ActionResult EditMovie(int id)
        {
            moviesheet m = service.Getmovie(id);

            return View(m);
        }

        //
        // POST: /Project/Edit/5
        [HttpPost]
        public ActionResult EditMovie(moviesheet m, HttpPostedFileBase imagep, HttpPostedFileBase video, HttpPostedFileBase sound_track)
        {
            if (imagep.ContentLength > 0 && video.ContentLength > 0 && sound_track.ContentLength > 0)
            {
                //m.imagep = imagep.FileName;
                //var path = Path.Combine(Server.MapPath("~/Content/Upload"), m.imagep);
                //imagep.SaveAs(path);

                m.trailer = video.FileName;
                var path1 = Path.Combine(Server.MapPath("~/Content/Videos"), m.trailer);
                video.SaveAs(path1);
                
               

                

                service.UpdateMovie(m);
            }
            return RedirectToAction("Index");

        }

        //
        // POST: /Movie/Edit/5



        //
        // GET: /Movie/Delete/5
        public ActionResult Delete(int id)
        {
            moviesheet m = service.Getmovie(id);
            service.deleteMovie(m);
            return RedirectToAction("Index");
        }

        //
        // POST: /Movie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreateMovie()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateMovie(moviesheet m, HttpPostedFileBase imagep, HttpPostedFileBase video, HttpPostedFileBase sound_track)
        {

            
                if (!ModelState.IsValid)
                {
                    return CreateMovie();
                }
                int idUser = Convert.ToInt32(Session["user_id"]);
                m.personne.id = idUser;    
                Session["Movie"] = m;
                Session["movie_id"] = m.id_Movie;

                //TempData["files"] = imagep;
                //m.img = imagep.FileName;

                //TempData["fileVideo"] = video;
                //m.video = video.FileName;

                //TempData["fileAudio"] = sound_track;
                //m.sound_track = sound_track.FileName;
                //service.CreateMovie(m);
                return RedirectToAction("ValidateMovie");
            
        }

        public ActionResult ValidateMovie(bool? insertion)
        {


            moviesheet m = Session["Movie"] as moviesheet;
            //DateTime now = DateTime.Now;
            //m.compilation_date = now;
            service.CreateMovie(m);
             return RedirectToAction("Index");

            //if (insertion == true)
            //{
            //    HttpPostedFileBase file = TempData["files"] as HttpPostedFileBase;

            //    HttpPostedFileBase videofile = TempData["fileVideo"] as HttpPostedFileBase;

            //    HttpPostedFileBase audiofile = TempData["fileAudio"] as HttpPostedFileBase;


            //    if (file.ContentLength > 0 && videofile.ContentLength > 0 && audiofile.ContentLength > 0)
            //    {
            //        //var path = Path.Combine(Server.MapPath(""), m.imagep);
            //        //file.SaveAs(path);

            //        //var path2 = Path.Combine(Server.MapPath(""), m.video);
            //        //videofile.SaveAs(path2);
            //        //var file1 = new FileInfo(path2);
            //        //if (file1.Exists)
            //        //{
            //        //    var stream = file1.OpenRead();
            //        //    var bytesinfile = new byte[stream.Length];
            //        //    stream.Read(bytesinfile, 0, (int)file1.Length);
            //        //    HttpContext.Response.BinaryWrite(bytesinfile);
            //        //} 

            //        //var path3 = Path.Combine(Server.MapPath(""), m.sound_track);
            //        //audiofile.SaveAs(path3);

            //        service.CreateMovie(m);
            //    }
            //    return RedirectToAction("Index");
            //}
            //else
            //{
            //    return View(m);
            //}
        }

        public ActionResult ShowCineastMovie(moviesheet m)
        {
            int idUser = Convert.ToInt32(Session["user_id"]);
            var movies = service.GetMovieByUser(idUser);
            return View(movies);
        }


    }
}
