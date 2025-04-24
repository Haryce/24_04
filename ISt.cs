using System;

namespace ConsoleApp3
{
    interface IStudent
    {
        string Name { get; set; }
        uint Age { get; set; }
        uint Avg { get; set; }
        void Print();
    }
}