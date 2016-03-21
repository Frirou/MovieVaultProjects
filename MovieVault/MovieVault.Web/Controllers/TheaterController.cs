using MovieVault.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieVault.Web.Controllers
{
    public class TheaterController : Controller
    {
        IEcineasteServices theater = null;
        public TheaterController()
        {
            theater = new EcineastService();
        }



        [HttpPost]
        public ActionResult Index(string address)
        {
            var theaters = theater.GetTheaterByaddress(address);
            return View(theaters);

        }
      public ActionResult SeePosition( int id)
        {
             var theaters = theater.GetTheater(id);
         return View(theaters);

        }

        //
        // GET: /Theater/
        public ActionResult Index()
        {
            var theaters = theater.GetTheaters();
            return View(theaters);
        }

        //
        // GET: /Theater/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Theater/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Theater/Create
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

        //
        // GET: /Theater/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Theater/Edit/5
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

        //
        // GET: /Theater/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Theater/Delete/5
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
    }
}
