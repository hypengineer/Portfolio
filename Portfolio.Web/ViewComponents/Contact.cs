﻿using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.ViewComponents
{
    public class Contact:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
