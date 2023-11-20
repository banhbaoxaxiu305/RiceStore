using RiceStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RiceStore.Controllers
{
    public class LoginController : Controller
    {
        private ricestoreEntities db = new ricestoreEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
    }
}