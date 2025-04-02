using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class QuanLyBuuPham
    {
        private List<BuuPham> danhSachBuuPham;

        public QuanLyBuuPham()
        {
            danhSachBuuPham = new List<BuuPham>();
        }

        public void ThemBuuPham(BuuPham buuPham)
        {
            danhSachBuuPham.Add(buuPham);
        }

        public void HienThiTatCaBuuPham()
        {
            Console.WriteLine("\n=== DANH SACH BUU PHAM ===");
            if (danhSachBuuPham.Count == 0)
            {
                Console.WriteLine("Khong co buu pham nao trong danh sach.");
                return;
            }

            foreach (var buuPham in danhSachBuuPham)
            {
                buuPham.HienThiThongTin();
            }
        }

        public int DemSoLuongHangHoa()
        {
            return danhSachBuuPham.Count(bp => bp is HangHoa);
        }

        public void TimThuTheoNguoiNhan(string tenNguoiNhan)
        {
            Console.WriteLine($"\n=== DANH SACH THU CUA NGUOI NHAN: {tenNguoiNhan} ===");
            var ketQua = danhSachBuuPham.Where(bp => bp is Thu && bp.NguoiNhan.Equals(tenNguoiNhan, StringComparison.OrdinalIgnoreCase)).ToList();

            if (ketQua.Count == 0)
            {
                Console.WriteLine($"Khong tim thay thu nao cho nguoi nhan {tenNguoiNhan}.");
                return;
            }

            foreach (var buuPham in ketQua)
            {
                buuPham.HienThiThongTin();
            }
        }

        public void SapXepBuuPham()
        {
            danhSachBuuPham = danhSachBuuPham
                .OrderBy(bp => bp.NguoiNhan)
                .ThenBy(bp => bp.TinhPhiVanChuyen())
                .ToList();
        }

        public void XoaThuThuong()
        {
            danhSachBuuPham.RemoveAll(bp => bp is Thu thu && thu.Loai == LoaiThu.Thuong);
        }

        public double TinhTongPhiVanChuyen()
        {
            return danhSachBuuPham.Sum(bp => bp.TinhPhiVanChuyen());
        }

        public void NhapTuDong()
        {
            ThemBuuPham(new HangHoa("123 ok, TP.DN", "Nguyen Van A", 2.5));
            ThemBuuPham(new HangHoa("123 ok, Ha Noi", "hoang dep trai", 1.8));

            ThemBuuPham(new Thu("123 ok, Da Nang", "Kim anh", LoaiThu.Thuong));
            ThemBuuPham(new Thu("123 ko ok", "hoang", LoaiThu.Nhanh));
        }

        public void NhapBuuPham()
        {
            Console.WriteLine("\n=== NHAP THONG TIN BUU PHAM ===");
            Console.WriteLine("Chon loai buu pham (1: Thu, 2: Hang hoa): ");
            int loai = int.Parse(Console.ReadLine());

            Console.Write("Nhap dia chi nguoi nhan: ");
            string diaChi = Console.ReadLine();

            Console.Write("Nhap ten nguoi nhan: ");
            string nguoiNhan = Console.ReadLine();

            if (loai == 1)
            {
                Console.Write("Loai thu (0: Thuong, 1: Nhanh): ");
                int loaiThu = int.Parse(Console.ReadLine());
                LoaiThu loaiThuEnum = loaiThu == 1 ? LoaiThu.Nhanh : LoaiThu.Thuong;
                ThemBuuPham(new Thu(diaChi, nguoiNhan, loaiThuEnum));
            }
            else if (loai == 2)
            {
                Console.Write("Nhap trong luong (kg): ");
                double trongLuong = double.Parse(Console.ReadLine());
                ThemBuuPham(new HangHoa(diaChi, nguoiNhan, trongLuong));
            }
            else
            {
                Console.WriteLine("Lua chon khong hop le!");
            }
        }
    }
}
