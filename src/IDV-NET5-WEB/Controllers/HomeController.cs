using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IDV_NET5_WEB.Service;
using IDV_NET5_WEB.Models;
using Microsoft.AspNetCore.Http;
using System.IO.Compression;

namespace IDV_NET5_WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserService _service;
        private readonly MovieService _serviceMovie;

        public HomeController(UserService service, MovieService serviceMovie)
        {
            _service = service;
            _serviceMovie = serviceMovie;
        }

        public IActionResult Index(Movie movie)
        {

            return View(_serviceMovie.GetAll());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

         public IActionResult Movie(int id)
        {
         return View(_serviceMovie.Get(id));
        }

        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _service.Register(user);
                ModelState.Clear();
                ViewBag.Message = user.FirstName + " " + user.LastName + "Ok pour registratiion";
            }

            return View();
        }

        public IActionResult Login (User user)
        {
            var account = _service.Login(user);
            if(account != null)
            {
                HttpContext.Session.SetString("ID", account.Id.ToString());
                HttpContext.Session.SetString("username", account.UserName.ToString());
                return RedirectToAction("Welcome");
            }
            else
            {
                ModelState.AddModelError("", "something turn wrong, please check you IDs");
            }

            return View();
        }

        public IActionResult Welcome()
        {
            if(HttpContext.Session.GetString("ID") != null)
            {
                List<User> user = _service.List();
                ViewBag.Username = HttpContext.Session.GetString("username");
                return View(user);
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult Account()
        {
            int id = int.Parse(HttpContext.Session.GetString("ID"));
           User user =  _service.GetSingle(id);

            return View(user);
        }

        public IActionResult AccountPatch(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            _service.Update(user);
            ViewBag.Message = user.FirstName + " " + user.LastName + "Ok pour update";

            return View();
        }

        

        public IActionResult DeleteUser()
        {
            int id = int.Parse(HttpContext.Session.GetString("ID"));
            _service.deleteUser((int)id);
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
