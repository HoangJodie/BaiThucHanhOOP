using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Letter: Package
    {
        public LetterType LetterType { get; set; }

        public Letter(string name, string address, LetterType letterType) : base(name, address)
        {
            LetterType = letterType;
        }

        public override double Calculate()
        {
            if(LetterType == LetterType.express)
            {
                return 3000;
            }
            else
            {
                return 500;
            }
        }

        public override void DisplayInformation() {
            Console.WriteLine($"Ten nguoi nhan: {Name}");
            Console.WriteLine($"Dia chi: {Address}");
            Console.WriteLine($"Loai thu: {LetterType}");
            Console.WriteLine($"Phi van chuyen: {Calculate()}");
        }
    }
}
