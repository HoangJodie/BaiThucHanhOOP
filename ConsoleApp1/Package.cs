using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Package:ICalculator
    {
        public Package(string name, string address) {
            Name = name;
            Address = address;
        }
        public string Name { get; set; }
        public string Address { get; set; }

        public abstract void DisplayInformation();

        public abstract double Calculate();

    }
}
