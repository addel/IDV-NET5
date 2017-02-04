using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IDV_NET5_WEB.Service;
using IDV_NET5_WEB.Models;
using Microsoft.AspNetCore.Http;

namespace IDV_NET5_WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserService _service;

        public HomeController(UserService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
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

        // public IActionResult Movie()
        //{
        // return View(_service.Get(1));
        //}

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
                HttpContext.Session.SetString("ID", user.Id.ToString());
                HttpContext.Session.SetString("username", user.UserName.ToString());
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





        public IActionResult Error()
        {
            return View();
        }
    }
}
