using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        // komentarz ze strony github
        public ActionResult Index()
        {
                // komentarz aaaaaaaaaaaaaaaa hhhhhhhhhhhhh
            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
                // visual dsafddsfaadsfdsdfs
            return View();
        }

        public ActionResult Contact()
        { //sdfgsdsdfadsf
            ViewBag.Message = "Your contact page.";
                // studio
            return View();
        }
        /*
         asdshsdafhkhkjh sadfdassdfasd
         sdafsadfsdafsdafsdafsdaf sdaf sadf
         dsfsadfsdafsadfsdafsdafsdafsdafsda
         opis */
    }
}
