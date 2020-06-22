using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace coderush.Controllers
{
    public class ElementExtraController : Controller
    {
        public ActionResult Timeout()
        {
            return View();
        }

        public ActionResult Idle()
        {
            return View();
        }

        public ActionResult Offline()
        {
            return View();
        }
    }
}