using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class NhanVienCongNhat : NhanVien
    {
        public int SoNgayCong { get; set; }
        private const double GiaNgayCong = 50000;

        public NhanVienCongNhat(string hoTen, DateTime ngaySinh, string diaChi, int soNgayCong) 
            : base(hoTen, ngaySinh, diaChi)
        {
            SoNgayCong = soNgayCong;
        }

        public override double TinhLuong()
        {
            return SoNgayCong * GiaNgayCong;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine("NHÂN VIÊN CÔNG NHẬT");
            base.HienThiThongTin();
            Console.WriteLine($"Số ngày công: {SoNgayCong}");
            Console.WriteLine("-------------------");
        }
    }
} 