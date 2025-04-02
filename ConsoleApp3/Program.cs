using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            CongTyBaoHiem congTy = new CongTyBaoHiem();
            
            NhapDuLieuMau(congTy);
            
            bool tiepTuc = true;
            while (tiepTuc)
            {
                HienThiMenu();
                Console.Write("Chọn chức năng: ");
                string luaChon = Console.ReadLine();
                
                switch (luaChon)
                {
                    case "1":
                        NhapNhanVien(congTy);
                        break;
                    case "2":
                        congTy.HienThiDanhSachNhanVien();
                        break;
                    case "3":
                        congTy.HienThiNhanVienCoHoaHongCao();
                        break;
                    case "4":
                        congTy.HienThiNhanVienBiPhat();
                        break;
                    case "5":
                        congTy.HienThiNhanVienDuocThuong();
                        break;
                    case "0":
                        tiepTuc = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
                
                Console.WriteLine("\nNhấn Enter để tiếp tục...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        
        static void HienThiMenu()
        {
            Console.WriteLine("===== QUẢN LÝ CÔNG TY BẢO HIỂM =====");
            Console.WriteLine("1. Nhập thông tin nhân viên và bảo hiểm");
            Console.WriteLine("2. Hiển thị danh sách nhân viên và bảo hiểm");
            Console.WriteLine("3. Hiển thị nhân viên có hoa hồng > 50 USD");
            Console.WriteLine("4. Hiển thị nhân viên bị phạt");
            Console.WriteLine("5. Hiển thị nhân viên được thưởng");
            Console.WriteLine("0. Thoát");
        }
        
        static void NhapNhanVien(CongTyBaoHiem congTy)
        {
            Console.WriteLine("\n===== NHẬP THÔNG TIN NHÂN VIÊN =====");
            Console.Write("Tên nhân viên: ");
            string ten = Console.ReadLine();
            
            double heSoLuong;
            while (true)
            {
                Console.Write("Hệ số lương: ");
                if (double.TryParse(Console.ReadLine(), out heSoLuong) && heSoLuong > 0)
                {
                    break;
                }
                Console.WriteLine("Hệ số lương không hợp lệ. Vui lòng nhập lại!");
            }
            
            NhanVien nhanVien = new NhanVien(ten, heSoLuong);
            congTy.ThemNhanVien(nhanVien);
            
            bool nhapBaoHiem = true;
            while (nhapBaoHiem)
            {
                Console.WriteLine("\n===== NHẬP THÔNG TIN BẢO HIỂM =====");
                Console.WriteLine("1. Bảo hiểm ngắn hạn");
                Console.WriteLine("2. Bảo hiểm dài hạn");
                Console.WriteLine("0. Quay lại");
                
                Console.Write("Chọn loại bảo hiểm: ");
                string luaChon = Console.ReadLine();
                
                switch (luaChon)
                {
                    case "1":
                        NhapBaoHiemNganHan(nhanVien);
                        break;
                    case "2":
                        NhapBaoHiemDaiHan(nhanVien);
                        break;
                    case "0":
                        nhapBaoHiem = false;
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            }
        }
        
        static void NhapBaoHiemNganHan(NhanVien nhanVien)
        {
            Console.Write("Tên người mua: ");
            string tenNguoiMua = Console.ReadLine();
            
            int thoiHan;
            while (true)
            {
                Console.Write("Thời hạn (tháng): ");
                if (int.TryParse(Console.ReadLine(), out thoiHan) && thoiHan > 0)
                {
                    break;
                }
                Console.WriteLine("Thời hạn không hợp lệ. Vui lòng nhập lại!");
            }
            
            double soTienPhaiDong;
            while (true)
            {
                Console.Write("Số tiền phải đóng (USD): ");
                if (double.TryParse(Console.ReadLine(), out soTienPhaiDong) && soTienPhaiDong > 0)
                {
                    break;
                }
                Console.WriteLine("Số tiền không hợp lệ. Vui lòng nhập lại!");
            }
            
            BaoHiemNganHan baoHiem = new BaoHiemNganHan(tenNguoiMua, thoiHan, soTienPhaiDong);
            nhanVien.ThemBaoHiem(baoHiem);
            Console.WriteLine("Đã thêm bảo hiểm ngắn hạn thành công!");
        }
        
        static void NhapBaoHiemDaiHan(NhanVien nhanVien)
        {
            Console.Write("Tên người mua: ");
            string tenNguoiMua = Console.ReadLine();
            
            int thoiHan;
            while (true)
            {
                Console.Write("Thời hạn (tháng, phải > 12): ");
                if (int.TryParse(Console.ReadLine(), out thoiHan) && thoiHan > 12)
                {
                    break;
                }
                Console.WriteLine("Thời hạn không hợp lệ. Phải lớn hơn 12 tháng!");
            }
            
            double soTienPhaiDong;
            while (true)
            {
                Console.Write("Số tiền phải đóng (USD): ");
                if (double.TryParse(Console.ReadLine(), out soTienPhaiDong) && soTienPhaiDong > 0)
                {
                    break;
                }
                Console.WriteLine("Số tiền không hợp lệ. Vui lòng nhập lại!");
            }
            
            double soTienDongHangThang;
            while (true)
            {
                Console.Write("Số tiền đóng hàng tháng (USD): ");
                if (double.TryParse(Console.ReadLine(), out soTienDongHangThang) && soTienDongHangThang > 0)
                {
                    break;
                }
                Console.WriteLine("Số tiền không hợp lệ. Vui lòng nhập lại!");
            }
            
            try
            {
                BaoHiemDaiHan baoHiem = new BaoHiemDaiHan(tenNguoiMua, thoiHan, soTienPhaiDong, soTienDongHangThang);
                nhanVien.ThemBaoHiem(baoHiem);
                Console.WriteLine("Đã thêm bảo hiểm dài hạn thành công!");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
        }
        
        static void NhapDuLieuMau(CongTyBaoHiem congTy)
        {
            NhanVien nv1 = new NhanVien("hoang", 2.5);
            nv1.ThemBaoHiem(new BaoHiemNganHan("anh", 6, 12000));
            nv1.ThemBaoHiem(new BaoHiemDaiHan("minh", 24, 8000, 400));
            congTy.ThemNhanVien(nv1);
            
            NhanVien nv2 = new NhanVien("dat", 1.8);
            nv2.ThemBaoHiem(new BaoHiemNganHan("khai", 3, 5000));
            congTy.ThemNhanVien(nv2);
            
            NhanVien nv3 = new NhanVien("huy", 3.0);
            nv3.ThemBaoHiem(new BaoHiemNganHan("my", 4, 9000));
            nv3.ThemBaoHiem(new BaoHiemNganHan("anh", 2, 6000));
            congTy.ThemNhanVien(nv3);
        }
    }
}
