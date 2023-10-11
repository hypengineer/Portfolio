using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
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
            var objAbout = _db.Abouts.FirstOrDefault();
            
            return View(objAbout);
        }
    }
}
