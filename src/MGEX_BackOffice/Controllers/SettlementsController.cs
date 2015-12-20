using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MGEX_BackOffice.Controllers
{
    public class SettlementsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AJCSettlements()
        {
            return View();
        }

        public IActionResult WheatSettlements()
        {
            return View();
        }
    }
}
