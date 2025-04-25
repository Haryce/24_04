using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface ICourse
    {
        string NameC { get; set; }
        uint Hours { get; set; }
        string Desc { get; set; }
        void PrintC();
    }
}
