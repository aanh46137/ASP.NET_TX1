
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace LuyenTapTX1_p1.Models
{
    public class Sanpham
    {
        public Sanpham() { }
        public Sanpham(string masp, string hangsx, string tensp, int soluong, double giatien)
        {
            this.masp = masp;
            this.hangsx = hangsx;
            this.tensp = tensp;
            this.soluong = soluong;
            this.giatien = giatien;
        }

        public string masp {  get; set; }
        public string hangsx { get; set; }
        public string tensp { get; set; }
        public int soluong { get; set; }
        public double giatien {  get; set; }
        public double tongtien
        {
            get => soluong * giatien;
        }
    }
}