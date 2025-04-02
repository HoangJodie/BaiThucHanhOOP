using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyNhanVien quanLy = new QuanLyNhanVien();
            
            ThemDuLieuMau(quanLy);
            
            int luaChon;
            do
            {
                HienThiMenu();
                luaChon = NhapLuaChon();
                
                XuLyLuaChon(luaChon, quanLy);
                
                if (luaChon != 0)
                {
                    Console.WriteLine("\nNhấn Enter để tiếp tục...");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (luaChon != 0);
        }
        
        static void HienThiMenu()
        {
            Console.WriteLine("QUẢN LÝ NHÂN VIÊN");
            Console.WriteLine("=================");
            Console.WriteLine("1. Thêm nhân viên mới");
            Console.WriteLine("2. Hiển thị danh sách nhân viên");
            Console.WriteLine("3. Tính tổng lương");
            Console.WriteLine("4. Tìm nhân viên lương cao nhất");
            Console.WriteLine("5. Tìm nhân viên lương thấp nhất");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng: ");
        }
        
        static int NhapLuaChon()
        {
            int luaChon;
            while (!int.TryParse(Console.ReadLine(), out luaChon) || luaChon < 0 || luaChon > 5)
            {
                Console.Write("Lựa chọn không hợp lệ. Vui lòng nhập lại: ");
            }
            return luaChon;
        }
        
        static void XuLyLuaChon(int luaChon, QuanLyNhanVien quanLy)
        {
            switch (luaChon)
            {
                case 1:
                    ThemNhanVien(quanLy);
                    break;
                case 2:
                    quanLy.HienThiDanhSach();
                    break;
                case 3:
                    Console.WriteLine($"Tổng lương: {quanLy.TinhTongLuong():N0} VND");
                    break;
                case 4:
                    HienThiNhanVienLuongCaoNhat(quanLy);
                    break;
                case 5:
                    HienThiNhanVienLuongThapNhat(quanLy);
                    break;
            }
        }
        
        static void ThemNhanVien(QuanLyNhanVien quanLy)
        {
            Console.WriteLine("\nTHÊM NHÂN VIÊN MỚI");
            Console.WriteLine("1. Nhân viên sản xuất");
            Console.WriteLine("2. Nhân viên công nhật");
            Console.WriteLine("3. Nhân viên quản lý");
            Console.Write("Chọn loại nhân viên: ");
            
            int loai;
            while (!int.TryParse(Console.ReadLine(), out loai) || loai < 1 || loai > 3)
            {
                Console.Write("Lựa chọn không hợp lệ. Vui lòng nhập lại: ");
            }
            
            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();
            
            DateTime ngaySinh = NhapNgaySinh();
            
            Console.Write("Địa chỉ: ");
            string diaChi = Console.ReadLine();
            
            switch (loai)
            {
                case 1:
                    ThemNhanVienSanXuat(quanLy, hoTen, ngaySinh, diaChi);
                    break;
                case 2:
                    ThemNhanVienCongNhat(quanLy, hoTen, ngaySinh, diaChi);
                    break;
                case 3:
                    ThemNhanVienQuanLy(quanLy, hoTen, ngaySinh, diaChi);
                    break;
            }
        }
        
        static DateTime NhapNgaySinh()
        {
            DateTime ngaySinh;
            while (true)
            {
                Console.Write("Ngày sinh (dd/MM/yyyy): ");
                if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, 
                    System.Globalization.DateTimeStyles.None, out ngaySinh))
                {
                    return ngaySinh;
                }
                Console.WriteLine("Ngày sinh không hợp lệ!");
            }
        }
        
        static void ThemNhanVienSanXuat(QuanLyNhanVien quanLy, string hoTen, DateTime ngaySinh, string diaChi)
        {
            Console.Write("Số sản phẩm: ");
            int soSanPham;
            while (!int.TryParse(Console.ReadLine(), out soSanPham) || soSanPham < 0)
            {
                Console.Write("Số sản phẩm không hợp lệ. Vui lòng nhập lại: ");
            }
            
            quanLy.ThemNhanVien(new NhanVienSanXuat(hoTen, ngaySinh, diaChi, soSanPham));
            Console.WriteLine("Đã thêm nhân viên sản xuất thành công!");
        }
        
        static void ThemNhanVienCongNhat(QuanLyNhanVien quanLy, string hoTen, DateTime ngaySinh, string diaChi)
        {
            Console.Write("Số ngày công: ");
            int soNgayCong;
            while (!int.TryParse(Console.ReadLine(), out soNgayCong) || soNgayCong < 0)
            {
                Console.Write("Số ngày công không hợp lệ. Vui lòng nhập lại: ");
            }
            
            quanLy.ThemNhanVien(new NhanVienCongNhat(hoTen, ngaySinh, diaChi, soNgayCong));
            Console.WriteLine("Đã thêm nhân viên công nhật thành công!");
        }
        
        static void ThemNhanVienQuanLy(QuanLyNhanVien quanLy, string hoTen, DateTime ngaySinh, string diaChi)
        {
            Console.Write("Lương cơ bản: ");
            double luongCoBan;
            while (!double.TryParse(Console.ReadLine(), out luongCoBan) || luongCoBan <= 0)
            {
                Console.Write("Lương cơ bản không hợp lệ. Vui lòng nhập lại: ");
            }
            
            Console.Write("Hệ số lương: ");
            double heSoLuong;
            while (!double.TryParse(Console.ReadLine(), out heSoLuong) || heSoLuong <= 0)
            {
                Console.Write("Hệ số lương không hợp lệ. Vui lòng nhập lại: ");
            }
            
            quanLy.ThemNhanVien(new NhanVienQuanLy(hoTen, ngaySinh, diaChi, luongCoBan, heSoLuong));
            Console.WriteLine("Đã thêm nhân viên quản lý thành công!");
        }
        
        static void HienThiNhanVienLuongCaoNhat(QuanLyNhanVien quanLy)
        {
            NhanVien nv = quanLy.TimNhanVienLuongCaoNhat();
            if (nv != null)
            {
                Console.WriteLine("\nNHÂN VIÊN CÓ LƯƠNG CAO NHẤT");
                nv.HienThiThongTin();
            }
            else
            {
                Console.WriteLine("Danh sách nhân viên trống");
            }
        }
        
        static void HienThiNhanVienLuongThapNhat(QuanLyNhanVien quanLy)
        {
            NhanVien nv = quanLy.TimNhanVienLuongThapNhat();
            if (nv != null)
            {
                Console.WriteLine("\nNHÂN VIÊN CÓ LƯƠNG THẤP NHẤT");
                nv.HienThiThongTin();
            }
            else
            {
                Console.WriteLine("Danh sách nhân viên trống");
            }
        }
        
        static void ThemDuLieuMau(QuanLyNhanVien quanLy)
        {
            quanLy.ThemNhanVien(new NhanVienSanXuat("Hoang dep trai", new DateTime(2003, 5, 15), "da nang", 150));
            quanLy.ThemNhanVien(new NhanVienCongNhat("hoang", new DateTime(2003, 3, 10), "ha noi", 22));
            quanLy.ThemNhanVien(new NhanVienQuanLy("anh", new DateTime(2003, 7, 5), "da nang", 10000000, 2.5));
        }
    }
}
