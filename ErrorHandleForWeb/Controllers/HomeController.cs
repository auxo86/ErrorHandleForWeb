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

        //可以自訂要顯示處理錯誤的View
        [HandleError(View="Error2")]
        public ActionResult ExceptionDemo2()
        {
            int i = 0;
            int j = 10 / i;
            return View();
        }
    }
}