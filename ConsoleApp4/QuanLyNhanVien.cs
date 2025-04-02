using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class QuanLyNhanVien
    {
        private List<NhanVien> danhSachNhanVien;

        public QuanLyNhanVien()
        {
            danhSachNhanVien = new List<NhanVien>();
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            danhSachNhanVien.Add(nhanVien);
        }

        public void HienThiDanhSach()
        {
            if (danhSachNhanVien.Count == 0)
            {
                Console.WriteLine("Danh sách nhân viên trống");
                return;
            }

            Console.WriteLine("DANH SÁCH NHÂN VIÊN");
            Console.WriteLine("===================");
            
            foreach (var nv in danhSachNhanVien)
            {
                nv.HienThiThongTin();
            }
        }

        public double TinhTongLuong()
        {
            return danhSachNhanVien.Sum(nv => nv.TinhLuong());
        }

        public NhanVien TimNhanVienLuongCaoNhat()
        {
            if (danhSachNhanVien.Count == 0)
                return null;
                
            return danhSachNhanVien.OrderByDescending(nv => nv.TinhLuong()).First();
        }

        public NhanVien TimNhanVienLuongThapNhat()
        {
            if (danhSachNhanVien.Count == 0)
                return null;
                
            return danhSachNhanVien.OrderBy(nv => nv.TinhLuong()).First();
        }
    }
} 