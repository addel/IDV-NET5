using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IDV_NET5_WEB.Service;

namespace IDV_NET5_WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly MovieService _service;

        public HomeController(MovieService service)
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

        public IActionResult Movie()
        {
            return View(_service.Get(1));
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
