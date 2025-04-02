using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class BaoHiem : IBaoHiem
    {
        public string TenNguoiMua { get; set; }
        public int ThoiHan { get; set; }
        public double SoTienPhaiDong { get; set; }

        protected BaoHiem(string tenNguoiMua, int thoiHan, double soTienPhaiDong)
        {
            TenNguoiMua = tenNguoiMua;
            ThoiHan = thoiHan;
            SoTienPhaiDong = soTienPhaiDong;
        }

        public abstract double TinhHoaHong();

        public virtual void HienThiThongTin()
        {
            Console.WriteLine($"Tên người mua: {TenNguoiMua}");
            Console.WriteLine($"Thời hạn: {ThoiHan} tháng");
            Console.WriteLine($"Số tiền phải đóng: {SoTienPhaiDong} USD");
            Console.WriteLine($"Hoa hồng: {TinhHoaHong()} USD");
        }
    }
} 