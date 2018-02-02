using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StoreController : Controller
        {
                //DAL dal = new DAL();

                // GET: Store

        MusicStoreDbEntities context = new MusicStoreDbEntities();

                public ViewResult Index()
                   {
                        //  ViewBag.Message = "It is my App";
                        List<Genere> generes = context.Generes.ToList();
                        ViewBag.GeneresCount = generes.Count;
                                     return View(generes);
     
                  }

                public ViewResult Browse(int ?genereid)
                {
                    //List<Album> albums = dal.GetAlbums(genereid);
                    //ViewBag.AlbumCount = albums.Count;
                    //ViewBag.Pagetitle = "Viewing albums for genereid...." + genereid;
                    //return View(albums);

                    //ENTITY FRAMEWORK
                    //get albums for a particular genere
                    //using linq to entities
                    var albums=  from a in context.Albums
                                 where a.genereid == genereid
                                 select a;
                            //List < Album > albums = context.Albums.ToList();
                            ViewBag.AlbumCount = albums.Count();
                    ViewBag.Pagetitle = "Browse Genere";
                    return View(albums.ToList());
                }

                public ViewResult Details(int albumid=-1)
                {
                    //return View();
                    //get artist details for a particular album

                    var album = (from a in context.Albums
                                  where a.albumid == albumid
                                  select a).SingleOrDefault();
                    return View(album.Artist);
                }


            public ViewResult Artist(int albumid)
            {
                    //Artist a = dal.GetArtist(albumid);
                    //return View(a);
                    return View();
            }

    }
}