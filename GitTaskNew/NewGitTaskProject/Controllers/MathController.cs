using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewGitTaskProject.Models;

namespace NewGitTaskProject.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Index()
        {
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(double NUM1, double NUM2)
        {
            Models.SimpleMath A = new SimpleMath();
            A.FirstNumber = NUM1;
            A.SecondNumber = NUM2;

            ViewBag.T = A.GetResult();
            return View();
        }
    }
}