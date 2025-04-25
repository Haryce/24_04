using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class CollegeStudent : IStudent
    {
        public string Name { get; set; }
        public uint Age { get; set; }
        public double Avg { get; set; }
        public void Print()
        {
            Console.WriteLine($"Name student: {Name}\nAge {Age}\nAvg {Avg}");
        }
    }
}
