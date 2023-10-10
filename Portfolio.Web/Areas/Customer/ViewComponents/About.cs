using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.ViewComponents
{
    public class About:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
