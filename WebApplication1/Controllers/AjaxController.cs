using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AjaxController : Controller
    {
        // GET: Ajax
        public ActionResult ServerTime()
        {
            return View();
        }

        public string GetServerTime()
        {
            System.Threading.Thread.Sleep(1000);
            return DateTime.Now.ToLongTimeString();
        }
    }
}