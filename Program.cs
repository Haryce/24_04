using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<CollegeStudent> st = new Repository<CollegeStudent>();
            st.Add(new CollegeStudent { Name = "Fgg", Age = 20, Avg = 4.5 });
            st.Add(new CollegeStudent { Name = "Ngg", Age = 22, Avg = 3.3 });
            Repository<CollegeCourse> cs = new Repository<CollegeCourse>();
            cs.Add(new CollegeCourse { NameC = "Math", Hours = 20, Desc = "wp" });
            cs.Add(new CollegeCourse { NameC = "Physics", Hours = 0, Desc = "sss" });
            Console.WriteLine("Students:");
            st.Show();
            Console.WriteLine("Courses:");
            cs.Show();
        }
    }
}
