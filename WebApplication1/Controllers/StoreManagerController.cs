using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.SqlClient;

namespace WebApplication1.Controllers
{
    public class StoreManagerController : Controller
    {
        MusicStoreDbEntities context = new MusicStoreDbEntities();

            // GET: StoreManager
            //DAL dal = new DAL();
            //public ActionResult GenereManager()
            //{
            //    //return View(dal.GetAllGenere());
            //    return View();
            //}
        public ActionResult AllAlbums()
        {
            //return View(dal.GetAllGenere());
            return View(context.Albums.ToList());
        }


        //this is called when link is clicked
        //public ActionResult AddGenere()
        //{
        //    return View();

        //}

        public ActionResult AddAlbum()
        {
            return View();

        }

        [HttpPost]
        public ActionResult AddAlbum(Album a)
        {
            //1.Add the object into the entity class collection
            context.Albums.Add(a);
            //2.tell Entity framework to fire insert query on this object
            context.SaveChanges();
            return RedirectToAction("AllAlbums");
            
        }

        //this is called when submit button is clicked
        //[HttpPost]
        //public ActionResult AddGenere(Genere g)
        //{
        //    try
        //    {
        //        //dal.insetgenere
        //        //dal.InsertGenere(g);
        //        return RedirectToAction("GenereManager");
        //    }
        //    catch(Exception e)
        //    {
        //        throw e;
        //    }
        //}


        public ActionResult EditAlbum(int albumid)
        {
            //get the album object from the database
            var album = (from a in context.Albums
                         where a.albumid == albumid
                         select a).SingleOrDefault();

            return View(album);
        }

        [HttpPost]
        public ActionResult EditAlbum(Album newalb)
        {
            //get the album object from the database
            //1.Get the old object from the collection
            var oldalbum = (from a in context.Albums
                           where a.albumid == newalb.albumid
                           select a).SingleOrDefault();

            //2.copy the contents of new object into old
            oldalbum.albumname = newalb.albumname;
            //ask ef to fire an 
            context.SaveChanges();
            return RedirectToAction("AllAlbums");
        }



        public ActionResult DeleteAlbum(int albumid)
        {
            
            //get the object to be deleted 
            var album = (from a in context.Albums
                         where a.albumid == albumid
                         select a).SingleOrDefault();
            //remove object from collection
            context.Albums.Remove(album);
            //fire delete query
            context.SaveChanges();
            //alert("Do you Want to Delete?");

            return RedirectToAction("AllAlbums");
        }


        public ActionResult EditGenere(int genereid)
        {
                try
                {
                    //Genere g = dal.GetGenere(genereid);

                    //return View(g);
                    return View();
                }
                catch (Exception e)
                {
                    throw e;
                }
        }


        [HttpPost]
        public ActionResult EditGenere(int genereid,string generename)
        {
                try
                {
                    //dal.insetgenere
                    //dal.UpdateGenere(genereid, generename);
                    return RedirectToAction("GenereManager");
            
                }
                catch (Exception e)
                {
                    throw e;
                }
        }



        public ActionResult DeleteGenere(int genereid)
        {
            try
            {
                //dal.DalGenere(genereid);
                return RedirectToAction("GenereManager");
            }
            catch (Exception e)
            {

                throw e;
            }
        }



    }
}