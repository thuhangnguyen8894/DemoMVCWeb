using addModelDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace addModelDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult GetPlayInfo()
        {
            ViewBag.Message = "Displaying model property values in a view.";

            PlayInfoModel somePlay = new PlayInfoModel();
            somePlay.Title = "The Secret Garden";
            somePlay.Synopsis = "A novel originally written by Frances.";
            return View("PlayInfo", somePlay);
        }

    }
}