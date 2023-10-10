using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.ViewComponents
{
    public class Services:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
