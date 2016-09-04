using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var persona = new Persona();
            return View(persona);
        }
        [HttpPost]
        public ActionResult Index(Persona persona)
        {
            return View(persona);
        }
    }
}