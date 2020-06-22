using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace coderush.Controllers
{
    public class CalendarController : Controller
    {
        public ActionResult FullCalendar()
        {
            return View();
        }
    }
}