using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.Areas.Customer.ViewComponents
{
    public class Resume : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
