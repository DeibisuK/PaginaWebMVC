using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaginaWebMVC.Controllers
{
    public class SharedController : Controller
    {
        // GET: Layout
        public ActionResult _LayoutPage()
        {
            return View();
        }
    }
}
