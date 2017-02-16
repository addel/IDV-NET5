using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IDV_NET5_WEB.Service;
using IDV_NET5_WEB.Models;
using Microsoft.AspNetCore.Http;
using System.IO.Compression;
using Microsoft.AspNetCore.Hosting;

namespace IDV_NET5_WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserService _service;
        private readonly MovieService _serviceMovie;
        private readonly CommentService _serviceComment;
        private readonly IHostingEnvironment _appEnvironment;

        public HomeController(UserService service, MovieService serviceMovie, CommentService serviceComment, IHostingEnvironment appEnvironment)
        {
            _service = service;
            _serviceMovie = serviceMovie;
            _serviceComment = serviceComment;
            _appEnvironment = appEnvironment;
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
            var tuple = new Tuple<Movie, List<Comment>, Comment>(_serviceMovie.Get(id), _serviceComment.GetByMovie(id), new Comment());
            return View(tuple);
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

        public IActionResult PostComment(FormCollection Form)
        {
            HttpRequest r =  Request;
            string movieId = r.Form["Item3.MovieId"];
            string commentText = r.Form["Item3.Text"];

            Comment com = new Comment();
            com.MovieId = int.Parse(movieId);
            com.Text = commentText;
            com.Username = HttpContext.Session.GetString("username");
            com.DateOfPost = DateTime.Now;

            _serviceComment.Post(com);

            return RedirectToAction("Movie", new { id = movieId });
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

            int id = int.Parse(HttpContext.Session.GetString("ID"));
            _service.Update(id,user);
            ViewBag.Message = user.FirstName + " " + user.LastName + " Ok pour update";

            return RedirectToAction("Index");
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

        public ActionResult ProcessForm(string image)
        {
            var webRoot = _appEnvironment.WebRootPath;
            var zipfolder = System.IO.Path.Combine(webRoot, "zippedFiles");
            var zipfile = System.IO.Path.Combine(zipfolder, "bundle.zip");
            var imageFolder = System.IO.Path.Combine(webRoot, "images");
            var imageFile = System.IO.Path.Combine(imageFolder, image);

            if (System.IO.File.Exists(zipfile))
            {
                System.IO.File.Delete(zipfile);
            }
            
            ZipArchive zip = ZipFile.Open(zipfile, ZipArchiveMode.Create);
            zip.CreateEntryFromFile(imageFolder, image);
            zip.Dispose();

            // comprend pas pourquoi ça ne fonctionne pas !!!!
            return File(zipfile,"application/zip", "bundle.zip");
        }
    }
}
