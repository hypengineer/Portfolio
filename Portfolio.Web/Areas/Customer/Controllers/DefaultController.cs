using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.Areas.Customer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

    }
}
