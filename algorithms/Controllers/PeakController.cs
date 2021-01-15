using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace algorithms.Controllers
{
    public class PeakController : Controller
    {
        // GET: Peak
        public ActionResult Index()
        {
            string mensaje = "trying o pass info";
            ViewBag.hola = mensaje;
            peakAlgorithm();
            return View();
        }

        public void peakAlgorithm()
        {

        }
    }
}
