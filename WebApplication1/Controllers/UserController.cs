using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    //for any action method within this class will handled automatically
    [HandleError]
    public class UserController : Controller
    {
        // GET: User
        DAL dal = new DAL();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllUsers()
        {
            try
            {
                List<Users> users = dal.GetAllUser();
            //throw new Exception("Not Getting Users List!!!");
                return PartialView(users);
            }
            catch (Exception e) { throw e; }

        }

        public ActionResult AddUsers()
        {
            return View();
        }



        [HttpPost]
        public ActionResult AddUsers(Users u)
        {
            try
            {
                dal.AddUser(u);
                List<Users> users = dal.GetAllUser();
            //throw new Exception(" Invalid Users!!!");

            return PartialView("GetAllUsers",users);


                return RedirectToAction("AddUsers");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public ActionResult RaiseException()
        {
            throw new Exception("Some Error occured!!!");
        }


    }
}