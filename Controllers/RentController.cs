using Akiya.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Akiya.Controllers
{
    public class RentController : Controller
    {

        private readonly projectnewContext _context;


        public RentController(projectnewContext context)
        {
            this._context = context;
        }

        //RENT PAGE
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("id") != null)
                ViewBag.Id = HttpContext.Session.GetInt32("id");

            var property = _context.Properties.Where(temp => temp.Purpose == "rent").ToList();
            return View(property);
        }

    }
}
