using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace MGEX_BackOffice.Controllers
{
    public class SettlementController : Controller
    {
        public IActionResult AJCSettlements()
        {
            ViewData["Message"] = "Enter Settlements for AJC Future Contracts Here.";

            return View();
        }

        public IActionResult WheatSettlements()
        {
            ViewData["Message"] = "Enter Settlements for Wheat Future Contracts Here.";

            return View();
        }
    }
}
