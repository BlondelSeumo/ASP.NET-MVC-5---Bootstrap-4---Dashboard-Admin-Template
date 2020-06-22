using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace coderush.Controllers
{
    public class MaintenanceController : Controller
    {
        public ActionResult Error()
        {
            return View();
        }

        public ActionResult ComingSoon()
        {
            return View();
        }

        public ActionResult OfflineUI()
        {
            return View();
        }
    }
}