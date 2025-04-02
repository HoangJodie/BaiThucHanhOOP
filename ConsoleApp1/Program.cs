using ConsoleApp1;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Chương trình quản lý bưu phẩm");

            PostOffice postOffice = new PostOffice();
            postOffice.AddPackageAutomatic();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Hiển thị tất cả bưu phẩm");
                Console.WriteLine("2. Đếm số lượng hàng hóa");
                Console.WriteLine("3. Xuất thông tin thư theo người nhận");
                Console.WriteLine("4. Sắp xếp và hiển thị bưu phẩm theo tên người nhận và phí vận chuyển");
                Console.WriteLine("5. Xóa thông tin về thư thường");
                Console.WriteLine("6. Tính tổng phí vận chuyển");
                Console.WriteLine("7. Hiển thị thông tin thư express");
                Console.WriteLine("8. Tìm bưu phẩm có phí vận chuyển cao nhất");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn chức năng: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 0:
                            exit = true;
                            break;
                        case 1:
                            postOffice.DisplayAllPackages();
                            break;
                        case 2:
                            Console.WriteLine($"Số lượng hàng hóa: {postOffice.CountMerchandise()}");
                            break;
                        case 3:
                            Console.Write("Nhập tên người nhận: ");
                            string name = Console.ReadLine() ?? "";
                            postOffice.DisplayLettersByRecipient(name);
                            break;
                        case 4:
                            postOffice.DisplaySortedPackages();
                            break;
                        case 5:
                            postOffice.RemoveRegularLetters();
                            Console.WriteLine("Đã xóa thông tin về thư thường");
                            postOffice.DisplayAllPackages();
                            break;
                        case 6:
                            Console.WriteLine($"Tổng phí vận chuyển: {postOffice.CalculateTotalShippingFee()} VND");
                            break;
                        case 7:
                            var expressLetters = postOffice.GetExpressLetters().ToList();
                            if (expressLetters.Any())
                            {
                                Console.WriteLine("Danh sách thư express:");
                                foreach (var letter in expressLetters)
                                {
                                    letter.DisplayInformation();
                                    Console.WriteLine("------------------------");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Không có thư express nào");
                            }
                            break;
                        case 8:
                            var maxFeePackage = postOffice.OrderByDescending(p => p.Calculate()).FirstOrDefault();
                            if (maxFeePackage != null)
                            {
                                Console.WriteLine("Bưu phẩm có phí vận chuyển cao nhất:");
                                maxFeePackage.DisplayInformation();
                            }
                            else
                            {
                                Console.WriteLine("Không có bưu phẩm nào");
                            }
                            break;
                        default:
                            Console.WriteLine("Chức năng không hợp lệ!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập số!");
                }
            }
        }
    }
}
