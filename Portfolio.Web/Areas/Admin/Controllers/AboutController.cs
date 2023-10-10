using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
