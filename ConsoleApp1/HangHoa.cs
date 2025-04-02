using System;

namespace ConsoleApp1
{
    class HangHoa : BuuPham
    {
        public double TrongLuong { get; set; }

        public HangHoa(string diaChi, string nguoiNhan, double trongLuong) : base(diaChi, nguoiNhan)
        {
            TrongLuong = trongLuong;
        }

        public override double TinhPhiVanChuyen()
        {
            return 10000 * TrongLuong;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine("Loai: Hang hoa");
            Console.WriteLine($"Nguoi nhan: {NguoiNhan}");
            Console.WriteLine($"Dia chi: {DiaChi}");
            Console.WriteLine($"Trong luong: {TrongLuong} kg");
            Console.WriteLine($"Phi van chuyen: {TinhPhiVanChuyen()} VND");
            Console.WriteLine("------------------------");
        }

        public override double Calculate(double x, double y)
        {
            return x * y;
        }
    }
}
