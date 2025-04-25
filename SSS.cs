using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Repository<T> where T : class
    {
        private List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public void Remove(T item)
        {
            items.Remove(item);
        }
        public void Show()
        {
            foreach (var item in items)
            {
                if (item is IStudent student)
                {
                    student.Print();
                }
                else if (item is ICourse course)
                {
                    course.PrintC();
                }
                Console.WriteLine();
            }
        }
    }
}
