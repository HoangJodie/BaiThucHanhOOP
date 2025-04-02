using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class NhanVienQuanLy : NhanVien
    {
        public double LuongCoBan { get; set; }
        public double HeSoLuong { get; set; }

        public NhanVienQuanLy(string hoTen, DateTime ngaySinh, string diaChi, double luongCoBan, double heSoLuong) 
            : base(hoTen, ngaySinh, diaChi)
        {
            LuongCoBan = luongCoBan;
            HeSoLuong = heSoLuong;
        }

        public override double TinhLuong()
        {
            return LuongCoBan * HeSoLuong;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine("NHÂN VIÊN QUẢN LÝ");
            base.HienThiThongTin();
            Console.WriteLine($"Lương cơ bản: {LuongCoBan:N0} VND");
            Console.WriteLine($"Hệ số lương: {HeSoLuong}");
            Console.WriteLine("-------------------");
        }
    }
} 