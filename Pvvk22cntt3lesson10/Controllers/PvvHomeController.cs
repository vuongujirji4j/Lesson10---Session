using Pvvk22cntt3lesson10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pvvk22cntt3lesson10.Controllers
{
    public class PvvHomeController : Controller
    {
        public ActionResult PvvIndex()
        {
            if (Session["PvvAccount"] != null)
            {
                var PvvAccount = Session["PvvAccount"] as PvvAccount;
                ViewBag.FullName = PvvAccount.PvvFullName;
            }
            return View();
        }

    

        public ActionResult PvvAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PvvContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}