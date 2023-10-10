using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.Areas.Customer.ViewComponents
{
    public class Portfolio : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
