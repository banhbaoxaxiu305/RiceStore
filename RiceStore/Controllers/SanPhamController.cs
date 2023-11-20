using RiceStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Net;

namespace RiceStore.Controllers
{
    public class SanPhamController : Controller
    {
        ricestoreEntities db = new ricestoreEntities();
        // GET: SanPham
        public ActionResult SanPham(int? page,int? pageSize)
        {
            if(page == null)
            {
                page = 1;
            }
            if(pageSize == null)
            {
                pageSize = 10;
            }
            List<ProDetail> pros = db.ProDetails.ToList();
            List<ProDetailViewModel> ProDetailViewModel = pros.Select(
                x => new ProDetailViewModel
                {
                    ProID = x.Product.ProID,
                    ProName = x.Product.ProName,
                    ProImage = x.Product.ProImage,
                    NameDecription = x.Product.NameDecription,
                    CreatedDate = x.Product.CreatedDate,
                    Price = x.Price
                }
                ).ToList();
            return View(ProDetailViewModel.ToPagedList((int)page,(int)pageSize));
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProDetail pros = db.ProDetails.FirstOrDefault(p => p.ProID == id);
            ProDetailViewModel ProDetailViewModel = new ProDetailViewModel
                {
                    ProID = pros.Product.ProID,
                    ProName = pros.Product.ProName,
                    ProImage = pros.Product.ProImage,
                    NameDecription = pros.Product.NameDecription,
                    CreatedDate = pros.Product.CreatedDate,
                    Price = pros.Price
                };
            //ProDetailViewModel product = ProDetailViewModel.Find(id);
            return View(ProDetailViewModel);
        }
    }
}