using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Thu : BuuPham
    {
        public LoaiThu Loai { get; set; }

        public Thu(string diaChi, string nguoiNhan, LoaiThu loai) : base(diaChi, nguoiNhan)
        {
            Loai = loai;
        }

        public override double TinhPhiVanChuyen()
        {
            return Loai == LoaiThu.Nhanh ? 3000 : 500;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine($"Loai: Thu {(Loai == LoaiThu.Nhanh ? "Nhanh" : "Thuong")}");
            Console.WriteLine($"Nguoi nhan: {NguoiNhan}");
            Console.WriteLine($"Dia chi: {DiaChi}");
            Console.WriteLine($"Phi van chuyen: {TinhPhiVanChuyen()} VND");
            Console.WriteLine("------------------------");
        }

        public override double Calculate(double x, double y)
        {
            return x == 1 ? 3000 : 500;
        }
    }
}
