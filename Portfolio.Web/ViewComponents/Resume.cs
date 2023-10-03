using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.ViewComponents
{
    public class Resume:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
