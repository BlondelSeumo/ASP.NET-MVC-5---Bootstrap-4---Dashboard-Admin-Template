using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace coderush.Controllers
{
    public class TaskController : Controller
    {
        public ActionResult TaskList()
        {
            return View();
        }

        public ActionResult TaskBoard()
        {
            return View();
        }

        public ActionResult TaskDetail()
        {
            return View();
        }
    }
}