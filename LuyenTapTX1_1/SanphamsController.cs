using LuyenTapTX1_p1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuyenTapTX1_p1.Controllers
{
    public class SanphamsController : Controller
    {
        // GET: Sanphams
        List<Sanpham> danhsach;

        public SanphamsController()
        {
            danhsach = new List<Sanpham>
            {
                new Sanpham("sp1", "Apple", "Iphone X", 20, 200),
                new Sanpham("sp2", "Xiaomi", "Xiaomi Ultra 15", 10, 500),
                new Sanpham("sp3", "Apple", "Apple", 30, 320),
                new Sanpham("sp4", "Apple", "Iphone 15", 40, 300),
                new Sanpham("sp5", "Xiaomi", "Xiaomi 14 pro", 10, 200),
                new Sanpham("sp6", "Xiaomi", "Xiaomi 15 pro", 15, 250),
            };
        }
        public ActionResult Index()
        {
            ViewBag.ds1 = danhsach.Where(sp => sp.giatien >= 250).ToList();
            ViewBag.ds2 = danhsach.Where(sp => sp.hangsx == "Xiaomi").ToList();
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