using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    public class TrainController : Controller
    {
        //
        // GET: /Train/

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult AddTrain()
        {
            return View ()
        }

        public ActionResult SearchTrain()
        {
            return View();

        }

        public ActionResult EditTrain()
        {
            return View();
        }

        public ActionResult DeleteTrain()
        {
            return View();
        }



    }
}
