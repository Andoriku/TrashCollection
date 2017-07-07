using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trash_Collector.Models;

namespace Trash_Collector.Controllers
{
    public class ViewMapController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: ViewMap
        public ActionResult Index()
        {
            return View(db.Users.ToList());
        }
    }
}