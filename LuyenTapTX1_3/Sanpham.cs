using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.DynamicData;

namespace LuyenTapTX1_p4.Models
{
    public class Sanpham
    {
        public Sanpham() { }
        public Sanpham(string masp, string tensanpham, int soluong, double giatien, int giamgia)
        {
            this.masp = masp;
            this.tensanpham = tensanpham;
            this.soluong = soluong;
            this.giatien = giatien;
            this.giamgia = giamgia;
        }

        public string masp {  get; set; }
        public string tensanpham { get; set; }
        public int soluong {  get; set; }
        public double giatien { get; set; }
        public int giamgia { get; set; }
        public double thanhtien
        {
            get
            {
                if ( giamgia == 1)
                {
                    return soluong * giatien * 0.9;
                } else {
                    return soluong * giatien;
            }
        }
}
    }
}