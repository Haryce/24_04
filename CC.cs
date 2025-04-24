using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class CollegeCourse : ICourse
    {
        public string NameC { get; set; }
        public uint Hours { get; set; }
        public uint Desc { get; set; }
        public void PrintC()
        {
            Console.WriteLine($"Name {NameC}\nHours {Hours}\nDescription {Desc}");
        }
    }
}