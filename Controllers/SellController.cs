using Akiya.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Akiya.Controllers
{
    public class SellController : Controller
    {

        private readonly projectnewContext _context;


        public SellController(projectnewContext context)
        {
            this._context = context;
        }
        //SELL PAGE

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("id") != null)
                ViewBag.Id = HttpContext.Session.GetInt32("id");
            return View();
        }

        [HttpPost]
        public IActionResult Index(Property pro)
        {
            pro.FkUser = HttpContext.Session.GetInt32("id");
            if (pro.FkUser != null || pro.FkUser > 0)
            {
                _context.Properties.Add(pro);
                _context.SaveChanges();
            }


          
            return RedirectToAction("index");
        }

    }
}
