using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class NhanVienSanXuat : NhanVien
    {
        public int SoSanPham { get; set; }
        private const double GiaSanPham = 20000;

        public NhanVienSanXuat(string hoTen, DateTime ngaySinh, string diaChi, int soSanPham) 
            : base(hoTen, ngaySinh, diaChi)
        {
            SoSanPham = soSanPham;
        }

        public override double TinhLuong()
        {
            return SoSanPham * GiaSanPham;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine("NHÂN VIÊN SẢN XUẤT");
            base.HienThiThongTin();
            Console.WriteLine($"Số sản phẩm: {SoSanPham}");
            Console.WriteLine("-------------------");
        }
    }
} 