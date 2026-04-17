using LuyenTapTX1_p3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LuyenTapTX1_p3.Controllers
{
    public class QunalyNhanvienController : Controller
    {
        // GET: QunalyNhanvien
        List<Nhanvien> danhsach;
        public QunalyNhanvienController()
        {
            danhsach = new List<Nhanvien>
            {
                new Nhanvien("Nv01", "Nguyễn Vân Anh", "Hà Nội", 15, 200000),
                new Nhanvien("Nv02", "Lê Thu Hà", "Hải Phòng", 27, 250000),
                new Nhanvien("Nv03", "Nguyễn Văn Hoàng", "Hà Nội", 18, 250000),
                new Nhanvien("Nv04", "Trần Thu Hương", "Hải Phòng", 25, 190000),
                new Nhanvien("Nv05", "Ngô Phương Thảo", "Quảng Ninh", 20, 180000)
            };
        }
        public ActionResult Index()
        {
            ViewBag.ds1 = danhsach.Where( nv => nv.songaylam < 20).ToList();
            ViewBag.ds2 = danhsach.Where(nv => nv.luongngay > 190000).ToList();
            ViewBag.ds3 = danhsach.Where(nv => nv.diachi.Equals("Hà Nội", StringComparison.OrdinalIgnoreCase));
            return View();
        }

        [HttpGet]
        public ActionResult Input()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Output(Nhanvien nhanvien)
        {
            return View(nhanvien);
        }
    }
}