using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using maktek.Models;

namespace maktek.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        aksateknikEntities db = new aksateknikEntities();
        public ActionResult Index()
        {
            var model = db.kullanici.ToList();
            return View();
        }
    }
}