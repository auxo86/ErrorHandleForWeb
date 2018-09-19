using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErrorHandleForWeb.Controllers
{
    //[HandleError]
    public class HomeController : Controller
    {
        // GET: Home
        //[HandleError]
        public ActionResult Index()
        {
            return View();
        }
        //[HandleError]
        public ActionResult ExceptionDemo()
        {
            int i = 0;
            int j = 10 / i;
            return View();
        }
    }
}