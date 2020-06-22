using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace coderush.Controllers
{
    public class InvoiceController : Controller
    {
        public ActionResult Invoice()
        {
            return View();
        }

        public ActionResult InvoiceSummary()
        {
            return View();
        }

        public ActionResult InvoiceList()
        {
            return View();
        }
    }
}