using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MGEX_BackOffice.Controllers
{
    public class ClosingController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AJCFutures()
        {
            return View("AJCFutures", "Closing");
        }

        public IActionResult AJCOptions()
        {
            return View("AJCOptions", "Closing");
        }

        public IActionResult IndexFutures()
        {
            return View("IndexFutures", "Closing");
        }

        public IActionResult WheatFutures()
        {
            return View("WheatFutures", "Closing");
        }

        public IActionResult WheatOptions()
        {
            return View("WheatOptions", "Closing");
        }
    }
}
