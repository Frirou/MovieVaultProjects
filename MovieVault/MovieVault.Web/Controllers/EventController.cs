using MovieVault.Domain;
using MovieVault.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieVault.Web.Controllers
{
    public class EventController : Controller
    {
        IEcineasteServices service = null;
        public EventController ()
        {
            service = new EcineastService();
        }
        // GET: Event
        public ActionResult Index()
        {
             var events = service.GetEvent();
             return View(events);
        }

        // GET: Event/Details/5
        public ActionResult Details(int id)
        {
            eventt m = Session["Event"] as eventt;
            return View(m);
        }

        // GET: Event/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Event/Create
        [HttpPost]
        public ActionResult Create(eventt m)
        {


           
            int idMovie = Convert.ToInt32(Session["movie_id"]);
            m.id_Movie = idMovie;
            
            Session["eventt"] = m;

            service.CreateEvent(m);
            //service.CreateMovie(m);
            return RedirectToAction("index","Movie");

        }

        public ActionResult ValidateMovie(bool? insertion)
        {


            eventt m = Session["eventt"] as eventt;
            //DateTime now = DateTime.Now;
            //m.compilation_date = now;


            if (insertion == true)
            {


                service.CreateEvent(m);
                
                return RedirectToAction("Index");
            }
            else
            {
                return View(m);
            }
        }

        // GET: Event/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Event/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Event/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Event/Delete/5
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
        public ActionResult SeePosition(int id)
        {
            var events = service.GetEventByID(id);
            return View(events);

        }
    }
}
