using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Bem vindo ao Ambiente Virtual de Aprendizagem!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
