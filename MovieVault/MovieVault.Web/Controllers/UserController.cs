using MovieVault.Domain;
using MovieVault.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieVault.Web.Controllers
{
    public class UserController : Controller
    {
        IUserService service = null;
        public UserController()
        {
            service = new UserService();
        }
        // GET: User
        public ActionResult Index(int id)
        {
            var user = service.GetUserById(id);
            return View(user);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            
            personne r = service.GetUserById(id);
            return View(r);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(personne m, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                service.CreateUser(m);
                //Session["User"] = m;
                return RedirectToAction("Index", "Movie", null);
            }
            catch
            {
                return View();
            }
        }
        public ActionResult ValidateUser()
        {

            personne m = Session["User"] as personne;


            return RedirectToAction("Index", "MovieController", null);

        }

        // GET: User/Edit/5
        public ActionResult Edit(int? id)
        {
            int idUser = Convert.ToInt32(Session["user_id"]);
            idUser = id.Value;
            personne p = service.GetUserById(id.Value);
            return View(p);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(personne r, FormCollection collection)
        {
            if (ModelState.IsValid)
            {
                service.UpdateUser(r);
                return RedirectToAction("Index");
            }
            return View(r);
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
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
        
        [HttpPost]
        public ActionResult CreateUser(personne m)
        {
            service.CreateUser(m);  
            //Session["User"] = m;
            return RedirectToAction("Login");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {


            try
            {
                
                string login = collection["login"];

                string password = collection["password"];
                personne u = service.AuthenticateUser(login, password);
                if (u != null && u.DTYPE=="Cineast" && u.valide==true)
                {
                    Session["user_id"] = u.id;
                    Session["firstname"] = u.nom;
                    Session["lastname"] = u.prenom;
                    Session["userEmail"] = u.mail;
                    Session["type"] = u.DTYPE;
                    Session["logedUser"] = u;

                    return RedirectToAction("Create", "Movie", null);
                }
                else if (u.DTYPE == "User" && u.valide == true)
                {
                    Session["lastname"] = u.nom;
                    Session["firstname"] = u.prenom;
                    Session["userEmail"] = u.mail;
                    Session["logedUser"] = u;
                    return RedirectToAction("Index", "Movie", null);
                }
                else
                {
                    ViewBag.LoginError = "Failed to login, please review your authentication data";
                    return View();
                }

                // TODO: Add insert logic here


            }
            catch
            {
                return View();
            }
        }

        public ActionResult Disable()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Disable(personne u)
        {
            personne user = (personne)Session["logedUser"];
            user.valide = false;
            service.UpdateUser(user);
            Session.Remove("logedUser");
            Session.Remove("user_id");
            Session.Remove("userEmail");
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Edit()
        {
            personne e = service.GetUserById((int)Session["user_id"]);
            if (e != null)
            {
                return View(e);
            }
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
        //
        // POST: /User/Edit/5
        [HttpPost]
        public ActionResult Edit(FormCollection collection)
        {
            try
            {


                personne e = service.GetUserById((int)Session["user_id"]);
                string adress = collection["adress"];
                string lastName = collection["lastName"];
                string login = collection["login"];
                string mail = collection["mail"];
                string password = collection["password"];
                string tel = collection["tel"];
                e.adress = adress;
                e.nom = lastName;
                e.login = login;
                e.mail = mail;
                e.password = password;
                e.id = (int)Session["user_id"];
                e.valide = true;


                // TODO: Add update logic here
                service.UpdateUser(e);
                Session["userEmail"] = e.mail;
                Session["logedUser"] = e;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult LogOut()
        {
            Session.Remove("logedUser");
            Session.Remove("user_id");
            Session.Remove("userEmail");
            return RedirectToAction("Index", "Movie");
        }

    }
}
