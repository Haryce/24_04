using System;

namespace ConsoleApp3
{
    interface IStudent
    {
        string Name { get; set; }
        uint Age { get; set; }
        double Avg { get; set; }
        void Print();
    }
}