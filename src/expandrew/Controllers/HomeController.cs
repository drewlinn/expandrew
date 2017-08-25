using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace expandrew.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Things()
        {
            ViewData["Message"] = "Your favorite things page.";

            return View();
        }
        public IActionResult Pet()
        {
            ViewData["Message"] = "Your favorite pet page.";

            return View();
        }
        public IActionResult People()
        {
            ViewData["Message"] = "Your favorite people page.";

            return View();
        }
        public IActionResult Places()
        {
            ViewData["Message"] = "Your favorite places page.";

            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
