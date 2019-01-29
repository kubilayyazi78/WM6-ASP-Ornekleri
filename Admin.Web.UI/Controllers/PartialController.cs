using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Admin.Web.UI.Controllers
{
    public class PartialController : Controller
    {
        public PartialViewResult DrawerPartial()
        {
            var data = new List<string>();
            return PartialView("Partials/_DrawerPartial", data);
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView("Partials/_HeaderPartial");
        }
        public PartialViewResult ModalPartial()
        {
            return PartialView("Partials/_ModalPartial");
        }

    }
}