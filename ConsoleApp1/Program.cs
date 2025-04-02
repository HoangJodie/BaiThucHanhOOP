using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
class ChuongTrinh
{
    static void Main(string[] args)
    {
        QuanLyBuuPham quanLy = new QuanLyBuuPham();

        quanLy.NhapTuDong();

        int luaChon;
        do
        {
            Console.WriteLine("\n=== QUAN LY BUU PHAM ===");
            Console.WriteLine("1. Nhap thong tin buu pham");
            Console.WriteLine("2. Hien thi tat ca buu pham");
            Console.WriteLine("3. Dem so luong hang hoa");
            Console.WriteLine("4. Tim thu theo ten nguoi nhan");
            Console.WriteLine("5. Sap xep buu pham theo ten nguoi nhan va phi van chuyen");
            Console.WriteLine("6. Xoa thu thuong");
            Console.WriteLine("7. Tinh tong phi van chuyen");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon cua ban: ");

            if (!int.TryParse(Console.ReadLine(), out luaChon))
            {
                luaChon = -1;
            }

            switch (luaChon)
            {
                case 1:
                    quanLy.NhapBuuPham();
                    break;
                case 2:
                    quanLy.HienThiTatCaBuuPham();
                    break;
                case 3:
                    Console.WriteLine($"\nTong so hang hoa: {quanLy.DemSoLuongHangHoa()}");
                    break;
                case 4:
                    Console.Write("\nNhap ten nguoi nhan can tim: ");
                    string tenNguoiNhan = Console.ReadLine();
                    quanLy.TimThuTheoNguoiNhan(tenNguoiNhan);
                    break;
                case 5:
                    quanLy.SapXepBuuPham();
                    Console.WriteLine("\nDa sap xep buu pham theo ten nguoi nhan va phi van chuyen.");
                    quanLy.HienThiTatCaBuuPham();
                    break;
                case 6:
                    quanLy.XoaThuThuong();
                    Console.WriteLine("\nDa xoa tat ca thu thuong.");
                    quanLy.HienThiTatCaBuuPham();
                    break;
                case 7:
                    Console.WriteLine($"\nTong phi van chuyen: {quanLy.TinhTongPhiVanChuyen()} VND");
                    break;
                case 0:
                    Console.WriteLine("\nCam on ban da su dung chuong trinh!");
                    break;
                default:
                    Console.WriteLine("\nDu lieu khong hop le, vui long nhap lai!");
                    break;
            }
        } while (luaChon != 0);
    }
}
