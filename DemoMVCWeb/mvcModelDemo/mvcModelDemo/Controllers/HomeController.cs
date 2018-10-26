using mvcModelDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcModelDemo.Controllers
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

        public ActionResult ListItemView()
        {
            ListItem itemsList = new ListItem();
            itemsList.Title = "Grocery Shopping";
            itemsList.ListItemEntry = "Pick up carrots, potatoes, onions and steak";
            itemsList.TimeCreated = DateTime.Now.ToString("T");

            ViewBag.Message = "Model information display view.";
            return View("ListItemView", itemsList);
        }
    }
}