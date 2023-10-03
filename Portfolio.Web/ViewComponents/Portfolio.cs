using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.ViewComponents
{
    public class Portfolio:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
