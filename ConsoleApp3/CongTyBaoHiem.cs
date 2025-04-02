using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CongTyBaoHiem
    {
        public List<NhanVien> DanhSachNhanVien { get; set; }

        public CongTyBaoHiem()
        {
            DanhSachNhanVien = new List<NhanVien>();
        }

        public void ThemNhanVien(NhanVien nhanVien)
        {
            DanhSachNhanVien.Add(nhanVien);
        }

        public void HienThiDanhSachNhanVien()
        {
            Console.WriteLine("\n===== DANH SÁCH NHÂN VIÊN =====");
            foreach (var nhanVien in DanhSachNhanVien)
            {
                nhanVien.HienThiThongTin();
            }
        }

        public void HienThiNhanVienCoHoaHongCao()
        {
            Console.WriteLine("\n===== DANH SÁCH NHÂN VIÊN CÓ HOA HỒNG > 50 USD =====");
            var danhSach = DanhSachNhanVien.Where(nv => nv.TinhTongHoaHong() > 50).ToList();
            
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Không có nhân viên nào có hoa hồng > 50 USD");
            }
            else
            {
                foreach (var nhanVien in danhSach)
                {
                    nhanVien.HienThiThongTin();
                }
            }
        }

        public void HienThiNhanVienBiPhat()
        {
            Console.WriteLine("\n===== DANH SÁCH NHÂN VIÊN BỊ PHẠT =====");
            var danhSach = DanhSachNhanVien.Where(nv => nv.BiPhat()).ToList();
            
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Không có nhân viên nào bị phạt");
            }
            else
            {
                foreach (var nhanVien in danhSach)
                {
                    nhanVien.HienThiThongTin();
                }
            }
        }

        public void HienThiNhanVienDuocThuong()
        {
            Console.WriteLine("\n===== DANH SÁCH NHÂN VIÊN ĐƯỢC THƯỞNG 100 USD =====");
            var danhSach = DanhSachNhanVien.Where(nv => nv.DuocThuong()).ToList();
            
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Không có nhân viên nào được thưởng");
            }
            else
            {
                foreach (var nhanVien in danhSach)
                {
                    nhanVien.HienThiThongTin();
                }
            }
        }
    }
} 