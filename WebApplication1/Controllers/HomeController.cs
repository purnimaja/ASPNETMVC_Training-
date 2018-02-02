using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //MusicStoreDbEntities context;

        public ActionResult Index()
        {
            //context = new MusicStoreDbEntities();
            //List<Genere> generes = context.Generes.ToList();
            return View();
        }
    }
}
