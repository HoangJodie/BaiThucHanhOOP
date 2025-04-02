using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class CongTy
    {
        public List<NhanVien> DanhSachNhanVien { get; set; }

        public CongTy()
        {
            DanhSachNhanVien = new List<NhanVien>();
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            DanhSachNhanVien.Add(nhanVien);
        }

        public void HienThiDanhSachNhanVien()
        {
            Console.WriteLine("\n===== DANH SÁCH NHÂN VIÊN CÔNG TY =====");
            if (DanhSachNhanVien.Count == 0)
            {
                Console.WriteLine("Không có nhân viên nào trong danh sách.");
                return;
            }

            foreach (var nhanVien in DanhSachNhanVien)
            {
                nhanVien.HienThiThongTin();
            }
        }

        public double TinhTongLuong()
        {
            return DanhSachNhanVien.Sum(nv => nv.TinhLuong());
        }

        public NhanVien TimNhanVienLuongCaoNhat()
        {
            if (DanhSachNhanVien.Count == 0)
                return null;

            return DanhSachNhanVien.OrderByDescending(nv => nv.TinhLuong()).First();
        }

        public NhanVien TimNhanVienLuongThapNhat()
        {
            if (DanhSachNhanVien.Count == 0)
                return null;

            return DanhSachNhanVien.OrderBy(nv => nv.TinhLuong()).First();
        }
    }
} 