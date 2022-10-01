using Akiya.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Akiya.Controllers
{
    public class HomeController : Controller
    {
     
      private readonly projectnewContext _context;
    
    
        public HomeController(projectnewContext context)
        {
            this._context = context;
        }

        //INDEX PAGE
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("id") != null)
                ViewBag.Id = HttpContext.Session.GetInt32("id");
            
            return View();
        }

        //LOGIN
        [HttpPost]
        public IActionResult Index(User ur)
        {
            ViewBag.login = HttpContext.Session.GetString("login");
            HttpContext.Session.SetString("login", "true");

            var user = _context.Users.Where(temp => temp.Email == ur.Email && temp.Password == ur.Password).FirstOrDefault();
            if (user != null)
                HttpContext.Session.SetInt32("id", user.UserId);
            else
                HttpContext.Session.SetString("login", "false");

            return RedirectToAction("index");
      
        }

        //DELETE PAGE
        public IActionResult Delete(int id)
        {
            if (HttpContext.Session.GetInt32("id") != null)
                ViewBag.Id = HttpContext.Session.GetInt32("id");

            var property = _context.Properties.Find(id);
            _context.Properties.Remove(property);
            _context.SaveChanges();
            return RedirectToAction("post","home");
        }


        //SIGNUP CONTROLLER
        [HttpPost]
        public IActionResult signup(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        
        //SEARCH
        [HttpPost]
        public IActionResult Search(string search)
        {
            if (HttpContext.Session.GetInt32("id") != null)
                ViewBag.Id = HttpContext.Session.GetInt32("id");
            var property = _context.Properties.Where(temp => temp.Descr == search || temp.Purpose == search || temp.PropType == search).ToList();
           
            return View(property);

            
        }

        //POST
        public IActionResult Post()
        {
            if (HttpContext.Session.GetInt32("id") != null)
                ViewBag.Id = HttpContext.Session.GetInt32("id");

            var id = HttpContext.Session.GetInt32("id");
            var property = _context.Properties.Where(temp => temp.FkUser == id).ToList();
            return View(property);
           
        }

       //SIGNOUT
        public IActionResult Signout()
        {
            HttpContext.Session.SetString("login", "false");
            HttpContext.Session.SetInt32("id", 0);
            return RedirectToAction("index");
        }

       

       
    }
}
