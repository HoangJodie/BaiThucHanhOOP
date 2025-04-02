using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IBaoHiem
    {
        string TenNguoiMua { get; set; }
        int ThoiHan { get; set; }
        double SoTienPhaiDong { get; set; }
        double TinhHoaHong();
        void HienThiThongTin();
    }
} 