using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewGitTaskProject.Controllers
{
    public class CalculateController : Controller
    {
        // GET: Calculate
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(double? num1, double? num2)
        {
            string total;
            if (num1.HasValue && num2.HasValue)
            {

                total = (num1 + num2).ToString();
            }
            else
            {
                total = "Please Enter Num 1 And Num 2";
            }
            ViewBag.total = total;
            return View();
        }
    }
}