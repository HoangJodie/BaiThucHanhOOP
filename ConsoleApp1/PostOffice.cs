using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PostOffice : IEnumerable<Package>
    {
        private List<Package> packages;

        public PostOffice()
        {
            packages = new List<Package>();
        }

        public void AddPackage(Package package)
        {
            packages.Add(package);
        }

        public void AddPackageAutomatic()
        {
            AddPackage(new Merchandise("Hoang", "da nang", 10));
            AddPackage(new Merchandise("Anh", "da nang", 5));
            AddPackage(new Letter("Hoang", "da nang", LetterType.express));
            AddPackage(new Letter("Anh", "da nang", LetterType.basis));
            AddPackage(new Letter("Binh", "ha noi", LetterType.basis));
        }

        public void DisplayAllPackages()
        {
            if (!packages.Any())
            {
                Console.WriteLine("Không có bưu phẩm nào");
                return;
            }

            Console.WriteLine("Danh sách tất cả bưu phẩm:");
            foreach (var package in this)
            {
                package.DisplayInformation();
                Console.WriteLine("------------------------");
            }
        }

        public int CountMerchandise() => this.Count(p => p is Merchandise);

        public IEnumerable<Letter> GetLettersByRecipient(string recipientName) => 
            this.OfType<Letter>()
                .Where(l => l.Name.Equals(recipientName, StringComparison.OrdinalIgnoreCase));

        public void DisplayLettersByRecipient(string recipientName)
        {
            var letters = GetLettersByRecipient(recipientName).ToList();

            if (!letters.Any())
            {
                Console.WriteLine($"Không tìm thấy thư nào cho người nhận {recipientName}");
                return;
            }

            Console.WriteLine($"Danh sách thư của người nhận {recipientName}:");
            foreach (var letter in letters)
            {
                letter.DisplayInformation();
                Console.WriteLine("------------------------");
            }
        }

        public IEnumerable<Package> GetSortedPackages() => 
            this.OrderBy(p => p.Name).ThenBy(p => p.Calculate());

        public void DisplaySortedPackages()
        {
            Console.WriteLine("Danh sách bưu phẩm đã sắp xếp:");
            foreach (var package in GetSortedPackages())
            {
                package.DisplayInformation();
                Console.WriteLine("------------------------");
            }
        }
        public void RemoveRegularLetters()
        {
            var regularLetters = this.OfType<Letter>()
                .Where(l => l.LetterType == LetterType.basis)
                .ToList();
            
            foreach (var letter in regularLetters)
            {
                packages.Remove(letter);
            }
        }

        public double CalculateTotalShippingFee() => this.Sum(p => p.Calculate());

        public IEnumerable<Merchandise> GetAllMerchandise() => this.OfType<Merchandise>();

        public IEnumerable<Letter> GetAllLetters() => this.OfType<Letter>();

        public IEnumerable<Letter> GetExpressLetters() => 
            this.OfType<Letter>().Where(l => l.LetterType == LetterType.express);

        public IEnumerator<Package> GetEnumerator()
        {
            return packages.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
