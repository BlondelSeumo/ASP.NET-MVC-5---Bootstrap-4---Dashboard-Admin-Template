using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace coderush.Controllers
{
    public class EditorController : Controller
    {
        public ActionResult CKEditor()
        {
            return View();
        }

        public ActionResult CKEditorBallon()
        {
            return View();
        }

        public ActionResult CKEditorInline()
        {
            return View();
        }

        public ActionResult CKEditorDocument()
        {
            return View();
        }

        public ActionResult TinyMCE()
        {
            return View();
        }
    }
}