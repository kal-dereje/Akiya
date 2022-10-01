using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Akiya.Models;
using System.Linq;

namespace Akiya.Controllers
{
    public class BuyController : Controller
    {
        private readonly projectnewContext _context;


        public BuyController(projectnewContext context)
        {
            this._context = context;
        }

        //BUY PAGE
        public IActionResult index()
        {
            if (HttpContext.Session.GetInt32("id") != null)
                ViewBag.Id = HttpContext.Session.GetInt32("id");

            var property = _context.Properties.ToList();
            return View(property);
        }

    }
}
