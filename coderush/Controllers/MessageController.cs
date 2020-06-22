using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace coderush.Controllers
{
    public class MessageController : Controller
    {
        public ActionResult Message()
        {
            return View();
        }
    }
}