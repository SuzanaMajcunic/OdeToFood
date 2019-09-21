using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            // var name = HttpContext.Request.QueryString["name"]; // or add parameter in Index()
            var model = new GreetingViewModel();
            model.Name = name ?? "No name."; // corelation operator (if null, then No name
            model.Message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}