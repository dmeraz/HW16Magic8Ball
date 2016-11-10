using HW16Magic8Ball.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.Threading.Tasks;
//using System.IO;

namespace HW16Magic8Ball.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult ShakeBall()
        {
            //create an object of type Magic8Ball
            Magic8Ball ball = new Magic8Ball();
            string reply = ball.getResponse();
            return Json(reply, JsonRequestBehavior.AllowGet);
        }
    }
}