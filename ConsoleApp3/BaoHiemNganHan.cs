using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class BaoHiemNganHan : BaoHiem
    {
        public BaoHiemNganHan(string tenNguoiMua, int thoiHan, double soTienPhaiDong) 
            : base(tenNguoiMua, thoiHan, soTienPhaiDong)
        {
        }

        public override double TinhHoaHong()
        {
            return SoTienPhaiDong * 0.05; 
        }

        public override void HienThiThongTin()
        {
            Console.WriteLine("THÔNG TIN BẢO HIỂM NGẮN HẠN");
            base.HienThiThongTin();
            Console.WriteLine("------------------------");
        }
    }
} 