using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stoper3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ResetLaps();
            return View();
        }

        public static List<string> times;
        public JsonResult Lap(string obj)
        {
            ViewBag.YourHTML = "obj;";
           
            times.Add(obj);
            if (times.Count>5)
            {
                times.Remove(times[0].ToString());
            }

            List<string> timesTemp = new List<string>();
            for (int i=1;i<=times.Count;i++)
            {
                timesTemp.Add(times[times.Count - i]);
            }
            
            return Json(timesTemp);
        }

       public void ResetLaps()
        {
            times = new List<string>();
        }

    }
}