using Akiya.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Akiya.Controllers
{
    public class EditController : Controller
    {

        private readonly projectnewContext _context;


        public EditController(projectnewContext context)
        {
            this._context = context;
        }
        //EDIT PAGE

        public IActionResult Index(int id)
        {
            if (HttpContext.Session.GetInt32("id") != null)
                ViewBag.Id = HttpContext.Session.GetInt32("id");

            var property = _context.Properties.Find(id);
            return View(property);
        }

        [HttpPost]
        public IActionResult Index(Property property)
        {

            property.FkUser = HttpContext.Session.GetInt32("id");
            _context.Properties.Update(property);
            _context.SaveChanges();
            return RedirectToAction("post", "home");
        }

    }
}
