using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Merchandise : Package
    {
        public double Weight { get; set; }
        
        public Merchandise(string name, string address, double weight) : base(name, address) {
            Weight = weight;
        }

        public override double Calculate()
        {
            return 10000 * Weight;
        }

        public override void DisplayInformation()
        {
            Console.WriteLine($"Ten nguoi nhan: {Name} ");
            Console.WriteLine($"Dia chi: {Address}");
            Console.WriteLine($"Trong luong: {Weight}");
            Console.WriteLine($"So tien: {Calculate()}");
        }
    }
}
