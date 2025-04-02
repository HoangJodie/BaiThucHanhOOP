using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public abstract class NhanVien
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }

        protected NhanVien(string hoTen, DateTime ngaySinh, string diaChi)
        {
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
        }

        public abstract double TinhLuong();

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Họ tên: {HoTen}");
            Console.WriteLine($"Ngày sinh: {NgaySinh:dd/MM/yyyy}");
            Console.WriteLine($"Địa chỉ: {DiaChi}");
            Console.WriteLine($"Lương: {TinhLuong():N0} VND");
        }
    }
} 