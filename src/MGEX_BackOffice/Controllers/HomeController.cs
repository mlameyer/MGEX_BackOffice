using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace MGEX_BackOffice.Controllers
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

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Wheat()
        {
            ViewData["Message"] = "Your application for Wheat Future Contracts.";

            return View();
        }

        public IActionResult AJC()
        {
            ViewData["Message"] = "Your application for Apple Juice Concentrate Contracts.";

            return View();
        }

        public IActionResult Indexes()
        {
            ViewData["Message"] = "Your application for Agricultural Indexes.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
