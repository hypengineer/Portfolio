using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using Portfolio.Models;
using Portfolio.Web.ViewComponents;

namespace Portfolio.Web.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AboutController(ApplicationDbContext db)
        {
           _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<AboutModel> objAbout = _db.Abouts.ToList();
            
            return View(objAbout);
        }

        public IActionResult Edit(int id)
        {
            if (ModelState.IsValid)
            {
                AboutModel? objAbout = _db.Abouts.Find(id);
                _db.Abouts.Update(objAbout);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
