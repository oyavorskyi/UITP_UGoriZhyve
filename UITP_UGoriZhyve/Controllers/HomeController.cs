using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UITP_UGoriZhyve.Models;

namespace UITP_UGoriZhyve.Controllers
{
    public class HomeController : Controller
    {

        RoomContext dbRoom = new RoomContext();
        SkiContext dbSki = new SkiContext();

        public ActionResult Index()
        {
            IEnumerable<Room> rooms = dbRoom.Rooms;

            ViewBag.Rooms = rooms;

            IEnumerable<SkiComplect> ski = dbSki.SkiComplects;

            ViewBag.SkiComplects = ski;

            return View();
        }

        public ActionResult Reserve()
        {

            IEnumerable<Room> rooms = dbRoom.Rooms;

            ViewBag.Rooms = rooms;

            return View();
        }

        public ActionResult Recreation()
        {
            IEnumerable<SkiComplect> ski = dbSki.SkiComplects;

            ViewBag.SkiComplects = ski;

            return View();
        }
    }
}