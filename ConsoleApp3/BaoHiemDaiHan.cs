using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class BaoHiemDaiHan : BaoHiem
    {
        public double SoTienDongHangThang { get; set; }

        public BaoHiemDaiHan(string tenNguoiMua, int thoiHan, double soTienPhaiDong, double soTienDongHangThang) 
            : base(tenNguoiMua, thoiHan, soTienPhaiDong)
        {
            if (thoiHan <= 12)
            {
                throw new ArgumentException("Bảo hiểm dài hạn phải có thời hạn trên 12 tháng");
            }
            SoTienDongHangThang = soTienDongHangThang;
        }

        public override double TinhHoaHong()
        {
            return SoTienDongHangThang * 0.5;
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine("THÔNG TIN BẢO HIỂM DÀI HẠN");
            base.HienThiThongTin();
            Console.WriteLine($"Số tiền đóng hàng tháng: {SoTienDongHangThang} USD");
            Console.WriteLine("------------------------");
        }
    }
} 