using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class BuuPham : ICalculator
    {
        public string DiaChi { get; set; }
        public string NguoiNhan { get; set; }

        public BuuPham(string diaChi, string nguoiNhan)
        {
            DiaChi = diaChi;
            NguoiNhan = nguoiNhan;
        }

        public abstract double TinhPhiVanChuyen();
        public abstract void HienThiThongTin();
        public abstract double Calculate(double x, double y);
    }
}
