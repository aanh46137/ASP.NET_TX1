using LuyenTapTX1_p4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuyenTapTX1_p4.Controllers
{
    public class QuanlySanphamController : Controller
    {
        // GET: QuanlySanpham
        List<Sanpham> danhsach;
        public QuanlySanphamController()
        {
            danhsach = new List<Sanpham>
            {
                new Sanpham("S01", "Sản phẩm 1", 10, 100, 0),
                new Sanpham("S02", "Sản phẩm 2", 20, 120, 1),
                new Sanpham("S03", "Sản phẩm 3", 15, 200, 1),
                new Sanpham("S04", "Sản phẩm 4", 30, 150, 0),
                new Sanpham("S05", "Sản phẩm 5", 20, 50, 1),
            };
        }
        public ActionResult Index()
        {
            ViewBag.ds1 = danhsach.Where( sp => sp.giatien > 100).ToList();
            ViewBag.ds2 = danhsach.Where( sp => sp.giamgia == 1).ToList();
            return View();
        }
        [HttpGet]
        public ActionResult Input()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Output(Sanpham sanpham)
        {
            return View(sanpham);
        }
    }
}