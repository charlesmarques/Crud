using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroDeClienteSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Sobre mim";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contato";

            return View();
        }
    }
}