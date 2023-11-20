using RiceStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace RiceStore.Controllers
{
    public class OrdersController : Controller
    {
        private ricestoreEntities db = new ricestoreEntities();
        // GET: Orders
        public ActionResult Index()
        {
            var order = db.Orders.Include(c => c.Customer);
            return View(order.ToList());
        }
        public ActionResult Detail(int? id)
        {
            Order ord = db.Orders.FirstOrDefault(o => o.OrderID == id);
            return View(ord);
        }
    }
}