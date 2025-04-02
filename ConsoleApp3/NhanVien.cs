using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class NhanVien
    {
        public string Ten { get; set; }
        public double HeSoLuong { get; set; }
        public List<IBaoHiem> DanhSachBaoHiem { get; set; }

        public NhanVien(string ten, double heSoLuong)
        {
            Ten = ten;
            HeSoLuong = heSoLuong;
            DanhSachBaoHiem = new List<IBaoHiem>();
        }

        public void ThemBaoHiem(IBaoHiem baoHiem)
        {
            DanhSachBaoHiem.Add(baoHiem);
        }

        public double TinhTongTienBaoHiem()
        {
            return DanhSachBaoHiem.Sum(bh => bh.SoTienPhaiDong);
        }

        public double TinhTongHoaHong()
        {
            return DanhSachBaoHiem.Sum(bh => bh.TinhHoaHong());
        }

        public bool DuocThuong()
        {
            return DanhSachBaoHiem.Any(bh => bh.SoTienPhaiDong > 10000);
        }

        public bool BiPhat()
        {
            return TinhTongTienBaoHiem() < 10000;
        }

        public double TinhLuong()
        {
            double luongCoBan = 40 * HeSoLuong;
            double phanTramTongTien = 0.01 * (TinhTongTienBaoHiem() - TinhTongHoaHong());
            double thuong = DuocThuong() ? 100 : 0;
            double phat = BiPhat() ? 30 : 0;
            
            return luongCoBan + phanTramTongTien + thuong - phat;
        }

        public void HienThiThongTin()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"THÔNG TIN NHÂN VIÊN: {Ten}");
            Console.WriteLine($"Hệ số lương: {HeSoLuong}");
            Console.WriteLine($"Tổng tiền bảo hiểm: {TinhTongTienBaoHiem()} USD");
            Console.WriteLine($"Tổng hoa hồng: {TinhTongHoaHong()} USD");
            Console.WriteLine($"Thưởng: {(DuocThuong() ? "100" : "0")} USD");
            Console.WriteLine($"Phạt: {(BiPhat() ? "30" : "0")} USD");
            Console.WriteLine($"Lương: {TinhLuong()} USD");
            Console.WriteLine("DANH SÁCH BẢO HIỂM:");
            
            if (DanhSachBaoHiem.Count == 0)
            {
                Console.WriteLine("Không có bảo hiểm nào");
            }
            else
            {
                foreach (var baoHiem in DanhSachBaoHiem)
                {
                    baoHiem.HienThiThongTin();
                }
            }
            Console.WriteLine("=================================");
        }
    }
} 