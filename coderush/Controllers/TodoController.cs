using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace coderush.Controllers
{
    public class TodoController : Controller
    {
        public ActionResult Todo()
        {
            return View();
        }

        public ActionResult Notes()
        {
            return View();
        }
    }
}