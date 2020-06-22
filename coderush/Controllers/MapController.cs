using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace coderush.Controllers
{
    public class MapController : Controller
    {
        public ActionResult GoogleMap()
        {
            return View();
        }

        public ActionResult Vector()
        {
            return View();
        }

        public ActionResult GMapSearch()
        {
            return View();
        }
        
    }
}